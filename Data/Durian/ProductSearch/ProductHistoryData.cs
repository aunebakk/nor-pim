/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:14:47 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  data access layer: https://en.wikipedia.org/wiki/Data_access_layer
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in ProductHistoryData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class ProductHistoryData {
        
        public System.Guid ProductId { get; set; }
        
        public string ProductName { get; set; }
        
        public string StateName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string UserName { get; set; }
        
        public System.Guid ProductBecameId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, ProductHistoryDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.StateName)) StateName = reader.GetString(ordinals.StateName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.UserName)) UserName = reader.GetString(ordinals.UserName);
            if (!reader.IsDBNull(ordinals.ProductBecameId)) ProductBecameId = reader.GetGuid(ordinals.ProductBecameId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in ProductHistoryData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class ProductHistoryDataOrdinals {
        
        public int ProductId;
        
        public int ProductName;
        
        public int StateName;
        
        public int DateTime;
        
        public int UserName;
        
        public int ProductBecameId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public ProductHistoryDataOrdinals(IDataReader reader) {
            ProductId = reader.GetOrdinal("product_id");
            ProductName = reader.GetOrdinal("product_name");
            StateName = reader.GetOrdinal("state_name");
            DateTime = reader.GetOrdinal("date_time");
            UserName = reader.GetOrdinal("user_name");
            ProductBecameId = reader.GetOrdinal("product_became_id");
        }
    }
}
