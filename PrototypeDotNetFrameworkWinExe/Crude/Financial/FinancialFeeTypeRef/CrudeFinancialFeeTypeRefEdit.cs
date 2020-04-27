/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:39 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialFeeTypeRefEdit : Form {
        
        private CrudeFinancialFeeTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialFeeTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialFeeTypeRefContract();
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
                _contract = new CrudeFinancialFeeTypeRefContract();
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
        
        public void ShowAsAdd(string financialFeeTypeRcd, string financialFeeTypeName, System.Guid userId) {
            try {
                _contract = new CrudeFinancialFeeTypeRefContract();
                _isNew = true;
                _contract.FinancialFeeTypeRcd = financialFeeTypeRcd;
                textBoxFinancialFeeType.Text = _contract.FinancialFeeTypeRcd;
                _contract.FinancialFeeTypeName = financialFeeTypeName;
                textBoxFinancialFeeTypeName.Text = _contract.FinancialFeeTypeName;
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
        
        public void ShowAsEdit(string financialFeeTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialFeeTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialFeeTypeRcd(financialFeeTypeRcd);
                textBoxFinancialFeeType.Text = _contract.FinancialFeeTypeRcd;
                textBoxFinancialFeeTypeName.Text = _contract.FinancialFeeTypeName;
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
            var service = new CrudeFinancialFeeTypeRefServiceClient();
            try {
                _contract.FinancialFeeTypeRcd = textBoxFinancialFeeType.Text;
                _contract.FinancialFeeTypeName = textBoxFinancialFeeTypeName.Text;

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
