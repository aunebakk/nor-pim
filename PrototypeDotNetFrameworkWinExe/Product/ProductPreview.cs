using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface
{
    public partial class ProductPreview : Form
    {
        private Guid _userId;
        private Guid _productCategoryId;

        private TreeNode _currentNode;
        private bool _onParent; // true if parent category was chosen

        private ProductContract _productContract = null;

        public ProductPreview() {
            InitializeComponent();

            InitializeGridProductType1(dataGridViewProducts1);

            InitializeGridProductAttribute();
            InitializeGridProductIdentifier();
            InitializeGridProductInfo();
            InitializeGridProductImages();
            InitializeGridProductDocumentation();

            InitializeGridProductCategoryDocumentation();
        }

        public void Show(Guid userId
                            ) {
            _userId = userId;
            Show();

            // select first node
            if ( treeViewHierarchy.Nodes.Count > 0 )
                SelectNode(treeViewHierarchy.Nodes[0]);

            treeViewHierarchy.SelectedNode = _currentNode;
        }

        void AddCategory(List<CategoryTreeContract> productCategoryContracts,
                            TreeNode node,
                            Guid productCategoryParentId
                            ) {
            foreach ( CategoryTreeContract contractChild in productCategoryContracts ) {
                // exclude parent
                if ( contractChild.ProductCategoryId == contractChild.ProductCategoryParentId )
                    continue;

                if ( contractChild.ProductCategoryParentId == productCategoryParentId ) {
                    TreeNode newNode = node.Nodes.Add(
                        contractChild.ProductCategoryId.ToString(),
                        contractChild.ProductCategoryName
                        );

                    AddCategory(productCategoryContracts,
                                newNode,
                                contractChild.ProductCategoryId
                                );
                }
            }
        }

        private void CategoryTreeviewRefresh() {
            treeViewHierarchy.Nodes.Clear();

            var productCategoryService = new CategorySearchService();
            List<CategoryTreeContract> productCategoryContracts = productCategoryService.CategoryTree();

            foreach ( CategoryTreeContract productCategoryContract in productCategoryContracts ) {
                // first level is it's own parent
                if ( productCategoryContract.ProductCategoryId != productCategoryContract.ProductCategoryParentId )
                    continue;

                TreeNode node = treeViewHierarchy.Nodes.Add(productCategoryContract.ProductCategoryId.ToString(),
                                                            productCategoryContract.ProductCategoryName);

                AddCategory(productCategoryContracts,
                            node,
                            productCategoryContract.ProductCategoryId
                            );
            }
        }

        private void CheckForm(Form form) {
            Singleton.Instance.CheckForm(form);
        }

        private void ProductPreview_Load(object sender, EventArgs e) {
            CategoryTreeviewRefresh();
        }

        private void Error(Exception ex) {
            Singleton.Instance.Error(ex);
        }

        private void SelectNode(TreeNode node) {
            try {
                _productCategoryId = new Guid(node.Name);
                _currentNode = node;
                _onParent = node.Nodes.Count != 0;

                UpdateCategory();
                UpdateProducts();

            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void treeViewHierarchy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            try {
                SelectNode(e.Node);
            } catch ( Exception ex ) {
                Error(ex);
                try {
                    dataGridViewProducts1.DataSource = null;
                    dataGridViewProducts1.Refresh();
                } catch { }
            }
        }

        void UpdateProducts() {
            var productSearchService = new ProductSearchService();

            Cursor.Current = Cursors.WaitCursor;

            try {
                // get all products for category
                InitializeGridProductType1(dataGridViewProducts1);
                dataGridViewProducts1.AutoGenerateColumns = false;
                dataGridViewProducts1.DataSource =
                    productSearchService.ProductSearchByCategory(
                        _productCategoryId,
                        _onParent
                        );
                dataGridViewProducts1.AutoResizeColumns();
                dataGridViewProducts1.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            } finally {
                productSearchService.Close();
            }

            Cursor.Current = Cursors.Default;
        }

        private void InitializeGridProductType1(DataGridView dataGridViewProducts) {
            try {
                dataGridViewProducts.Columns.Clear();
                dataGridViewProducts.AutoGenerateColumns = false;
                dataGridViewProducts.Columns.Add("ProductId", "Product Id");
                dataGridViewProducts.Columns.Add("ProductName", "Product Name");
                dataGridViewProducts.Columns.Add("Identifier", "Identifier");
                dataGridViewProducts.Columns.Add("Value", "Value");
                dataGridViewProducts.Columns.Add("ProductInfoValue", "Product Info Value");
                dataGridViewProducts.Columns.Add("ProductImageTypeRcd", "Product Image Type");
                dataGridViewProducts.Columns.Add("ProductImageTypeName", "Product Image Type Name");
                dataGridViewProducts.Columns.Add("Image", "Image");
                dataGridViewProducts.Columns.Add("ExtensionData", "");
                dataGridViewProducts.Columns["ExtensionData"].Visible = false;
                foreach ( DataGridViewColumn column in dataGridViewProducts.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }
                dataGridViewProducts.AutoResizeColumns();
                dataGridViewProducts.Refresh();
                //dataGridViewProducts.ColumnHeadersVisible = false;
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void InitializeGridProductAttribute() {
            try {
                dataGridViewProductAttribute.Columns.Clear();
                dataGridViewProductAttribute.AutoGenerateColumns = false;
                dataGridViewProductAttribute.Columns.Add("ProductAttributeId", "Product Attribute Id");
                dataGridViewProductAttribute.Columns.Add("ProductId", "Product Id");
                dataGridViewProductAttribute.Columns.Add("ProductAttributeRcd", "Product Attribute");
                dataGridViewProductAttribute.Columns.Add("Value", "Value");
                dataGridViewProductAttribute.Columns.Add("UserId", "User Id");
                dataGridViewProductAttribute.Columns.Add("DateTime", "Date Time");
                dataGridViewProductAttribute.Columns.Add("ProductAttributeUnitCd", "Product Attribute Unit Cd");
                dataGridViewProductAttribute.Columns.Add("ExtensionData", "");
                dataGridViewProductAttribute.Columns["ExtensionData"].Visible = false;
                foreach ( DataGridViewColumn column in dataGridViewProductAttribute.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }
                dataGridViewProductAttribute.AutoResizeColumns();
                dataGridViewProductAttribute.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }
        private void InitializeGridProductIdentifier() {
            try {
                dataGridViewProductIdentifier.Columns.Clear();
                dataGridViewProductIdentifier.AutoGenerateColumns = false;
                dataGridViewProductIdentifier.Columns.Add("ProductIdentifierId", "Product Identifier Id");
                dataGridViewProductIdentifier.Columns.Add("ProductId", "Product Id");
                dataGridViewProductIdentifier.Columns.Add("ProductIdentifierRcd", "Product Identifier");
                dataGridViewProductIdentifier.Columns.Add("Identifier", "Identifier");
                dataGridViewProductIdentifier.Columns.Add("UserId", "User Id");
                dataGridViewProductIdentifier.Columns.Add("DateTime", "Date Time");
                dataGridViewProductIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewProductIdentifier.Columns["ExtensionData"].Visible = false;
                foreach ( DataGridViewColumn column in dataGridViewProductIdentifier.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }
                dataGridViewProductIdentifier.AutoResizeColumns();
                dataGridViewProductIdentifier.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void InitializeGridProductInfo() {
            try {
                dataGridViewProductInfo.Columns.Clear();
                dataGridViewProductInfo.AutoGenerateColumns = false;
                dataGridViewProductInfo.Columns.Add("ProductInfoRcd", "Product Info");
                dataGridViewProductInfo.Columns.Add("ProductInfoName", "Product Info Name");
                dataGridViewProductInfo.Columns.Add("UserId", "User Id");
                dataGridViewProductInfo.Columns.Add("DateTime", "Date Time");
                dataGridViewProductInfo.Columns.Add("ExtensionData", "");
                dataGridViewProductInfo.Columns["ExtensionData"].Visible = false;

                foreach ( DataGridViewColumn column in dataGridViewProductInfo.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }

                dataGridViewProductInfo.AutoResizeColumns();
                dataGridViewProductInfo.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void InitializeGridProductImages() {
            try {
                dataGridViewProductImage.Columns.Clear();
                dataGridViewProductImage.AutoGenerateColumns = false;
                dataGridViewProductImage.Columns.Add("ProductImageId", "Product Image Id");
                dataGridViewProductImage.Columns.Add("ProductId", "Product Id");
                dataGridViewProductImage.Columns.Add("ProductImageTypeRcd", "Product Image Type");
                dataGridViewProductImage.Columns.Add("Image", "Image");
                dataGridViewProductImage.Columns.Add("UserId", "User Id");
                dataGridViewProductImage.Columns.Add("DateTime", "Date Time");
                dataGridViewProductImage.Columns.Add("ExtensionData", "");
                dataGridViewProductImage.Columns["ExtensionData"].Visible = false;

                foreach ( DataGridViewColumn column in dataGridViewProductImage.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }

                dataGridViewProductImage.AutoResizeColumns();
                dataGridViewProductImage.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void InitializeGridProductDocumentation() {
            try {
                dataGridViewProductDocumentation.Columns.Clear();
                dataGridViewProductDocumentation.AutoGenerateColumns = false;
                dataGridViewProductDocumentation.Columns.Add("ProductDocumentationId", "Product Documentation Id");
                dataGridViewProductDocumentation.Columns.Add("ProductId", "Product Id");
                dataGridViewProductDocumentation.Columns.Add("ProductDocumentationTypeRcd", "Product Documentation Type");
                dataGridViewProductDocumentation.Columns.Add("Documentation", "Documentation");
                dataGridViewProductDocumentation.Columns.Add("UserId", "User Id");
                dataGridViewProductDocumentation.Columns.Add("DateTime", "Date Time");
                dataGridViewProductDocumentation.Columns.Add("ExtensionData", "");
                dataGridViewProductDocumentation.Columns["ExtensionData"].Visible = false;

                foreach ( DataGridViewColumn column in dataGridViewProductDocumentation.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }

                dataGridViewProductDocumentation.AutoResizeColumns();
                dataGridViewProductDocumentation.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void InitializeGridProductCategoryDocumentation() {
            try {
                dataGridViewProductCategoryDocumentation.Columns.Clear();
                dataGridViewProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationId", "Product Category Documentation Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationTypeRcd", "Product Category Documentation Type");
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryId", "Product Category Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("Documentation", "Documentation");
                dataGridViewProductCategoryDocumentation.Columns.Add("UserId", "User Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("DateTime", "Date Time");
                dataGridViewProductCategoryDocumentation.Columns["DateTime"].Visible = false;
                dataGridViewProductCategoryDocumentation.Columns.Add("ExtensionData", "");
                dataGridViewProductCategoryDocumentation.Columns["ExtensionData"].Visible = false;

                foreach ( DataGridViewColumn column in dataGridViewProductCategoryDocumentation.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }

                dataGridViewProductCategoryDocumentation.AutoResizeColumns();
                dataGridViewProductCategoryDocumentation.Refresh();
                dataGridViewProductCategoryDocumentation.ColumnHeadersVisible = false;
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void UpdateProduct(Guid productId) {
            // Show product info
            var productServiceClient = new ProductServiceClient();
            try {
                _productContract =
                    productServiceClient.ProductGetCompleteById(
                        productId);

                if ( productId == Guid.Empty ) {
                    // big todo
                    // either set this to empty here, or allow comobo / datetime, etc to be null/empty
                    // note 1.. not doing this now because it causes flicker in the end
                    //textBoxProductName.Text = string.Empty;
                    //stateRefComboProduct.Text = string.Empty;
                    //dateTimePickerProduct.Text = string.Empty;
                } else {

                    textBoxProductName.Text = _productContract.Product.ProductName;

                    PopulateProductAttribute(_productContract.ProductAttribute);
                    PopulateProductIdentifier(_productContract.ProductIdentifier);
                    PopulateProductInfo(_productContract.ProductInfo);
                    PopulateProductImage(_productContract.ProductImage);
                    PopulateProductDocument(_productContract.ProductDocumentation);
                }
            } catch ( Exception ex ) {
                Error(ex);
            } finally {
                productServiceClient.Close();
            }
        }

        private void UpdateCategory() {
            var productCategoryServiceClient = new ProductCategoryServiceClient();
            try {
                ProductCategoryContract contract = 
                    productCategoryServiceClient.ProductCategoryGetCompleteById(
                        _productCategoryId
                        );

                textBoxProductCategoryCode.Text = contract.ProductCategory.ProductCategoryCode;
                textBoxProductCategoryName.Text = contract.ProductCategory.ProductCategoryName;

                PopulateProductCategoryImage(contract.ProductCategoryImage);
                PopulateProductCategoryDocument(contract.ProductCategoryDocumentation);
            } catch ( Exception ex ) {
                Error(ex);
            } finally {
                productCategoryServiceClient.Close();
            }
        }

        private void PopulateProductAttribute(List<CrudeProductAttributeContract> attributeContract) {
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = attributeContract;
                dataGridViewProductAttribute.AutoGenerateColumns = false;
                dataGridViewProductAttribute.DataSource = bindingSource;
                dataGridViewProductAttribute.AutoResizeColumns();
                dataGridViewProductAttribute.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void PopulateProductIdentifier(List<CrudeProductIdentifierContract> identifierContract) {
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = identifierContract;
                dataGridViewProductIdentifier.AutoGenerateColumns = false;
                dataGridViewProductIdentifier.DataSource = bindingSource;
                dataGridViewProductIdentifier.AutoResizeColumns();
                dataGridViewProductIdentifier.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void PopulateProductInfo(List<CrudeProductInfoContract> InfoContract) {
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = InfoContract;
                dataGridViewProductInfo.AutoGenerateColumns = false;
                dataGridViewProductInfo.DataSource = bindingSource;
                dataGridViewProductInfo.AutoResizeColumns();
                dataGridViewProductInfo.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void PopulateProductImage(List<CrudeProductImageContract> ImageContract) {
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ImageContract;
                dataGridViewProductImage.AutoGenerateColumns = false;
                dataGridViewProductImage.DataSource = bindingSource;
                dataGridViewProductImage.AutoResizeColumns();
                dataGridViewProductImage.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void PopulateProductDocument(List<CrudeProductDocumentationContract> DocumentContract) {
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DocumentContract;
                dataGridViewProductDocumentation.AutoGenerateColumns = false;
                dataGridViewProductDocumentation.DataSource = bindingSource;
                dataGridViewProductDocumentation.AutoResizeColumns();
                dataGridViewProductDocumentation.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void PopulateProductCategoryImage(List<CrudeProductCategoryImageContract> ImageContract) {
            var service = new CrudeProductCategoryImageServiceClient ();
            try {
                var contract = service.FetchByProductCategoryImageId ( ImageContract [ 0 ].ProductCategoryImageId );
                pictureBoxImage.Image = ByteToImage ( contract.Image );
            } catch ( Exception ex ) {
                Error ( ex );
                pictureBoxImage.Image = null;
            } finally {
                service.Close ();
            }

        }

        private void PopulateProductCategoryDocument(List<CrudeProductCategoryDocumentationContract> DocumentContract) {

            BindingSource bindingSource = new BindingSource();
            try {
                bindingSource.DataSource = DocumentContract;
                dataGridViewProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewProductCategoryDocumentation.DataSource = bindingSource;
                dataGridViewProductCategoryDocumentation.AutoResizeColumns();
                dataGridViewProductCategoryDocumentation.Refresh();
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private System.Drawing.Image ByteToImage(byte[] byteArrayIn) {
            var ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }

        private void dataGridViewProducts1_SelectionChanged(object sender, EventArgs e) {
            try {
                if ( dataGridViewProducts1.CurrentRow == null )
                    return;

                Guid currentProductId = Guid.Empty;

                if ( dataGridViewProducts1.CurrentRow.Cells["ProductId"].Value != null )
                    currentProductId = ( System.Guid ) dataGridViewProducts1.CurrentRow.Cells["ProductId"].Value;

                if ( _productContract == null || _productContract.Product.ProductId != currentProductId )
                    UpdateProduct(currentProductId);
            } catch ( Exception ex ) {
                Error(ex);
            }
        }

        private void toolStripTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e) {
            if ( e.KeyChar == ( char ) 13 ) {
                e.Handled = true;

                // find category
                var productCategoryService = new CategorySearchService();
                List<CategoryFindContract> productCategoryContracts = productCategoryService.CategoryFind(toolStripTextBoxSearch.Text);
                productCategoryService.Close();

                if ( productCategoryContracts.Count == 0 )
                    return;

                Guid productCategoryId = productCategoryContracts[0].ProductCategoryId;

                foreach ( TreeNode node in treeViewHierarchy.Nodes ) {
                    if ( new Guid(node.Name) == productCategoryId ) {
                        node.Expand();
                        treeViewHierarchy.SelectedNode = node;
                        SelectNode(node);
                        treeViewHierarchy.Select();
                    }

                    foreach ( TreeNode subNode in node.Nodes ) {
                        if ( new Guid(subNode.Name) == productCategoryId ) {
                            subNode.Parent.Expand();
                            treeViewHierarchy.SelectedNode = subNode;
                            SelectNode(subNode);
                            treeViewHierarchy.Select();

                            // select grid row
                            // figure out how to position on a row in the grid
                            //dataGridViewProducts1.CurrentRow = dataGridViewProducts1.Select.Cells["ProductId"].Value
                            //dataGridViewProducts1.SelectedRows. = 
                        }
                    }
                }
            }
        }
    }
}
