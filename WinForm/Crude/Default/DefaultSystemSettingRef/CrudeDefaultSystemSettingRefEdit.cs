/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:56:38 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemSettingRefEdit : Form {
        
        private CrudeDefaultSystemSettingRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultSystemSettingRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultSystemSettingRefContract();
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
                _contract = new CrudeDefaultSystemSettingRefContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;
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
        
        public void ShowAsAdd(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultSystemSettingRefContract();
                _isNew = true;
                _contract.DefaultSystemSettingRcd = defaultSystemSettingRcd;
                textBoxDefaultSystemSetting.Text = _contract.DefaultSystemSettingRcd;
                _contract.DefaultSystemSettingName = defaultSystemSettingName;
                textBoxDefaultSystemSettingName.Text = _contract.DefaultSystemSettingName;
                _contract.DefaultUserId = defaultUserId;
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
        
        public void ShowAsEdit(string defaultSystemSettingRcd, System.Guid defaultUserId) {
            var service = new CrudeDefaultSystemSettingRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);
                textBoxDefaultSystemSetting.Text = _contract.DefaultSystemSettingRcd;
                textBoxDefaultSystemSettingName.Text = _contract.DefaultSystemSettingName;
                _contract.DefaultUserId = defaultUserId;
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
            var service = new CrudeDefaultSystemSettingRefServiceClient();
            try {
                _contract.DefaultSystemSettingRcd = textBoxDefaultSystemSetting.Text;
                _contract.DefaultSystemSettingName = textBoxDefaultSystemSettingName.Text;

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
