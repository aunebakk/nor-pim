/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:52:39 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderEventTypeRefEdit : Form {
        
        private CrudeFinancialOrderEventTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialOrderEventTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderEventTypeRefContract();
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
                _contract = new CrudeFinancialOrderEventTypeRefContract();
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
        
        public void ShowAsAdd(string financialOrderEventTypeRcd, string financialOrderEventTypeName, System.Guid userId) {
            try {
                _contract = new CrudeFinancialOrderEventTypeRefContract();
                _isNew = true;
                _contract.FinancialOrderEventTypeRcd = financialOrderEventTypeRcd;
                textBoxFinancialOrderEventType.Text = _contract.FinancialOrderEventTypeRcd;
                _contract.FinancialOrderEventTypeName = financialOrderEventTypeName;
                textBoxFinancialOrderEventTypeName.Text = _contract.FinancialOrderEventTypeName;
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
        
        public void ShowAsEdit(string financialOrderEventTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialOrderEventTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd);
                textBoxFinancialOrderEventType.Text = _contract.FinancialOrderEventTypeRcd;
                textBoxFinancialOrderEventTypeName.Text = _contract.FinancialOrderEventTypeName;
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
            var service = new CrudeFinancialOrderEventTypeRefServiceClient();
            try {
                _contract.FinancialOrderEventTypeRcd = textBoxFinancialOrderEventType.Text;
                _contract.FinancialOrderEventTypeName = textBoxFinancialOrderEventTypeName.Text;

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
