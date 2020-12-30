/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:04:18 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/d8f07424-3438-4ff9-8853-3976c1227bad
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/9dd1c3bf-68b5-40b4-868a-735ee7394422
    public partial class CrudeDefaultUserSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _defaultStateRcd;
        
        private System.Guid _createdByDefaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeDefaultUserSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultUser();
            this.AcceptButton = buttonCrudeDefaultUserSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/c778f8fe-1b09-4755-891f-f9d3126d1b85
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/499f894b-7c95-446b-be0a-57fd47b768e3
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9e26c97-bd6d-404a-80ad-d252a24c6fe8
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/4c1fe3ad-84a0-4295-bd83-73d9e9afe750
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/6b990ce5-1c34-4759-bffd-659ae312004d
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/a90065e7-8ace-4de7-9367-d4653a7c637f
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
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
