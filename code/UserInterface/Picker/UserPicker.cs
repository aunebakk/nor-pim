using System;
using System.ComponentModel;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class UserPicker : UserControl {
        
        private System.Guid _userId;
        
        public UserPicker() {
           InitializeComponent();
        }
        
        public System.Guid SelectedValue {
            get {
                return _userId;
            }
            set {
                if (!DesignMode) {
                    _userId = value;
                    var user = new CrudeUserService();
                    try {
                        CrudeUserContract contract = user.FetchByUserId(_userId);
                        if (contract != null) {
                            txtUserName.Text = contract.UserName;
                            txtUserCode.Text = contract.UserCode;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        if (user != null) user.Close();
                    }
                };
            }
        }
        
        private void txtUserCode_Validating(object sender, CancelEventArgs e) {
            if (!DesignMode) {
                // empty picker on no code
                if (txtUserCode.Text == String.Empty) {
                    _userId = Guid.Empty;
                    txtUserName.Text = string.Empty;
                    txtUserCode.Text = string.Empty;
                    return;
                }

                CrudeUserService user = null;

                try {
                    user = new CrudeUserService();
                    CrudeUserContract contract = user.FetchByUserCode(txtUserCode.Text);

                    if (contract != null) {
                        txtUserCode.Text = contract.UserCode;
                        txtUserName.Text = contract.UserName;
                        _userId = contract.UserId;
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (user != null) user.Close();
                }
            }
        }
    }
}
