/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:20 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System.Collections.Generic;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface ICategorySearchService {

        [OperationContract()]
        List<CategoryTreeContract> CategoryTree();
        [OperationContract()]
        List<CategoryFindContract> CategoryFind(string findWhat);
    }

    public partial class CategorySearchService : ICategorySearchService {

        public virtual List<CategoryTreeContract> CategoryTree() {
            DataAccessLayer.CategorySearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.CategorySearch();
            CategoryTree businessLogicLayer = new CategoryTree();
            return businessLogicLayer.CategoryTreeFromDal(dataAccessLayer.CategoryTree());
        }

        public List<CategoryFindContract> CategoryFind(string findWhat) {
            DataAccessLayer.CategorySearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.CategorySearch();
            CategoryFind businessLogicLayer = new CategoryFind();
            return businessLogicLayer.CategoryFindFromDal(dataAccessLayer.CategoryFind(findWhat));
        }
    }
}
