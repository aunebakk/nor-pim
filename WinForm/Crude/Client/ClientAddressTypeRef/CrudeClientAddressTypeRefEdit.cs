/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:07:05 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientAddressTypeRefEdit : Form {
        
        private CrudeClientAddressTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientAddressTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientAddressTypeRefContract();
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
                _contract = new CrudeClientAddressTypeRefContract();
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
        
        public void ShowAsAdd(string clientAddressTypeRcd, string clientAddressTypeName, string clientAddressTypeDescription, bool activeFlag, int sortOrder, System.Guid userId) {
            try {
                _contract = new CrudeClientAddressTypeRefContract();
                _isNew = true;
                _contract.ClientAddressTypeRcd = clientAddressTypeRcd;
                textBoxClientAddressType.Text = _contract.ClientAddressTypeRcd;
                _contract.ClientAddressTypeName = clientAddressTypeName;
                textBoxClientAddressTypeName.Text = _contract.ClientAddressTypeName;
                _contract.ClientAddressTypeDescription = clientAddressTypeDescription;
                textBoxClientAddressTypeDescription.Text = _contract.ClientAddressTypeDescription;
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
        
        public void ShowAsEdit(string clientAddressTypeRcd, System.Guid userId) {
            var service = new CrudeClientAddressTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientAddressTypeRcd(clientAddressTypeRcd);
                textBoxClientAddressType.Text = _contract.ClientAddressTypeRcd;
                textBoxClientAddressTypeName.Text = _contract.ClientAddressTypeName;
                textBoxClientAddressTypeDescription.Text = _contract.ClientAddressTypeDescription;
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
            var service = new CrudeClientAddressTypeRefServiceClient();
            try {
                _contract.ClientAddressTypeRcd = textBoxClientAddressType.Text;
                _contract.ClientAddressTypeName = textBoxClientAddressTypeName.Text;
                _contract.ClientAddressTypeDescription = textBoxClientAddressTypeDescription.Text;
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
