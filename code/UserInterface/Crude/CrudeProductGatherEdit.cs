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
    
    
    public partial class CrudeProductGatherEdit : Form {
        
        private CrudeProductGatherContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductGatherEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductGatherContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductGatherContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productGatherId) {
            var service = new CrudeProductGatherService();
            isNew = false;
            try {
                _contract = service.FetchByProductGatherId(productGatherId);
                dateTimePickerStartDateTime.Text = _contract.StartDateTime.ToLongDateString();
                dateTimePickerFinishDateTime.Text = _contract.FinishDateTime.ToLongDateString();
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
            CrudeProductGatherService service = new CrudeProductGatherService();
            try {
                _contract.StartDateTime = Convert.ToDateTime(dateTimePickerStartDateTime.Value);
                _contract.FinishDateTime = Convert.ToDateTime(dateTimePickerFinishDateTime.Value);
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
