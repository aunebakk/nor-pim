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
    
    
    public partial class CrudeProductChangeSetEdit : Form {
        
        private CrudeProductChangeSetContract _contract;
        
        private Boolean isNew;
        
        private Guid _productId;
        
        private Guid _productGatherKeyId;
        
        private Guid _userId;
        
        public CrudeProductChangeSetEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductChangeSetContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productId, Guid productGatherKeyId, Guid userId) {
            _contract = new CrudeProductChangeSetContract();
            isNew = true;
            _productId = productId;
            productPicker.SelectedValue = productId;
            _productGatherKeyId = productGatherKeyId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productChangeSetId) {
            var service = new CrudeProductChangeSetService();
            isNew = false;
            try {
                _contract = service.FetchByProductChangeSetId(productChangeSetId);
                productPicker.SelectedValue = _contract.ProductId;
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
            CrudeProductChangeSetService service = new CrudeProductChangeSetService();
            try {
                _contract.ProductId = (Guid)(productPicker.SelectedValue);
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
