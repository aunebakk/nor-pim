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

    public partial class CrudeDefaultRuleEdit : Form {
        
        private CrudeDefaultRuleContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultRuleEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultRuleContract();
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
                _contract = new CrudeDefaultRuleContract();
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
        
        public void ShowAsAddByDefaultRuleType(string defaultRuleTypeRcd) {
            try {
                _contract = new CrudeDefaultRuleContract();
                _isNew = true;
                _contract.DefaultRuleTypeRcd = defaultRuleTypeRcd;
                defaultRuleTypeRefCombo.Text = _contract.DefaultRuleTypeRcd != null ? _contract.DefaultRuleTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string defaultRuleTypeRcd, string address, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultRuleContract();
                _isNew = true;
                _contract.DefaultRuleTypeRcd = defaultRuleTypeRcd;
                defaultRuleTypeRefCombo.Text = _contract.DefaultRuleTypeRcd != null ? _contract.DefaultRuleTypeRcd : String.Empty;
                _contract.Address = address;
                textBoxAddress.Text = _contract.Address;
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
        
        public void ShowAsEdit(System.Guid defaultRuleId, System.Guid defaultUserId) {
            var service = new CrudeDefaultRuleServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultRuleId(defaultRuleId);
                defaultRuleTypeRefCombo.Text = _contract.DefaultRuleTypeRcd != null ? _contract.DefaultRuleTypeRcd : String.Empty;
                textBoxAddress.Text = _contract.Address;
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
            var service = new CrudeDefaultRuleServiceClient();
            try {
                _contract.DefaultRuleTypeRcd = defaultRuleTypeRefCombo.Text;
                _contract.Address = textBoxAddress.Text;
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
