/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:07:06 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultUserActivityEdit : Form {
        
        private CrudeDefaultUserActivityContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultUserActivityEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultUserActivityContract();
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
                _contract = new CrudeDefaultUserActivityContract();
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
        
        public void ShowAsAdd(string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultUserActivityContract();
                _isNew = true;
                _contract.DefaultUserActivityTypeRcd = defaultUserActivityTypeRcd;
                defaultUserActivityTypeRefCombo.Text = _contract.DefaultUserActivityTypeRcd != null ? _contract.DefaultUserActivityTypeRcd : String.Empty;
                _contract.UserActivityNote = userActivityNote;
                textBoxUserActivityNote.Text = _contract.UserActivityNote;
                _contract.OriginatingAddress = originatingAddress;
                textBoxOriginatingAddress.Text = _contract.OriginatingAddress;
                _contract.Referrer = referrer;
                textBoxReferrer.Text = _contract.Referrer;
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
        
        public void ShowAsEdit(System.Guid defaultUserActivityId, System.Guid defaultUserId) {
            var service = new CrudeDefaultUserActivityServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultUserActivityId(defaultUserActivityId);
                defaultUserActivityTypeRefCombo.Text = _contract.DefaultUserActivityTypeRcd != null ? _contract.DefaultUserActivityTypeRcd : String.Empty;
                textBoxUserActivityNote.Text = _contract.UserActivityNote;
                textBoxOriginatingAddress.Text = _contract.OriginatingAddress;
                textBoxReferrer.Text = _contract.Referrer;
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
            var service = new CrudeDefaultUserActivityServiceClient();
            try {
                _contract.DefaultUserActivityTypeRcd = defaultUserActivityTypeRefCombo.Text;
                _contract.UserActivityNote = textBoxUserActivityNote.Text;
                _contract.OriginatingAddress = textBoxOriginatingAddress.Text;
                _contract.Referrer = textBoxReferrer.Text;
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
