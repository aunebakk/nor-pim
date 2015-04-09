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
    
    
    public partial class CrudeProductAttributeEdit : Form {
        
        private CrudeProductAttributeContract _contract;
        
        private Boolean isNew;
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductAttributeEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductAttributeContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productId, Guid userId) {
            _contract = new CrudeProductAttributeContract();
            isNew = true;
            _productId = productId;
            productPicker.SelectedValue = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productAttributeId) {
            var service = new CrudeProductAttributeService();
            isNew = false;
            try {
                _contract = service.FetchByProductAttributeId(productAttributeId);
                productPicker.SelectedValue = _contract.ProductId;
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd;
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd;
                textBoxValue.Text = _contract.Value;
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
            CrudeProductAttributeService service = new CrudeProductAttributeService();
            try {
                _contract.ProductId = (Guid)(productPicker.SelectedValue);
                _contract.ProductAttributeRcd = (productAttributeRefCombo.Text);
                _contract.ProductAttributeUnitRcd = (productAttributeUnitRefCombo.Text);
                _contract.Value = (textBoxValue.Text);
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
