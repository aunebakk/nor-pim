/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:43 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceTypeRefEdit : Form {
        
        private CrudeProductGatherSourceTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductGatherSourceTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductGatherSourceTypeRefContract();
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
                _contract = new CrudeProductGatherSourceTypeRefContract();
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
        
        public void ShowAsAdd(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId) {
            try {
                _contract = new CrudeProductGatherSourceTypeRefContract();
                _isNew = true;
                _contract.ProductGatherSourceTypeRcd = productGatherSourceTypeRcd;
                textBoxProductGatherSourceType.Text = _contract.ProductGatherSourceTypeRcd;
                _contract.ProductGatherSourceTypeName = productGatherSourceTypeName;
                textBoxProductGatherSourceTypeName.Text = _contract.ProductGatherSourceTypeName;
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
        
        public void ShowAsEdit(string productGatherSourceTypeRcd, System.Guid userId) {
            var service = new CrudeProductGatherSourceTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
                textBoxProductGatherSourceType.Text = _contract.ProductGatherSourceTypeRcd;
                textBoxProductGatherSourceTypeName.Text = _contract.ProductGatherSourceTypeName;
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
            var service = new CrudeProductGatherSourceTypeRefServiceClient();
            try {
                _contract.ProductGatherSourceTypeRcd = textBoxProductGatherSourceType.Text;
                _contract.ProductGatherSourceTypeName = textBoxProductGatherSourceTypeName.Text;

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
