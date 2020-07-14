/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 1:11:46 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductFieldSetMappingEdit : Form {
        
        private CrudeProductFieldSetMappingContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductFieldSetMappingEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
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
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
