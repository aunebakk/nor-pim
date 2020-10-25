using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.ProxyLayer;

namespace SolutionNorSolutionPim.UserInterface
{
    public partial class ProductWhiteboard : Form
    {
        private Guid _userId;
        private Guid _productCategoryId;

        private TreeNode _currentNode;
        private bool _onParent; // true if parent category was chosen
        private bool _refreshing = false;
        private const bool _logEvents = true;

        private ProductContract _productContract = null;

        public ProductWhiteboard() {
            InitializeComponent();

            InitializeGridProductType1(dataGridViewProducts1);
            InitializeGridProductType2(dataGridViewProducts2);
            dataGridViewProducts2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            InitializeGridProductType3(dataGridViewProducts3);

            InitializeGridProductAttribute();
            InitializeGridProductIdentifier();
            InitializeGridProductInfo();
            InitializeGridProductImages();
            InitializeGridProductDocumentation();
            InitializeGridProductHistory();

            InitializeGridProductCategoryImages();
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

        private void CategoryTreeViewRefresh() {
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

        private void ProductWhiteboard_Load(object sender, EventArgs e) {
            CategoryTreeViewRefresh();
        }

        private void Log(string caller, string message) {
            if ( _logEvents )
                Singleton.Instance.Log(caller + " : " + message);
        }

        private void Log(string message) {
            if ( _logEvents )
                Singleton.Instance.Log(message);
        }

        private void Error(Exception ex) {
            Singleton.Instance.Error(ex);
        }

        private void Error(string caller, Exception ex) {
            Singleton.Instance.Error(caller, ex);
        }

        private void SelectNode(TreeNode node) {
            Log("SelectNode");

            try {
                _productCategoryId = new Guid(node.Name);
                _currentNode = node;
                _onParent = node.Nodes.Count != 0;

                if ( tabControlSplit.SelectedTab == tabPageCategory )
                    UpdateCategory();
                else if ( tabControlSplit.SelectedTab == tabPageProducts )
                    RefreshProductList();

            } catch ( Exception ex ) {
                Error("SelectNode", ex);
            }
        }

        private void treeViewHierarchy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            Log("treeViewHierarchy_NodeMouseClick");

            try {
                SelectNode(e.Node);
            } catch ( Exception ex ) {
                Error("treeViewHierarchy_NodeMouseClick", ex);

                try {
                    dataGridViewProducts1.DataSource = null;
                    dataGridViewProducts1.Refresh();
                } catch { }
            }
        }

        void RefreshProductList() {
            Log("RefreshProductList, start");
            bool logIt = true;

            Cursor.Current = Cursors.WaitCursor;

            try {
                _refreshing = true;

                // get all products for category
                if ( tabControlProductsPage.SelectedTab == tabPageProductsView1 ) {
                    dataGridViewProducts1.AutoGenerateColumns = false;
                    dataGridViewProducts1.DataSource =
                        new ProductSearchService().ProductSearchByCategory(
                            _productCategoryId,
                            _onParent
                            );
                    dataGridViewProducts1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridViewProducts1.AutoResizeColumns();
                    dataGridViewProducts1.Refresh();

                } else if ( tabControlProductsPage.SelectedTab == tabPageProductsView2 ) {
                    // remember selected row
                    int position = 0;
                    if ( dataGridViewProducts2.CurrentRow != null )
                        position = dataGridViewProducts2.CurrentRow.Index;

                    // fetch new dataset
                    if ( logIt )
                        Log("RefreshProductList", "BindingSource");
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource =
                        new ProductSearchService().ProductSearchByCategoryType1(
                            _productCategoryId,
                            _onParent
                            );

                    if ( logIt )
                        Log("RefreshProductList", "AutoGenerateColumns");
                    dataGridViewProducts2.AutoGenerateColumns = true;

                    if ( logIt )
                        Log("RefreshProductList", "DataSource");
                    try {
                        dataGridViewProducts2.DataSource = bindingSource;
                    } catch { }

                    if ( logIt )
                        Log("RefreshProductList", "AutoResizeColumns");
                    dataGridViewProducts2.AutoResizeColumns();

                    // position to previous row
                    if ( logIt )
                        Log("RefreshProductList", "Position");
                    try {
                        if ( dataGridViewProducts2.Rows.Count > 0 )
                            foreach ( DataGridViewCell cell in dataGridViewProducts2.Rows[position].Cells )
                                if ( cell.Visible )
                                    dataGridViewProducts2.CurrentCell = cell;
                    } catch { }
                } else if ( tabControlProductsPage.SelectedTab == tabPageProductsView3 ) {
                    dataGridViewProducts3.AutoGenerateColumns = false;
                    dataGridViewProducts3.DataSource =
                        new ProductSearchService().ProductSearchByCategoryType2(
                            _productCategoryId,
                            _onParent
                            );
                    dataGridViewProducts3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridViewProducts3.AutoResizeColumns();
                    dataGridViewProducts3.Refresh();
                }

            } catch ( Exception ex ) {
                Error("RefreshProductList", ex);
            } finally {
                _refreshing = false;
            }
            Log("RefreshProductList, end");

            Cursor.Current = Cursors.Default;
        }

        private void InitializeGridProductType1(DataGridView dataGridViewProducts) {
            Log("InitializeGridProductType1");

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

                dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProducts.AutoResizeColumns();
                dataGridViewProducts.Refresh();
            } catch ( Exception ex ) {
                Error("InitializeGridProductType1", ex);
            }
        }

