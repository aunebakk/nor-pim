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
    
    
    public partial class CrudeProductGatherAttributeEdit : Form {
        
        private CrudeProductGatherAttributeContract _contract;
        
        private Boolean isNew;
        
        private Guid _productGatherKeyId;
        
        private Guid _userId;
        
        public CrudeProductGatherAttributeEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductGatherAttributeContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productGatherKeyId, Guid userId) {
            _contract = new CrudeProductGatherAttributeContract();
            isNew = true;
            _productGatherKeyId = productGatherKeyId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productGatherAttributeId) {
            var service = new CrudeProductGatherAttributeService();
            isNew = false;
            try {
                _contract = service.FetchByProductGatherAttributeId(productGatherAttributeId);
                textBoxProductGatherAttributeValue.Text = _contract.ProductGatherAttributeValue;
                productGatherAttributeTypeRefCombo.Text = _contract.ProductGatherAttributeTypeRcd;
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
            CrudeProductGatherAttributeService service = new CrudeProductGatherAttributeService();
            try {
                _contract.ProductGatherAttributeValue = (textBoxProductGatherAttributeValue.Text);
                _contract.ProductGatherAttributeTypeRcd = (productGatherAttributeTypeRefCombo.Text);
                _contract.ProductGatherKeyId = _productGatherKeyId;
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
