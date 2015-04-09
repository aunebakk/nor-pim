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
    
    
    public partial class CrudeProductGatherSourceEdit : Form {
        
        private CrudeProductGatherSourceContract _contract;
        
        private Boolean isNew;
        
        private Guid _productGatherId;
        
        private Guid _userId;
        
        public CrudeProductGatherSourceEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductGatherSourceContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productGatherId, Guid userId) {
            _contract = new CrudeProductGatherSourceContract();
            isNew = true;
            _productGatherId = productGatherId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productGatherSourceId) {
            var service = new CrudeProductGatherSourceService();
            isNew = false;
            try {
                _contract = service.FetchByProductGatherSourceId(productGatherSourceId);
                userPicker.SelectedValue = _contract.UserId;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                productGatherSourceTypeRefCombo.Text = _contract.ProductGatherSourceTypeRcd;
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeProductGatherSourceService service = new CrudeProductGatherSourceService();
            try {
                _contract.ProductGatherId = _productGatherId;
                _contract.UserId = (Guid)(userPicker.SelectedValue);
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);
                _contract.ProductGatherSourceTypeRcd = (productGatherSourceTypeRefCombo.Text);
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
