// test
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.BusinessLogicLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [ServiceContract()]
    public interface ICategorySearchService {
        [OperationContract()]
        List<CategoryTreeContract> CategoryTree();

        [OperationContract()]
        List<CategoryFindContract> CategoryFind(string findWhat);
    }

    public class CategorySearchService : ICategorySearchService {
        public List<CategoryTreeContract> CategoryTree() {
            var dataAccessLayer = new norpim.DataAccessLayer.CategorySearch();
            var businessLogicLayer = new CategoryTree();
            return businessLogicLayer.CategoryTreeFromDal(dataAccessLayer.CategoryTree());
        }

        public List<CategoryFindContract> CategoryFind(string findWhat) {
            var dataAccessLayer = new norpim.DataAccessLayer.CategorySearch();
            var businessLogicLayer = new CategoryFind();
            return businessLogicLayer.CategoryFindFromDal(dataAccessLayer.CategoryFind(findWhat));
        }
    }
}