        private void InitializeGridProductType2(DataGridView dataGridViewProducts) {
            Log("InitializeGridProductType2");

            try {
                dataGridViewProducts.Columns.Clear();
                dataGridViewProducts.AutoGenerateColumns = false;
                dataGridViewProducts.Columns.Add("ProductId", "Product Id");
                dataGridViewProducts.Columns.Add("ProductName", "Product Name");
                dataGridViewProducts.Columns.Add("Gtin13", "Gtin 13");
                dataGridViewProducts.Columns.Add("Color", "Color");
                dataGridViewProducts.Columns.Add("ExtensionData", "");
                dataGridViewProducts.Columns["ExtensionData"].Visible = false;

                foreach ( DataGridViewColumn column in dataGridViewProducts.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }

                dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProducts.AutoResizeColumns();
            } catch ( Exception ex ) {
                Error("InitializeGridProductType2", ex);
            }
        }

        private void InitializeGridProductType3(DataGridView dataGridViewProducts) {
            Log("InitializeGridProductType3");

            try {
                dataGridViewProducts.Columns.Clear();
                dataGridViewProducts.AutoGenerateColumns = false;
                dataGridViewProducts.Columns.Add("ProductId", "Product Id");
                dataGridViewProducts.Columns.Add("ProductName", "Product Name");
                dataGridViewProducts.Columns.Add("Gtin13", "Gtin 13");
                dataGridViewProducts.Columns.Add("Hn", "HN");
                dataGridViewProducts.Columns.Add("Color", "Color");
                dataGridViewProducts.Columns.Add("ExtensionData", "");
                dataGridViewProducts.Columns["ExtensionData"].Visible = false;

                foreach ( DataGridViewColumn column in dataGridViewProducts.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }

                dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProducts.AutoResizeColumns();
            } catch ( Exception ex ) {
                Error("InitializeGridProductType3", ex);
            }
        }

        private void InitializeGridProductAttribute() {
            Log("InitializeGridProductAttribute");

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
                dataGridViewProductAttribute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductAttribute.AutoResizeColumns();
                dataGridViewProductAttribute.Refresh();
            } catch ( Exception ex ) {
                Error("InitializeGridProductAttribute", ex);
            }
        }

