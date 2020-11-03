/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:14:03 AM
  From Machine: DESKTOP-9A2DH39
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
    public partial interface IProductReferenceCategoryDocumentationTypeService {
        
        // Gets parent and children
        [OperationContract()]
        ProductReferenceCategoryDocumentationTypeContract ProductReferenceCategoryDocumentationTypeCompleteGet(string productCategoryDocumentationTypeRcd, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        [OperationContract()]
        string ProductReferenceCategoryDocumentationTypeCompleteUpdate(string productCategoryDocumentationTypeRcd, ProductReferenceCategoryDocumentationTypeContract productContract, System.Guid userId);
    }
    
    public partial class ProductReferenceCategoryDocumentationTypeService : IProductReferenceCategoryDocumentationTypeService {
        
        // Gets parent and children
        public ProductReferenceCategoryDocumentationTypeContract ProductReferenceCategoryDocumentationTypeCompleteGet(string productCategoryDocumentationTypeRcd, System.Guid userId) {
            var productContract = 
                new ProductReferenceCategoryDocumentationTypeContract();

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                try {
                    productContract.ProductCategoryDocumentationTypeRef = 
                        new CrudeProductCategoryDocumentationTypeRefService().FetchAll();

                    // save checksum for comparison on update
                    productContract.ChecksumAfterGet = productContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child ProductCategoryDocumentationTypeRef", ex);
                }
            }

            return productContract;
        }
        
        // Updates parent, children are added or updated as needed
        public string ProductReferenceCategoryDocumentationTypeCompleteUpdate(string productCategoryDocumentationTypeRcd, ProductReferenceCategoryDocumentationTypeContract productContract, System.Guid userId) {

            // check for differences since fetch
            if (productContract.ChecksumAfterGet.Equals(productContract.Checksum()))
                return String.Empty;

            // check for database differences since fetch
            ProductReferenceCategoryDocumentationTypeContract productContractCurrent = ProductReferenceCategoryDocumentationTypeCompleteGet(productCategoryDocumentationTypeRcd, userId);
            if (!productContract.ChecksumAfterGet.Equals(productContractCurrent.Checksum())) 
                throw new Exception("ProductReferenceCategoryDocumentationTypeCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent product category documentation type ref
                    foreach (CrudeProductCategoryDocumentationTypeRefContract productCategoryDocumentationTypeRef in productContract.ProductCategoryDocumentationTypeRef) {
                        new CrudeProductCategoryDocumentationTypeRefService().Update(productCategoryDocumentationTypeRef, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child ProductCategoryDocumentationTypeRef", ex);
                }
            }

            return String.Empty;

        }
    }
}
