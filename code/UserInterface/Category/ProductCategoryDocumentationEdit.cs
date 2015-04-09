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
    
    
    public partial class ProductCategoryDocumentationEdit : Form {
        
        private CrudeProductCategoryDocumentationContract _contract;
        private Guid _userId;
        
        public ProductCategoryDocumentationEdit() {
           InitializeComponent();
           this.AcceptButton = btnSave;
           this.CancelButton = btnClose;

        }

        public void ShowAsAdd(Guid productCategoryId,
                              Guid userId
                              ) {
            _contract = new CrudeProductCategoryDocumentationContract();
            _contract.ProductCategoryId = productCategoryId;                    
            _contract.UserId = _userId;
            _userId = userId;
            Show();
        }
        
        public void ShowAsEdit( System.Guid productCategoryDocumentationId,
                                Guid userId
                                ) {
            var service = new CrudeProductCategoryDocumentationService();
            try {
                _contract = service.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd;
                textBoxDocumentation.Text = _contract.Documentation;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                _userId = userId;
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            CrudeProductCategoryDocumentationService service = new CrudeProductCategoryDocumentationService();
            try {
                _contract.ProductCategoryDocumentationTypeRcd = (productCategoryDocumentationTypeRefCombo.Text);
                _contract.Documentation = (textBoxDocumentation.Text);
                _contract.UserId = _userId;
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);

                if (_contract.ProductCategoryDocumentationId == Guid.Empty)
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
        
        public void ShowAsAdd() {
            Show();
        }
                
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
