/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:45:54 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultTestRunResultRefEdit : Form {
        
        private CrudeDefaultTestRunResultRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultTestRunResultRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultTestRunResultRefContract();
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
        
        public void ShowAsAdd(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId) {
            try {
                _contract = new CrudeDefaultTestRunResultRefContract();
                _isNew = true;
                _contract.DefaultTestRunResultRcd = defaultTestRunResultRcd;
                textBoxDefaultTestRunResult.Text = _contract.DefaultTestRunResultRcd;
                _contract.DefaultTestRunResultName = defaultTestRunResultName;
                textBoxDefaultTestRunResultName.Text = _contract.DefaultTestRunResultName;
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
        
        public void ShowAsEdit(string defaultTestRunResultRcd) {
            var service = new CrudeDefaultTestRunResultRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);
                textBoxDefaultTestRunResult.Text = _contract.DefaultTestRunResultRcd;
                textBoxDefaultTestRunResultName.Text = _contract.DefaultTestRunResultName;
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
            var service = new CrudeDefaultTestRunResultRefServiceClient();
            try {
                _contract.DefaultTestRunResultRcd = textBoxDefaultTestRunResult.Text;
                _contract.DefaultTestRunResultName = textBoxDefaultTestRunResultName.Text;

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
