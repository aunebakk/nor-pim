using System;
using System.Deployment.Application;
using System.Reflection;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface
{
    partial class AboutBox : Form
    {
        public AboutBox() {
            InitializeComponent();
            //this.Text = String.Format("About {0}", AssemblyTitle);
            //this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            //this.labelCompanyName.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if ( attributes.Length > 0 ) {
                    AssemblyTitleAttribute titleAttribute = ( AssemblyTitleAttribute ) attributes[0];
                    if ( titleAttribute.Title != "" ) {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion {
            get {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if ( attributes.Length == 0 ) {
                    return "";
                }
                return ( ( AssemblyDescriptionAttribute ) attributes[0] ).Description;
            }
        }

        public string AssemblyProduct {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if ( attributes.Length == 0 ) {
                    return "";
                }
                return ( ( AssemblyProductAttribute ) attributes[0] ).Product;
            }
        }

        public string AssemblyCopyright {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if ( attributes.Length == 0 ) {
                    return "";
                }
                return ( ( AssemblyCopyrightAttribute ) attributes[0] ).Copyright;
            }
        }

        public string AssemblyCompany {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if ( attributes.Length == 0 ) {
                    return "";
                }
                return ( ( AssemblyCompanyAttribute ) attributes[0] ).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void AboutBox_Shown(object sender, EventArgs e) {
            if ( !System.Diagnostics.Debugger.IsAttached )
                labelVersion.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
            else
                labelVersion.Text = "Debugging";
        }

        private void AboutBox_Load(object sender, EventArgs e) {
            linkLabelNorPortWeb.Text = "http://localhost:41901/";
        }
    }
}
