/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:26:06 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemReferenceTableEdit : Form {
        
        private CrudeDefaultSystemReferenceTableContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultSystemReferenceTableEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultSystemReferenceTableContract();
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
                _contract = new CrudeDefaultSystemReferenceTableContract();
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
        
        public void ShowAsAdd(string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultSystemReferenceTableContract();
                _isNew = true;
                _contract.DefaultSystemReferenceTableName = defaultSystemReferenceTableName;
                textBoxDefaultSystemReferenceTableName.Text = _contract.DefaultSystemReferenceTableName;
                _contract.DefaultSystemReferenceDisplayName = defaultSystemReferenceDisplayName;
                textBoxDefaultSystemReferenceDisplayName.Text = _contract.DefaultSystemReferenceDisplayName;
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
        
        public void ShowAsEdit(System.Guid defaultSystemReferenceTableId, System.Guid defaultUserId) {
            var service = new CrudeDefaultSystemReferenceTableServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);
                textBoxDefaultSystemReferenceTableName.Text = _contract.DefaultSystemReferenceTableName;
                textBoxDefaultSystemReferenceDisplayName.Text = _contract.DefaultSystemReferenceDisplayName;
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
            var service = new CrudeDefaultSystemReferenceTableServiceClient();
            try {
                _contract.DefaultSystemReferenceTableName = textBoxDefaultSystemReferenceTableName.Text;
                _contract.DefaultSystemReferenceDisplayName = textBoxDefaultSystemReferenceDisplayName.Text;
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
