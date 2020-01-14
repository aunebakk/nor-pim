/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:19:31 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientIdentifierTypeRefEdit : Form {
        
        private CrudeClientIdentifierTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientIdentifierTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientIdentifierTypeRefContract();
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
                _contract = new CrudeClientIdentifierTypeRefContract();
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
        
        public void ShowAsAdd(string clientIdentifierTypeRcd, string clientIdentifierTypeName, string clientIdentifierTypeDescription, bool activeFlag, int sortOrder, System.Guid userId) {
            try {
                _contract = new CrudeClientIdentifierTypeRefContract();
                _isNew = true;
                _contract.ClientIdentifierTypeRcd = clientIdentifierTypeRcd;
                textBoxClientIdentifierType.Text = _contract.ClientIdentifierTypeRcd;
                _contract.ClientIdentifierTypeName = clientIdentifierTypeName;
                textBoxClientIdentifierTypeName.Text = _contract.ClientIdentifierTypeName;
                _contract.ClientIdentifierTypeDescription = clientIdentifierTypeDescription;
                textBoxClientIdentifierTypeDescription.Text = _contract.ClientIdentifierTypeDescription;
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
        
        public void ShowAsEdit(string clientIdentifierTypeRcd, System.Guid userId) {
            var service = new CrudeClientIdentifierTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd);
                textBoxClientIdentifierType.Text = _contract.ClientIdentifierTypeRcd;
                textBoxClientIdentifierTypeName.Text = _contract.ClientIdentifierTypeName;
                textBoxClientIdentifierTypeDescription.Text = _contract.ClientIdentifierTypeDescription;
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
            var service = new CrudeClientIdentifierTypeRefServiceClient();
            try {
                _contract.ClientIdentifierTypeRcd = textBoxClientIdentifierType.Text;
                _contract.ClientIdentifierTypeName = textBoxClientIdentifierTypeName.Text;
                _contract.ClientIdentifierTypeDescription = textBoxClientIdentifierTypeDescription.Text;
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
