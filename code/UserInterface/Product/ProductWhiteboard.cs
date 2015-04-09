using System;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    public partial class ProductWhiteboard : Form {
        private Guid _userId;
        private Guid _productCategoryId;

        private TreeNode _currentNode;
        private bool _onParent; // true if parent category was chosen

        private norpim.BusinessLogicLayer.Other.ProductContract _productContract = null;

        public ProductWhiteboard() {
            InitializeComponent();

            InitializeGridProductType1(dataGridViewProducts1);
            InitializeGridProductType2(dataGridViewProducts2);
            InitializeGridProductType3(dataGridViewProducts3);

            InitializeGridProductAttribute();
            InitializeGridProductIdentifier();
            InitializeGridProductInfo();
            InitializeGridProductImages();
            InitializeGridProductDocumentation();

            InitializeGridProductCategoryImages();
            InitializeGridProductCategoryDocumentation();
        }

        public void Show(   Guid userId
                            ) {
            _userId = userId;
            Show();

            // select first node
            if (treeViewHierarchy.Nodes.Count > 0)
                SelectNode(treeViewHierarchy.Nodes[0]);

            treeViewHierarchy.SelectedNode = _currentNode;
        }

        void AddCategory(   CategoryTreeContract[] productCategoryContracts,
                            TreeNode node,
                            Guid productCategoryParentId
                            ) {
            foreach (CategoryTreeContract contractChild in productCategoryContracts) {
                // exclude parent
                if (contractChild.ProductCategoryId == contractChild.ProductCategoryParentId)
                    continue;

                if (contractChild.ProductCategoryParentId == productCategoryParentId) {
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
            CategoryTreeContract[] productCategoryContracts = productCategoryService.CategoryTree();

            foreach (CategoryTreeContract productCategoryContract in productCategoryContracts) {
                // first level is it's own parent
                if (productCategoryContract.ProductCategoryId != productCategoryContract.ProductCategoryParentId)
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

        private void Log(string message) {
            Singleton.Instance.Log(message);
        }

        private void Error(Exception ex) {
            Singleton.Instance.Error(ex);
        }

        private void SelectNode(TreeNode node) {
            try {
                _productCategoryId = new Guid(node.Name);
                _currentNode = node;
                _onParent = node.Nodes.Count != 0;

                if (tabControlSplit.SelectedTab == tabPageCategory)
                    UpdateCategory();
                else if (tabControlSplit.SelectedTab == tabPageProducts)
                    UpdateProducts();

            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void treeViewHierarchy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            try { 
                SelectNode(e.Node);
            } catch (Exception ex) {
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
                if (tabControlProductsPage.SelectedTab == tabPageProductsView1) {
                    InitializeGridProductType1(dataGridViewProducts1);
                    dataGridViewProducts1.AutoGenerateColumns = false;
                    dataGridViewProducts1.DataSource = 
                        productSearchService.ProductSearchByCategory(
                            _productCategoryId,
                            _onParent
                            );
                    dataGridViewProducts1.AutoResizeColumns();
                    dataGridViewProducts1.Refresh();
                
                } else if (tabControlProductsPage.SelectedTab == tabPageProductsView2) {
                    InitializeGridProductType2(dataGridViewProducts2);
                    dataGridViewProducts2.AutoGenerateColumns = false;
                    dataGridViewProducts2.DataSource = 
                        productSearchService.ProductSearchByCategoryType1(
                            _productCategoryId,
                            _onParent
                            );
                    dataGridViewProducts2.AutoResizeColumns();
                    dataGridViewProducts2.Refresh();

                } else if (tabControlProductsPage.SelectedTab == tabPageProductsView3) {
                    InitializeGridProductType3(dataGridViewProducts3);
                    dataGridViewProducts3.AutoGenerateColumns = false;
                    dataGridViewProducts3.DataSource = 
                        productSearchService.ProductSearchByCategoryType2(
                            _productCategoryId,
                            _onParent
                            );
                    dataGridViewProducts3.AutoResizeColumns();
                    dataGridViewProducts3.Refresh();
                }

            } catch (Exception ex) {
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
                dataGridViewProducts.Columns.Add("ProductId","Product Id");
                dataGridViewProducts.Columns.Add("ProductName","Product Name");
                dataGridViewProducts.Columns.Add("Identifier","Identifier");
                dataGridViewProducts.Columns.Add("Value","Value");
                dataGridViewProducts.Columns.Add("ProductInfoValue","Product Info Value");
                dataGridViewProducts.Columns.Add("ProductImageTypeRcd","Product Image Type");
                dataGridViewProducts.Columns.Add("ProductImageTypeName","Product Image Type Name");
                dataGridViewProducts.Columns.Add("Image","Image");
                dataGridViewProducts.Columns.Add("ExtensionData", "");
                dataGridViewProducts.Columns["ExtensionData"].Visible = false;
                foreach (DataGridViewColumn column in dataGridViewProducts.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }
                dataGridViewProducts.AutoResizeColumns();
                dataGridViewProducts.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void InitializeGridProductType2(DataGridView dataGridViewProducts) {
            try {
                dataGridViewProducts.Columns.Clear();
                dataGridViewProducts.AutoGenerateColumns = false;
                dataGridViewProducts.Columns.Add("ProductId","Product Id");
                dataGridViewProducts.Columns.Add("ProductName","Product Name");
                dataGridViewProducts.Columns.Add("Gtin","Gtin");
                dataGridViewProducts.Columns.Add("Color","Color");
                dataGridViewProducts.Columns.Add("ExtensionData", "");
                dataGridViewProducts.Columns["ExtensionData"].Visible = false;

                foreach (DataGridViewColumn column in dataGridViewProducts.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }

                dataGridViewProducts.AutoResizeColumns();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void InitializeGridProductType3(DataGridView dataGridViewProducts) {
            try {
                dataGridViewProducts.Columns.Clear();
                dataGridViewProducts.AutoGenerateColumns = false;
                dataGridViewProducts.Columns.Add("ProductId","Product Id");
                dataGridViewProducts.Columns.Add("ProductName","Product Name");
                dataGridViewProducts.Columns.Add("Gtin","Gtin");
                dataGridViewProducts.Columns.Add("Hn","HN");
                dataGridViewProducts.Columns.Add("Color","Color");
                dataGridViewProducts.Columns.Add("ExtensionData", "");
                dataGridViewProducts.Columns["ExtensionData"].Visible = false;

                foreach (DataGridViewColumn column in dataGridViewProducts.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }

                dataGridViewProducts.AutoResizeColumns();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void InitializeGridProductAttribute() {
            try {
                dataGridViewProductAttribute.Columns.Clear();
                dataGridViewProductAttribute.AutoGenerateColumns = false;
                dataGridViewProductAttribute.Columns.Add("ProductAttributeId","Product Attribute Id");
                dataGridViewProductAttribute.Columns.Add("ProductId","Product Id");
                dataGridViewProductAttribute.Columns.Add("ProductAttributeRcd","Product Attribute");
                dataGridViewProductAttribute.Columns.Add("Value","Value");
                dataGridViewProductAttribute.Columns.Add("UserId","User Id");
                dataGridViewProductAttribute.Columns.Add("DateTime","Date Time");
                dataGridViewProductAttribute.Columns.Add("ProductAttributeUnitCd","Product Attribute Unit Cd");
                dataGridViewProductAttribute.Columns.Add("ExtensionData", "");
                dataGridViewProductAttribute.Columns["ExtensionData"].Visible = false;
                foreach (DataGridViewColumn column in dataGridViewProductAttribute.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }
                dataGridViewProductAttribute.AutoResizeColumns();
                dataGridViewProductAttribute.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }
        private void InitializeGridProductIdentifier() {
            try {
                dataGridViewProductIdentifier.Columns.Clear();
                dataGridViewProductIdentifier.AutoGenerateColumns = false;
                dataGridViewProductIdentifier.Columns.Add("ProductIdentifierId","Product Identifier Id");
                dataGridViewProductIdentifier.Columns.Add("ProductId","Product Id");
                dataGridViewProductIdentifier.Columns.Add("ProductIdentifierRcd","Product Identifier");
                dataGridViewProductIdentifier.Columns.Add("Identifier","Identifier");
                dataGridViewProductIdentifier.Columns.Add("UserId","User Id");
                dataGridViewProductIdentifier.Columns.Add("DateTime","Date Time");
                dataGridViewProductIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewProductIdentifier.Columns["ExtensionData"].Visible = false;
                foreach (DataGridViewColumn column in dataGridViewProductIdentifier.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }
                dataGridViewProductIdentifier.AutoResizeColumns();
                dataGridViewProductIdentifier.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void InitializeGridProductInfo() {
            try {
                dataGridViewProductInfo.Columns.Clear();
                dataGridViewProductInfo.AutoGenerateColumns = false;
                dataGridViewProductInfo.Columns.Add("ProductInfoRcd","Product Info");
                dataGridViewProductInfo.Columns.Add("ProductInfoName","Product Info Name");
                dataGridViewProductInfo.Columns.Add("UserId","User Id");
                dataGridViewProductInfo.Columns.Add("DateTime","Date Time");
                dataGridViewProductInfo.Columns.Add("ExtensionData", "");
                dataGridViewProductInfo.Columns["ExtensionData"].Visible = false;

                foreach (DataGridViewColumn column in dataGridViewProductInfo.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }

                dataGridViewProductInfo.AutoResizeColumns();
                dataGridViewProductInfo.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void InitializeGridProductImages() {
            try {
                dataGridViewProductImage.Columns.Clear();
                dataGridViewProductImage.AutoGenerateColumns = false;
                dataGridViewProductImage.Columns.Add("ProductImageId","Product Image Id");
                dataGridViewProductImage.Columns.Add("ProductId","Product Id");
                dataGridViewProductImage.Columns.Add("ProductImageTypeRcd","Product Image Type");
                dataGridViewProductImage.Columns.Add("Image","Image");
                dataGridViewProductImage.Columns.Add("UserId","User Id");
                dataGridViewProductImage.Columns.Add("DateTime","Date Time");
                dataGridViewProductImage.Columns.Add("ExtensionData", "");
                dataGridViewProductImage.Columns["ExtensionData"].Visible = false;

                foreach (DataGridViewColumn column in dataGridViewProductImage.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }

                dataGridViewProductImage.AutoResizeColumns();
                dataGridViewProductImage.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void InitializeGridProductDocumentation() {
            try {
                dataGridViewProductDocumentation.Columns.Clear();
                dataGridViewProductDocumentation.AutoGenerateColumns = false;
                dataGridViewProductDocumentation.Columns.Add("ProductDocumentationId","Product Documentation Id");
                dataGridViewProductDocumentation.Columns.Add("ProductId","Product Id");
                dataGridViewProductDocumentation.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
                dataGridViewProductDocumentation.Columns.Add("Documentation","Documentation");
                dataGridViewProductDocumentation.Columns.Add("UserId","User Id");
                dataGridViewProductDocumentation.Columns.Add("DateTime","Date Time");
                dataGridViewProductDocumentation.Columns.Add("ExtensionData", "");
                dataGridViewProductDocumentation.Columns["ExtensionData"].Visible = false;

                foreach (DataGridViewColumn column in dataGridViewProductDocumentation.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }

                dataGridViewProductDocumentation.AutoResizeColumns();
                dataGridViewProductDocumentation.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void InitializeGridProductCategoryImages() {
            try {
                dataGridViewProductCategoryImage.Columns.Clear();
                dataGridViewProductCategoryImage.AutoGenerateColumns = false;
                dataGridViewProductCategoryImage.Columns.Add("ProductCategoryImageId","Category Image Id");
                dataGridViewProductCategoryImage.Columns.Add("ProductCategoryId","Category Id");
                dataGridViewProductCategoryImage.Columns.Add("ProductCategoryImageTypeRcd","Category Image Type");
                dataGridViewProductCategoryImage.Columns.Add("Image","Image");
                dataGridViewProductCategoryImage.Columns.Add("UserId","User Id");
                dataGridViewProductCategoryImage.Columns.Add("DateTime","Date Time");
                dataGridViewProductCategoryImage.Columns.Add("ExtensionData", "");
                dataGridViewProductCategoryImage.Columns["ExtensionData"].Visible = false;

                foreach (DataGridViewColumn column in dataGridViewProductCategoryImage.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }

                dataGridViewProductCategoryImage.AutoResizeColumns();
                dataGridViewProductCategoryImage.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void InitializeGridProductCategoryDocumentation() {
            try {
                dataGridViewProductCategoryDocumentation.Columns.Clear();
                dataGridViewProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationId","Product Category Documentation Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationTypeRcd","Product Category Documentation Type");
                dataGridViewProductCategoryDocumentation.Columns.Add("ProductCategoryId","Product Category Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("Documentation","Documentation");
                dataGridViewProductCategoryDocumentation.Columns.Add("UserId","User Id");
                dataGridViewProductCategoryDocumentation.Columns.Add("DateTime","Date Time");
                dataGridViewProductCategoryDocumentation.Columns.Add("ExtensionData", "");
                dataGridViewProductCategoryDocumentation.Columns["ExtensionData"].Visible = false;

                foreach (DataGridViewColumn column in dataGridViewProductCategoryDocumentation.Columns) {
                    column.DataPropertyName = column.Name;
                    if (column.Name.EndsWith("Id"))
                        column.Visible = false;
                }

                dataGridViewProductCategoryDocumentation.AutoResizeColumns();
                dataGridViewProductCategoryDocumentation.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void UpdateProduct(Guid productId) {
            // Show product info
            var productServiceClient = new norpim.BusinessLogicLayer.Other.ProductServiceClient();
            try {
                _productContract = 
                    productServiceClient.ProductGetCompleteById(
                        productId);

                if (productId == Guid.Empty) {
                    // big todo
                    // either set this to empty here, or allow comobo / datetime, etc to be null/empty
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
                }
            } catch (Exception ex) {
                Error(ex);
            } finally {
                productServiceClient.Close();
            }
        }

        private void UpdateCategory() {
            var productCategoryServiceClient = new norpim.BusinessLogicLayer.Other.ProductCategoryServiceClient();
            try {
                norpim.BusinessLogicLayer.Other.ProductCategoryContract contract = 
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
            } catch (Exception ex) {
                Error(ex);
            } finally {
                productCategoryServiceClient.Close();
            }
        }

        private void PopulateProductAttribute(norpim.BusinessLogicLayer.Other.CrudeProductAttributeContract[] attributeContract) {
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = attributeContract;
                dataGridViewProductAttribute.AutoGenerateColumns = false;
                dataGridViewProductAttribute.DataSource = bindingSource;
                dataGridViewProductAttribute.AutoResizeColumns();
                dataGridViewProductAttribute.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void PopulateProductIdentifier(norpim.BusinessLogicLayer.Other.CrudeProductIdentifierContract[] identifierContract) {
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = identifierContract;
                dataGridViewProductIdentifier.AutoGenerateColumns = false;
                dataGridViewProductIdentifier.DataSource = bindingSource;
                dataGridViewProductIdentifier.AutoResizeColumns();
                dataGridViewProductIdentifier.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void PopulateProductInfo(norpim.BusinessLogicLayer.Other.CrudeProductInfoContract[] InfoContract) {          
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = InfoContract;
                dataGridViewProductInfo.AutoGenerateColumns = false;
                dataGridViewProductInfo.DataSource = bindingSource;
                dataGridViewProductInfo.AutoResizeColumns();
                dataGridViewProductInfo.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void PopulateProductImage(norpim.BusinessLogicLayer.Other.CrudeProductImageContract[] ImageContract) {           
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ImageContract;
                dataGridViewProductImage.AutoGenerateColumns = false;
                dataGridViewProductImage.DataSource = bindingSource;
                dataGridViewProductImage.AutoResizeColumns();
                dataGridViewProductImage.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void PopulateProductDocument(norpim.BusinessLogicLayer.Other.CrudeProductDocumentationContract[] DocumentContract) {         
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = DocumentContract;
                dataGridViewProductDocumentation.AutoGenerateColumns = false;
                dataGridViewProductDocumentation.DataSource = bindingSource;
                dataGridViewProductDocumentation.AutoResizeColumns();
                dataGridViewProductDocumentation.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void PopulateProductCategoryImage(norpim.BusinessLogicLayer.Other.CrudeProductCategoryImageContract[] ImageContract) {
            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ImageContract;
                dataGridViewProductCategoryImage.AutoGenerateColumns = false;
                dataGridViewProductCategoryImage.DataSource = bindingSource;
                dataGridViewProductCategoryImage.AutoResizeColumns();
                dataGridViewProductCategoryImage.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void PopulateProductCategoryDocument(norpim.BusinessLogicLayer.Other.CrudeProductCategoryDocumentationContract[] DocumentContract) {
            
            BindingSource bindingSource = new BindingSource();
            try {
                bindingSource.DataSource = DocumentContract;
                dataGridViewProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewProductCategoryDocumentation.DataSource = bindingSource;
                dataGridViewProductCategoryDocumentation.AutoResizeColumns();
                dataGridViewProductCategoryDocumentation.Refresh();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void btnCategoryImageAdd_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new ProductCategoryImageEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(_productCategoryId,
                                      _userId
                                      );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void btnCategoryImageEdit_Click(object sender, EventArgs e) {
            try {
            var editForm = new ProductCategoryImageEdit();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit((System.Guid) dataGridViewProductCategoryImage.CurrentRow.Cells["ProductCategoryImageId"].Value,
                                    _userId
                                    );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void dataGridViewProductCategoryImage_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                var editForm = new ProductCategoryImageEdit();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit((System.Guid) dataGridViewProductCategoryImage.CurrentRow.Cells["ProductCategoryImageId"].Value,
                                    _userId
                                    );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductCategoryDocumentationAdd_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new ProductCategoryDocumentationEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(_productCategoryId,
                                      _userId
                                      );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductCategoryDocumentationEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new ProductCategoryDocumentationEdit();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit((System.Guid) dataGridViewProductCategoryDocumentation.CurrentRow.Cells["ProductCategoryDocumentationId"].Value,
                                    _userId
                                    );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void dataGridViewProductCategoryDocumentation_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                var editForm = new ProductCategoryDocumentationEdit();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit((System.Guid) dataGridViewProductCategoryDocumentation.CurrentRow.Cells["ProductCategoryDocumentationId"].Value,
                                    _userId
                                    );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductCategoryEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryEdit();
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit(_productCategoryId);
                UpdateCategory();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductEdit_Click(object sender, EventArgs e) {
            try { 
                var editForm = new CrudeProductEdit();
                Guid productId = (System.Guid) dataGridViewProducts1.CurrentRow.Cells["ProductId"].Value;
                editForm.MdiParent = this.MdiParent;
                CheckForm(editForm);
                editForm.ShowAsEdit(productId);
            
                // refresh product list and view
                UpdateProduct(productId);
                UpdateProducts();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductSave_Click(object sender, EventArgs e) {
            var productServiceClient = new norpim.BusinessLogicLayer.Other.ProductServiceClient();
            try { 
                _productContract.Product.ProductName = textBoxProductName.Text;
                productServiceClient.ProductSaveCompleteById(   _productContract, 
                                                                _userId
                                                                );
                // update grid, product
                UpdateProducts();
            } catch (Exception ex) {
                Error(ex);
            } finally {
                productServiceClient.Close();
            }
        }

        private void buttonProductHistory_Click(object sender, EventArgs e) {
            try { 
                Guid productId = (System.Guid) dataGridViewProducts1.CurrentRow.Cells["ProductId"].Value;
                var history = new ProductHistory(productId);
                history.MdiParent = this.MdiParent;
                CheckForm(history);
                history.Show();
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void TreeviewMoveUp(TreeNode node) {
            try { 
                TreeNode parent = node.Parent;
                TreeView view = node.TreeView;
                if (parent != null) {
                    int index = parent.Nodes.IndexOf(node);
                    if (index > 0) {
                        parent.Nodes.RemoveAt(index);
                        parent.Nodes.Insert(index - 1, node);
                    }
                } else if (node.TreeView.Nodes.Contains(node)) { //root node
                    int index = view.Nodes.IndexOf(node);
                    if (index > 0) {
                        view.Nodes.RemoveAt(index);
                        view.Nodes.Insert(index - 1, node);
                    }
                }
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void TreeviewMoveDown(TreeNode node) {
            try { 
                TreeNode parent = node.Parent;
                TreeView view = node.TreeView;
                if (parent != null) {
                    int index = parent.Nodes.IndexOf(node);
                    if (index < parent.Nodes.Count -1) {
                        parent.Nodes.RemoveAt(index);
                        parent.Nodes.Insert(index + 1, node);
                    }
                } else if (view != null && view.Nodes.Contains(node)) { //root node
                    int index = view.Nodes.IndexOf(node);
                    if (index < view.Nodes.Count - 1) {
                        view.Nodes.RemoveAt(index);
                        view.Nodes.Insert(index + 1, node);
                    }
                }
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void toolStripButtonUp_Click(object sender, EventArgs e) {
            var productCategoryServiceClient = new norpim.BusinessLogicLayer.Other.ProductCategoryServiceClient();
            try {
                Log("new position" + productCategoryServiceClient.PositionUp(_productCategoryId).ToString());
                TreeviewMoveUp(_currentNode);
                treeViewHierarchy.SelectedNode = _currentNode;
            } catch (Exception ex) {
                Error(ex);
            } finally {
                productCategoryServiceClient.Close();
            }
        }

        private void toolStripButtonDown_Click(object sender, EventArgs e) {
            var productCategoryServiceClient = new norpim.BusinessLogicLayer.Other.ProductCategoryServiceClient();
            try {
                Log("new position" + productCategoryServiceClient.PositionDown(_productCategoryId).ToString());
                TreeviewMoveDown(_currentNode);
                treeViewHierarchy.SelectedNode = _currentNode;
            } catch (Exception ex) {
                Error(ex);
            } finally {
                productCategoryServiceClient.Close();
            }
        }

        private void buttonProductIdentifierAdd_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductIdentifierEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(  _productContract.Product.ProductId,
                                        _userId
                                        );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductIdentifierEdit_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductIdentifierEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit( (System.Guid) dataGridViewProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductAttributeAdd_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductAttributeEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(  _productContract.Product.ProductId,
                                        _userId
                                        );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductAttributeEdit_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductAttributeEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit( (System.Guid) dataGridViewProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductInfoAdd_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductInfoEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(  _productContract.Product.ProductId,
                                        _userId
                                        );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductImageAdd_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductImageEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(  _productContract.Product.ProductId,
                                        _userId
                                        );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductDocumentationAdd_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductDocumentationEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsAdd(  _productContract.Product.ProductId,
                                        _userId
                                        );
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductInfoEdit_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductInfoEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit( (System.Guid) dataGridViewProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductImageEdit_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductImageEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit( (System.Guid) dataGridViewProductImage.CurrentRow.Cells["ProductImageId"].Value);
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void buttonProductDocumentationEdit_Click(object sender, EventArgs e) {
            try {
                var newMDIChild = new CrudeProductDocumentationEdit();
                newMDIChild.MdiParent = this.MdiParent;
                CheckForm(newMDIChild);
                newMDIChild.ShowAsEdit( (System.Guid) dataGridViewProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void tabControlProductsPage_Selected(object sender, TabControlEventArgs e) {
            UpdateProducts();
        }

        private void tabControlSplit_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControlSplit.SelectedTab == tabPageCategory)
                UpdateCategory();
            else if (tabControlSplit.SelectedTab == tabPageProducts)
                UpdateProducts();
        }

        private void dataGridViewProducts1_SelectionChanged(object sender, EventArgs e) {
            try {
                if (dataGridViewProducts1.CurrentRow == null)
                    return;

                Guid currentProductId = Guid.Empty; 
            
                if (dataGridViewProducts1.CurrentRow.Cells["ProductId"].Value != null)
                    currentProductId = (System.Guid) dataGridViewProducts1.CurrentRow.Cells["ProductId"].Value;

                if (_productContract == null || _productContract.Product.ProductId != currentProductId)
                    UpdateProduct(currentProductId);
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void dataGridViewProducts2_SelectionChanged(object sender, EventArgs e) {
            try {
                if (dataGridViewProducts2.CurrentRow == null)
                    return;

                Guid currentProductId = Guid.Empty; 
            
                if (dataGridViewProducts2.CurrentRow.Cells["ProductId"].Value != null)
                    currentProductId = (System.Guid) dataGridViewProducts2.CurrentRow.Cells["ProductId"].Value;

                if (_productContract == null || _productContract.Product.ProductId != currentProductId)
                    UpdateProduct(currentProductId);
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void dataGridViewProducts3_SelectionChanged(object sender, EventArgs e) {
            try {
                if (dataGridViewProducts3.CurrentRow == null)
                    return;

                Guid currentProductId = Guid.Empty; 
            
                if (dataGridViewProducts3.CurrentRow.Cells["ProductId"].Value != null)
                    currentProductId = (System.Guid) dataGridViewProducts3.CurrentRow.Cells["ProductId"].Value;

                if (_productContract == null || _productContract.Product.ProductId != currentProductId)
                    UpdateProduct(currentProductId);
            } catch (Exception ex) {
                Error(ex);
            }
        }

        private void toolStripTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char) 13) {
                e.Handled = true;

                // find category
                var productCategoryService = new CategorySearchService();
                CategoryFindContract[] productCategoryContracts = productCategoryService.CategoryFind(toolStripTextBoxSearch.Text);
                productCategoryService.Close();

                if (productCategoryContracts.Length == 0)
                    return;

                Guid productCategoryId = productCategoryContracts[0].ProductCategoryId;

                foreach (TreeNode node in treeViewHierarchy.Nodes) {
                    if (new Guid(node.Name) == productCategoryId) {
                        node.Expand();
                        treeViewHierarchy.SelectedNode = node;
                        SelectNode(node);
                        tabControlSplit.SelectedTab = tabPageCategory;
                        treeViewHierarchy.Select();
                    }

                    foreach (TreeNode subNode in node.Nodes) {
                        if (new Guid(subNode.Name) == productCategoryId) {
                            subNode.Parent.Expand();
                            treeViewHierarchy.SelectedNode = subNode;
                            SelectNode(subNode);
                            tabControlSplit.SelectedTab = tabPageProducts;
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
