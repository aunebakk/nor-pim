/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:40:52 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategoryImageTypeRefEdit : Form {
        
        private CrudeProductCategoryImageTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductCategoryImageTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductCategoryImageTypeRefContract();
                _isNew = true;
                this.Text += " - Not Savable (User Missing)";
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
                _contract = new CrudeProductCategoryImageTypeRefContract();
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
        
        public void ShowAsAdd(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryImageTypeRefContract();
                _isNew = true;
                _contract.ProductCategoryImageTypeRcd = productCategoryImageTypeRcd;
                textBoxProductCategoryImageType.Text = _contract.ProductCategoryImageTypeRcd;
                _contract.ProductCategoryImageTypeName = productCategoryImageTypeName;
                textBoxProductCategoryImageTypeName.Text = _contract.ProductCategoryImageTypeName;
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
        
        public void ShowAsEdit(string productCategoryImageTypeRcd, System.Guid userId) {
            var service = new CrudeProductCategoryImageTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
                textBoxProductCategoryImageType.Text = _contract.ProductCategoryImageTypeRcd;
                textBoxProductCategoryImageTypeName.Text = _contract.ProductCategoryImageTypeName;
                _contract.UserId = userId;
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
            var service = new CrudeProductCategoryImageTypeRefServiceClient();
            try {
                _contract.ProductCategoryImageTypeRcd = textBoxProductCategoryImageType.Text;
                _contract.ProductCategoryImageTypeName = textBoxProductCategoryImageTypeName.Text;

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
