/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:57:35 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherSourceEdit : Form {
        
        private CrudeProductGatherSourceContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductGatherSourceEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductGatherSourceContract();
                _isNew = true;
                this.Text += " - Not Savable (ProductGather,User Missing)";
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
                _contract = new CrudeProductGatherSourceContract();
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
        
        public void ShowAsAddByProductGather(System.Guid productGatherId) {
            try {
                _contract = new CrudeProductGatherSourceContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductGatherId = productGatherId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByProductGatherSourceType(string productGatherSourceTypeRcd) {
            try {
                _contract = new CrudeProductGatherSourceContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductGatherSourceTypeRcd = productGatherSourceTypeRcd;
                productGatherSourceTypeRefCombo.Text = _contract.ProductGatherSourceTypeRcd != null ? _contract.ProductGatherSourceTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid productGatherId, string productGatherSourceTypeRcd, System.Guid userId) {
            try {
                _contract = new CrudeProductGatherSourceContract();
                _isNew = true;
                _contract.ProductGatherId = productGatherId;
                _contract.ProductGatherSourceTypeRcd = productGatherSourceTypeRcd;
                productGatherSourceTypeRefCombo.Text = _contract.ProductGatherSourceTypeRcd != null ? _contract.ProductGatherSourceTypeRcd : String.Empty;
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
        
        public void ShowAsEdit(System.Guid productGatherSourceId) {
            var service = new CrudeProductGatherSourceServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductGatherSourceId(productGatherSourceId);
                productGatherSourceTypeRefCombo.Text = _contract.ProductGatherSourceTypeRcd != null ? _contract.ProductGatherSourceTypeRcd : String.Empty;
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
            var service = new CrudeProductGatherSourceServiceClient();
            try {
                _contract.ProductGatherSourceTypeRcd = productGatherSourceTypeRefCombo.Text;

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
