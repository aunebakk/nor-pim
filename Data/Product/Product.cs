using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public class Product {
        public CrudeProductData product;
        public List<CrudeProductAttributeData> ProductAttribute { get; set; }
        public List<CrudeProductIdentifierData> ProductIdentifier { get; set; }
        public List<CrudeProductInfoData> ProductInfo { get; set; }
        public List<CrudeProductImageData> ProductImage { get; set; }
        public List<CrudeProductDocumentationData> ProductDocumentation { get; set; }

        public Product() {
            // product base info
            product = new CrudeProductData();

            // product attributes
            ProductAttribute = new List<CrudeProductAttributeData>();

            // product identifiers
            ProductIdentifier = new List<CrudeProductIdentifierData>();

            // product information links
            ProductInfo = new List<CrudeProductInfoData>();

            // product images
            ProductImage = new List<CrudeProductImageData>();

            // product documentation
            ProductDocumentation = new List<CrudeProductDocumentationData>();
        }

        public Product(Guid productId) {

            // product base info
            product = new CrudeProductData();
            product.FetchByProductId(productId);

            // product attributes
            ProductAttribute = CrudeProductAttributeData.FetchByProductId(productId);

            // product identifiers
            ProductIdentifier = CrudeProductIdentifierData.FetchByProductId(productId);

            // product information links
            ProductInfo = CrudeProductInfoData.FetchByProductId(productId);

            // product images
            ProductImage = CrudeProductImageData.FetchByProductId(productId);

            // product documentation
            ProductDocumentation = CrudeProductDocumentationData.FetchByProductId(productId);
        }

        public void Save(Guid userId) {
            // start transaction
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try {
                    // keep copy of 'old' product
                    CrudeProductData oldProduct = ObjectCopier.Clone(product);

                    // save new product
                    product.ProductId = Guid.NewGuid();
                    product.StateRcd = DefaultStateRef.Updated;
                    product.UserId = userId;
                    product.DateTime = DateTime.UtcNow;
                    product.Insert(connection, transaction);

                    // duplicate old products category mapping
                    CrudeProductCategoryData.InsertNewCategoryMapping(
                        connection,
                        transaction,
                        oldProduct.ProductId,
                        product.ProductId,
                        userId
                        );

                    // update product to be 'old' version
                    oldProduct.ProductBecameId = product.ProductId;
                    oldProduct.UpdateBecame(connection, transaction);

                    // change identifier keys, save
                    foreach (CrudeProductIdentifierData identifier in ProductIdentifier) {
                        identifier.ProductIdentifierId = Guid.NewGuid();
                        identifier.ProductId = product.ProductId;
                        identifier.UserId = userId;
                        identifier.DateTime = DateTime.UtcNow;
                        identifier.Insert(connection, transaction);
                    }

                    // change attribute keys, save
                    foreach (CrudeProductAttributeData attribute in ProductAttribute) {
                        attribute.ProductAttributeId = Guid.NewGuid();
                        attribute.ProductId = product.ProductId;
                        attribute.UserId = userId;
                        attribute.DateTime = DateTime.UtcNow;
                        attribute.Insert(connection, transaction);
                    }

                    // change info keys, save
                    foreach (CrudeProductInfoData info in ProductInfo) {
                        info.ProductInfoId = Guid.NewGuid();
                        info.ProductId = product.ProductId;
                        info.UserId = userId;
                        info.DateTime = DateTime.UtcNow;
                        info.Insert(connection, transaction);
                    }

                    // change documentation keys, save
                    foreach (CrudeProductDocumentationData documentation in ProductDocumentation) {
                        documentation.ProductDocumentationId = Guid.NewGuid();
                        documentation.ProductId = product.ProductId;
                        documentation.UserId = userId;
                        documentation.DateTime = DateTime.UtcNow;
                        documentation.Insert(connection, transaction);
                    }

                    // change image keys, save
                    foreach (CrudeProductImageData image in ProductImage) {
                        image.ProductImageId = Guid.NewGuid();
                        image.ProductId = product.ProductId;
                        image.UserId = userId;
                        image.DateTime = DateTime.UtcNow;
                        image.Insert(connection, transaction);
                    }

                    // commit transaction
                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("DataAccessLayer, Product, Save, Failed", ex);
                }
            }
        }
    }
}
