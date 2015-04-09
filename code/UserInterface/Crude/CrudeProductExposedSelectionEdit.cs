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
    
    
    public partial class CrudeProductExposedSelectionEdit : Form {
        
        private CrudeProductExposedSelectionContract _contract;
        
        private Boolean isNew;
        
        private Guid _productExposeId;
        
        private Guid _userId;
        
        public CrudeProductExposedSelectionEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductExposedSelectionContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productExposeId, Guid userId) {
            _contract = new CrudeProductExposedSelectionContract();
            isNew = true;
            _productExposeId = productExposeId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productExposedSelectionId) {
            var service = new CrudeProductExposedSelectionService();
            isNew = false;
            try {
                _contract = service.FetchByProductExposedSelectionId(productExposedSelectionId);
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
            CrudeProductExposedSelectionService service = new CrudeProductExposedSelectionService();
            try {
                _contract.ProductExposeId = _productExposeId;
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
