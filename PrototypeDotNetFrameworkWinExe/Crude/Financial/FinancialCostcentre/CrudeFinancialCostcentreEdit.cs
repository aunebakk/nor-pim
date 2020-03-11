/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:29:28 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCostcentreEdit : Form {
        
        private CrudeFinancialCostcentreContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialCostcentreEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialCostcentreContract();
                _isNew = true;
                this.Text += " - Not Savable (FinancialCompany,User Missing)";
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
                _contract = new CrudeFinancialCostcentreContract();
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
        
        public void ShowAsAddByFinancialCompany(System.Guid financialCompanyId) {
            try {
                _contract = new CrudeFinancialCostcentreContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCompanyId = financialCompanyId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string financialCostcentreName, string financialCostcentreCode, System.Guid financialCompanyId, System.Guid userId) {
            try {
                _contract = new CrudeFinancialCostcentreContract();
                _isNew = true;
                _contract.FinancialCostcentreName = financialCostcentreName;
                textBoxFinancialCostcentreName.Text = _contract.FinancialCostcentreName;
                _contract.FinancialCostcentreCode = financialCostcentreCode;
                textBoxFinancialCostcentreCode.Text = _contract.FinancialCostcentreCode;
                _contract.FinancialCompanyId = financialCompanyId;
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
        
        public void ShowAsEdit(System.Guid financialCostcentreId) {
            var service = new CrudeFinancialCostcentreServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialCostcentreId(financialCostcentreId);
                textBoxFinancialCostcentreName.Text = _contract.FinancialCostcentreName;
                textBoxFinancialCostcentreCode.Text = _contract.FinancialCostcentreCode;
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
            var service = new CrudeFinancialCostcentreServiceClient();
            try {
                _contract.FinancialCostcentreName = textBoxFinancialCostcentreName.Text;
                _contract.FinancialCostcentreCode = textBoxFinancialCostcentreCode.Text;

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
