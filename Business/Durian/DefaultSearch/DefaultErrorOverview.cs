/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:13:57 PM
  From Machine: DESKTOP-LSRVP12
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
//  data access layer: https://en.wikipedia.org/wiki/Data_access_layer
//  docLink: http://sql2x.org/documentationLink/3f5526a4-3503-435d-96a1-5a88aaeb7b9f
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of DefaultErrorOverview's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/babfd233-23de-489f-8f62-51eaec05a19e
    public class DefaultErrorOverview {
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  how to generate durians: https://sql2x.org
        //  docLink: http://sql2x.org/documentationLink/6a251e13-1f76-48af-af34-18c592706874
        // parameters:
        //  dataContract: from durian ansi sql select statement
        public List<DefaultErrorOverviewContract> DefaultErrorOverviewFromDal(List<DefaultErrorOverviewData> dataList) {
           var list = new List<DefaultErrorOverviewContract>();

           foreach (DefaultErrorOverviewData data in dataList) {
               var contract = new DefaultErrorOverviewContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        // transfer serialized data contract to business wcf contract
        // links:
        //  how to generate durians: https://sql2x.org
        //  docLink: http://sql2x.org/documentationLink/6140089a-d7c9-4e92-b385-f6fd91026820
        // parameters:
        //  dalDefaultErrorOverview: from durian ansi sql select statement
        //  dataContract: business wcf contract
        public void DataToContract(DefaultErrorOverviewData dalDefaultErrorOverview, DefaultErrorOverviewContract dataContract) {
            dataContract.DefaultErrorId = dalDefaultErrorOverview.DefaultErrorId;
            dataContract.DateTime = dalDefaultErrorOverview.DateTime;
            dataContract.DefaultErrorLayerName = dalDefaultErrorOverview.DefaultErrorLayerName;
            dataContract.DefaultErrorTypeName = dalDefaultErrorOverview.DefaultErrorTypeName;
            dataContract.DomainName = dalDefaultErrorOverview.DomainName;
            dataContract.ClassName = dalDefaultErrorOverview.ClassName;
            dataContract.MethodName = dalDefaultErrorOverview.MethodName;
            dataContract.ErrorMessage = dalDefaultErrorOverview.ErrorMessage;
        }
    }
}
