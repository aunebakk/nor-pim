/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:42 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductAttributeEdit : Form {
        
        private CrudeProductAttributeContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductAttributeEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                this.Text += " - Not Savable (Product,User Missing)";
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
                _contract = new CrudeProductAttributeContract();
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
        
        public void ShowAsAddByProduct(System.Guid productId) {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductId = productId;

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
                _contract = new CrudeProductAttributeContract();
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
        
        public void ShowAsAddByProductAttributeUnit(string productAttributeUnitRcd) {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductAttributeUnitRcd = productAttributeUnitRcd;
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId) {
            try {
                _contract = new CrudeProductAttributeContract();
                _isNew = true;
                _contract.ProductId = productId;
                _contract.ProductAttributeRcd = productAttributeRcd;
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : String.Empty;
                _contract.ProductAttributeUnitRcd = productAttributeUnitRcd;
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : String.Empty;
                _contract.Value = value;
                textBoxValue.Text = _contract.Value;
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
        
        public void ShowAsEdit(System.Guid productAttributeId) {
            var service = new CrudeProductAttributeServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductAttributeId(productAttributeId);
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd != null ? _contract.ProductAttributeRcd : String.Empty;
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd != null ? _contract.ProductAttributeUnitRcd : String.Empty;
                textBoxValue.Text = _contract.Value;
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
            var service = new CrudeProductAttributeServiceClient();
            try {
                _contract.ProductAttributeRcd = productAttributeRefCombo.Text;
                _contract.ProductAttributeUnitRcd = productAttributeUnitRefCombo.Text;
                _contract.Value = textBoxValue.Text;

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
