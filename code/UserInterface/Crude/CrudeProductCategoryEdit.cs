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
    
    
    public partial class CrudeProductCategoryEdit : Form {
        
        private CrudeProductCategoryContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductCategoryEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductCategoryContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductCategoryContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productCategoryId) {
            var service = new CrudeProductCategoryService();
            isNew = false;
            try {
                _contract = service.FetchByProductCategoryId(productCategoryId);
                textBoxProductCategoryCode.Text = _contract.ProductCategoryCode;
                textBoxProductCategoryName.Text = _contract.ProductCategoryName;
                maskedTextBoxProductCategoryPosition.Text = _contract.ProductCategoryPosition.ToString();
                stateRefCombo.Text = _contract.StateRcd;
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
            CrudeProductCategoryService service = new CrudeProductCategoryService();
            try {
                _contract.ProductCategoryCode = (textBoxProductCategoryCode.Text);
                _contract.ProductCategoryName = (textBoxProductCategoryName.Text);
                _contract.ProductCategoryPosition = Convert.ToInt32(maskedTextBoxProductCategoryPosition.Text);
                _contract.StateRcd = (stateRefCombo.Text);
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
