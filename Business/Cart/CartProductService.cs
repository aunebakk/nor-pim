/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:53:46 AM
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
    public partial interface ICartProductService {
        
        // Gets parent and children
        // getter for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/28672bb5-d65f-4daa-84f5-56d7bfad4b22
        [OperationContract()]
        CartProductContract CartProductCompleteGet(System.Guid cartProductId, System.Guid userId);
        
        // Updates parent, children are added or updated as needed
        // updater for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/b1aacc4e-64a1-4147-8b95-3a76ab53cf0c
        [OperationContract()]
        System.Guid CartProductCompleteUpdate(System.Guid cartProductId, CartProductContract cartProductContract, System.Guid userId);
    }
    
    public partial class CartProductService : ICartProductService {
        
        // Gets parent and children
        // getter for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/28672bb5-d65f-4daa-84f5-56d7bfad4b22
        public CartProductContract CartProductCompleteGet(System.Guid cartProductId, System.Guid userId) {
            var cartProductContract = 
                new CartProductContract();

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                try {
                    cartProductContract.CartProduct = 
                        new CrudeCartProductService().FetchAll();

                    // save checksum for comparison on update
                    cartProductContract.ChecksumAfterGet = cartProductContract.Checksum();

                } catch (Exception ex) {
                    throw new Exception("Failed to get Parent/Child CartProduct", ex);
                }
            }

            return cartProductContract;
        }
        
        // Updates parent, children are added or updated as needed
        // updater for service
        // links:
        //  docLink: http://sql2x.org/documentationLink/b1aacc4e-64a1-4147-8b95-3a76ab53cf0c
        public System.Guid CartProductCompleteUpdate(System.Guid cartProductId, CartProductContract cartProductContract, System.Guid userId) {

            // check for differences since fetch
            if (cartProductContract.ChecksumAfterGet.Equals(cartProductContract.Checksum()))
                return Guid.Empty;

            // check for database differences since fetch
            CartProductContract cartProductContractCurrent = CartProductCompleteGet(cartProductId, userId);
            if (!cartProductContract.ChecksumAfterGet.Equals(cartProductContractCurrent.Checksum())) 
                throw new Exception("CartProductCompleteUpdate, data has changed since fetch");

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // update parent cart product
                    foreach (CrudeCartProductContract cartProduct in cartProductContract.CartProduct) {
                        new CrudeCartProductService().Update(cartProduct, connection, transaction);
                    }

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Failed to update Parent/Child CartProduct", ex);
                }
            }

            return Guid.Empty;

        }
    }
}
