/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:19 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultTestRunEdit : Form {
        
        private CrudeDefaultTestRunContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultTestRunEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultTestRunContract();
                _isNew = true;
                this.Text += " - Not Savable (DefaultTest,User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultTestRunContract();
                _isNew = true;
                _contract.DefaultTestId = defaultTestId;
                _contract.DefaultTestRunResultRcd = defaultTestRunResultRcd;
                defaultTestRunResultRefCombo.Text = _contract.DefaultTestRunResultRcd != null ? _contract.DefaultTestRunResultRcd : String.Empty;
                _contract.Result = result;
                textBoxResult.Text = _contract.Result;
                _contract.StartDateTime = startDateTime;
                dateTimePickerStartDateTime.Value = _contract.StartDateTime != DateTime.MinValue ? _contract.StartDateTime : dateTimePickerStartDateTime.MinDate;
                dateTimePickerStartDateTime.Checked = _contract.StartDateTime != DateTime.MinValue;
                _contract.EndDateTime = endDateTime;
                dateTimePickerEndDateTime.Value = _contract.EndDateTime != DateTime.MinValue ? _contract.EndDateTime : dateTimePickerEndDateTime.MinDate;
                dateTimePickerEndDateTime.Checked = _contract.EndDateTime != DateTime.MinValue;
                _contract.ElapsedMilliseconds = elapsedMilliseconds;
                maskedTextBoxElapsedMilliseconds.Text = _contract.ElapsedMilliseconds.ToString();
                _contract.UserId = userId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid defaultTestRunId) {
            var service = new CrudeDefaultTestRunServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultTestRunId(defaultTestRunId);
                defaultTestRunResultRefCombo.Text = _contract.DefaultTestRunResultRcd != null ? _contract.DefaultTestRunResultRcd : String.Empty;
                textBoxResult.Text = _contract.Result;
                dateTimePickerStartDateTime.Value = _contract.StartDateTime != DateTime.MinValue ? _contract.StartDateTime : dateTimePickerStartDateTime.MinDate;
                dateTimePickerStartDateTime.Checked = _contract.StartDateTime != DateTime.MinValue;
                dateTimePickerEndDateTime.Value = _contract.EndDateTime != DateTime.MinValue ? _contract.EndDateTime : dateTimePickerEndDateTime.MinDate;
                dateTimePickerEndDateTime.Checked = _contract.EndDateTime != DateTime.MinValue;
                maskedTextBoxElapsedMilliseconds.Text = _contract.ElapsedMilliseconds.ToString();
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

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
            var service = new CrudeDefaultTestRunServiceClient();
            try {
                _contract.DefaultTestRunResultRcd = defaultTestRunResultRefCombo.Text;
                _contract.Result = textBoxResult.Text;
                _contract.StartDateTime = dateTimePickerStartDateTime.Checked ? Convert.ToDateTime(dateTimePickerStartDateTime.Value): DateTime.MinValue;
                _contract.EndDateTime = dateTimePickerEndDateTime.Checked ? Convert.ToDateTime(dateTimePickerEndDateTime.Value): DateTime.MinValue;
                _contract.ElapsedMilliseconds = maskedTextBoxElapsedMilliseconds.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxElapsedMilliseconds.Text);
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;

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
