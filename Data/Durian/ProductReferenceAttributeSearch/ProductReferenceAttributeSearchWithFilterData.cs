/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:55:00 AM
  From Machine: DESKTOP-9A2DH39
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
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in ProductReferenceAttributeSearchWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class ProductReferenceAttributeSearchWithFilterData {
        
        public string ProductAttributeName { get; set; }
        
        public string ProductAttributeRcd { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, ProductReferenceAttributeSearchWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductAttributeName)) ProductAttributeName = reader.GetString(ordinals.ProductAttributeName);
            if (!reader.IsDBNull(ordinals.ProductAttributeRcd)) ProductAttributeRcd = reader.GetString(ordinals.ProductAttributeRcd);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in ProductReferenceAttributeSearchWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class ProductReferenceAttributeSearchWithFilterDataOrdinals {
        
        public int ProductAttributeName;
        
        public int ProductAttributeRcd;
        
        public int DateTime;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public ProductReferenceAttributeSearchWithFilterDataOrdinals(IDataReader reader) {
            ProductAttributeName = reader.GetOrdinal("product_attribute_name");
            ProductAttributeRcd = reader.GetOrdinal("product_attribute_rcd");
            DateTime = reader.GetOrdinal("date_time");
        }
    }
}
