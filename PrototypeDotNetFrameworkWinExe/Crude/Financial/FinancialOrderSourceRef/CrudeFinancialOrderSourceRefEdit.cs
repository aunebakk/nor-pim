/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:40:35 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderSourceRefEdit : Form {
        
        private CrudeFinancialOrderSourceRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialOrderSourceRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderSourceRefContract();
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
                _contract = new CrudeFinancialOrderSourceRefContract();
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
        
        public void ShowAsAdd(string financialOrderSourceRcd, string financialOrderSourceName, string financialOrderSourceCode, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId) {
            try {
                _contract = new CrudeFinancialOrderSourceRefContract();
                _isNew = true;
                _contract.FinancialOrderSourceRcd = financialOrderSourceRcd;
                textBoxFinancialOrderSource.Text = _contract.FinancialOrderSourceRcd;
                _contract.FinancialOrderSourceName = financialOrderSourceName;
                textBoxFinancialOrderSourceName.Text = _contract.FinancialOrderSourceName;
                _contract.FinancialOrderSourceCode = financialOrderSourceCode;
                textBoxFinancialOrderSourceCode.Text = _contract.FinancialOrderSourceCode;
                _contract.SortSequenceNumber = sortSequenceNumber;
                maskedTextBoxSortSequenceNumber.Text = _contract.SortSequenceNumber.ToString();
                _contract.ChangeFlag = changeFlag;
                checkBoxChangeFlag.Checked = _contract.ChangeFlag;
                _contract.StatusCode = statusCode;
                textBoxStatusCode.Text = _contract.StatusCode;
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
        
        public void ShowAsEdit(string financialOrderSourceRcd, System.Guid userId) {
            var service = new CrudeFinancialOrderSourceRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialOrderSourceRcd(financialOrderSourceRcd);
                textBoxFinancialOrderSource.Text = _contract.FinancialOrderSourceRcd;
                textBoxFinancialOrderSourceName.Text = _contract.FinancialOrderSourceName;
                textBoxFinancialOrderSourceCode.Text = _contract.FinancialOrderSourceCode;
                maskedTextBoxSortSequenceNumber.Text = _contract.SortSequenceNumber.ToString();
                checkBoxChangeFlag.Checked = _contract.ChangeFlag;
                textBoxStatusCode.Text = _contract.StatusCode;
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
            var service = new CrudeFinancialOrderSourceRefServiceClient();
            try {
                _contract.FinancialOrderSourceRcd = textBoxFinancialOrderSource.Text;
                _contract.FinancialOrderSourceName = textBoxFinancialOrderSourceName.Text;
                _contract.FinancialOrderSourceCode = textBoxFinancialOrderSourceCode.Text;
                _contract.SortSequenceNumber = maskedTextBoxSortSequenceNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortSequenceNumber.Text);
                _contract.ChangeFlag = Convert.ToBoolean(checkBoxChangeFlag.Checked);
                _contract.StatusCode = textBoxStatusCode.Text;

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
