using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.BusinessLogicLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public interface IGatherSearchService {

        [OperationContract()]
        List<GatherOverviewContract> GatherOverview();

        [OperationContract()]
        List<GatherProductDetailsContract> GatherProductDetails(Guid productGatherId);
    }

    public class GatherSearchService : IGatherSearchService {

        public List<GatherOverviewContract> GatherOverview() {
            var dataAccessLayer = new norpim.DataAccessLayer.GatherSearch();
            var businessLogicLayer = new GatherOverview();
            return businessLogicLayer.GatherOverviewFromDal(dataAccessLayer.GatherOverview());
        }

        public List<GatherProductDetailsContract> GatherProductDetails(Guid productGatherId) {
            var dataAccessLayer = new norpim.DataAccessLayer.GatherSearch();
            var businessLogicLayer = new GatherProductDetails();
            return businessLogicLayer.GatherProductDetailsFromDal(dataAccessLayer.GatherProductDetails(productGatherId));
        }
    }
}
