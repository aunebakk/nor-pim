using SolutionNorSolutionPim.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    [ServiceContract()]
    public interface IProductService {
        [OperationContract()]
        ProductContract ProductGetCompleteById(
            Guid productId
            );

        [OperationContract()]
        Guid ProductSaveCompleteById(
            ProductContract contract,
            Guid userId
            );

        [OperationContract()]
        Guid ProductAdd(
            Guid productCategoryId,
            string productName,
            Guid userId
            );

        [OperationContract()]
        List<ProductHistoryContract> ProductHistory(
            Guid productId
            );

        [OperationContract()]
        void ProductChangeAttribute(
            List<Guid> productIds,
            string productAttributeRcd,
            string newAttributeValue,
            string productIdentifierRcd,
            string newIdentifierValue,
            Guid userId
            );

        [OperationContract()]
        void ProductChangeEntities(
            List<ProductChangeEntityContract> productEntities,
            Guid userId
            );
    }

    /// <domain>Product</domain>
    /// <namespace>SolutionNorSolutionPim.BusinessLogicLayer</namespace>
    public class ProductService : IProductService {

        /// <summary>
        /// get product and all entities
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ProductContract ProductGetCompleteById(
            Guid productId
            ) {
            ProductContract contract = new ProductContract();
            Product data = new Product(productId);

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

        /// <summary>
        /// save product and all entities
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="userId"></param>
        /// <returns>new product id</returns>
        public Guid ProductSaveCompleteById(
            ProductContract contract,
            Guid userId
            ) {

            // check checksum ( object has hash code )

            // move from contract to data
            Product data = new Product();
            CrudeProductService.ContractToData(contract.Product, data.product);
            CrudeProductAttributeService.ContractListToDataList(contract.ProductAttribute, data.ProductAttribute);
            CrudeProductIdentifierService.ContractListToDataList(contract.ProductIdentifier, data.ProductIdentifier);
            CrudeProductInfoService.ContractListToDataList(contract.ProductInfo, data.ProductInfo);
            CrudeProductImageService.ContractListToDataList(contract.ProductImage, data.ProductImage);
            CrudeProductDocumentationService.ContractListToDataList(contract.ProductDocumentation, data.ProductDocumentation);

            // save product
            data.Save(userId);

            return data.product.ProductId;
        }

        /// <summary>
        /// add a new product and map it to a category
        /// </summary>
        /// <param name="productCategoryId"></param>
        /// <param name="productName"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Guid ProductAdd(
            Guid productCategoryId,
            string productName,
            Guid userId
            ) {

            // add product
            CrudeProductContract productContract = new CrudeProductContract {
                ProductId = Guid.NewGuid(),
                ProductName = productName,
                StateRcd = DefaultStateRef.Created,
                UserId = userId,
                DateTime = DateTime.UtcNow
            };

            CrudeProductService productBll = new CrudeProductService();
            productBll.Insert(productContract);

            // map to category
            CrudeProductCategoryMappingContract productCategoryMapping = new CrudeProductCategoryMappingContract {
                ProductCategoryMappingId = Guid.NewGuid(),
                ProductId = productContract.ProductId,
                ProductCategoryId = productCategoryId,
                UserId = userId,
                DateTime = DateTime.UtcNow
            };

            CrudeProductCategoryMappingService mappingBll = new CrudeProductCategoryMappingService();
            mappingBll.Insert(productCategoryMapping);

            return productContract.ProductId;
        }

        /// <summary>
        /// get current, past and present information about a product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<ProductHistoryContract> ProductHistory(
            Guid productId
            ) {
            ProductSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ProductSearch();
            List<SolutionNorSolutionPim.DataAccessLayer.ProductHistoryData> dataList = new List<DataAccessLayer.ProductHistoryData>();

            // get start
            ProductHistoryData data = dataAccessLayer.ProductHistoryPart(productId);
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

            ProductHistory businessLogicLayer = new ProductHistory();

            return businessLogicLayer.ProductHistoryFromDal(dataList);
        }

        /// <summary>
        /// change attributes on a series of products
        /// check if current column value is what it was when displayed, if not; change column value and save history
        /// </summary>
        /// <param name="productIds">List if product's to change</param>
        /// <param name="productIdentifierRcd">identifier type</param>
        /// <param name="newIdentifierValue">new identifier</param>
        /// <param name="productAttributeRcd">attribute type</param>
        /// <param name="newAttributeValue">attribute value</param>
        /// <param name="userId">user who initiated the change</param>
        public void ProductChangeAttribute(
            List<Guid> productIds,
            string productAttributeRcd,
            string newAttributeValue,
            string productIdentifierRcd,
            string newIdentifierValue,
            Guid userId
            ) {

            if (productIds.Count.Equals(0)) {
                throw new Exception("ProductService, ProductChangeAttribute, no products");
            }

            foreach (Guid productId in productIds) {
                // get current product
                ProductContract product = ProductGetCompleteById(productId);

                if (product.Product.ProductId.Equals(Guid.Empty)) {
                    throw new Exception("ProductService, ProductChangeAttribute, product: " + productId + " not found");
                }

                // check if any change was made
                bool didChange = false;
                bool didFind = false;

                // check attributes
                foreach (CrudeProductAttributeContract attribute in product.ProductAttribute) {
                    if (attribute.ProductAttributeRcd.Equals(productAttributeRcd)) {
                        // check if current column value is the same as proposed new value
                        if (!attribute.Value.Equals(newAttributeValue)) {
                            // change column value
                            attribute.Value = newAttributeValue;
                            attribute.DateTime = DateTime.UtcNow;
                            attribute.UserId = userId;
                            didChange = true;
                        }
                        didFind = true;
                    }
                }

                if (!didFind) {
                    // attribute not present, add it
                    CrudeProductAttributeContract attribute = new CrudeProductAttributeContract {
                        ProductAttributeRcd = productAttributeRcd,
                        Value = newAttributeValue,
                        DateTime = DateTime.UtcNow,
                        UserId = userId
                    };

                    product.ProductAttribute.Add(attribute);
                }

                // check identifiers
                foreach (CrudeProductIdentifierContract identifier in product.ProductIdentifier) {
                    if (identifier.ProductIdentifierRcd.Equals(productIdentifierRcd)) {
                        // check if current column value is the same as proposed new value
                        if (!identifier.Identifier.Equals(newIdentifierValue)) {
                            // change column value
                            identifier.Identifier = newIdentifierValue;
                            identifier.DateTime = DateTime.UtcNow;
                            identifier.UserId = userId;

                            didChange = true;
                        }
                    }
                }

                // save if any change was made
                if (didChange) {
                    ProductSaveCompleteById(product, userId);
                }
            }
        }

        /// <summary>
        /// change multiple product's entities
        /// </summary>
        /// <param name="productEntities">products and entities to change</param>
        /// <param name="userId">user who initiated the change</param>
        public void ProductChangeEntities(
            List<ProductChangeEntityContract> productEntities,
            Guid userId
            ) {
            //productEntities.Reverse();  // because of updated by sort order

            foreach (ProductChangeEntityContract productEntity in productEntities) {
                // get current product
                ProductContract product = ProductGetCompleteById(productEntity.ProductId);
                // check if any change was made
                bool didChange = false;
                foreach (ProductChangeEntityDetailContract entityDetail in productEntity.EntityChanges) {
                    switch (entityDetail.ProductEntityTypeRcd) {
                        case ProductEntityTypeRef.Product: {
                                // check if current column value is the same as proposed new value
                                if (product.Product.ProductName == null || !product.Product.ProductName.Equals(entityDetail.ProductEntityNewValue)) {
                                    // change product name
                                    product.Product.ProductName = entityDetail.ProductEntityNewValue;
                                    product.Product.DateTime = DateTime.UtcNow;
                                    product.Product.UserId = userId;
                                    didChange = true;
                                }
                                break;
                            }
                        case ProductEntityTypeRef.ProductAttribute: {
                                bool didFind = false;
                                foreach (CrudeProductAttributeContract attribute in product.ProductAttribute) {
                                    if (attribute.ProductAttributeRcd.Equals(entityDetail.ProductEntityRcd)) {
                                        // check if current column value is the same as proposed new value
                                        if (attribute.Value == null || !attribute.Value.Equals(entityDetail.ProductEntityNewValue)) {
                                            // change column value
                                            attribute.Value = entityDetail.ProductEntityNewValue;
                                            attribute.DateTime = DateTime.UtcNow;
                                            attribute.UserId = userId;
                                            didChange = true;
                                        }
                                        didFind = true;
                                        break;
                                    }
                                }
                                if (!didFind) {
                                    // attribute not present, add it
                                    CrudeProductAttributeContract attribute = new CrudeProductAttributeContract {
                                        ProductAttributeRcd = entityDetail.ProductEntityRcd,
                                        Value = entityDetail.ProductEntityNewValue,
                                        DateTime = DateTime.UtcNow,
                                        UserId = userId
                                    };
                                    product.ProductAttribute.Add(attribute);
                                    didChange = true;
                                }
                                break;
                            }
                        case ProductEntityTypeRef.ProductIdentifier: {
                                bool didFind = false;
                                foreach (CrudeProductIdentifierContract identifier in product.ProductIdentifier) {
                                    if (identifier.ProductIdentifierRcd.Equals(entityDetail.ProductEntityRcd)) {
                                        // check if current column value is the same as proposed new value
                                        if (identifier.Identifier == null || !identifier.Identifier.Equals(entityDetail.ProductEntityNewValue)) {
                                            // change column value
                                            identifier.Identifier = entityDetail.ProductEntityNewValue;
                                            identifier.DateTime = DateTime.UtcNow;
                                            identifier.UserId = userId;
                                            didChange = true;
                                        }
                                        didFind = true;
                                    }
                                }
                                if (!didFind) {
                                    // identifier not present, add it
                                    CrudeProductIdentifierContract identifier = new CrudeProductIdentifierContract {
                                        ProductIdentifierRcd = entityDetail.ProductEntityRcd,
                                        Identifier = entityDetail.ProductEntityNewValue,
                                        DateTime = DateTime.UtcNow,
                                        UserId = userId
                                    };
                                    product.ProductIdentifier.Add(identifier);
                                    didChange = true;
                                }
                                break;
                            }
                    }
                }

                // save if any change was made
                if (didChange) {
                    ProductSaveCompleteById(product, userId);
                }
            }
        }
    }
}
