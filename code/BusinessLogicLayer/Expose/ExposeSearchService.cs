using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.BusinessLogicLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public interface IExposeSearchService {
        [OperationContract()]
        List<ExposeProductDetailsContract> ExposeProductDetails(Guid productExposeSetId);
    }
    
    public class ExposeSearchService : IExposeSearchService {
        public List<ExposeProductDetailsContract> ExposeProductDetails(Guid productExposeSetId) {
            var dataAccessLayer = new norpim.DataAccessLayer.ExposeSearch();
            var businessLogicLayer = new ExposeProductDetails();
            return businessLogicLayer.ExposeProductDetailsFromDal(dataAccessLayer.ExposeProductDetails(productExposeSetId));
        }
    }
}
