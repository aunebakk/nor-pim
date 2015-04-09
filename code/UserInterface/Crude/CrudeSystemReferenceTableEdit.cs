using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeSystemReferenceTableEdit : Form {
        
        private CrudeSystemReferenceTableContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeSystemReferenceTableEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeSystemReferenceTableContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeSystemReferenceTableContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid systemReferenceTableId) {
            var service = new CrudeSystemReferenceTableService();
            isNew = false;
            try {
                _contract = service.FetchBySystemReferenceTableId(systemReferenceTableId);
                textBoxSystemReferenceTableName.Text = _contract.SystemReferenceTableName;
                textBoxSystemReferenceDisplayName.Text = _contract.SystemReferenceDisplayName;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                userPicker.SelectedValue = _contract.UserId;
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeSystemReferenceTableService service = new CrudeSystemReferenceTableService();
            try {
                _contract.SystemReferenceTableName = (textBoxSystemReferenceTableName.Text);
                _contract.SystemReferenceDisplayName = (textBoxSystemReferenceDisplayName.Text);
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);
                _contract.UserId = (Guid)(userPicker.SelectedValue);
                if (isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
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
