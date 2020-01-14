/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:42:46 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCardTypeRefEdit : Form {
        
        private CrudeFinancialCardTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialCardTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialCardTypeRefContract();
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
                _contract = new CrudeFinancialCardTypeRefContract();
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
        
        public void ShowAsAdd(string financialCardTypeRcd, string financialCardTypeName, System.Guid userId) {
            try {
                _contract = new CrudeFinancialCardTypeRefContract();
                _isNew = true;
                _contract.FinancialCardTypeRcd = financialCardTypeRcd;
                textBoxFinancialCardType.Text = _contract.FinancialCardTypeRcd;
                _contract.FinancialCardTypeName = financialCardTypeName;
                textBoxFinancialCardTypeName.Text = _contract.FinancialCardTypeName;
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
        
        public void ShowAsEdit(string financialCardTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialCardTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialCardTypeRcd(financialCardTypeRcd);
                textBoxFinancialCardType.Text = _contract.FinancialCardTypeRcd;
                textBoxFinancialCardTypeName.Text = _contract.FinancialCardTypeName;
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
            var service = new CrudeFinancialCardTypeRefServiceClient();
            try {
                _contract.FinancialCardTypeRcd = textBoxFinancialCardType.Text;
                _contract.FinancialCardTypeName = textBoxFinancialCardTypeName.Text;

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
