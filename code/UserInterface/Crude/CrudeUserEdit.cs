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
    
    
    public partial class CrudeUserEdit : Form {
        
        private CrudeUserContract _contract;
        
        private Boolean isNew;
        
        public CrudeUserEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeUserContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsEdit(System.Guid userId) {
            var service = new CrudeUserService();
            isNew = false;
            try {
                _contract = service.FetchByUserId(userId);
                textBoxUserCode.Text = _contract.UserCode;
                textBoxUserName.Text = _contract.UserName;
                textBoxEmail.Text = _contract.Email;
                textBoxPassword.Text = _contract.Password;
                stateRefCombo.Text = _contract.StateRcd;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeUserService service = new CrudeUserService();
            try {
                _contract.UserCode = (textBoxUserCode.Text);
                _contract.UserName = (textBoxUserName.Text);
                _contract.Email = (textBoxEmail.Text);
                _contract.Password = (textBoxPassword.Text);
                _contract.StateRcd = (stateRefCombo.Text);
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);
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
