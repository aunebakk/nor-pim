/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:27:48 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class ProductReferenceAttributeSearchWithFilterData {
        
        public string ProductAttributeName { get; set; }
        
        public string ProductAttributeRcd { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void Populate(IDataReader reader, ProductReferenceAttributeSearchWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductAttributeName)) ProductAttributeName = reader.GetString(ordinals.ProductAttributeName);
            if (!reader.IsDBNull(ordinals.ProductAttributeRcd)) ProductAttributeRcd = reader.GetString(ordinals.ProductAttributeRcd);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
        }
    }
    
    public partial class ProductReferenceAttributeSearchWithFilterDataOrdinals {
        
        public int ProductAttributeName;
        
        public int ProductAttributeRcd;
        
        public int DateTime;
        
        public ProductReferenceAttributeSearchWithFilterDataOrdinals(IDataReader reader) {
            ProductAttributeName = reader.GetOrdinal("product_attribute_name");
            ProductAttributeRcd = reader.GetOrdinal("product_attribute_rcd");
            DateTime = reader.GetOrdinal("date_time");
        }
    }
}
