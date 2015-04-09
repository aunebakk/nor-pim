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
    
    
    public partial class CrudeProductExposeSetTypeRefEdit : Form {
        
        private CrudeProductExposeSetTypeRefContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductExposeSetTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductExposeSetTypeRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductExposeSetTypeRefContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(string productExposeSetTypeRcd) {
            var service = new CrudeProductExposeSetTypeRefService();
            isNew = false;
            try {
                _contract = service.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd;
                textBoxProductExposeSetTypeName.Text = _contract.ProductExposeSetTypeName;
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
            CrudeProductExposeSetTypeRefService service = new CrudeProductExposeSetTypeRefService();
            try {
                _contract.ProductExposeSetTypeRcd = (productExposeSetTypeRefCombo.Text);
                _contract.ProductExposeSetTypeName = (textBoxProductExposeSetTypeName.Text);
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
