/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:59:42 PM
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
    public partial interface IProductReferenceImageTypeService {
        
        // Gets parent and children
        [OperationContract()]
        ProductReferenceImageTypeContract ProductReferenceImageTypeCompleteGet(string productImageTypeRcd, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        [OperationContract()]
        string ProductReferenceImageTypeCompleteUpdate(string productImageTypeRcd, ProductReferenceImageTypeContract productContract, System.Guid userId);
    }
    
    public partial class ProductReferenceImageTypeService : IProductReferenceImageTypeService {
        
        // Gets parent and children
        public ProductReferenceImageTypeContract ProductReferenceImageTypeCompleteGet(string productImageTypeRcd, System.Guid userId) {
            var productContract = 
                new ProductReferenceImageTypeContract();

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                try {
                    productContract.ProductImageTypeRef = 
                        new CrudeProductImageTypeRefService().FetchAll();

                    // save checksum for comparison on update
                    productContract.ChecksumAfterGet = productContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child ProductImageTypeRef", ex);
                }
            }

            return productContract;
        }
        
        // Updates parent, children are added or updated as needed
        public string ProductReferenceImageTypeCompleteUpdate(string productImageTypeRcd, ProductReferenceImageTypeContract productContract, System.Guid userId) {

            // check for differences since fetch
            if (productContract.ChecksumAfterGet.Equals(productContract.Checksum()))
                return String.Empty;

            // check for database differences since fetch
            ProductReferenceImageTypeContract productContractCurrent = ProductReferenceImageTypeCompleteGet(productImageTypeRcd, userId);
            if (!productContract.ChecksumAfterGet.Equals(productContractCurrent.Checksum())) 
                throw new Exception("ProductReferenceImageTypeCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent product image type ref
                    foreach (CrudeProductImageTypeRefContract productImageTypeRef in productContract.ProductImageTypeRef) {
                        new CrudeProductImageTypeRefService().Update(productImageTypeRef, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child ProductImageTypeRef", ex);
                }
            }

            return String.Empty;

        }
    }
}
