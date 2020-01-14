/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:19:43 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialTaxTypeRefEdit : Form {
        
        private CrudeFinancialTaxTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialTaxTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialTaxTypeRefContract();
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
                _contract = new CrudeFinancialTaxTypeRefContract();
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
        
        public void ShowAsAdd(string financialTaxTypeName, string financialTaxTypeRcd, System.Guid userId) {
            try {
                _contract = new CrudeFinancialTaxTypeRefContract();
                _isNew = true;
                _contract.FinancialTaxTypeName = financialTaxTypeName;
                textBoxFinancialTaxTypeName.Text = _contract.FinancialTaxTypeName;
                _contract.FinancialTaxTypeRcd = financialTaxTypeRcd;
                textBoxFinancialTaxType.Text = _contract.FinancialTaxTypeRcd;
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
        
        public void ShowAsEdit(string financialTaxTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialTaxTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialTaxTypeRcd(financialTaxTypeRcd);
                textBoxFinancialTaxTypeName.Text = _contract.FinancialTaxTypeName;
                textBoxFinancialTaxType.Text = _contract.FinancialTaxTypeRcd;
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
            var service = new CrudeFinancialTaxTypeRefServiceClient();
            try {
                _contract.FinancialTaxTypeName = textBoxFinancialTaxTypeName.Text;
                _contract.FinancialTaxTypeRcd = textBoxFinancialTaxType.Text;

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
