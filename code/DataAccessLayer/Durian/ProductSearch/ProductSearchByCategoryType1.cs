using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class ProductSearchByCategoryType1 {
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductName { get; set; } //;
        
        public string Gtin { get; set; } //;
        
        public string Color { get; set; } //;
        
        public void Populate(IDataReader reader, ProductSearchByCategoryType1Ordinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.Gtin)) Gtin = reader.GetString(ordinals.Gtin);
            if (!reader.IsDBNull(ordinals.Color)) Color = reader.GetString(ordinals.Color);
        }
    }
    
    public partial class ProductSearchByCategoryType1Ordinals {
        
        public int ProductId;
        
        public int ProductName;
        
        public int Gtin;
        
        public int Color;
        
        public ProductSearchByCategoryType1Ordinals(IDataReader reader) {
            ProductId = reader.GetOrdinal("product_id");
            ProductName = reader.GetOrdinal("product_name");
            Gtin = reader.GetOrdinal("gtin");
            Color = reader.GetOrdinal("color");
        }
    }
}
