/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 1:46:17 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherAttributeTypeRefEdit : Form {
        
        private CrudeProductGatherAttributeTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductGatherAttributeTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductGatherAttributeTypeRefContract();
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
                _contract = new CrudeProductGatherAttributeTypeRefContract();
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
        
        public void ShowAsAdd(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId) {
            try {
                _contract = new CrudeProductGatherAttributeTypeRefContract();
                _isNew = true;
                _contract.ProductGatherAttributeTypeRcd = productGatherAttributeTypeRcd;
                textBoxProductGatherAttributeType.Text = _contract.ProductGatherAttributeTypeRcd;
                _contract.ProductGatherAttributeTypeName = productGatherAttributeTypeName;
                textBoxProductGatherAttributeTypeName.Text = _contract.ProductGatherAttributeTypeName;
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
        
        public void ShowAsEdit(string productGatherAttributeTypeRcd, System.Guid userId) {
            var service = new CrudeProductGatherAttributeTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
                textBoxProductGatherAttributeType.Text = _contract.ProductGatherAttributeTypeRcd;
                textBoxProductGatherAttributeTypeName.Text = _contract.ProductGatherAttributeTypeName;
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
            var service = new CrudeProductGatherAttributeTypeRefServiceClient();
            try {
                _contract.ProductGatherAttributeTypeRcd = textBoxProductGatherAttributeType.Text;
                _contract.ProductGatherAttributeTypeName = textBoxProductGatherAttributeTypeName.Text;

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
