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
    
    
    public partial class CrudeStateRefEdit : Form {
        
        private CrudeStateRefContract _contract;
        
        private Boolean isNew;
        
        public CrudeStateRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeStateRefContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsEdit(string stateRcd) {
            var service = new CrudeStateRefService();
            isNew = false;
            try {
                _contract = service.FetchByStateRcd(stateRcd);
                stateRefCombo.Text = _contract.StateRcd;
                textBoxStateName.Text = _contract.StateName;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeStateRefService service = new CrudeStateRefService();
            try {
                _contract.StateRcd = (stateRefCombo.Text);
                _contract.StateName = (textBoxStateName.Text);
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
