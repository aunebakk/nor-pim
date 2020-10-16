/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 8:59:53 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeProductFieldSetMappingEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeProductFieldSetMappingContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductFieldSetMappingEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                this.Text += " - Not Savable (ProductFieldSet,User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByProductFieldSet(System.Guid productFieldSetId) {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductFieldSetId = productFieldSetId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByProductIdentifier(string productIdentifierRcd) {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductIdentifierRcd = productIdentifierRcd;
                productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByProductAttribute(string productAttributeRcd) {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductAttributeRcd = productAttributeRcd;
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByProductInfo(string productInfoRcd) {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductInfoRcd = productInfoRcd;
                productInfoRefCombo.Text = _contract.ProductInfoRcd != null ? _contract.ProductInfoRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByProductImageType(string productImageTypeRcd) {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductImageTypeRcd = productImageTypeRcd;
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByProductDocumentationType(string productDocumentationTypeRcd) {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductDocumentationTypeRcd = productDocumentationTypeRcd;
                productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd != null ? _contract.ProductDocumentationTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId) {
            try {
                _contract = new CrudeProductFieldSetMappingContract();
                _isNew = true;
                _contract.ProductFieldSetId = productFieldSetId;
                _contract.ProductIdentifierRcd = productIdentifierRcd;
                productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;
                _contract.ProductAttributeRcd = productAttributeRcd;
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : String.Empty;
                _contract.ProductInfoRcd = productInfoRcd;
                productInfoRefCombo.Text = _contract.ProductInfoRcd != null ? _contract.ProductInfoRcd : String.Empty;
                _contract.ProductImageTypeRcd = productImageTypeRcd;
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : String.Empty;
                _contract.ProductDocumentationTypeRcd = productDocumentationTypeRcd;
                productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd != null ? _contract.ProductDocumentationTypeRcd : String.Empty;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid productFieldSetMappingId) {
            var service = new CrudeProductFieldSetMappingServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductFieldSetMappingId(productFieldSetMappingId);
                productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : String.Empty;
                productInfoRefCombo.Text = _contract.ProductInfoRcd != null ? _contract.ProductInfoRcd : String.Empty;
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : String.Empty;
                productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd != null ? _contract.ProductDocumentationTypeRcd : String.Empty;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }
        }
        
        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductFieldSetMappingServiceClient();
            try {
                _contract.ProductIdentifierRcd = productIdentifierRefCombo.Text;
                _contract.ProductAttributeRcd = productAttributeRefCombo.Text;
                _contract.ProductInfoRcd = productInfoRefCombo.Text;
                _contract.ProductImageTypeRcd = productImageTypeRefCombo.Text;
                _contract.ProductDocumentationTypeRcd = productDocumentationTypeRefCombo.Text;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
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
