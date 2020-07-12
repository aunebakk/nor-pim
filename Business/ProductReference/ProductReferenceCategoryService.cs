/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:51:39 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateByServiceTableCrudGenerator.BusinessUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface IProductReferenceCategoryService {
        
        // Gets parent and children
        [OperationContract()]
        ProductReferenceCategoryContract ProductReferenceCategoryCompleteGet(System.Guid productCategoryId, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        [OperationContract()]
        System.Guid ProductReferenceCategoryCompleteUpdate(System.Guid productCategoryId, ProductReferenceCategoryContract productContract, System.Guid userId);
    }
    
    public partial class ProductReferenceCategoryService : IProductReferenceCategoryService {
        
        // Gets parent and children
        public ProductReferenceCategoryContract ProductReferenceCategoryCompleteGet(System.Guid productCategoryId, System.Guid userId) {
            var productContract = 
                new ProductReferenceCategoryContract();

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                try {
                    productContract.ProductCategory = 
                        new CrudeProductCategoryService().FetchAll();

                    // save checksum for comparison on update
                    productContract.ChecksumAfterGet = productContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child ProductCategory", ex);
                }
            }

            return productContract;
        }
        
        // Updates parent, children are added or updated as needed
        public System.Guid ProductReferenceCategoryCompleteUpdate(System.Guid productCategoryId, ProductReferenceCategoryContract productContract, System.Guid userId) {

            // check for differences since fetch
            if (productContract.ChecksumAfterGet.Equals(productContract.Checksum()))
                return Guid.Empty;

            // check for database differences since fetch
            ProductReferenceCategoryContract productContractCurrent = ProductReferenceCategoryCompleteGet(productCategoryId, userId);
            if (!productContract.ChecksumAfterGet.Equals(productContractCurrent.Checksum())) 
                throw new Exception("ProductReferenceCategoryCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent product category
                    foreach (CrudeProductCategoryContract productCategory in productContract.ProductCategory) {
                        new CrudeProductCategoryService().Update(productCategory, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child ProductCategory", ex);
                }
            }

            return Guid.Empty;

        }
    }
}
