/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:20:16 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentTypeRefEdit : Form {
        
        private CrudeFinancialPaymentTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialPaymentTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialPaymentTypeRefContract();
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
                _contract = new CrudeFinancialPaymentTypeRefContract();
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
        
        public void ShowAsAdd(string financialPaymentTypeRcd, string financialPaymentTypeName, System.Guid userId) {
            try {
                _contract = new CrudeFinancialPaymentTypeRefContract();
                _isNew = true;
                _contract.FinancialPaymentTypeRcd = financialPaymentTypeRcd;
                textBoxFinancialPaymentType.Text = _contract.FinancialPaymentTypeRcd;
                _contract.FinancialPaymentTypeName = financialPaymentTypeName;
                textBoxFinancialPaymentTypeName.Text = _contract.FinancialPaymentTypeName;
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
        
        public void ShowAsEdit(string financialPaymentTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialPaymentTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialPaymentTypeRcd(financialPaymentTypeRcd);
                textBoxFinancialPaymentType.Text = _contract.FinancialPaymentTypeRcd;
                textBoxFinancialPaymentTypeName.Text = _contract.FinancialPaymentTypeName;
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
            var service = new CrudeFinancialPaymentTypeRefServiceClient();
            try {
                _contract.FinancialPaymentTypeRcd = textBoxFinancialPaymentType.Text;
                _contract.FinancialPaymentTypeName = textBoxFinancialPaymentTypeName.Text;

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
