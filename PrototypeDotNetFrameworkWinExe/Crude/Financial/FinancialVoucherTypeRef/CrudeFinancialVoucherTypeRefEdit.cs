/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:40 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialVoucherTypeRefEdit : Form {
        
        private CrudeFinancialVoucherTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialVoucherTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialVoucherTypeRefContract();
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
                _contract = new CrudeFinancialVoucherTypeRefContract();
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
        
        public void ShowAsAdd(string financialVoucherTypeRcd, string financialVoucherTypeName, System.Guid userId) {
            try {
                _contract = new CrudeFinancialVoucherTypeRefContract();
                _isNew = true;
                _contract.FinancialVoucherTypeRcd = financialVoucherTypeRcd;
                textBoxFinancialVoucherType.Text = _contract.FinancialVoucherTypeRcd;
                _contract.FinancialVoucherTypeName = financialVoucherTypeName;
                textBoxFinancialVoucherTypeName.Text = _contract.FinancialVoucherTypeName;
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
        
        public void ShowAsEdit(string financialVoucherTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialVoucherTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd);
                textBoxFinancialVoucherType.Text = _contract.FinancialVoucherTypeRcd;
                textBoxFinancialVoucherTypeName.Text = _contract.FinancialVoucherTypeName;
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
            var service = new CrudeFinancialVoucherTypeRefServiceClient();
            try {
                _contract.FinancialVoucherTypeRcd = textBoxFinancialVoucherType.Text;
                _contract.FinancialVoucherTypeName = textBoxFinancialVoucherTypeName.Text;

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
