/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:34:56 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface ICategorySearchService {
        [OperationContract()]
        List<CategoryFindContract> CategoryFind (System.String findWhat);
        
        [OperationContract()]
        List<CategoryTreeContract> CategoryTree();
    }
    
    public partial class CategorySearchService : ICategorySearchService {
        public List<CategoryFindContract> CategoryFind (System.String findWhat) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.CategorySearch();
            var businessLogicLayer = new CategoryFind();
            return businessLogicLayer.CategoryFindFromDal(dataAccessLayer.CategoryFind(findWhat));
        }
        
        public virtual List<CategoryTreeContract> CategoryTree() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.CategorySearch();
            var businessLogicLayer = new CategoryTree();
            return businessLogicLayer.CategoryTreeFromDal(dataAccessLayer.CategoryTree());
        }
    }
}
