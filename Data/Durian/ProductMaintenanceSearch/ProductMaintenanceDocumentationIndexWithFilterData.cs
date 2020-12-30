/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:15:49 PM
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
    // this class start with an identical representation of a ansi sql select statement in ProductMaintenanceDocumentationIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class ProductMaintenanceDocumentationIndexWithFilterData {
        
        public string ProductName { get; set; }
        
        public string ProductDocumentationTypeName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public string StateRcd { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string ProductDocumentationTypeRcd { get; set; }
        
        public string Documentation { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ProductDocumentationId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, ProductMaintenanceDocumentationIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.ProductDocumentationTypeName)) ProductDocumentationTypeName = reader.GetString(ordinals.ProductDocumentationTypeName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductDocumentationTypeRcd)) ProductDocumentationTypeRcd = reader.GetString(ordinals.ProductDocumentationTypeRcd);
            if (!reader.IsDBNull(ordinals.Documentation)) Documentation = reader.GetString(ordinals.Documentation);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductDocumentationId)) ProductDocumentationId = reader.GetGuid(ordinals.ProductDocumentationId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in ProductMaintenanceDocumentationIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class ProductMaintenanceDocumentationIndexWithFilterDataOrdinals {
        
        public int ProductName;
        
        public int ProductDocumentationTypeName;
        
        public int DefaultUserName;
        
        public int StateRcd;
        
        public int ProductId;
        
        public int ProductDocumentationTypeRcd;
        
        public int Documentation;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductDocumentationId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public ProductMaintenanceDocumentationIndexWithFilterDataOrdinals(IDataReader reader) {
            ProductName = reader.GetOrdinal("product_name");
            ProductDocumentationTypeName = reader.GetOrdinal("product_documentation_type_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            ProductId = reader.GetOrdinal("product_id");
            ProductDocumentationTypeRcd = reader.GetOrdinal("product_documentation_type_rcd");
            Documentation = reader.GetOrdinal("documentation");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductDocumentationId = reader.GetOrdinal("product_documentation_id");
        }
    }
}
