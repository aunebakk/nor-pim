/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:55:15 AM
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

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface IProductReferenceAttributeUnitService {
        
        // Gets parent and children
        // getter for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/28672bb5-d65f-4daa-84f5-56d7bfad4b22
        [OperationContract()]
        ProductReferenceAttributeUnitContract ProductReferenceAttributeUnitCompleteGet(string productAttributeUnitRcd, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        // updater for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/b1aacc4e-64a1-4147-8b95-3a76ab53cf0c
        [OperationContract()]
        string ProductReferenceAttributeUnitCompleteUpdate(string productAttributeUnitRcd, ProductReferenceAttributeUnitContract productContract, System.Guid userId);
    }
    
    public partial class ProductReferenceAttributeUnitService : IProductReferenceAttributeUnitService {
        
        // Gets parent and children
        // getter for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/28672bb5-d65f-4daa-84f5-56d7bfad4b22
        public ProductReferenceAttributeUnitContract ProductReferenceAttributeUnitCompleteGet(string productAttributeUnitRcd, System.Guid userId) {
            var productContract = 
                new ProductReferenceAttributeUnitContract();

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                try {
                    productContract.ProductAttributeUnitRef = 
                        new CrudeProductAttributeUnitRefService().FetchAll();

                    // save checksum for comparison on update
                    productContract.ChecksumAfterGet = productContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child ProductAttributeUnitRef", ex);
                }
            }

            return productContract;
        }
        
        // Updates parent, children are added or updated as needed
        // updater for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/b1aacc4e-64a1-4147-8b95-3a76ab53cf0c
        public string ProductReferenceAttributeUnitCompleteUpdate(string productAttributeUnitRcd, ProductReferenceAttributeUnitContract productContract, System.Guid userId) {

            // check for differences since fetch
            if (productContract.ChecksumAfterGet.Equals(productContract.Checksum()))
                return String.Empty;

            // check for database differences since fetch
            ProductReferenceAttributeUnitContract productContractCurrent = ProductReferenceAttributeUnitCompleteGet(productAttributeUnitRcd, userId);
            if (!productContract.ChecksumAfterGet.Equals(productContractCurrent.Checksum())) 
                throw new Exception("ProductReferenceAttributeUnitCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent product attribute unit ref
                    foreach (CrudeProductAttributeUnitRefContract productAttributeUnitRef in productContract.ProductAttributeUnitRef) {
                        new CrudeProductAttributeUnitRefService().Update(productAttributeUnitRef, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child ProductAttributeUnitRef", ex);
                }
            }

            return String.Empty;

        }
    }
}
