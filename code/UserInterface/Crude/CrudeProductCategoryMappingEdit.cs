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
    
    
    public partial class CrudeProductCategoryMappingEdit : Form {
        
        private CrudeProductCategoryMappingContract _contract;
        
        private Boolean isNew;
        
        private Guid _productCategoryId;
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductCategoryMappingEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductCategoryMappingContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productCategoryId, Guid productId, Guid userId) {
            _contract = new CrudeProductCategoryMappingContract();
            isNew = true;
            _productCategoryId = productCategoryId;
            productCategoryPicker.SelectedValue = productCategoryId;
            _productId = productId;
            productPicker.SelectedValue = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productCategoryMappingId) {
            var service = new CrudeProductCategoryMappingService();
            isNew = false;
            try {
                _contract = service.FetchByProductCategoryMappingId(productCategoryMappingId);
                productCategoryPicker.SelectedValue = _contract.ProductCategoryId;
                productPicker.SelectedValue = _contract.ProductId;
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
            CrudeProductCategoryMappingService service = new CrudeProductCategoryMappingService();
            try {
                _contract.ProductCategoryId = (Guid)(productCategoryPicker.SelectedValue);
                _contract.ProductId = (Guid)(productPicker.SelectedValue);
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
