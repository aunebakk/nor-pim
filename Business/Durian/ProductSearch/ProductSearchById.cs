/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:44 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class ProductSearchById {

        public ProductSearchByIdContract ProductSearchByIdFromDal(ProductSearchByIdData data) {
            ProductSearchByIdContract contract = new ProductSearchByIdContract();
            DataToContract(data, contract);

            return contract;
        }

        public void DataToContract(ProductSearchByIdData dalProductSearchById, ProductSearchByIdContract dataContract) {
            dataContract.ProductName = dalProductSearchById.ProductName;
            dataContract.Identifier = dalProductSearchById.Identifier;
            dataContract.Value = dalProductSearchById.Value;
            dataContract.ProductInfoValue = dalProductSearchById.ProductInfoValue;
            dataContract.ProductImageTypeRcd = dalProductSearchById.ProductImageTypeRcd;
            dataContract.ProductImageTypeName = dalProductSearchById.ProductImageTypeName;
            dataContract.Image = dalProductSearchById.Image;
        }
    }
}
