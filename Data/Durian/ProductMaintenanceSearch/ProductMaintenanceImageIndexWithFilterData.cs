/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:54:38 AM
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
    // this class start with an identical representation of a ansi sql select statement in ProductMaintenanceImageIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class ProductMaintenanceImageIndexWithFilterData {
        
        public string ProductName { get; set; }
        
        public string ProductImageTypeName { get; set; }
        
        public string ImageFileName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public string StateRcd { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string ProductImageTypeRcd { get; set; }
        
        public byte[] Image { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ProductImageId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, ProductMaintenanceImageIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.ProductImageTypeName)) ProductImageTypeName = reader.GetString(ordinals.ProductImageTypeName);
            if (!reader.IsDBNull(ordinals.ImageFileName)) ImageFileName = reader.GetString(ordinals.ImageFileName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductImageTypeRcd)) ProductImageTypeRcd = reader.GetString(ordinals.ProductImageTypeRcd);
            if (!reader.IsDBNull(ordinals.Image)) Image = (System.Byte[]) reader[ordinals.Image];
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductImageId)) ProductImageId = reader.GetGuid(ordinals.ProductImageId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in ProductMaintenanceImageIndexWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class ProductMaintenanceImageIndexWithFilterDataOrdinals {
        
        public int ProductName;
        
        public int ProductImageTypeName;
        
        public int ImageFileName;
        
        public int DefaultUserName;
        
        public int StateRcd;
        
        public int ProductId;
        
        public int ProductImageTypeRcd;
        
        public int Image;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductImageId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public ProductMaintenanceImageIndexWithFilterDataOrdinals(IDataReader reader) {
            ProductName = reader.GetOrdinal("product_name");
            ProductImageTypeName = reader.GetOrdinal("product_image_type_name");
            ImageFileName = reader.GetOrdinal("image_file_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            ProductId = reader.GetOrdinal("product_id");
            ProductImageTypeRcd = reader.GetOrdinal("product_image_type_rcd");
            Image = reader.GetOrdinal("image");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductImageId = reader.GetOrdinal("product_image_id");
        }
    }
}
