using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    public class ProductStatisticsByMonth {
        
        public List<ProductStatisticsByMonthContract> ProductStatisticsByMonthFromDal(List<norpim.DataAccessLayer.ProductStatisticsByMonth> dataList) {
           var list = new List<ProductStatisticsByMonthContract>();

           foreach (norpim.DataAccessLayer.ProductStatisticsByMonth data in dataList) {
               var contract = new ProductStatisticsByMonthContract();
               CopyDalToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void CopyDalToContract(norpim.DataAccessLayer.ProductStatisticsByMonth dalProductStatisticsByMonth, ProductStatisticsByMonthContract dataContract) {
            dataContract.ActivityDate = dalProductStatisticsByMonth.ActivityDate;
            dataContract.DayCount = dalProductStatisticsByMonth.DayCount;
        }
    }
    
    [DataContract()]
    public class ProductStatisticsByMonthContract {
        
        [DataMember()]
        public string ActivityDate { get; set; } //;
        
        [DataMember()]
        public int DayCount { get; set; } //;
    }
}
