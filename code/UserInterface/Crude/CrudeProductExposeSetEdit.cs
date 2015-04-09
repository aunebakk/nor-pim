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
    
    
    public partial class CrudeProductExposeSetEdit : Form {
        
        private CrudeProductExposeSetContract _contract;
        
        private Boolean isNew;
        
        private Guid _userId;
        
        public CrudeProductExposeSetEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductExposeSetContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid userId) {
            _contract = new CrudeProductExposeSetContract();
            isNew = true;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productExposeSetId) {
            var service = new CrudeProductExposeSetService();
            isNew = false;
            try {
                _contract = service.FetchByProductExposeSetId(productExposeSetId);
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd;
                textBoxProductExposeSetName.Text = _contract.ProductExposeSetName;
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
            CrudeProductExposeSetService service = new CrudeProductExposeSetService();
            try {
                _contract.ProductExposeSetTypeRcd = (productExposeSetTypeRefCombo.Text);
                _contract.ProductExposeSetName = (textBoxProductExposeSetName.Text);
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
