/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:54:37 AM
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
    public partial interface IProductReferenceDocumentationTypeService {
        
        // Gets parent and children
        [OperationContract()]
        ProductReferenceDocumentationTypeContract ProductReferenceDocumentationTypeCompleteGet(string productDocumentationTypeRcd, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        [OperationContract()]
        string ProductReferenceDocumentationTypeCompleteUpdate(string productDocumentationTypeRcd, ProductReferenceDocumentationTypeContract productContract, System.Guid userId);
    }
    
    public partial class ProductReferenceDocumentationTypeService : IProductReferenceDocumentationTypeService {
        
        // Gets parent and children
        public ProductReferenceDocumentationTypeContract ProductReferenceDocumentationTypeCompleteGet(string productDocumentationTypeRcd, System.Guid userId) {
            var productContract = 
                new ProductReferenceDocumentationTypeContract();

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                try {
                    productContract.ProductDocumentationTypeRef = 
                        new CrudeProductDocumentationTypeRefService().FetchAll();

                    // save checksum for comparison on update
                    productContract.ChecksumAfterGet = productContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child ProductDocumentationTypeRef", ex);
                }
            }

            return productContract;
        }
        
        // Updates parent, children are added or updated as needed
        public string ProductReferenceDocumentationTypeCompleteUpdate(string productDocumentationTypeRcd, ProductReferenceDocumentationTypeContract productContract, System.Guid userId) {

            // check for differences since fetch
            if (productContract.ChecksumAfterGet.Equals(productContract.Checksum()))
                return String.Empty;

            // check for database differences since fetch
            ProductReferenceDocumentationTypeContract productContractCurrent = ProductReferenceDocumentationTypeCompleteGet(productDocumentationTypeRcd, userId);
            if (!productContract.ChecksumAfterGet.Equals(productContractCurrent.Checksum())) 
                throw new Exception("ProductReferenceDocumentationTypeCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent product documentation type ref
                    foreach (CrudeProductDocumentationTypeRefContract productDocumentationTypeRef in productContract.ProductDocumentationTypeRef) {
                        new CrudeProductDocumentationTypeRefService().Update(productDocumentationTypeRef, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child ProductDocumentationTypeRef", ex);
                }
            }

            return String.Empty;

        }
    }
}
