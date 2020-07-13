/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:56:39 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherAttributeEdit : Form {
        
        private CrudeProductGatherAttributeContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductGatherAttributeEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                this.Text += " - Not Savable (ProductGatherKey,User Missing)";
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
                _contract = new CrudeProductGatherAttributeContract();
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
        
        public void ShowAsAddByProductGatherAttributeType(string productGatherAttributeTypeRcd) {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductGatherAttributeTypeRcd = productGatherAttributeTypeRcd;
                productGatherAttributeTypeRefCombo.Text = _contract.ProductGatherAttributeTypeRcd != null ? _contract.ProductGatherAttributeTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByProductGatherKey(System.Guid productGatherKeyId) {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductGatherKeyId = productGatherKeyId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId) {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                _contract.ProductGatherAttributeValue = productGatherAttributeValue;
                textBoxProductGatherAttributeValue.Text = _contract.ProductGatherAttributeValue;
                _contract.ProductGatherAttributeTypeRcd = productGatherAttributeTypeRcd;
                productGatherAttributeTypeRefCombo.Text = _contract.ProductGatherAttributeTypeRcd != null ? _contract.ProductGatherAttributeTypeRcd : String.Empty;
                _contract.ProductGatherKeyId = productGatherKeyId;
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
        
        public void ShowAsEdit(System.Guid productGatherAttributeId) {
            var service = new CrudeProductGatherAttributeServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductGatherAttributeId(productGatherAttributeId);
                textBoxProductGatherAttributeValue.Text = _contract.ProductGatherAttributeValue;
                productGatherAttributeTypeRefCombo.Text = _contract.ProductGatherAttributeTypeRcd != null ? _contract.ProductGatherAttributeTypeRcd : String.Empty;
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
            var service = new CrudeProductGatherAttributeServiceClient();
            try {
                _contract.ProductGatherAttributeValue = textBoxProductGatherAttributeValue.Text;
                _contract.ProductGatherAttributeTypeRcd = productGatherAttributeTypeRefCombo.Text;

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
