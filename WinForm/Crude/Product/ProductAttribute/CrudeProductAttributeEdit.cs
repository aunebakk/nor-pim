/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:19 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeProductAttributeEdit : Form {

        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeProductAttributeContract _contract;

        private bool _isNew;

        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductAttributeEdit() {
            InitializeComponent();
            AcceptButton = buttonSave;
            CancelButton = buttonClose;
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                Text += " - Not Savable (Product,User Missing)";
                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows by foreign keys
        public void ShowAsAddByProduct(System.Guid productId) {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductId = productId;

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows by foreign keys
        public void ShowAsAddByProductAttribute(string productAttributeRcd) {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductAttributeRcd = productAttributeRcd;
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : string.Empty;

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows by foreign keys
        public void ShowAsAddByProductAttributeUnit(string productAttributeUnitRcd) {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductAttributeUnitRcd = productAttributeUnitRcd;
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : string.Empty;

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId) {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                _contract.ProductId = productId;
                _contract.ProductAttributeRcd = productAttributeRcd;
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : string.Empty;
                _contract.ProductAttributeUnitRcd = productAttributeUnitRcd;
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : string.Empty;
                _contract.Value = value;
                textBoxValue.Text = _contract.Value;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form in edit modus
        public void ShowAsEdit(System.Guid productAttributeId) {
            CrudeProductAttributeServiceClient service = new CrudeProductAttributeServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductAttributeId(productAttributeId);
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : string.Empty;
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : string.Empty;
                textBoxValue.Text = _contract.Value;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            } finally {
                service.Close();
            }
        }

        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeProductAttributeServiceClient service = new CrudeProductAttributeServiceClient();
            try {
                _contract.ProductAttributeRcd = productAttributeRefCombo.Text;
                _contract.ProductAttributeUnitRcd = productAttributeUnitRefCombo.Text;
                _contract.Value = textBoxValue.Text;

                if (_isNew) {
                    service.Insert(_contract);
                } else {
                    service.Update(_contract);
                }
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            } finally {
                service.Close();
            }

            Close();
        }

        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
