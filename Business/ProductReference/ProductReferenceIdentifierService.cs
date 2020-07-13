/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:06:19 AM
  From Machine: DESKTOP-00MSEIL
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
    public partial interface IProductReferenceIdentifierService {
        
        // Gets parent and children
        [OperationContract()]
        ProductReferenceIdentifierContract ProductReferenceIdentifierCompleteGet(System.Guid productIdentifierId, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        [OperationContract()]
        System.Guid ProductReferenceIdentifierCompleteUpdate(System.Guid productIdentifierId, ProductReferenceIdentifierContract productContract, System.Guid userId);
    }
    
    public partial class ProductReferenceIdentifierService : IProductReferenceIdentifierService {
        
        // Gets parent and children
        public ProductReferenceIdentifierContract ProductReferenceIdentifierCompleteGet(System.Guid productIdentifierId, System.Guid userId) {
            var productContract = 
                new ProductReferenceIdentifierContract();

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                try {
                    productContract.ProductIdentifier = 
                        new CrudeProductIdentifierService().FetchAll();

                    productContract.ProductIdentifierRef = 
                        new CrudeProductIdentifierRefService().FetchAll();

                    // save checksum for comparison on update
                    productContract.ChecksumAfterGet = productContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child ProductIdentifier", ex);
                }
            }

            return productContract;
        }
        
        // Updates parent, children are added or updated as needed
        public System.Guid ProductReferenceIdentifierCompleteUpdate(System.Guid productIdentifierId, ProductReferenceIdentifierContract productContract, System.Guid userId) {

            // check for differences since fetch
            if (productContract.ChecksumAfterGet.Equals(productContract.Checksum()))
                return Guid.Empty;

            // check for database differences since fetch
            ProductReferenceIdentifierContract productContractCurrent = ProductReferenceIdentifierCompleteGet(productIdentifierId, userId);
            if (!productContract.ChecksumAfterGet.Equals(productContractCurrent.Checksum())) 
                throw new Exception("ProductReferenceIdentifierCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent product identifier
                    foreach (CrudeProductIdentifierContract productIdentifier in productContract.ProductIdentifier) {
                        new CrudeProductIdentifierService().Update(productIdentifier, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child ProductIdentifier", ex);
                }
            }

            return Guid.Empty;

        }
    }
}
