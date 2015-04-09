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
    
    
    public partial class CrudeProductImageTypeRefEdit : Form {
        
        private CrudeProductImageTypeRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductImageTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductImageTypeRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductImageTypeRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string productImageTypeRcd) {
            var service = new CrudeProductImageTypeRefService();
            isNew = false;
            try {
                _contract = service.FetchByProductImageTypeRcd(productImageTypeRcd);
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd;
                textBoxProductImageTypeName.Text = _contract.ProductImageTypeName;
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
            CrudeProductImageTypeRefService service = new CrudeProductImageTypeRefService();
            try {
                _contract.ProductImageTypeRcd = (productImageTypeRefCombo.Text);
                _contract.ProductImageTypeName = (textBoxProductImageTypeName.Text);
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
