/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 7:22:48 PM
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
    public partial interface IProductReferenceAttributeService {
        
        // Gets parent and children
        [OperationContract()]
        ProductReferenceAttributeContract ProductReferenceAttributeCompleteGet(string productAttributeRcd, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        [OperationContract()]
        string ProductReferenceAttributeCompleteUpdate(string productAttributeRcd, ProductReferenceAttributeContract productContract, System.Guid userId);
    }
    
    public partial class ProductReferenceAttributeService : IProductReferenceAttributeService {
        
        // Gets parent and children
        public ProductReferenceAttributeContract ProductReferenceAttributeCompleteGet(string productAttributeRcd, System.Guid userId) {
            var productContract = 
                new ProductReferenceAttributeContract();

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                try {
                    productContract.ProductAttributeRef = 
                        new CrudeProductAttributeRefService().FetchAll();

                    // save checksum for comparison on update
                    productContract.ChecksumAfterGet = productContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child ProductAttributeRef", ex);
                }
            }

            return productContract;
        }
        
        // Updates parent, children are added or updated as needed
        public string ProductReferenceAttributeCompleteUpdate(string productAttributeRcd, ProductReferenceAttributeContract productContract, System.Guid userId) {

            // check for differences since fetch
            if (productContract.ChecksumAfterGet.Equals(productContract.Checksum()))
                return String.Empty;

            // check for database differences since fetch
            ProductReferenceAttributeContract productContractCurrent = ProductReferenceAttributeCompleteGet(productAttributeRcd, userId);
            if (!productContract.ChecksumAfterGet.Equals(productContractCurrent.Checksum())) 
                throw new Exception("ProductReferenceAttributeCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent product attribute ref
                    foreach (CrudeProductAttributeRefContract productAttributeRef in productContract.ProductAttributeRef) {
                        new CrudeProductAttributeRefService().Update(productAttributeRef, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child ProductAttributeRef", ex);
                }
            }

            return String.Empty;

        }
    }
}
