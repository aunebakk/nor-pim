/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:16:35 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultPerformanceTimeRollupEdit : Form {
        
        private CrudeDefaultPerformanceTimeRollupContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultPerformanceTimeRollupEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultPerformanceTimeRollupContract();
                _isNew = true;
                this.Text += " - Not Savable (DefaultUser Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByRules(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultPerformanceTimeRollupContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultPerformanceTimeRollupContract();
                _isNew = true;
                _contract.CommandName = commandName;
                textBoxCommandName.Text = _contract.CommandName;
                _contract.Milliseconds = milliseconds;
                maskedTextBoxMilliseconds.Text = _contract.Milliseconds.ToString();
                _contract.Hits = hits;
                maskedTextBoxHits.Text = _contract.Hits.ToString();
                _contract.DefaultUserId = defaultUserId;
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
        
        public void ShowAsEdit(System.Guid defaultPerformanceTimeRollupId, System.Guid defaultUserId) {
            var service = new CrudeDefaultPerformanceTimeRollupServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultPerformanceTimeRollupId(defaultPerformanceTimeRollupId);
                textBoxCommandName.Text = _contract.CommandName;
                maskedTextBoxMilliseconds.Text = _contract.Milliseconds.ToString();
                maskedTextBoxHits.Text = _contract.Hits.ToString();
                _contract.DefaultUserId = defaultUserId;
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
            var service = new CrudeDefaultPerformanceTimeRollupServiceClient();
            try {
                _contract.CommandName = textBoxCommandName.Text;
                _contract.Milliseconds = maskedTextBoxMilliseconds.Text == String.Empty ? 0 : Convert.ToInt64(maskedTextBoxMilliseconds.Text);
                _contract.Hits = maskedTextBoxHits.Text == String.Empty ? 0 : Convert.ToInt64(maskedTextBoxHits.Text);
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
