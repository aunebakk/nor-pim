/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:51:12 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  docLink: http://sql2x.org/documentationLink/3f5526a4-3503-435d-96a1-5a88aaeb7b9f
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of ProductSearchById's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/babfd233-23de-489f-8f62-51eaec05a19e
    public class ProductSearchById {
        
        public ProductSearchByIdContract ProductSearchByIdFromDal(ProductSearchByIdData data) {
            var contract = new ProductSearchByIdContract();
            DataToContract(data, contract);

            return contract;
        }
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/6140089a-d7c9-4e92-b385-f6fd91026820
        // parameters:
        //  dalProductSearchById: from durian ansi sql select statement
        //  dataContract: business wcf contract
        public void DataToContract(ProductSearchByIdData dalProductSearchById, ProductSearchByIdContract dataContract) {
            dataContract.ProductName = dalProductSearchById.ProductName;
            dataContract.Identifier = dalProductSearchById.Identifier;
            dataContract.Value = dalProductSearchById.Value;
            dataContract.ProductInfoValue = dalProductSearchById.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchById.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchById.ProductImageTypeName;
            dataContract.Image = dalProductSearchById.Image;
        }
    }
}
