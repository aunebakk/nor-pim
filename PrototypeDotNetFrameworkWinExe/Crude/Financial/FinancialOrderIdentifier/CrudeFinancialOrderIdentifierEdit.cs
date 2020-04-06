/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:37:51 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderIdentifierEdit : Form {
        
        private CrudeFinancialOrderIdentifierContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialOrderIdentifierEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderIdentifierContract();
                _isNew = true;
                this.Text += " - Not Savable (FinancialOrder,User Missing)";
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
                _contract = new CrudeFinancialOrderIdentifierContract();
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
        
        public void ShowAsAddByFinancialOrder(System.Guid financialOrderId) {
            try {
                _contract = new CrudeFinancialOrderIdentifierContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialOrderId = financialOrderId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialOrderAndFinancialOrderIdentifierType(System.Guid financialOrderId, string financialOrderIdentifierTypeRcd) {
            try {
                _contract = new CrudeFinancialOrderIdentifierContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialOrderId = financialOrderId;
                _contract.FinancialOrderIdentifierTypeRcd = financialOrderIdentifierTypeRcd;
                financialOrderIdentifierTypeRefCombo.Text = _contract.FinancialOrderIdentifierTypeRcd != null ? _contract.FinancialOrderIdentifierTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid financialOrderId, string financialOrderIdentifierTypeRcd, string financialOrderIdentifierCode, System.Guid userId) {
            try {
                _contract = new CrudeFinancialOrderIdentifierContract();
                _isNew = true;
                _contract.FinancialOrderId = financialOrderId;
                _contract.FinancialOrderIdentifierTypeRcd = financialOrderIdentifierTypeRcd;
                financialOrderIdentifierTypeRefCombo.Text = _contract.FinancialOrderIdentifierTypeRcd != null ? _contract.FinancialOrderIdentifierTypeRcd : String.Empty;
                _contract.FinancialOrderIdentifierCode = financialOrderIdentifierCode;
                textBoxFinancialOrderIdentifierCode.Text = _contract.FinancialOrderIdentifierCode;
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
        
        public void ShowAsEdit(System.Guid financialOrderIdentifierId) {
            var service = new CrudeFinancialOrderIdentifierServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialOrderIdentifierId(financialOrderIdentifierId);
                financialOrderIdentifierTypeRefCombo.Text = _contract.FinancialOrderIdentifierTypeRcd != null ? _contract.FinancialOrderIdentifierTypeRcd : String.Empty;
                textBoxFinancialOrderIdentifierCode.Text = _contract.FinancialOrderIdentifierCode;
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
            var service = new CrudeFinancialOrderIdentifierServiceClient();
            try {
                _contract.FinancialOrderIdentifierTypeRcd = financialOrderIdentifierTypeRefCombo.Text;
                _contract.FinancialOrderIdentifierCode = textBoxFinancialOrderIdentifierCode.Text;

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
