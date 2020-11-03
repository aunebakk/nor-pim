/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:47:58 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeDefaultUserSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _defaultStateRcd;
        
        private System.Guid _createdByDefaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultUserSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultUser();
            this.AcceptButton = buttonCrudeDefaultUserSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string defaultStateRcd, System.Guid createdByDefaultUserId) {
            try {
                _defaultStateRcd = defaultStateRcd;
                _createdByDefaultUserId = createdByDefaultUserId;

                RefreshCrudeDefaultUser();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultUserEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultUser.CurrentRow.Cells["DefaultUserId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultUserAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAdd();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeDefaultUser_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultUser.CurrentRow.Cells["DefaultUserId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultUserSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultUser();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
        public void RefreshCrudeDefaultUser() {
            var defaultUser = new CrudeDefaultUserServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultUser.FetchWithFilter(
                             Guid.Empty
                            ,textBoxDefaultUserCode.Text
                            ,textBoxDefaultUserName.Text
                            ,textBoxEmail.Text
                            ,textBoxPassword.Text
                            ,defaultStateRefCombo.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            ,dateTimePickerLastActivityDateTime.Checked ? Convert.ToDateTime(dateTimePickerLastActivityDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultUser.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultUser.DataSource = bindingSource;
                dataGridViewCrudeDefaultUser.AutoResizeColumns();
                dataGridViewCrudeDefaultUser.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultUser.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultUser() {
            try {
                dataGridViewCrudeDefaultUser.Columns.Clear();
                dataGridViewCrudeDefaultUser.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultUser.Columns.Add("DefaultUserName","Default User Name");
                dataGridViewCrudeDefaultUser.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
                dataGridViewCrudeDefaultUser.Columns.Add("DefaultUserCode","Default User Code");
                dataGridViewCrudeDefaultUser.Columns["DefaultUserCode"].DataPropertyName = "DefaultUserCode";
                dataGridViewCrudeDefaultUser.Columns.Add("Email","Email");
                dataGridViewCrudeDefaultUser.Columns["Email"].DataPropertyName = "Email";
                dataGridViewCrudeDefaultUser.Columns.Add("Password","Password");
                dataGridViewCrudeDefaultUser.Columns["Password"].DataPropertyName = "Password";
                dataGridViewCrudeDefaultUser.Columns.Add("DefaultStateRcd","Default State");
                dataGridViewCrudeDefaultUser.Columns["DefaultStateRcd"].DataPropertyName = "DefaultStateRcd";
                dataGridViewCrudeDefaultUser.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultUser.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultUser.Columns.Add("LastActivityDateTime","Last Activity Date Time");
                dataGridViewCrudeDefaultUser.Columns["LastActivityDateTime"].DataPropertyName = "LastActivityDateTime";
                dataGridViewCrudeDefaultUser.Columns.Add("CreatedByDefaultUserId","Created By Default User");
                dataGridViewCrudeDefaultUser.Columns["CreatedByDefaultUserId"].DataPropertyName = "CreatedByDefaultUserId";
                dataGridViewCrudeDefaultUser.Columns["CreatedByDefaultUserId"].Visible = false;
                dataGridViewCrudeDefaultUser.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultUser.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultUser.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
