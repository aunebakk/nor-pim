using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using norpim.DataAccessLayer;
using System.Collections.Generic;

namespace norpim.BusinessLogicLayer {
    [ServiceContract()]
    public interface IProductService {
        [OperationContract()]
        ProductContract ProductGetCompleteById( Guid productId);

        [OperationContract()]
        void ProductSaveCompleteById(   ProductContract contract,
                                        Guid userId
                                        );

        [OperationContract()]
        Guid ProductAdd(    Guid productCategoryId,
                            string productName,
                            Guid userId
                            );

        [OperationContract()]
        List<ProductHistoryContract> ProductHistory(Guid productId);
    }

    /// <domain>Product</domain>
    /// <namespace>norpim.BusinessLogicLayer.Other</namespace>
    public class ProductService : IProductService {

        public ProductContract ProductGetCompleteById(Guid productId) {
            var contract = new ProductContract();
            var data = new Product(productId);

            // move data from data access layer to business logic layer
            contract.Product = new CrudeProductContract();
            CrudeProductService.DataToContract(data.product, contract.Product);

            contract.ProductAttribute = CrudeProductAttributeService.DataListToContractList(data.ProductAttribute);
            contract.ProductIdentifier = CrudeProductIdentifierService.DataListToContractList(data.ProductIdentifier);
            contract.ProductInfo = CrudeProductInfoService.DataListToContractList(data.ProductInfo);
            contract.ProductImage = CrudeProductImageService.DataListToContractList(data.ProductImage);
            contract.ProductDocumentation = CrudeProductDocumentationService.DataListToContractList(data.ProductDocumentation);

            // generate checksum 

            return contract;
        }

        public void ProductSaveCompleteById(ProductContract contract,
                                            Guid userId
                                            ) {

            // check checksum ( object has hash code )

            // move from contract to data
            var data = new Product();
            CrudeProductService.DataToContract(data.product, contract.Product);
            CrudeProductAttributeService.ContractListToDataList(contract.ProductAttribute, data.ProductAttribute);
            CrudeProductIdentifierService.ContractListToDataList(contract.ProductIdentifier, data.ProductIdentifier);
            CrudeProductInfoService.ContractListToDataList(contract.ProductInfo, data.ProductInfo);
            CrudeProductImageService.ContractListToDataList(contract.ProductImage, data.ProductImage);
            CrudeProductDocumentationService.ContractListToDataList(contract.ProductDocumentation, data.ProductDocumentation);

            // save product
            data.Save(userId);
        }
        
        public Guid ProductAdd( Guid productCategoryId,
                                string productName,
                                Guid userId
                                ) {

            // add product
            var productContract = new CrudeProductContract();
            productContract.ProductId = Guid.NewGuid();
            productContract.ProductName = productName;
            productContract.StateRcd = StateRef.Created;
            productContract.UserId = userId;
            productContract.DateTime = DateTime.UtcNow;

            var productBll = new CrudeProductService();
            productBll.Insert(productContract);

            // map to category
            var productCategoryMapping = new CrudeProductCategoryMappingContract();
            productCategoryMapping.ProductCategoryMappingId = Guid.NewGuid();
            productCategoryMapping.ProductId = productContract.ProductId;
            productCategoryMapping.ProductCategoryId = productCategoryId;
            productCategoryMapping.UserId = userId;
            productCategoryMapping.DateTime = DateTime.UtcNow;

            var mappingBll = new CrudeProductCategoryMappingService();
            mappingBll.Insert(productCategoryMapping);

            return productContract.ProductId;
        }

        public List<ProductHistoryContract> ProductHistory(Guid productId) {
            var dataAccessLayer = new norpim.DataAccessLayer.ProductSearch();
            List<norpim.DataAccessLayer.ProductHistory> dataList = new List<DataAccessLayer.ProductHistory>();

            // get start
            var data = dataAccessLayer.ProductHistoryPart(productId);
            dataList.Add(data);

            // get next
            while (data.ProductBecameId != Guid.Empty) {
                data = dataAccessLayer.ProductHistoryPart(data.ProductBecameId);
                dataList.Add(data);
            }

            // get previous
            data = dataAccessLayer.ProductHistoryBecame(productId);
            while (data.ProductId != Guid.Empty) {
                dataList.Add(data);
                data = dataAccessLayer.ProductHistoryBecame(data.ProductId);
            }

            var businessLogicLayer = new ProductHistory();
            return businessLogicLayer.ProductHistoryFromDal(dataList);
        }

    }

    [DataContract()]
    public class ProductContract {
        [DataMember()]
        public CrudeProductContract Product { get; set; }

        [DataMember()]
        public List<CrudeProductAttributeContract> ProductAttribute { get; set; }        

        [DataMember()]
        public List<CrudeProductIdentifierContract> ProductIdentifier { get; set; }        

        [DataMember()]
        public List<CrudeProductInfoContract> ProductInfo { get; set; }        

        [DataMember()]
        public List<CrudeProductImageContract> ProductImage { get; set; }        

        [DataMember()]
        public List<CrudeProductDocumentationContract> ProductDocumentation { get; set; }        
    }
}
