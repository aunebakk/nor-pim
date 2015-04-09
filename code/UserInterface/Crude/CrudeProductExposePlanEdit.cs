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
    
    
    public partial class CrudeProductExposePlanEdit : Form {
        
        private CrudeProductExposePlanContract _contract;
        
        private Boolean isNew;
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductExposePlanEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductExposePlanContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productId, Guid userId) {
            _contract = new CrudeProductExposePlanContract();
            isNew = true;
            _productId = productId;
            productPicker.SelectedValue = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productExposePlanId) {
            var service = new CrudeProductExposePlanService();
            isNew = false;
            try {
                _contract = service.FetchByProductExposePlanId(productExposePlanId);
                productPicker.SelectedValue = _contract.ProductId;
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd;
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
            CrudeProductExposePlanService service = new CrudeProductExposePlanService();
            try {
                _contract.ProductId = (Guid)(productPicker.SelectedValue);
                _contract.ProductExposeSetTypeRcd = (productExposeSetTypeRefCombo.Text);
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
