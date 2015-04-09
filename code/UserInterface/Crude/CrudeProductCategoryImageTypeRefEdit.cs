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
    
    
    public partial class CrudeProductCategoryImageTypeRefEdit : Form {
        
        private CrudeProductCategoryImageTypeRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductCategoryImageTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductCategoryImageTypeRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductCategoryImageTypeRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string productCategoryImageTypeRcd) {
            var service = new CrudeProductCategoryImageTypeRefService();
            isNew = false;
            try {
                _contract = service.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
                productCategoryImageTypeRefCombo.Text = _contract.ProductCategoryImageTypeRcd;
                textBoxProductCategoryImageTypeName.Text = _contract.ProductCategoryImageTypeName;
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
            CrudeProductCategoryImageTypeRefService service = new CrudeProductCategoryImageTypeRefService();
            try {
                _contract.ProductCategoryImageTypeRcd = (productCategoryImageTypeRefCombo.Text);
                _contract.ProductCategoryImageTypeName = (textBoxProductCategoryImageTypeName.Text);
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
