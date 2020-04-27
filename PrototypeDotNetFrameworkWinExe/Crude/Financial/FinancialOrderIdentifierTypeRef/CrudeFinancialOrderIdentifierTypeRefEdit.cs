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
    
    
    public partial class CrudeFinancialOrderIdentifierTypeRefEdit : Form {
        
        private CrudeFinancialOrderIdentifierTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialOrderIdentifierTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderIdentifierTypeRefContract();
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
                _contract = new CrudeFinancialOrderIdentifierTypeRefContract();
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
        
        public void ShowAsAdd(string financialOrderIdentifierTypeRcd, string financialOrderIdentifierTypeCode, string financialOrderIdentifierTypeName, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId) {
            try {
                _contract = new CrudeFinancialOrderIdentifierTypeRefContract();
                _isNew = true;
                _contract.FinancialOrderIdentifierTypeRcd = financialOrderIdentifierTypeRcd;
                textBoxFinancialOrderIdentifierType.Text = _contract.FinancialOrderIdentifierTypeRcd;
                _contract.FinancialOrderIdentifierTypeCode = financialOrderIdentifierTypeCode;
                textBoxFinancialOrderIdentifierTypeCode.Text = _contract.FinancialOrderIdentifierTypeCode;
                _contract.FinancialOrderIdentifierTypeName = financialOrderIdentifierTypeName;
                textBoxFinancialOrderIdentifierTypeName.Text = _contract.FinancialOrderIdentifierTypeName;
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
        
        public void ShowAsEdit(string financialOrderIdentifierTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialOrderIdentifierTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialOrderIdentifierTypeRcd(financialOrderIdentifierTypeRcd);
                textBoxFinancialOrderIdentifierType.Text = _contract.FinancialOrderIdentifierTypeRcd;
                textBoxFinancialOrderIdentifierTypeCode.Text = _contract.FinancialOrderIdentifierTypeCode;
                textBoxFinancialOrderIdentifierTypeName.Text = _contract.FinancialOrderIdentifierTypeName;
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
            var service = new CrudeFinancialOrderIdentifierTypeRefServiceClient();
            try {
                _contract.FinancialOrderIdentifierTypeRcd = textBoxFinancialOrderIdentifierType.Text;
                _contract.FinancialOrderIdentifierTypeCode = textBoxFinancialOrderIdentifierTypeCode.Text;
                _contract.FinancialOrderIdentifierTypeName = textBoxFinancialOrderIdentifierTypeName.Text;
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
