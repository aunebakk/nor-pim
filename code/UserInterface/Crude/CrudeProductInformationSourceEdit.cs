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
    
    
    public partial class CrudeProductInformationSourceEdit : Form {
        
        private CrudeProductInformationSourceContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductInformationSourceEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductInformationSourceContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductInformationSourceContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productInformationSourceId) {
            var service = new CrudeProductInformationSourceService();
            isNew = false;
            try {
                _contract = service.FetchByProductInformationSourceId(productInformationSourceId);
                productInformationSourceTypeRefCombo.Text = _contract.ProductInformationSourceTypeRcd;
                textBoxProductInformationSource.Text = _contract.ProductInformationSource;
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
            CrudeProductInformationSourceService service = new CrudeProductInformationSourceService();
            try {
                _contract.ProductInformationSourceTypeRcd = (productInformationSourceTypeRefCombo.Text);
                _contract.ProductInformationSource = (textBoxProductInformationSource.Text);
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