        private void InitializeGridProductIdentifier() {
            Log("InitializeGridProductIdentifier");

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
                dataGridViewProductIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductIdentifier.AutoResizeColumns();
                dataGridViewProductIdentifier.Refresh();
            } catch ( Exception ex ) {
                Error("InitializeGridProductIdentifier", ex);
            }
        }

        private void InitializeGridProductInfo() {
            Log("InitializeGridProductInfo");

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

                dataGridViewProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductInfo.AutoResizeColumns();
                dataGridViewProductInfo.Refresh();
            } catch ( Exception ex ) {
                Error("InitializeGridProductInfo", ex);
            }
        }

        private void InitializeGridProductImages() {
            Log("InitializeGridProductImages");

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

                dataGridViewProductImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductImage.AutoResizeColumns();
                dataGridViewProductImage.Refresh();
            } catch ( Exception ex ) {
                Error("InitializeGridProductImages", ex);
            }
        }

        private void InitializeGridProductDocumentation() {
            Log("InitializeGridProductDocumentation");

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

                dataGridViewProductDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductDocumentation.AutoResizeColumns();
                dataGridViewProductDocumentation.Refresh();
            } catch ( Exception ex ) {
                Error("InitializeGridProductDocumentation", ex);
            }
        }

        private void InitializeGridProductCategoryImages() {
            Log("InitializeGridProductCategoryImages");

            try {
                dataGridViewProductCategoryImage.Columns.Clear();
                dataGridViewProductCategoryImage.AutoGenerateColumns = false;
                dataGridViewProductCategoryImage.Columns.Add("ProductCategoryImageId", "Category Image Id");
                dataGridViewProductCategoryImage.Columns.Add("ProductCategoryId", "Category Id");
                dataGridViewProductCategoryImage.Columns.Add("ProductCategoryImageTypeRcd", "Category Image Type");
                dataGridViewProductCategoryImage.Columns.Add("Image", "Image");
                dataGridViewProductCategoryImage.Columns.Add("UserId", "User Id");
                dataGridViewProductCategoryImage.Columns.Add("DateTime", "Date Time");
                dataGridViewProductCategoryImage.Columns.Add("ExtensionData", "");
                dataGridViewProductCategoryImage.Columns["ExtensionData"].Visible = false;

                foreach ( DataGridViewColumn column in dataGridViewProductCategoryImage.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }

                dataGridViewProductCategoryImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductCategoryImage.AutoResizeColumns();
                dataGridViewProductCategoryImage.Refresh();
            } catch ( Exception ex ) {
                Error("InitializeGridProductCategoryImages", ex);
            }
        }

        private void InitializeGridProductCategoryDocumentation() {
            Log("InitializeGridProductCategoryDocumentation");

            try {
                dataGridViewProductCategoryDocumentation.Columns.Clear();
                dataGridViewProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationId", "Product Category Documentation Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationTypeRcd", "Product Category Documentation Type");
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryId", "Product Category Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("Documentation", "Documentation");
                dataGridViewProductCategoryDocumentation.Columns.Add("UserId", "User Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("DateTime", "Date Time");
                dataGridViewProductCategoryDocumentation.Columns.Add("ExtensionData", "");
                dataGridViewProductCategoryDocumentation.Columns["ExtensionData"].Visible = false;

                foreach ( DataGridViewColumn column in dataGridViewProductCategoryDocumentation.Columns ) {
                    column.DataPropertyName = column.Name;
                    if ( column.Name.EndsWith("Id") )
                        column.Visible = false;
                }

                dataGridViewProductCategoryDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductCategoryDocumentation.AutoResizeColumns();
                dataGridViewProductCategoryDocumentation.Refresh();
            } catch ( Exception ex ) {
                Error("InitializeGridProductCategoryDocumentation", ex);
            }
        }

        private void InitializeGridProductHistory() {
            dataGridViewProductHistory.Columns.Clear();
            dataGridViewProductHistory.AutoGenerateColumns = false;
            dataGridViewProductHistory.Columns.Add("ProductId", "Product Id");
            dataGridViewProductHistory.Columns.Add("ProductName", "Product Name");
            dataGridViewProductHistory.Columns.Add("StateName", "State");
            dataGridViewProductHistory.Columns.Add("DateTime", "Date Time");
            dataGridViewProductHistory.Columns.Add("UserName", "User Name");
            dataGridViewProductHistory.Columns.Add("ProductBecameId", "Product Became Id");
            dataGridViewProductHistory.Columns.Add("ExtensionData", "");
            dataGridViewProductHistory.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewProductHistory.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewProductHistory.AutoResizeColumns();
        }

        private void UpdateProduct(Guid productId) {
            Log("UpdateProduct");

            // Show product info
            try {
                _productContract =
                    new ProductServiceClient().ProductGetCompleteById(
                            productId
                            );

                if ( productId == Guid.Empty ) {
                    // todo
                    // either set this to empty here, or allow combo / datetime, etc to be null/empty
                    // note 1.. not doing this now because it causes flicker in the end
                    //textBoxProductName.Text = string.Empty;
                    //stateRefComboProduct.Text = string.Empty;
                    //dateTimePickerProduct.Text = string.Empty;
                } else {

                    textBoxProductName.Text = _productContract.Product.ProductName;
                    stateRefComboProduct.Text = _productContract.Product.StateRcd;
                    dateTimePickerProduct.Text = _productContract.Product.DateTime.ToLongDateString();

                    PopulateProductAttribute(_productContract.ProductAttribute);
                    PopulateProductIdentifier(_productContract.ProductIdentifier);
                    PopulateProductInfo(_productContract.ProductInfo);
                    PopulateProductImage(_productContract.ProductImage);
                    PopulateProductDocument(_productContract.ProductDocumentation);
                    PopulateProductHistory();
                }
            } catch ( Exception ex ) {
                Error("UpdateProduct", ex);
            }
        }

        private void UpdateCategory() {
            Log("UpdateCategory");

            var productCategoryServiceClient = new ProductCategoryServiceClient();
            try {
                ProductCategoryContract contract = 
                    productCategoryServiceClient.ProductCategoryGetCompleteById(
                        _productCategoryId
                        );

                textBoxProductCategoryCode.Text = contract.ProductCategory.ProductCategoryCode;
                textBoxProductCategoryName.Text = contract.ProductCategory.ProductCategoryName;
                maskedTextBoxProductCategoryPosition.Text = contract.ProductCategory.ProductCategoryPosition.ToString();
                dateTimePickerCategory.Text = contract.ProductCategory.DateTime.ToLongDateString();
                stateRefComboCategory.Text = contract.ProductCategory.StateRcd;

                PopulateProductCategoryImage(contract.ProductCategoryImage);
                PopulateProductCategoryDocument(contract.ProductCategoryDocumentation);
            } catch ( Exception ex ) {
                Error("UpdateCategory", ex);
            } finally {
                productCategoryServiceClient.Close();
            }
        }

        private void PopulateProductAttribute(List<CrudeProductAttributeContract> attributeContract) {
            Log("PopulateProductAttribute");

            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = attributeContract;
                dataGridViewProductAttribute.AutoGenerateColumns = false;
                dataGridViewProductAttribute.DataSource = bindingSource;
                dataGridViewProductAttribute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductAttribute.AutoResizeColumns();
                dataGridViewProductAttribute.Refresh();
            } catch ( Exception ex ) {
                Error("PopulateProductAttribute", ex);
            }
        }

        private void PopulateProductIdentifier(List<CrudeProductIdentifierContract> identifierContract) {
            Log("PopulateProductIdentifier");

            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = identifierContract;
                dataGridViewProductIdentifier.AutoGenerateColumns = false;
                dataGridViewProductIdentifier.DataSource = bindingSource;
                dataGridViewProductIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductIdentifier.AutoResizeColumns();
                dataGridViewProductIdentifier.Refresh();
            } catch ( Exception ex ) {
                Error("PopulateProductIdentifier", ex);
            }
        }

        private void PopulateProductInfo(List<CrudeProductInfoContract> InfoContract) {
            Log("PopulateProductInfo");

            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = InfoContract;
                dataGridViewProductInfo.AutoGenerateColumns = false;
                dataGridViewProductInfo.DataSource = bindingSource;
                dataGridViewProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductInfo.AutoResizeColumns();
                dataGridViewProductInfo.Refresh();
            } catch ( Exception ex ) {
                Error("PopulateProductInfo", ex);
            }
        }

        private void PopulateProductImage(List<CrudeProductImageContract> ImageContract) {
            Log("PopulateProductImage");

            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ImageContract;
                dataGridViewProductImage.AutoGenerateColumns = false;
                dataGridViewProductImage.DataSource = bindingSource;
                dataGridViewProductImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductImage.AutoResizeColumns();
                dataGridViewProductImage.Refresh();
            } catch ( Exception ex ) {
                Error("PopulateProductImage", ex);
            }
        }

        private void PopulateProductDocument(List<CrudeProductDocumentationContract> DocumentContract) {
            Log("PopulateProductDocument");

            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DocumentContract;
                dataGridViewProductDocumentation.AutoGenerateColumns = false;
                dataGridViewProductDocumentation.DataSource = bindingSource;
                dataGridViewProductDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductDocumentation.AutoResizeColumns();
                dataGridViewProductDocumentation.Refresh();
            } catch ( Exception ex ) {
                Error("PopulateProductDocument", ex);
            }
        }

        private void PopulateProductHistory() {
            Log("PopulateProductHistory");

            ProductServiceClient productHistory = new ProductServiceClient();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productHistory.ProductHistory(_productContract.Product.ProductId);
                dataGridViewProductHistory.AutoGenerateColumns = true;
                dataGridViewProductHistory.DataSource = bindingSource;
                dataGridViewProductHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductHistory.AutoResizeColumns();
                dataGridViewProductHistory.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                productHistory.Close();
            }
        }

        private void PopulateProductCategoryImage(List<CrudeProductCategoryImageContract> ImageContract) {
            Log("PopulateProductCategoryImage");

            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ImageContract;
                dataGridViewProductCategoryImage.AutoGenerateColumns = false;
                dataGridViewProductCategoryImage.DataSource = bindingSource;
                dataGridViewProductCategoryImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductCategoryImage.AutoResizeColumns();
                dataGridViewProductCategoryImage.Refresh();
            } catch ( Exception ex ) {
                Error("PopulateProductCategoryImage", ex);
            }
        }

        private void PopulateProductCategoryDocument(List<CrudeProductCategoryDocumentationContract> DocumentContract) {
            Log("PopulateProductCategoryDocument");

            BindingSource bindingSource = new BindingSource();
            try {
                bindingSource.DataSource = DocumentContract;
                dataGridViewProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewProductCategoryDocumentation.DataSource = bindingSource;
                dataGridViewProductCategoryDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewProductCategoryDocumentation.AutoResizeColumns();
                dataGridViewProductCategoryDocumentation.Refresh();
            } catch ( Exception ex ) {
                Error("PopulateProductCategoryDocument", ex);
            }
        }

        private void btnCategoryImageAdd_Click(object sender, EventArgs e) {
            Log("btnCategoryImageAdd_Click");

            try {
                var newMDIChild = new CrudeProductCategoryImageEdit ();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAddByProductCategory(_productCategoryId
                                      );
            } catch ( Exception ex ) {
                Error("btnCategoryImageAdd_Click", ex);
            }
        }

        private void btnCategoryImageEdit_Click(object sender, EventArgs e) {
            Log("btnCategoryImageEdit_Click");

            try {
                var editForm = new CrudeProductCategoryImageEdit ();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit(( System.Guid ) dataGridViewProductCategoryImage.CurrentRow.Cells["ProductCategoryImageId"].Value
                                    );
            } catch ( Exception ex ) {
                Error("btnCategoryImageEdit_Click", ex);
            }
        }

        private void dataGridViewProductCategoryImage_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Log("dataGridViewProductCategoryImage_CellDoubleClick");

            try {
                var editForm = new CrudeProductCategoryImageEdit ();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit(( System.Guid ) dataGridViewProductCategoryImage.CurrentRow.Cells["ProductCategoryImageId"].Value
                                    );
            } catch ( Exception ex ) {
                Error("dataGridViewProductCategoryImage_CellDoubleClick", ex);
            }
        }

        private void buttonProductCategoryDocumentationAdd_Click(object sender, EventArgs e) {
            Log("buttonProductCategoryDocumentationAdd_Click");

            try {
                var newMDIChild = new CrudeProductCategoryDocumentationEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAddByProductCategory(_productCategoryId
                                      );
            } catch ( Exception ex ) {
                Error("buttonProductCategoryDocumentationAdd_Click", ex);
            }
        }

        private void buttonProductCategoryDocumentationEdit_Click(object sender, EventArgs e) {
            Log("buttonProductCategoryDocumentationEdit_Click");

            try {
                var editForm = new CrudeProductCategoryDocumentationEdit ();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit(( System.Guid ) dataGridViewProductCategoryDocumentation.CurrentRow.Cells["ProductCategoryDocumentationId"].Value
                                    
                                    );
            } catch ( Exception ex ) {
                Error("buttonProductCategoryDocumentationEdit_Click", ex);
            }
        }

        private void dataGridViewProductCategoryDocumentation_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Log("dataGridViewProductCategoryDocumentation_CellDoubleClick");

            try {
                var editForm = new CrudeProductCategoryDocumentationEdit();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit(( System.Guid ) dataGridViewProductCategoryDocumentation.CurrentRow.Cells["ProductCategoryDocumentationId"].Value
                                    );
            } catch ( Exception ex ) {
                Error("dataGridViewProductCategoryDocumentation_CellDoubleClick", ex);
            }
        }

        private void buttonProductCategoryEdit_Click(object sender, EventArgs e) {
            Log("buttonProductCategoryEdit_Click");

            try {
                var editForm = new CrudeProductCategoryEdit();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit(_productCategoryId);
                UpdateCategory();
            } catch ( Exception ex ) {
                Error("buttonProductCategoryEdit_Click", ex);
            }
        }

        private void buttonProductEdit_Click(object sender, EventArgs e) {
            Log("buttonProductEdit_Click");

            try {
                var editForm = new ProductMaintenance();
                Guid productId = _productContract.Product.ProductId;
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.Show(productId, _userId);

                // refresh product list and view
                UpdateProduct(productId);
                RefreshProductList();
            } catch ( Exception ex ) {
                Error("buttonProductEdit_Click", ex);
            }
        }

        private void buttonProductSave_Click(object sender, EventArgs e) {
            Log("buttonProductSave_Click");

            var productServiceClient = new ProductServiceClient();
            try {
                _productContract.Product.ProductName = textBoxProductName.Text;
                productServiceClient.ProductSaveCompleteById(
                    _productContract,
                    _userId
                    );

                // update grid, product
                RefreshProductList();
            } catch ( Exception ex ) {
                Error("buttonProductSave_Click", ex);
            } finally {
                productServiceClient.Close();
            }
        }

        private void buttonProductHistory_Click(object sender, EventArgs e) {
            Log("buttonProductHistory_Click");

            try {
                Log("buttonProductHistory_Click: ProductId: " + _productContract.Product.ProductId);
                var history = new ProductHistory(_productContract.Product.ProductId);
                history.MdiParent = this.MdiParent;
                CheckForm(history);
                history.Show();
            } catch ( Exception ex ) {
                Error("buttonProductHistory_Click", ex);
            }
        }

        private void TreeviewMoveUp(TreeNode node) {
            Log("TreeviewMoveUp");

            try {
                TreeNode parent = node.Parent;
                TreeView view = node.TreeView;
                if ( parent != null ) {
                    int index = parent.Nodes.IndexOf(node);
                    if ( index > 0 ) {
                        parent.Nodes.RemoveAt(index);
                        parent.Nodes.Insert(index - 1, node);
                    }
                } else if ( node.TreeView.Nodes.Contains(node) ) { //root node
                    int index = view.Nodes.IndexOf(node);
                    if ( index > 0 ) {
                        view.Nodes.RemoveAt(index);
                        view.Nodes.Insert(index - 1, node);
                    }
                }
            } catch ( Exception ex ) {
                Error("TreeviewMoveUp", ex);
            }
        }

        private void TreeviewMoveDown(TreeNode node) {
            Log("TreeviewMoveDown");

            try {
                TreeNode parent = node.Parent;
                TreeView view = node.TreeView;
                if ( parent != null ) {
                    int index = parent.Nodes.IndexOf(node);
                    if ( index < parent.Nodes.Count - 1 ) {
                        parent.Nodes.RemoveAt(index);
                        parent.Nodes.Insert(index + 1, node);
                    }
                } else if ( view != null && view.Nodes.Contains(node) ) { //root node
                    int index = view.Nodes.IndexOf(node);
                    if ( index < view.Nodes.Count - 1 ) {
                        view.Nodes.RemoveAt(index);
                        view.Nodes.Insert(index + 1, node);
                    }
                }
            } catch ( Exception ex ) {
                Error("TreeviewMoveDown", ex);
            }
        }

        private void toolStripButtonUp_Click(object sender, EventArgs e) {
            Log("toolStripButtonUp_Click");

            var productCategoryServiceClient = new ProductCategoryServiceClient();
            try {
                Log("new position" + productCategoryServiceClient.PositionUp(_productCategoryId).ToString());
                TreeviewMoveUp(_currentNode);
                treeViewHierarchy.SelectedNode = _currentNode;
            } catch ( Exception ex ) {
                Error("toolStripButtonUp_Click", ex);
            } finally {
                productCategoryServiceClient.Close();
            }
        }

        private void toolStripButtonDown_Click(object sender, EventArgs e) {
            var productCategoryServiceClient = new ProductCategoryServiceClient();
            try {
                Log("new position" + productCategoryServiceClient.PositionDown(_productCategoryId).ToString());
                TreeviewMoveDown(_currentNode);
                treeViewHierarchy.SelectedNode = _currentNode;
            } catch ( Exception ex ) {
                Error("toolStripButtonDown_Click", ex);
            } finally {
                productCategoryServiceClient.Close();
            }
        }

        private void buttonProductIdentifierAdd_Click(object sender, EventArgs e) {
            Log("buttonProductIdentifierAdd_Click");

            try {
                var newMDIChild = new CrudeProductIdentifierEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(_productContract.Product.ProductId,
                                        string.Empty,
                                        string.Empty,
                                        _userId
                                        );
            } catch ( Exception ex ) {
                Error("buttonProductIdentifierAdd_Click", ex);
            }
        }

        private void buttonProductIdentifierEdit_Click(object sender, EventArgs e) {
            Log("buttonProductIdentifierEdit_Click");

            try {
                var newMDIChild = new CrudeProductIdentifierEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit(( System.Guid ) dataGridViewProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
            } catch ( Exception ex ) {
                Error("buttonProductIdentifierEdit_Click", ex);
            }
        }

        private void buttonProductAttributeAdd_Click(object sender, EventArgs e) {
            Log("buttonProductAttributeAdd_Click");

            try {
                var newMDIChild = new CrudeProductAttributeEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(_productContract.Product.ProductId,
                                        string.Empty,
                                        string.Empty,
                                        string.Empty,
                                        _userId
                                        );
            } catch ( Exception ex ) {
                Error("buttonProductAttributeAdd_Click", ex);
            }
        }

        private void buttonProductAttributeEdit_Click(object sender, EventArgs e) {
            Log("buttonProductAttributeEdit_Click");

            try {
                var newMDIChild = new CrudeProductAttributeEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit(( System.Guid ) dataGridViewProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
            } catch ( Exception ex ) {
                Error("buttonProductAttributeEdit_Click", ex);
            }
        }

        private void buttonProductInfoAdd_Click(object sender, EventArgs e) {
            Log("buttonProductInfoAdd_Click");

            try {
                var newMDIChild = new CrudeProductInfoEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(_productContract.Product.ProductId,
                                        string.Empty,
                                        string.Empty,
                                        _userId
                                        );
            } catch ( Exception ex ) {
                Error("buttonProductInfoAdd_Click", ex);
            }
        }

        private void buttonProductImageAdd_Click(object sender, EventArgs e) {
            Log("buttonProductImageAdd_Click");

            try {
                var newMDIChild = new CrudeProductImageEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(_productContract.Product.ProductId,
                                        string.Empty,
                                        string.Empty,
                                        null,
                                        _userId
                                        );
            } catch ( Exception ex ) {
                Error("buttonProductImageAdd_Click", ex);
            }
        }

        private void buttonProductDocumentationAdd_Click(object sender, EventArgs e) {
            Log("buttonProductDocumentationAdd_Click");

            try {
                var newMDIChild = new CrudeProductDocumentationEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(_productContract.Product.ProductId,
                                        string.Empty,
                                        string.Empty,
                                        _userId
                                        );
            } catch ( Exception ex ) {
                Error("buttonProductDocumentationAdd_Click", ex);
            }
        }

        private void buttonProductInfoEdit_Click(object sender, EventArgs e) {
            Log("buttonProductInfoEdit_Click");

            try {
                var newMDIChild = new CrudeProductInfoEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit(( System.Guid ) dataGridViewProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
            } catch ( Exception ex ) {
                Error("buttonProductInfoEdit_Click", ex);
            }
        }

        private void buttonProductImageEdit_Click(object sender, EventArgs e) {
            Log("buttonProductImageEdit_Click");

            try {
                var newMDIChild = new CrudeProductImageEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit(( System.Guid ) dataGridViewProductImage.CurrentRow.Cells["ProductImageId"].Value);
            } catch ( Exception ex ) {
                Error("buttonProductImageEdit_Click", ex);
            }
        }

        private void buttonProductDocumentationEdit_Click(object sender, EventArgs e) {
            Log("buttonProductDocumentationEdit_Click");

            try {
                var newMDIChild = new CrudeProductDocumentationEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit(( System.Guid ) dataGridViewProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
            } catch ( Exception ex ) {
                Error("buttonProductDocumentationEdit_Click", ex);
            }
        }

        private void tabControlProductsPage_Selected(object sender, TabControlEventArgs e) {
            Log("tabControlProductsPage_Selected");

            RefreshProductList();
        }

        private void tabControlSplit_SelectedIndexChanged(object sender, EventArgs e) {
            Log("tabControlSplit_SelectedIndexChanged");

            if ( tabControlSplit.SelectedTab == tabPageCategory )
                UpdateCategory();
            else if ( tabControlSplit.SelectedTab == tabPageProducts )
                RefreshProductList();
        }

        private void dataGridViewProducts1_SelectionChanged(object sender, EventArgs e) {
            Log("dataGridViewProducts1_SelectionChanged");

            try {
                if ( dataGridViewProducts1.CurrentRow == null )
                    return;

                Guid currentProductId = Guid.Empty;

                if ( dataGridViewProducts1.CurrentRow.Cells["ProductId"].Value != null )
                    currentProductId = ( System.Guid ) dataGridViewProducts1.CurrentRow.Cells["ProductId"].Value;

                if ( _productContract == null || _productContract.Product.ProductId != currentProductId )
                    UpdateProduct(currentProductId);
            } catch ( Exception ex ) {
                Error("dataGridViewProducts1_SelectionChanged", ex);
            }
        }

        private void dataGridViewProducts3_SelectionChanged(object sender, EventArgs e) {
            Log("dataGridViewProducts3_SelectionChanged");

            try {
                if ( dataGridViewProducts3.CurrentRow == null )
                    return;

                Guid currentProductId = Guid.Empty;

                if ( dataGridViewProducts3.CurrentRow.Cells["ProductId"].Value != null )
                    currentProductId = ( System.Guid ) dataGridViewProducts3.CurrentRow.Cells["ProductId"].Value;

                if ( _productContract == null || _productContract.Product.ProductId != currentProductId )
                    UpdateProduct(currentProductId);
            } catch ( Exception ex ) {
                Error("dataGridViewProducts3_SelectionChanged", ex);
            }
        }

        private void toolStripTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e) {
            Log("toolStripTextBoxSearch_KeyPress");

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
                        tabControlSplit.SelectedTab = tabPageCategory;
                        treeViewHierarchy.Select();
                    }

                    foreach ( TreeNode subNode in node.Nodes ) {
                        if ( new Guid(subNode.Name) == productCategoryId ) {
                            subNode.Parent.Expand();
                            treeViewHierarchy.SelectedNode = subNode;
                            SelectNode(subNode);
                            tabControlSplit.SelectedTab = tabPageProducts;
                            treeViewHierarchy.Select();
                        }
                    }
                }
            }
        }

        private void dataGridViewProducts2_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            Log("dataGridViewProducts2_CellEndEdit");

            if ( _refreshing )
                return;

            try {
                DataGridViewColumn colorColumn = dataGridViewProducts2.Columns[ProductAttributeRef.Color];
                DataGridViewColumn gtinColumn = dataGridViewProducts2.Columns[ProductIdentifierRef.GlobalTradeItemNumber13];
                DataGridViewColumn nameColumn = dataGridViewProducts2.Columns["ProductName"];
                DataGridViewColumn productIdColumn = dataGridViewProducts2.Columns["ProductId"];

                var productEntities = new List<ProductChangeEntityContract>();

                // product
                DataGridViewRow row = dataGridViewProducts2.CurrentRow;
                var productEntitiyChange = new ProductChangeEntityContract();
                productEntitiyChange.ProductId = ( Guid ) row.Cells[productIdColumn.Index].Value;
                productEntitiyChange.EntityChanges = new List<ProductChangeEntityDetailContract>();

                // product name
                if ( nameColumn != null && e.ColumnIndex.Equals(nameColumn.Index) ) {
                    if ( dataGridViewProducts2.CurrentRow != null ) {
                        var entityDetail = new ProductChangeEntityDetailContract();
                        entityDetail.ProductEntityTypeRcd = ProductEntityTypeRef.Product;
                        entityDetail.ProductEntityRcd = string.Empty;
                        entityDetail.ProductEntityOldValue = string.Empty;
                        entityDetail.ProductEntityNewValue = ( string ) row.Cells[nameColumn.Index].EditedFormattedValue;
                        productEntitiyChange.EntityChanges.Add(entityDetail);
                    }
                }

                // check identifier
                if ( gtinColumn != null && e.ColumnIndex.Equals(gtinColumn.Index) ) {
                    if ( dataGridViewProducts2.CurrentRow != null ) {
                        var entityDetail = new ProductChangeEntityDetailContract();
                        entityDetail.ProductEntityTypeRcd = ProductEntityTypeRef.ProductIdentifier;
                        entityDetail.ProductEntityRcd = ProductIdentifierRef.GlobalTradeItemNumber13;
                        entityDetail.ProductEntityOldValue = string.Empty;
                        entityDetail.ProductEntityNewValue = ( string ) row.Cells[gtinColumn.Index].EditedFormattedValue;
                        productEntitiyChange.EntityChanges.Add(entityDetail);
                    }
                }

                // color value
                if ( colorColumn != null && e.ColumnIndex.Equals(colorColumn.Index) ) {
                    if ( dataGridViewProducts2.CurrentRow != null ) {
                        var entityDetail = new ProductChangeEntityDetailContract();
                        entityDetail.ProductEntityTypeRcd = ProductEntityTypeRef.ProductAttribute;
                        entityDetail.ProductEntityRcd = ProductAttributeRef.Color;
                        entityDetail.ProductEntityOldValue = string.Empty;
                        entityDetail.ProductEntityNewValue = ( string ) row.Cells[colorColumn.Index].EditedFormattedValue;
                        productEntitiyChange.EntityChanges.Add(entityDetail);
                    }
                }

                try {
                    productEntities.Add(productEntitiyChange);
                    new ProductServiceClient().ProductChangeEntities(
                        productEntities.ToArray(),
                        Singleton.Instance.UserId
                        );

                    RefreshProductList();
                } catch ( Exception ex ) {
                    Error("dataGridViewProducts2_CellEndEdit", ex);
                }
            } catch ( Exception ex ) {
                Error("dataGridViewProducts2_CellEndEdit", ex);
            }
        }

        private void dataGridViewProductIdentifier_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            Log("dataGridViewProductIdentifier_CellEndEdit");

            if ( _refreshing )
                return;

            DataGridViewColumn identifierColumn = dataGridViewProducts2.Columns["identifier"];

            if ( identifierColumn != null ) {
                if ( e.ColumnIndex.Equals(identifierColumn.Index) ) {

                    // update identifier value
                    string identifier = ( string ) dataGridViewProductIdentifier.CurrentRow.Cells["identifier"].EditedFormattedValue;

                    CrudeProductIdentifierContract identifierContract =
                        new CrudeProductIdentifierServiceClient().FetchByProductId(_productContract.Product.ProductId)[0];

                    if ( !identifierContract.Identifier.Equals(identifier) ) {
                        identifierContract.Identifier = identifier;
                        new CrudeProductIdentifierServiceClient().Update(identifierContract);
                    }
                }
            }
        }

        private void dataGridViewProducts2_RowEnter(object sender, DataGridViewCellEventArgs e) {
            Log("dataGridViewProducts2_RowEnter");

            if ( _refreshing )
                return;

            try {
                if ( dataGridViewProducts2.CurrentRow == null )
                    return;

                Guid currentProductId = Guid.Empty;

                //if (dataGridViewProducts2.CurrentRow.Cells["ProductId"].Value != null)
                if ( dataGridViewProducts2.Rows[e.RowIndex].Cells["ProductId"].Value != null )
                    currentProductId = ( System.Guid ) dataGridViewProducts2.Rows[e.RowIndex].Cells["ProductId"].Value;

                if ( _productContract == null || _productContract.Product.ProductId != currentProductId )
                    UpdateProduct(currentProductId);
            } catch ( Exception ex ) {
                Error("dataGridViewProducts2_RowEnter", ex);
            }
        }
        
        private IEnumerable<DataGridViewRow> SelectedRows(
            DataGridView dgv
            ) {
            IEnumerable<DataGridViewRow> selectedRows = 
                dgv.SelectedCells.Cast<DataGridViewCell>()
                   .Select(cell => cell.OwningRow)
                   .OrderByDescending(cell => cell.Index)
                   .Distinct();

            return selectedRows;
        }

        private void Paste() {
            // bail if nothing selected
            if ( dataGridViewProducts2.SelectedCells.Count.Equals(0) )
                return;

            DataGridViewColumn colorColumn = dataGridViewProducts2.Columns[ProductAttributeRef.Color];
            DataGridViewColumn gtinColumn = dataGridViewProducts2.Columns[ProductIdentifierRef.GlobalTradeItemNumber13];
            DataGridViewColumn nameColumn = dataGridViewProducts2.Columns["ProductName"];
            DataGridViewColumn productIdColumn = dataGridViewProducts2.Columns["ProductId"];

            // check clipboard
            // if only one line with no tabs then assume one value
            // if only one line with tabs then assume one row with multiple values
            // if multiple lines with no tabs then assume multiple rows, one value
            // if multiple lines with tabs then assume multiple rows, multiple values
            char[] rowSplitter = { '\r', '\n' };
            char[] columnSplitter = { '\t' };

            // get the text from clipboard
            IDataObject dataInClipboard = Clipboard.GetDataObject();
            string stringInClipboard = ( string ) dataInClipboard.GetData(DataFormats.Text);

            if ( string.IsNullOrEmpty(stringInClipboard) )
                return;

            // split it into lines
            string[] clipboardRows = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);
            string[][] clipboardColumns = new string[clipboardRows.Length][];

            // make sure row / column counts match
            int columnCount = -1;
            int rowCount = -1;
            foreach ( string row in clipboardRows ) { // .Reverse()
                rowCount++;

                // split row into cell values
                clipboardColumns[rowCount] = row.Split(columnSplitter);

                if ( columnCount.Equals(-1) )
                    columnCount = clipboardColumns[rowCount].Count();
                else
                    if ( !columnCount.Equals(clipboardColumns[rowCount].Count()) )
                        throw new Exception("Paste, number of columns in rows does not match");

            }

            // get product changes
            var productEntities = new List<ProductChangeEntityContract>();
            int rowIndex = 0;
            try {
                IEnumerable<DataGridViewRow> selectedRows = SelectedRows(dataGridViewProducts2);
                selectedRows = selectedRows.Reverse();

                foreach ( var row in selectedRows ) {
                    // product
                    var productEntitiyChange = new ProductChangeEntityContract();
                    productEntitiyChange.ProductId = ( Guid ) row.Cells[productIdColumn.Index].Value;
                    productEntitiyChange.EntityChanges = new List<ProductChangeEntityDetailContract>();

                    int columnIndex = -1;
                    var entityDetail = new ProductChangeEntityDetailContract();
                    // product name
                    /*
                    entityDetail = new ProductChangeEntityDetailContract();
                    entityDetail.ProductEntityTypeRcd = ProductEntityTypeRef.Product;
                    entityDetail.ProductEntityRcd = string.Empty;
                    entityDetail.ProductEntityOldValue = (string) row.Cells[nameColumn.Index].EditedFormattedValue;
                    entityDetail.ProductEntityNewValue = (string) clipboardColumns[rowIndex][columnIndex];
                    productEntitiyChange.EntityChanges.Add(entityDetail);
                    */
                    // identifier
                    if ( row.Cells[gtinColumn.Index].Selected ) {
                        entityDetail = new ProductChangeEntityDetailContract();
                        entityDetail.ProductEntityTypeRcd = ProductEntityTypeRef.ProductIdentifier;
                        entityDetail.ProductEntityRcd = ProductIdentifierRef.GlobalTradeItemNumber13;
                        entityDetail.ProductEntityOldValue = ( string ) row.Cells[gtinColumn.Index].EditedFormattedValue;
                        entityDetail.ProductEntityNewValue = GetColumn(clipboardColumns, rowIndex, ++columnIndex);
                        productEntitiyChange.EntityChanges.Add(entityDetail);
                    }

                    // color
                    if ( row.Cells[colorColumn.Index].Selected ) {
                        entityDetail = new ProductChangeEntityDetailContract();
                        entityDetail.ProductEntityTypeRcd = ProductEntityTypeRef.ProductAttribute;
                        entityDetail.ProductEntityRcd = ProductAttributeRef.Color;
                        entityDetail.ProductEntityOldValue = ( string ) row.Cells[colorColumn.Index].EditedFormattedValue;
                        entityDetail.ProductEntityNewValue = GetColumn(clipboardColumns, rowIndex, ++columnIndex);
                        productEntitiyChange.EntityChanges.Add(entityDetail);
                    }

                    rowIndex++;
                    productEntities.Add(productEntitiyChange);
                }
            } catch ( Exception ex ) {
                Error("Paste, unique products", ex);
            }

            try {
                new ProductServiceClient().ProductChangeEntities(
                    productEntities.ToArray(),
                    Singleton.Instance.UserId
                    );

                RefreshProductList();
            } catch ( Exception ex ) {
                Error("Paste", ex);
            }
        }

        private bool IsColumnSelected(DataGridViewColumn column) {
            foreach ( DataGridViewColumn selectedColumn in dataGridViewProducts2.SelectedColumns ) {
                if ( selectedColumn.Index.Equals(column.Index) )
                    return true;
            }
            return false;
        }

        private string GetColumn(
            string[][] clipboardColumns,
            int rowIndex,
            int columnIndex
            ) {

            string found = string.Empty;

            // try to find best match
            try {
                // first possible value
                found = ( string ) clipboardColumns[0][0];
                // first row value
                found = ( string ) clipboardColumns[rowIndex][0];
                // closest match
                found = ( string ) clipboardColumns[rowIndex][columnIndex];
            } catch { }

            return found;
        }

        private void dataGridViewProducts2_KeyUp(object sender, KeyEventArgs e) {
            if ( e.Modifiers.Equals(Keys.Control) ) {
                // copy
                if ( e.KeyCode.Equals(Keys.C) ) {
                    Log("dataGridViewProducts2_KeyUp", "Ctrl + C");
                    DataObject content = dataGridViewProducts2.GetClipboardContent();
                    if ( content != null )
                        Clipboard.SetDataObject(
                            content
                            );
                }

                // paste
                if ( e.KeyCode.Equals(Keys.V) ) {
                    Log("dataGridViewProducts2_KeyUp", "Ctrl + V");
                    Paste();
                }
            }
        }

    }
}
