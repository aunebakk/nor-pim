/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:49:42 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductAttributeUnitRefEdit : Form {
        
        private CrudeProductAttributeUnitRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductAttributeUnitRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductAttributeUnitRefContract();
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
                _contract = new CrudeProductAttributeUnitRefContract();
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
        
        public void ShowAsAdd(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId) {
            try {
                _contract = new CrudeProductAttributeUnitRefContract();
                _isNew = true;
                _contract.ProductAttributeUnitRcd = productAttributeUnitRcd;
                textBoxProductAttributeUnit.Text = _contract.ProductAttributeUnitRcd;
                _contract.ProductAttributeUnitName = productAttributeUnitName;
                textBoxProductAttributeUnitName.Text = _contract.ProductAttributeUnitName;
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
        
        public void ShowAsEdit(string productAttributeUnitRcd, System.Guid userId) {
            var service = new CrudeProductAttributeUnitRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
                textBoxProductAttributeUnit.Text = _contract.ProductAttributeUnitRcd;
                textBoxProductAttributeUnitName.Text = _contract.ProductAttributeUnitName;
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
            var service = new CrudeProductAttributeUnitRefServiceClient();
            try {
                _contract.ProductAttributeUnitRcd = textBoxProductAttributeUnit.Text;
                _contract.ProductAttributeUnitName = textBoxProductAttributeUnitName.Text;

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
