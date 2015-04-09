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
    
    
    public partial class CrudeProductGatherSourceTypeRefEdit : Form {
        
        private CrudeProductGatherSourceTypeRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductGatherSourceTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductGatherSourceTypeRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductGatherSourceTypeRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string productGatherSourceTypeRcd) {
            var service = new CrudeProductGatherSourceTypeRefService();
            isNew = false;
            try {
                _contract = service.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
                productGatherSourceTypeRefCombo.Text = _contract.ProductGatherSourceTypeRcd;
                textBoxProductGatherSourceTypeName.Text = _contract.ProductGatherSourceTypeName;
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
            CrudeProductGatherSourceTypeRefService service = new CrudeProductGatherSourceTypeRefService();
            try {
                _contract.ProductGatherSourceTypeRcd = (productGatherSourceTypeRefCombo.Text);
                _contract.ProductGatherSourceTypeName = (textBoxProductGatherSourceTypeName.Text);
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
