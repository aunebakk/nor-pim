﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:22:02 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class CategoryFind {
        
        public List<CategoryFindContract> CategoryFindFromDal(List<CategoryFindData> dataList) {
           var list = new List<CategoryFindContract>();

           foreach (CategoryFindData data in dataList) {
               var contract = new CategoryFindContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(CategoryFindData dalCategoryFind, CategoryFindContract dataContract) {
            dataContract.ProductCategoryCode = dalCategoryFind.ProductCategoryCode;
            dataContract.ProductName = dalCategoryFind.ProductName;
            dataContract.ProductCategoryId = dalCategoryFind.ProductCategoryId;
            dataContract.ProductId = dalCategoryFind.ProductId;
        }
    }
}