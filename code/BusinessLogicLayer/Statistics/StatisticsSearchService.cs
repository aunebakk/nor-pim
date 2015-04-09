using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.BusinessLogicLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public interface IStatisticsSearchService {

        [OperationContract()]
        List<ProductStatisticsTop5Contract> ProductStatisticsTop5();

        [OperationContract()]
        List<ProductStatisticsContract> ProductStatistics();

        [OperationContract()]
        List<ProductStatisticsByMonthContract> ProductStatisticsByMonth();
    }

    public class StatisticsSearchService : IStatisticsSearchService {

        public List<ProductStatisticsTop5Contract> ProductStatisticsTop5() {
            var dataAccessLayer = new norpim.DataAccessLayer.StatisticsSearch();
            var businessLogicLayer = new ProductStatisticsTop5();
            return businessLogicLayer.ProductStatisticsTop5FromDal(dataAccessLayer.ProductStatisticsTop5());
        }

        public List<ProductStatisticsContract> ProductStatistics() {
            var dataAccessLayer = new norpim.DataAccessLayer.StatisticsSearch();
            var businessLogicLayer = new ProductStatistics();
            return businessLogicLayer.ProductStatisticsFromDal(dataAccessLayer.ProductStatistics());
        }

        public List<ProductStatisticsByMonthContract> ProductStatisticsByMonth() {
            var dataAccessLayer = new norpim.DataAccessLayer.StatisticsSearch();
            var businessLogicLayer = new ProductStatisticsByMonth();
            return businessLogicLayer.ProductStatisticsByMonthFromDal(dataAccessLayer.ProductStatisticsByMonth());
        }
    }
}
