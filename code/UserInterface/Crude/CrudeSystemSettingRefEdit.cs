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
    
    
    public partial class CrudeSystemSettingRefEdit : Form {
        
        private CrudeSystemSettingRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeSystemSettingRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeSystemSettingRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeSystemSettingRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string systemSettingRcd) {
            var service = new CrudeSystemSettingRefService();
            isNew = false;
            try {
                _contract = service.FetchBySystemSettingRcd(systemSettingRcd);
                systemSettingRefCombo.Text = _contract.SystemSettingRcd;
                textBoxSystemSettingName.Text = _contract.SystemSettingName;
                userPicker.SelectedValue = _contract.UserId;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeSystemSettingRefService service = new CrudeSystemSettingRefService();
            try {
                _contract.SystemSettingRcd = (systemSettingRefCombo.Text);
                _contract.SystemSettingName = (textBoxSystemSettingName.Text);
                _contract.UserId = (Guid)(userPicker.SelectedValue);
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
