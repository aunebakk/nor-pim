/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:41 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultSystemSettingEdit : Form {
        
        private CrudeDefaultSystemSettingContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultSystemSettingEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultSystemSettingContract();
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
                _contract = new CrudeDefaultSystemSettingContract();
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
        
        public void ShowAsAddByDefaultSystemSetting(string defaultSystemSettingRcd) {
            try {
                _contract = new CrudeDefaultSystemSettingContract();
                _isNew = true;
                _contract.DefaultSystemSettingRcd = defaultSystemSettingRcd;
                defaultSystemSettingRefCombo.Text = _contract.DefaultSystemSettingRcd != null ? _contract.DefaultSystemSettingRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultSystemSettingContract();
                _isNew = true;
                _contract.DefaultSystemSettingRcd = defaultSystemSettingRcd;
                defaultSystemSettingRefCombo.Text = _contract.DefaultSystemSettingRcd != null ? _contract.DefaultSystemSettingRcd : String.Empty;
                _contract.DefaultSystemSettingValue = defaultSystemSettingValue;
                textBoxDefaultSystemSettingValue.Text = _contract.DefaultSystemSettingValue;
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
        
        public void ShowAsEdit(System.Guid defaultSystemSettingId, System.Guid defaultUserId) {
            var service = new CrudeDefaultSystemSettingServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultSystemSettingId(defaultSystemSettingId);
                defaultSystemSettingRefCombo.Text = _contract.DefaultSystemSettingRcd != null ? _contract.DefaultSystemSettingRcd : String.Empty;
                textBoxDefaultSystemSettingValue.Text = _contract.DefaultSystemSettingValue;
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
            var service = new CrudeDefaultSystemSettingServiceClient();
            try {
                _contract.DefaultSystemSettingRcd = defaultSystemSettingRefCombo.Text;
                _contract.DefaultSystemSettingValue = textBoxDefaultSystemSettingValue.Text;
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
