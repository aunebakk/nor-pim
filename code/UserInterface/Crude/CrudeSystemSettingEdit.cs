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
    
    
    public partial class CrudeSystemSettingEdit : Form {
        
        private CrudeSystemSettingContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeSystemSettingEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeSystemSettingContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeSystemSettingContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid systemSettingId) {
            var service = new CrudeSystemSettingService();
            isNew = false;
            try {
                _contract = service.FetchBySystemSettingId(systemSettingId);
                systemSettingRefCombo.Text = _contract.SystemSettingRcd;
                textBoxSystemSettingValue.Text = _contract.SystemSettingValue;
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
            CrudeSystemSettingService service = new CrudeSystemSettingService();
            try {
                _contract.SystemSettingRcd = (systemSettingRefCombo.Text);
                _contract.SystemSettingValue = (textBoxSystemSettingValue.Text);
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
