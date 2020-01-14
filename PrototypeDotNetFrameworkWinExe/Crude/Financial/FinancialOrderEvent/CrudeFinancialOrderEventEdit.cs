/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:19:57 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderEventEdit : Form {
        
        private CrudeFinancialOrderEventContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialOrderEventEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderEventContract();
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
                _contract = new CrudeFinancialOrderEventContract();
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
                _contract = new CrudeFinancialOrderEventContract();
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
        
        public void ShowAsAddByFinancialOrderEventType(string financialOrderEventTypeRcd) {
            try {
                _contract = new CrudeFinancialOrderEventContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialOrderEventTypeRcd = financialOrderEventTypeRcd;
                financialOrderEventTypeRefCombo.Text = _contract.FinancialOrderEventTypeRcd != null ? _contract.FinancialOrderEventTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid financialOrderId, System.Guid userId, string comment, string financialOrderEventTypeRcd) {
            try {
                _contract = new CrudeFinancialOrderEventContract();
                _isNew = true;
                _contract.FinancialOrderId = financialOrderId;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.Comment = comment;
                textBoxComment.Text = _contract.Comment;
                _contract.FinancialOrderEventTypeRcd = financialOrderEventTypeRcd;
                financialOrderEventTypeRefCombo.Text = _contract.FinancialOrderEventTypeRcd != null ? _contract.FinancialOrderEventTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid fiancialOrderEventId) {
            var service = new CrudeFinancialOrderEventServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFiancialOrderEventId(fiancialOrderEventId);
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                textBoxComment.Text = _contract.Comment;
                financialOrderEventTypeRefCombo.Text = _contract.FinancialOrderEventTypeRcd != null ? _contract.FinancialOrderEventTypeRcd : String.Empty;

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
            var service = new CrudeFinancialOrderEventServiceClient();
            try {
                _contract.Comment = textBoxComment.Text;
                _contract.FinancialOrderEventTypeRcd = financialOrderEventTypeRefCombo.Text;

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
