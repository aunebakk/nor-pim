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
    
    
    public partial class CrudeProductDocumentationTypeRefEdit : Form {
        
        private CrudeProductDocumentationTypeRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductDocumentationTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductDocumentationTypeRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductDocumentationTypeRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string productDocumentationTypeRcd) {
            var service = new CrudeProductDocumentationTypeRefService();
            isNew = false;
            try {
                _contract = service.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
                productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd;
                textBoxProductDocumentationTypeName.Text = _contract.ProductDocumentationTypeName;
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
            CrudeProductDocumentationTypeRefService service = new CrudeProductDocumentationTypeRefService();
            try {
                _contract.ProductDocumentationTypeRcd = (productDocumentationTypeRefCombo.Text);
                _contract.ProductDocumentationTypeName = (textBoxProductDocumentationTypeName.Text);
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
