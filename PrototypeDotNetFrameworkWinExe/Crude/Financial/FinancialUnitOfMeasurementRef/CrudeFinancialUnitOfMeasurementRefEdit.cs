/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:19:44 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialUnitOfMeasurementRefEdit : Form {
        
        private CrudeFinancialUnitOfMeasurementRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialUnitOfMeasurementRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialUnitOfMeasurementRefContract();
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
                _contract = new CrudeFinancialUnitOfMeasurementRefContract();
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
        
        public void ShowAsAdd(string financialUnitOfMeasurementRcd, int sortSequenceNumber, bool changeFlag, string statusCode, string financialUnitOfMeasurementName, string financialUnitOfMeasurementCode, System.Guid userId) {
            try {
                _contract = new CrudeFinancialUnitOfMeasurementRefContract();
                _isNew = true;
                _contract.FinancialUnitOfMeasurementRcd = financialUnitOfMeasurementRcd;
                textBoxFinancialUnitOfMeasurement.Text = _contract.FinancialUnitOfMeasurementRcd;
                _contract.SortSequenceNumber = sortSequenceNumber;
                maskedTextBoxSortSequenceNumber.Text = _contract.SortSequenceNumber.ToString();
                _contract.ChangeFlag = changeFlag;
                checkBoxChangeFlag.Checked = _contract.ChangeFlag;
                _contract.StatusCode = statusCode;
                textBoxStatusCode.Text = _contract.StatusCode;
                _contract.FinancialUnitOfMeasurementName = financialUnitOfMeasurementName;
                textBoxFinancialUnitOfMeasurementName.Text = _contract.FinancialUnitOfMeasurementName;
                _contract.FinancialUnitOfMeasurementCode = financialUnitOfMeasurementCode;
                textBoxFinancialUnitOfMeasurementCode.Text = _contract.FinancialUnitOfMeasurementCode;
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
        
        public void ShowAsEdit(string financialUnitOfMeasurementRcd, System.Guid userId) {
            var service = new CrudeFinancialUnitOfMeasurementRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialUnitOfMeasurementRcd(financialUnitOfMeasurementRcd);
                textBoxFinancialUnitOfMeasurement.Text = _contract.FinancialUnitOfMeasurementRcd;
                maskedTextBoxSortSequenceNumber.Text = _contract.SortSequenceNumber.ToString();
                checkBoxChangeFlag.Checked = _contract.ChangeFlag;
                textBoxStatusCode.Text = _contract.StatusCode;
                textBoxFinancialUnitOfMeasurementName.Text = _contract.FinancialUnitOfMeasurementName;
                textBoxFinancialUnitOfMeasurementCode.Text = _contract.FinancialUnitOfMeasurementCode;
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
            var service = new CrudeFinancialUnitOfMeasurementRefServiceClient();
            try {
                _contract.FinancialUnitOfMeasurementRcd = textBoxFinancialUnitOfMeasurement.Text;
                _contract.SortSequenceNumber = maskedTextBoxSortSequenceNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortSequenceNumber.Text);
                _contract.ChangeFlag = Convert.ToBoolean(checkBoxChangeFlag.Checked);
                _contract.StatusCode = textBoxStatusCode.Text;
                _contract.FinancialUnitOfMeasurementName = textBoxFinancialUnitOfMeasurementName.Text;
                _contract.FinancialUnitOfMeasurementCode = textBoxFinancialUnitOfMeasurementCode.Text;

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
