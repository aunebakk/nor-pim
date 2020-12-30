/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:16:09 PM
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
    // this class start with an identical representation of a ansi sql select statement in ProductReferenceAttributeUnitSearchWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class ProductReferenceAttributeUnitSearchWithFilterData {
        
        public string ProductAttributeUnitName { get; set; }
        
        public string ProductAttributeUnitRcd { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, ProductReferenceAttributeUnitSearchWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductAttributeUnitName)) ProductAttributeUnitName = reader.GetString(ordinals.ProductAttributeUnitName);
            if (!reader.IsDBNull(ordinals.ProductAttributeUnitRcd)) ProductAttributeUnitRcd = reader.GetString(ordinals.ProductAttributeUnitRcd);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in ProductReferenceAttributeUnitSearchWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class ProductReferenceAttributeUnitSearchWithFilterDataOrdinals {
        
        public int ProductAttributeUnitName;
        
        public int ProductAttributeUnitRcd;
        
        public int DateTime;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public ProductReferenceAttributeUnitSearchWithFilterDataOrdinals(IDataReader reader) {
            ProductAttributeUnitName = reader.GetOrdinal("product_attribute_unit_name");
            ProductAttributeUnitRcd = reader.GetOrdinal("product_attribute_unit_rcd");
            DateTime = reader.GetOrdinal("date_time");
        }
    }
}
