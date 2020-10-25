using System;
using System.ComponentModel;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface
{


    public partial class DefaultUserPicker : UserControl
    {

        private System.Guid _defaultUserId;

        public DefaultUserPicker() {
            InitializeComponent();
        }

        public System.Guid SelectedValue {
            get {
                return _defaultUserId;
            }
            set {
                if ( !DesignMode ) {
                    _defaultUserId = value;
                    var defaultUser = new CrudeDefaultUserServiceClient();
                    try {
                        CrudeDefaultUserContract contract = defaultUser.FetchByDefaultUserId(_defaultUserId);

                        if ( contract != null ) {
                            txtDefaultUserName.Text = contract.DefaultUserName;
                            txtDefaultUserCode.Text = contract.DefaultUserCode;
                        }
                    } catch ( Exception ex ) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        if ( defaultUser != null )
                            defaultUser.Close();
                    }
                };
            }
        }

        public event EventHandler Picked;

        private void txtDefaultUserCode_Validating(object sender, CancelEventArgs e) {
            if ( !DesignMode ) {
                // empty picker on no code
                if ( string.IsNullOrEmpty(txtDefaultUserCode.Text) ) {
                    _defaultUserId = Guid.Empty;
                    txtDefaultUserName.Text = string.Empty;
                    txtDefaultUserCode.Text = string.Empty;
                    return;
                }

                CrudeDefaultUserServiceClient defaultUser = null;

                try {
                    defaultUser = new CrudeDefaultUserServiceClient();
                    CrudeDefaultUserContract contract = defaultUser.FetchByDefaultUserName(txtDefaultUserCode.Text);

                    if ( contract != null ) {
                        txtDefaultUserCode.Text = contract.DefaultUserCode;
                        txtDefaultUserName.Text = contract.DefaultUserName;
                        _defaultUserId = contract.DefaultUserId;
                    }
                } catch ( Exception ex ) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if ( defaultUser != null )
                        defaultUser.Close();
                }

                if ( this.Picked != null )
                    this.Picked(new object(), new EventArgs());
            }
        }
    }
}
