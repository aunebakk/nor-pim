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
    
    
    public partial class CrudeProductCategoryDocumentationEdit : Form {
        
        private CrudeProductCategoryDocumentationContract _contract;
        
        private Boolean isNew;
        
        private Guid _productCategoryId;
        
        private Guid _userId;
        
        public CrudeProductCategoryDocumentationEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductCategoryDocumentationContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productCategoryId, Guid userId) {
            _contract = new CrudeProductCategoryDocumentationContract();
            isNew = true;
            _productCategoryId = productCategoryId;
            productCategoryPicker.SelectedValue = productCategoryId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productCategoryDocumentationId) {
            var service = new CrudeProductCategoryDocumentationService();
            isNew = false;
            try {
                _contract = service.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd;
                productCategoryPicker.SelectedValue = _contract.ProductCategoryId;
                textBoxDocumentation.Text = _contract.Documentation;
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
            CrudeProductCategoryDocumentationService service = new CrudeProductCategoryDocumentationService();
            try {
                _contract.ProductCategoryDocumentationTypeRcd = (productCategoryDocumentationTypeRefCombo.Text);
                _contract.ProductCategoryId = (Guid)(productCategoryPicker.SelectedValue);
                _contract.Documentation = (textBoxDocumentation.Text);
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
