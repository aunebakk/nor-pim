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
    
    
    public partial class CrudeProductDocumentationEdit : Form {
        
        private CrudeProductDocumentationContract _contract;
        
        private Boolean isNew;
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductDocumentationEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductDocumentationContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productId, Guid userId) {
            _contract = new CrudeProductDocumentationContract();
            isNew = true;
            _productId = productId;
            productPicker.SelectedValue = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productDocumentationId) {
            var service = new CrudeProductDocumentationService();
            isNew = false;
            try {
                _contract = service.FetchByProductDocumentationId(productDocumentationId);
                productPicker.SelectedValue = _contract.ProductId;
                productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd;
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
            CrudeProductDocumentationService service = new CrudeProductDocumentationService();
            try {
                _contract.ProductId = (Guid)(productPicker.SelectedValue);
                _contract.ProductDocumentationTypeRcd = (productDocumentationTypeRefCombo.Text);
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
