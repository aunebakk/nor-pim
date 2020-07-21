/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:47:25 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientNationalityRefEdit : Form {
        
        private CrudeClientNationalityRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientNationalityRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientNationalityRefContract();
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
                _contract = new CrudeClientNationalityRefContract();
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
        
        public void ShowAsAdd(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId) {
            try {
                _contract = new CrudeClientNationalityRefContract();
                _isNew = true;
                _contract.ClientNationalityRcd = clientNationalityRcd;
                textBoxClientNationality.Text = _contract.ClientNationalityRcd;
                _contract.ClientNationalityName = clientNationalityName;
                textBoxClientNationalityName.Text = _contract.ClientNationalityName;
                _contract.ClientNationalityDescription = clientNationalityDescription;
                textBoxClientNationalityDescription.Text = _contract.ClientNationalityDescription;
                _contract.ActiveFlag = activeFlag;
                checkBoxActiveFlag.Checked = _contract.ActiveFlag;
                _contract.SortOrder = sortOrder;
                maskedTextBoxSortOrder.Text = _contract.SortOrder.ToString();
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
        
        public void ShowAsEdit(string clientNationalityRcd, System.Guid userId) {
            var service = new CrudeClientNationalityRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientNationalityRcd(clientNationalityRcd);
                textBoxClientNationality.Text = _contract.ClientNationalityRcd;
                textBoxClientNationalityName.Text = _contract.ClientNationalityName;
                textBoxClientNationalityDescription.Text = _contract.ClientNationalityDescription;
                checkBoxActiveFlag.Checked = _contract.ActiveFlag;
                maskedTextBoxSortOrder.Text = _contract.SortOrder.ToString();
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
            var service = new CrudeClientNationalityRefServiceClient();
            try {
                _contract.ClientNationalityRcd = textBoxClientNationality.Text;
                _contract.ClientNationalityName = textBoxClientNationalityName.Text;
                _contract.ClientNationalityDescription = textBoxClientNationalityDescription.Text;
                _contract.ActiveFlag = Convert.ToBoolean(checkBoxActiveFlag.Checked);
                _contract.SortOrder = maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text);

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
