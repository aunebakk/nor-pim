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
    
    
    public partial class CrudeProductAttributeUnitRefEdit : Form {
        
        private CrudeProductAttributeUnitRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductAttributeUnitRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductAttributeUnitRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductAttributeUnitRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string productAttributeUnitRcd) {
            var service = new CrudeProductAttributeUnitRefService();
            isNew = false;
            try {
                _contract = service.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
                productAttributeUnitRefCombo.Text = _contract.ProductAttributeUnitRcd;
                textBoxProductAttributeUnitName.Text = _contract.ProductAttributeUnitName;
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
            CrudeProductAttributeUnitRefService service = new CrudeProductAttributeUnitRefService();
            try {
                _contract.ProductAttributeUnitRcd = (productAttributeUnitRefCombo.Text);
                _contract.ProductAttributeUnitName = (textBoxProductAttributeUnitName.Text);
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
