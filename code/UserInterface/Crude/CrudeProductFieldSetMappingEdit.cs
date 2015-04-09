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
    
    
    public partial class CrudeProductFieldSetMappingEdit : Form {
        
        private CrudeProductFieldSetMappingContract _contract;
        
        private Boolean isNew;
        
        private Guid _productFieldSetId;
        
        private Guid _userId;
        
        public CrudeProductFieldSetMappingEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductFieldSetMappingContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productFieldSetId, Guid userId) {
            _contract = new CrudeProductFieldSetMappingContract();
            isNew = true;
            _productFieldSetId = productFieldSetId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productFieldSetMappingId) {
            var service = new CrudeProductFieldSetMappingService();
            isNew = false;
            try {
                _contract = service.FetchByProductFieldSetMappingId(productFieldSetMappingId);
                productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd;
                productAttributeRefCombo.Text = _contract.ProductAttributeRcd;
                productInfoRefCombo.Text = _contract.ProductInfoRcd;
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd;
                productDocumentationTypeRefCombo.Text = _contract.ProductDocumentationTypeRcd;
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
            CrudeProductFieldSetMappingService service = new CrudeProductFieldSetMappingService();
            try {
                _contract.ProductFieldSetId = _productFieldSetId;
                _contract.ProductIdentifierRcd = (productIdentifierRefCombo.Text);
                _contract.ProductAttributeRcd = (productAttributeRefCombo.Text);
                _contract.ProductInfoRcd = (productInfoRefCombo.Text);
                _contract.ProductImageTypeRcd = (productImageTypeRefCombo.Text);
                _contract.ProductDocumentationTypeRcd = (productDocumentationTypeRefCombo.Text);
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
