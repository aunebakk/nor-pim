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
    
    
    public partial class CrudeProductCategoryDocumentationTypeRefEdit : Form {
        
        private CrudeProductCategoryDocumentationTypeRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductCategoryDocumentationTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductCategoryDocumentationTypeRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductCategoryDocumentationTypeRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string productCategoryDocumentationTypeRcd) {
            var service = new CrudeProductCategoryDocumentationTypeRefService();
            isNew = false;
            try {
                _contract = service.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd;
                textBoxProductCategoryDocumentationTypeName.Text = _contract.ProductCategoryDocumentationTypeName;
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
            CrudeProductCategoryDocumentationTypeRefService service = new CrudeProductCategoryDocumentationTypeRefService();
            try {
                _contract.ProductCategoryDocumentationTypeRcd = (productCategoryDocumentationTypeRefCombo.Text);
                _contract.ProductCategoryDocumentationTypeName = (textBoxProductCategoryDocumentationTypeName.Text);
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
