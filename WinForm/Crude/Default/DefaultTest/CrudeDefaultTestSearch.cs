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
    public partial class CrudeDefaultTestSearch : Form {
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeDefaultTestSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultTest();
            this.AcceptButton = buttonCrudeDefaultTestSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public new void Show() {
            try {

                RefreshCrudeDefaultTest();

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
        private void buttonCrudeDefaultTestEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultTest.CurrentRow.Cells["DefaultTestId"].Value);
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
        private void buttonCrudeDefaultTestAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestEdit();
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
        private void dataGridViewCrudeDefaultTest_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultTest.CurrentRow.Cells["DefaultTestId"].Value);
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
        private void buttonCrudeDefaultTestSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultTest();
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
        public void RefreshCrudeDefaultTest() {
            var defaultTest = new CrudeDefaultTestServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultTest.FetchWithFilter(
                             Guid.Empty
                            ,textBoxSystemName.Text
                            ,textBoxTestArea.Text
                            ,textBoxTestSubArea.Text
                            ,textBoxTestAddress.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultTest.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTest.DataSource = bindingSource;
                dataGridViewCrudeDefaultTest.AutoResizeColumns();
                dataGridViewCrudeDefaultTest.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultTest.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeDefaultTest() {
            try {
                dataGridViewCrudeDefaultTest.Columns.Clear();
                dataGridViewCrudeDefaultTest.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTest.Columns.Add("SystemName","System Name");
                dataGridViewCrudeDefaultTest.Columns["SystemName"].DataPropertyName = "SystemName";
                dataGridViewCrudeDefaultTest.Columns.Add("TestArea","Test Area");
                dataGridViewCrudeDefaultTest.Columns["TestArea"].DataPropertyName = "TestArea";
                dataGridViewCrudeDefaultTest.Columns.Add("TestSubArea","Test Sub Area");
                dataGridViewCrudeDefaultTest.Columns["TestSubArea"].DataPropertyName = "TestSubArea";
                dataGridViewCrudeDefaultTest.Columns.Add("TestAddress","Test Address");
                dataGridViewCrudeDefaultTest.Columns["TestAddress"].DataPropertyName = "TestAddress";
                dataGridViewCrudeDefaultTest.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultTest.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultTest.Columns.Add("DefaultTestId","Default Test");
                dataGridViewCrudeDefaultTest.Columns["DefaultTestId"].DataPropertyName = "DefaultTestId";
                dataGridViewCrudeDefaultTest.Columns["DefaultTestId"].Visible = false;
                dataGridViewCrudeDefaultTest.Columns.Add("UserId","User");
                dataGridViewCrudeDefaultTest.Columns["UserId"].DataPropertyName = "UserId";
                dataGridViewCrudeDefaultTest.Columns["UserId"].Visible = false;
                dataGridViewCrudeDefaultTest.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultTest.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultTest.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
