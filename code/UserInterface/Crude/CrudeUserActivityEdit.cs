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
    
    
    public partial class CrudeUserActivityEdit : Form {
        
        private CrudeUserActivityContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeUserActivityEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeUserActivityContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeUserActivityContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid userActivityId) {
            var service = new CrudeUserActivityService();
            isNew = false;
            try {
                _contract = service.FetchByUserActivityId(userActivityId);
                userActivityTypeRefCombo.Text = _contract.UserActivityTypeRcd;
                textBoxUserActivityNote.Text = _contract.UserActivityNote;
                userPicker.SelectedValue = _contract.UserId;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                textBoxOriginatingAddress.Text = _contract.OriginatingAddress;
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeUserActivityService service = new CrudeUserActivityService();
            try {
                _contract.UserActivityTypeRcd = (userActivityTypeRefCombo.Text);
                _contract.UserActivityNote = (textBoxUserActivityNote.Text);
                _contract.UserId = (Guid)(userPicker.SelectedValue);
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);
                _contract.OriginatingAddress = (textBoxOriginatingAddress.Text);
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
