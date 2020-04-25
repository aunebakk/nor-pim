﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:41:01 AM
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
    public partial interface IProductMaintenanceSearchService {
        
        [OperationContract()]
        List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter(System.Guid productId);
    }
    
    public partial class ProductMaintenanceSearchService : IProductMaintenanceSearchService {
        
        public virtual List<ProductMaintenanceInfoIndexWithFilterContract> ProductMaintenanceInfoIndexWithFilter(System.Guid productId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductMaintenanceSearch();
            var businessLogicLayer = new ProductMaintenanceInfoIndexWithFilter();
            return businessLogicLayer.ProductMaintenanceInfoIndexWithFilterFromDal(dataAccessLayer.ProductMaintenanceInfoIndexWithFilter(productId));
        }
    }
}
