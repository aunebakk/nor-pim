/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:52:45 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategoryDocumentationEdit : Form {
        
        private CrudeProductCategoryDocumentationContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductCategoryDocumentationEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                this.Text += " - Not Savable (ProductCategory,User Missing)";
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
                _contract = new CrudeProductCategoryDocumentationContract();
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
        
        public void ShowAsAddByProductCategoryDocumentationTypeAndDocumentation(string productCategoryDocumentationTypeRcd, string documentation) {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductCategoryDocumentationTypeRcd = productCategoryDocumentationTypeRcd;
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd != null ? _contract.ProductCategoryDocumentationTypeRcd : String.Empty;
                _contract.Documentation = documentation;
                textBoxDocumentation.Text = _contract.Documentation;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByProductCategory(System.Guid productCategoryId) {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductCategoryId = productCategoryId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                _contract.ProductCategoryDocumentationTypeRcd = productCategoryDocumentationTypeRcd;
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd != null ? _contract.ProductCategoryDocumentationTypeRcd : String.Empty;
                _contract.ProductCategoryId = productCategoryId;
                _contract.Documentation = documentation;
                textBoxDocumentation.Text = _contract.Documentation;
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
        
        public void ShowAsEdit(System.Guid productCategoryDocumentationId) {
            var service = new CrudeProductCategoryDocumentationServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd != null ? _contract.ProductCategoryDocumentationTypeRcd : String.Empty;
                textBoxDocumentation.Text = _contract.Documentation;
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
            var service = new CrudeProductCategoryDocumentationServiceClient();
            try {
                _contract.ProductCategoryDocumentationTypeRcd = productCategoryDocumentationTypeRefCombo.Text;
                _contract.Documentation = textBoxDocumentation.Text;

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
