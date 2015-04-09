using norpim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace  norpim.UserInterface {
    partial class Login : Form {

        private Main _parent;

        public Login(Main parent) {
            InitializeComponent();
            Log("login version 3");
            Log("diagnostics, system information local computer name : " + SystemInformation.ComputerName);
            Log("diagnostics, system information user domain name : " + SystemInformation.UserDomainName);
            Log("diagnostics, system information user name : " + SystemInformation.UserName);
            _parent = parent;

            textBoxUserName.Text = SystemInformation.ComputerName;
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            Log("diagnostics, instantiate");
            var diagnostics = new norpim.BusinessLogicLayer.Other.DiagnosticsServiceClient();
            
            try {
                Log("diagnostics, open");
                diagnostics.Open();
                Log("diagnostics, state: " + diagnostics.State);
                Log("diagnostics, endpoint binding: " + diagnostics.Endpoint.Address.ToString());
                Log("diagnostics, client credentials user name: " + diagnostics.ClientCredentials.UserName.UserName);
                Log("diagnostics, inner channel: " + diagnostics.InnerChannel.ToString());
                Log("diagnostics, system information local computer name : " + SystemInformation.ComputerName);
                Log("diagnostics, ping test: " + diagnostics.PingTest().ToString());
                Log("diagnostics, system information remote computer name : " + diagnostics.ComputerName());
                Log("diagnostics, database: " + diagnostics.Database());
                
                // log the login
                Log("login, add activity login");
                var activity = new norpim.BusinessLogicLayer.Other.ActivityServiceClient();

                Singleton.Instance.UserId = activity.Login(textBoxUserName.Text);

                activity.AddActivity(   Singleton.Instance.UserId, 
                                        UserActivityTypeRef.Login, 
                                        textBoxUserName.Text
                                        );

                Log("login, closing activity");
                activity.Close();
                _parent.ShowUserInfo();

                Log("login, get system settings");
                Singleton.Instance.RefreshSystemSettings();
                Singleton.Instance.CheckForm(this);
                Singleton.Instance.CheckForm(this.MdiParent);

            } catch (Exception ex) {
                Log("exception: " + ex.Message);
                if (ex.InnerException != null)
                    Log("exception inner: " + ex.InnerException.Message);
            } finally {
                Log("login, closing diagnostics");
                diagnostics.Close();
                Log("login, closing login");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }

        public void Log(string message) {
            try { 
                textBoxLog.Text = DateTime.UtcNow + " - " + message + "\r\n" + textBoxLog.Text;
            } catch { }
            Application.DoEvents();
        }
    }
}
