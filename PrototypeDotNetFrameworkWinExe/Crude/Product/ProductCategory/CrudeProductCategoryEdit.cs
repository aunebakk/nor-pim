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
    
    
    public partial class CrudeProductCategoryEdit : Form {
        
        private CrudeProductCategoryContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductCategoryEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductCategoryContract();
                _isNew = true;
                this.Text += " - Not Savable (ProductCategoryParent,User Missing)";
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
                _contract = new CrudeProductCategoryContract();
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
        
        public void ShowAsAddByProductCategoryParent(System.Guid productCategoryParentId) {
            try {
                _contract = new CrudeProductCategoryContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductCategoryParentId = productCategoryParentId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByProductCategoryBecame(System.Guid productCategoryBecameId) {
            try {
                _contract = new CrudeProductCategoryContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductCategoryBecameId = productCategoryBecameId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryContract();
                _isNew = true;
                _contract.ProductCategoryBecameId = productCategoryBecameId;
                _contract.ProductCategoryParentId = productCategoryParentId;
                _contract.ProductCategoryCode = productCategoryCode;
                textBoxProductCategoryCode.Text = _contract.ProductCategoryCode;
                _contract.ProductCategoryName = productCategoryName;
                textBoxProductCategoryName.Text = _contract.ProductCategoryName;
                _contract.ProductCategoryPosition = productCategoryPosition;
                maskedTextBoxProductCategoryPosition.Text = _contract.ProductCategoryPosition.ToString();
                _contract.StateRcd = stateRcd;
                textBoxState.Text = _contract.StateRcd;
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
        
        public void ShowAsEdit(System.Guid productCategoryId) {
            var service = new CrudeProductCategoryServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductCategoryId(productCategoryId);
                textBoxProductCategoryCode.Text = _contract.ProductCategoryCode;
                textBoxProductCategoryName.Text = _contract.ProductCategoryName;
                maskedTextBoxProductCategoryPosition.Text = _contract.ProductCategoryPosition.ToString();
                textBoxState.Text = _contract.StateRcd;
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
            var service = new CrudeProductCategoryServiceClient();
            try {
                _contract.ProductCategoryCode = textBoxProductCategoryCode.Text;
                _contract.ProductCategoryName = textBoxProductCategoryName.Text;
                _contract.ProductCategoryPosition = maskedTextBoxProductCategoryPosition.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxProductCategoryPosition.Text);
                _contract.StateRcd = textBoxState.Text;

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
