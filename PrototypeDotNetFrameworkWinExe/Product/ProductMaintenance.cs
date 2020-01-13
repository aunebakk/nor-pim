using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface
{
    public partial class ProductMaintenance : Form
    {
        Guid _userId;
        Guid _productId;
        //Form _parent;
        const bool _logEvents = true;
        ProductContract _productContract = null;

        public ProductMaintenance() {
            InitializeComponent();
            InitializeGridProductAttribute();
            InitializeGridProductIdentifier();
            InitializeGridProductInfo();
            InitializeGridProductImages();
            InitializeGridProductDocumentation();
            InitializeGridProductHistory();
        }

        private void Show(
            Guid productId,
            Guid userId,
            Form mdiParent
            ) {

            _productId = productId;
            _userId = userId;

            // save 
            if ( mdiParent != null )
                MdiParent = mdiParent;

            UpdateProduct(productId);

            this.Show();
        }

        public void Show(
            Guid productId,
            Guid userId
            ) {

            Show(productId, userId, null);
        }

        private void buttonProductSave_Click(object sender, EventArgs e) {
            Log("buttonProductSave_Click");

            try {
                _productContract.Product.ProductName = textBoxProductName.Text;
                Guid newProductId =
                    new ProductServiceClient().ProductSaveCompleteById(
                        _productContract,
                        _userId
                        );

                //// update caller with new product id
                //if ( _airlineId != Guid.Empty ) {
                //    // NOTE: airline specific code
                //    new AirlineServiceClient().PIMLinkUpdate(_airlineId, newProductId, _userId);

                //} else if ( _airportId != Guid.Empty ) {
                //    // NOTE: airport specific code
                //    new AirportServiceClient().PIMLinkUpdate(_airportId, newProductId, _userId);

                //} else if ( _ferryId != Guid.Empty ) {
                //    // NOTE: ferry specific code
                //    new FerryServiceClient().PIMLinkUpdate(_ferryId, newProductId, _userId);

                //} else if ( _serviceHotelId != Guid.Empty ) {
                //    // NOTE: serviceHotel specific code
                //    new HotelServiceClient().PIMLinkUpdate(_serviceHotelId, newProductId, _userId);

                //} else if ( _carRentalId != Guid.Empty ) {
                //    // NOTE: car rental specific code
                //    new CarRentalServiceClient().PIMLinkUpdate(_carRentalId, newProductId, _userId);
                //}

                // get new product ( check for updated data, needed? )
                UpdateProduct(newProductId);
            } catch ( Exception ex ) {
                Error("buttonProductSave_Click", ex);
            }
        }

        private void ProductMaintenance_FormClosed(object sender, FormClosedEventArgs e) {
            //if ( _airlineId != Guid.Empty ) {
            //    // NOTE: airline specific code
            //    ( ( AirlineSearch ) _parent ).RefreshAll();

            //} else if ( _airportId != Guid.Empty ) {
            //    // NOTE: airport specific code
            //    ( ( GetAirportIndexWithFilterSearch ) _parent ).RefreshAirport();

            //} else if ( _aircraftId != Guid.Empty ) {
            //    // NOTE: aircraft specific code
            //    ( ( Aircrafts ) _parent ).RefreshAircraft();

            //} else if ( _ferryId != Guid.Empty ) {
            //    // NOTE: ferry specific code
            //    ( ( ServiceFerryListSearch ) _parent ).RefreshFerry();

            //} else if ( _serviceHotelId != Guid.Empty ) {
            //    // NOTE: hotel specific code
            //    ( ( GetHotelIndexWithFilterSearch ) _parent ).RefreshHotel();

            //} else if ( _carRentalId != Guid.Empty ) {
            //    // NOTE: car rental specific code
            //    ( ( GetCarRentalIndexWithFilterSearch ) _parent ).RefreshCarRental();
            //}
        }

        //public void ShowFromAirline(
        //    Guid airlineId,
        //    Guid productId,
        //    Guid userId,
        //    Form parent
        //    ) {

        //    _airlineId = airlineId;
        //    _parent = parent;
        //    _userId = userId;

        //    productId = new AirlineServiceClient().PIMLinkCheck(airlineId, productId, userId);

        //    Show(productId, userId, _parent.MdiParent);
        //}

        //public void ShowFromAircraft(
        //    Guid aircraftId,
        //    Guid productId,
        //    Guid userId,
        //    Form parent
        //    ) {

        //    _aircraftId = aircraftId;
        //    _parent = parent;
        //    _userId = userId;


        //    Show(productId, userId, _parent.MdiParent);
        //}

        //public void ShowFromFerry(
        //    Guid ferryId,
        //    Guid productId,
        //    Guid userId,
        //    Form parent
        //    ) {

        //    _ferryId = ferryId;
        //    _parent = parent;
        //    _userId = userId;

        //    productId = new FerryServiceClient().PIMLinkCheck(ferryId, productId, userId);

        //    Show(productId, userId, _parent.MdiParent);
        //}

        //public void ShowFromAirport(
        //    Guid airportId,
        //    Guid productId,
        //    Guid userId,
        //    Form parent
        //    ) {

        //    _airportId = airportId;
        //    _parent = parent;
        //    _userId = userId;

        //    productId = new AirportServiceClient().PIMLinkCheck(airportId, productId, userId);

        //    Show(productId, userId, _parent.MdiParent);
        //}

        //public void ShowFromServiceHotel(
        //    Guid serviceHotelId,
        //    Guid productId,
        //    Guid userId,
        //    Form parent
        //    ) {

        //    _serviceHotelId = serviceHotelId;
        //    _parent = parent;
        //    _userId = userId;

        //    productId = new AirportServiceClient().PIMLinkCheck(serviceHotelId, productId, userId);

        //    Show(productId, userId, _parent.MdiParent);
        //}

        //public void ShowFromCarRental(
        //    Guid carRentalId,
        //    Guid productId,
        //    Guid userId,
        //    Form parent
        //    ) {

        //    _carRentalId = carRentalId;
        //    _parent = parent;
        //    _userId = userId;

        //    productId = new AirportServiceClient().PIMLinkCheck(_carRentalId, productId, userId);

        //    Show(productId, userId, _parent.MdiParent);
        //}

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void CheckForm(Form form) {
            Singleton.Instance.CheckForm(form);
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

        private void UpdateProduct(Guid productId) {
            Log("UpdateProduct");

            // Show product info
            try {
                _productId = productId;

                _productContract =
                    new ProductServiceClient().ProductGetCompleteById(
                            productId
                            );

                textBoxProductName.Text = _productContract.Product.ProductName;
                stateRefComboProduct.Text = _productContract.Product.StateRcd;
                dateTimePickerProduct.Text = _productContract.Product.DateTime.ToLongDateString();

                PopulateProductAttribute(_productContract.ProductAttribute);
                PopulateProductIdentifier(_productContract.ProductIdentifier);
                PopulateProductInfo(_productContract.ProductInfo);
                PopulateProductImage(_productContract.ProductImage);
                PopulateProductDocument(_productContract.ProductDocumentation);
                PopulateProductHistory();
            } catch ( Exception ex ) {
                Error("UpdateProduct", ex);
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
    }
}
