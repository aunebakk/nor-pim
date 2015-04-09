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
    
    
    public partial class CrudeProductGatherAttributeTypeRefEdit : Form {
        
        private CrudeProductGatherAttributeTypeRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductGatherAttributeTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductGatherAttributeTypeRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductGatherAttributeTypeRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string productGatherAttributeTypeRcd) {
            var service = new CrudeProductGatherAttributeTypeRefService();
            isNew = false;
            try {
                _contract = service.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
                productGatherAttributeTypeRefCombo.Text = _contract.ProductGatherAttributeTypeRcd;
                textBoxProductGatherAttributeTypeName.Text = _contract.ProductGatherAttributeTypeName;
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
            CrudeProductGatherAttributeTypeRefService service = new CrudeProductGatherAttributeTypeRefService();
            try {
                _contract.ProductGatherAttributeTypeRcd = (productGatherAttributeTypeRefCombo.Text);
                _contract.ProductGatherAttributeTypeName = (textBoxProductGatherAttributeTypeName.Text);
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
