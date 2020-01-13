using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.ServiceModel;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer
{

    [ServiceContract()]
    public interface IProductCategoryService
    {
        /// <summary>
        /// invalidate all first level categories, creating a 'clean slate' to work from
        /// </summary>
        [OperationContract()]
        void CleanSlate(Guid userId
                        );

        /// <summary>
        /// get all products for category
        /// </summary>
        [OperationContract()]
        Guid ProductCategoryAdd(string productCategoryCode,
                                string productCategoryName,
                                Guid productCategoryParentId,
                                int productCategoryPosition,
                                Guid userId
                                );

        /// <summary>
        /// get all products for category
        /// </summary>
        [OperationContract()]
        ProductCategoryContract ProductCategoryGetCompleteById(System.Guid productCategoryId);

        /// <summary>
        /// move category position down one step, return new position
        /// </summary>
        [OperationContract()]
        long PositionDown(Guid productCategoryId);

        /// <summary>
        /// move category position up one step, return new position
        /// </summary>
        [OperationContract()]
        long PositionUp(Guid productCategoryId);
    }

    /// <domain>Product</domain>
    /// <namespace>SolutionNorSolutionPim.BusinessLogicLayer</namespace>
    public class ProductCategoryService : IProductCategoryService
    {
        public void CleanSlate(Guid userId
                                ) {

            var crudeProductCategoryData = new CrudeProductCategoryData();
            List<CrudeProductCategoryData> productCategoryDataList = crudeProductCategoryData.FetchTopLevel();

            foreach ( CrudeProductCategoryData productCategoryData in productCategoryDataList ) {

                // start transaction
                using ( var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try {
                        // keep copy of 'old' category
                        CrudeProductCategoryData oldProductCategory = ObjectCopier.Clone(productCategoryData);

                        // set new state to invalidated
                        productCategoryData.ProductCategoryId = Guid.NewGuid();
                        productCategoryData.StateRcd = DefaultStateRef.Invalidated;
                        productCategoryData.UserId = userId;
                        productCategoryData.DateTime = DateTime.UtcNow;
                        productCategoryData.Insert(connection, transaction);

                        // update category to be 'old' version
                        oldProductCategory.ProductCategoryBecameId = productCategoryData.ProductCategoryId;
                        oldProductCategory.Update(connection, transaction);

                        // commit transaction
                        transaction.Commit();
                    } catch ( Exception ex ) {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public Guid ProductCategoryAdd(string productCategoryCode,
                                        string productCategoryName,
                                        Guid productCategoryParentId,
                                        int productCategoryPosition,
                                        Guid userId
                                        ) {
            var contract = new CrudeProductCategoryContract();

            contract.ProductCategoryId = Guid.NewGuid();
            contract.ProductCategoryCode = productCategoryCode;
            contract.ProductCategoryName = productCategoryName;
            contract.ProductCategoryPosition = productCategoryPosition;

            if ( productCategoryParentId == Guid.Empty ) {
                // first level is it's own parent
                contract.ProductCategoryParentId = contract.ProductCategoryId;
            } else {
                contract.ProductCategoryParentId = productCategoryParentId;
            }

            contract.StateRcd = DefaultStateRef.Created;
            contract.UserId = userId;
            contract.DateTime = DateTime.UtcNow;

            var bll = new CrudeProductCategoryService();
            bll.Insert(contract);

            return contract.ProductCategoryId;
        }

        public ProductCategoryContract ProductCategoryGetCompleteById(Guid productCategoryId) {
            var contract = new ProductCategoryContract();
            var data = new Category(productCategoryId);

            // move data from data access layer to business logic layer
            contract.ProductCategory = new CrudeProductCategoryContract();
            CrudeProductCategoryService.DataToContract(data.ProductCategory, contract.ProductCategory);

            contract.ProductCategoryImage = CrudeProductCategoryImageService.DataListToContractList(data.ProductCategoryImage);
            contract.ProductCategoryDocumentation = CrudeProductCategoryDocumentationService.DataListToContractList(data.ProductCategoryDocumentation);

            return contract;
        }

        public long PositionDown(Guid productCategoryId) {
            // get current category
            var currentCategoryData = new CrudeProductCategoryData();
            currentCategoryData.FetchByProductCategoryId(productCategoryId);

            // get next category according to position
            var nextCategoryData = new CrudeProductCategoryData();
            nextCategoryData.FetchNextProductCategoryByPosition(currentCategoryData.ProductCategoryParentId,
                                                                currentCategoryData.ProductCategoryPosition
                                                                );

            // protect against edge cases
            if ( nextCategoryData.ProductCategoryId != Guid.Empty ) {
                // swap 
                int nextPosition = nextCategoryData.ProductCategoryPosition;
                nextCategoryData.ProductCategoryPosition = currentCategoryData.ProductCategoryPosition;
                currentCategoryData.ProductCategoryPosition = nextPosition;

                // start transaction
                using ( var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try {
                        currentCategoryData.Update(connection, transaction);
                        nextCategoryData.Update(connection, transaction);

                        transaction.Commit();
                    } catch ( Exception ex ) {
                        transaction.Rollback();
                        throw ex;
                    }
                }

                return nextPosition;
            }
            return 0;
        }

        public long PositionUp(Guid productCategoryId) {
            // get current category
            var currentCategoryData = new CrudeProductCategoryData();
            currentCategoryData.FetchByProductCategoryId(productCategoryId);

            // get previous category according to position
            var previousCategoryData = new CrudeProductCategoryData();
            previousCategoryData.FetchPreviousProductCategoryByPosition(currentCategoryData.ProductCategoryParentId,
                                                                        currentCategoryData.ProductCategoryPosition
                                                                        );

            // protect against edge cases
            if ( previousCategoryData.ProductCategoryId != Guid.Empty ) {
                // swap
                int previousPosition = previousCategoryData.ProductCategoryPosition;
                previousCategoryData.ProductCategoryPosition = currentCategoryData.ProductCategoryPosition;
                currentCategoryData.ProductCategoryPosition = previousPosition;

                // start transaction
                using ( var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try {
                        currentCategoryData.Update(connection, transaction);
                        previousCategoryData.Update(connection, transaction);
                        transaction.Commit();
                    } catch ( Exception ex ) {
                        transaction.Rollback();
                        throw ex;
                    }
                }

                return previousPosition;
            }

            return 0;
        }
    }
}
