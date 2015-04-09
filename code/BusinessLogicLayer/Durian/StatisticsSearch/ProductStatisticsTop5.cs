using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductStatisticsTop5 {
        
        public List<ProductStatisticsTop5Contract> ProductStatisticsTop5FromDal(List<norpim.DataAccessLayer.ProductStatisticsTop5> dataList) {
           var list = new List<ProductStatisticsTop5Contract>();

           foreach (norpim.DataAccessLayer.ProductStatisticsTop5 data in dataList) {
               var contract = new ProductStatisticsTop5Contract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductStatisticsTop5 dalProductStatisticsTop5, ProductStatisticsTop5Contract dataContract) {
            dataContract.Measurement = dalProductStatisticsTop5.Measurement;
            dataContract.Value = dalProductStatisticsTop5.Value;
        }
    }
    
    [DataContract()]
    public class ProductStatisticsTop5Contract {
        
        [DataMember()]
        public string Measurement { get; set; } //;
        
        [DataMember()]
        public string Value { get; set; } //;
    }
}
