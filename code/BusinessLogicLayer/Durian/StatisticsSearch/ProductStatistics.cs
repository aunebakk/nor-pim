using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductStatistics {
        
        public List<ProductStatisticsContract> ProductStatisticsFromDal(List<norpim.DataAccessLayer.ProductStatistics> dataList) {
           var list = new List<ProductStatisticsContract>();

           foreach (norpim.DataAccessLayer.ProductStatistics data in dataList) {
               var contract = new ProductStatisticsContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductStatistics dalProductStatistics, ProductStatisticsContract dataContract) {
            dataContract.ActivityDate = dalProductStatistics.ActivityDate;
            dataContract.DayCount = dalProductStatistics.DayCount;
        }
    }
    
    [DataContract()]
    public class ProductStatisticsContract {
        
        [DataMember()]
        public string ActivityDate { get; set; } //;
        
        [DataMember()]
        public int DayCount { get; set; } //;
    }
}
