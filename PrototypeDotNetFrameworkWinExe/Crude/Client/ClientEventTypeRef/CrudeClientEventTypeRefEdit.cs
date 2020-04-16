/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:18 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientEventTypeRefEdit : Form {
        
        private CrudeClientEventTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientEventTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientEventTypeRefContract();
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
                _contract = new CrudeClientEventTypeRefContract();
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
        
        public void ShowAsAdd(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId) {
            try {
                _contract = new CrudeClientEventTypeRefContract();
                _isNew = true;
                _contract.ClientEventTypeRcd = clientEventTypeRcd;
                textBoxClientEventType.Text = _contract.ClientEventTypeRcd;
                _contract.ClientEventTypeName = clientEventTypeName;
                textBoxClientEventTypeName.Text = _contract.ClientEventTypeName;
                _contract.ClientEventTypeDescription = clientEventTypeDescription;
                textBoxClientEventTypeDescription.Text = _contract.ClientEventTypeDescription;
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
        
        public void ShowAsEdit(string clientEventTypeRcd, System.Guid userId) {
            var service = new CrudeClientEventTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientEventTypeRcd(clientEventTypeRcd);
                textBoxClientEventType.Text = _contract.ClientEventTypeRcd;
                textBoxClientEventTypeName.Text = _contract.ClientEventTypeName;
                textBoxClientEventTypeDescription.Text = _contract.ClientEventTypeDescription;
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
            var service = new CrudeClientEventTypeRefServiceClient();
            try {
                _contract.ClientEventTypeRcd = textBoxClientEventType.Text;
                _contract.ClientEventTypeName = textBoxClientEventTypeName.Text;
                _contract.ClientEventTypeDescription = textBoxClientEventTypeDescription.Text;
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
