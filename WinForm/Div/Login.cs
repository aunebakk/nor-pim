using System;
using System.Net;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;
using SolutionNorSolutionPim.ProxyLayer;

namespace SolutionNorSolutionPim.UserInterface
{
    partial class Login : Form
    {

        private Main _parent;

        public Login(Main parent) {
            InitializeComponent();
            Log(message: "login version 3");
            Log("diagnostics, system information local computer name : " + SystemInformation.ComputerName);
            Log("diagnostics, system information user domain name : " + SystemInformation.UserDomainName);
            Log("diagnostics, system information user name : " + SystemInformation.UserName);
            _parent = parent;

            textBoxUserName.Text = SystemInformation.ComputerName;

            // for development only
            Singleton.Instance.UserId = new Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            Log("diagnostics, instantiate");
            var diagnostics = new DiagnosticsServiceClient();

            try {
                Log("diagnostics, open");
                diagnostics.Open();
                Log("diagnostics, state: " + diagnostics.State);
                Log("diagnostics, endpoint binding: " + diagnostics.Endpoint.Address.ToString());
                Log("diagnostics, client credentials user name: " + diagnostics.ClientCredentials.UserName.UserName);
                Log("diagnostics, inner channel: " + diagnostics.InnerChannel.ToString());
                Log("diagnostics, system information local computer name : " + SystemInformation.ComputerName);
                Application.DoEvents();
                Log("diagnostics, ping test: " + diagnostics.PingTest().ToString());
                Application.DoEvents();
                Log("diagnostics, system information remote computer name : " + diagnostics.ComputerName());
                Application.DoEvents();
                Log("diagnostics, database: " + diagnostics.Database());
                Application.DoEvents();
                // log the login
                Log("login, add activity login");
                var activity = new DefaultUserActivityServiceClient();

                Application.DoEvents();

                Singleton.Instance.UserId = activity.Login(textBoxUserName.Text);

                activity.AddActivityAsync(
                    Singleton.Instance.UserId,
                    DefaultUserActivityTypeRef.Login,
                    textBoxUserName.Text,
                    Dns.GetHostName()
                    );

                Log("login, closing activity");
                activity.Close();
                //_parent.ShowUserInfo();

                Log("login, get system settings");
                Singleton.Instance.RefreshSystemSettings();
                Singleton.Instance.CheckForm(this);
                Singleton.Instance.CheckForm(this.MdiParent);

            } catch ( Exception ex ) {
                Log("exception: " + ex.Message);
                if ( ex.InnerException != null )
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

            try {
                //Application.DoEvents();
            } catch { }
        }

        private void Login_Shown(object sender, EventArgs e) {
            Application.DoEvents();
            buttonOK_Click(new object(), new EventArgs());
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            textBoxLog.Text = string.Empty;
        }
    }
}
