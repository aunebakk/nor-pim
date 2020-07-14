/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:45:16 AM
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
    public partial class ProductReferenceAttributeUnitSearchWithFilterData {
        
        public string ProductAttributeUnitName { get; set; }
        
        public string ProductAttributeUnitRcd { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void Populate(IDataReader reader, ProductReferenceAttributeUnitSearchWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductAttributeUnitName)) ProductAttributeUnitName = reader.GetString(ordinals.ProductAttributeUnitName);
            if (!reader.IsDBNull(ordinals.ProductAttributeUnitRcd)) ProductAttributeUnitRcd = reader.GetString(ordinals.ProductAttributeUnitRcd);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
        }
    }
    
    public partial class ProductReferenceAttributeUnitSearchWithFilterDataOrdinals {
        
        public int ProductAttributeUnitName;
        
        public int ProductAttributeUnitRcd;
        
        public int DateTime;
        
        public ProductReferenceAttributeUnitSearchWithFilterDataOrdinals(IDataReader reader) {
            ProductAttributeUnitName = reader.GetOrdinal("product_attribute_unit_name");
            ProductAttributeUnitRcd = reader.GetOrdinal("product_attribute_unit_rcd");
            DateTime = reader.GetOrdinal("date_time");
        }
    }
}
