/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:46:00 PM
  From Machine: DESKTOP-742U247
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
    public partial class CrudeDefaultTestRunSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _defaultTestRunResultRcd;
        
        private System.Guid _defaultTestId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultTestRunSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultTestRun();
            this.AcceptButton = buttonCrudeDefaultTestRunSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string defaultTestRunResultRcd, System.Guid defaultTestId) {
            try {
                _defaultTestRunResultRcd = defaultTestRunResultRcd;
                _defaultTestId = defaultTestId;

                RefreshCrudeDefaultTestRun();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultTestRunEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultTestRun.CurrentRow.Cells["DefaultTestRunId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultTestRunAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunEdit();
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
        private void dataGridViewCrudeDefaultTestRun_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultTestRun.CurrentRow.Cells["DefaultTestRunId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultTestRunSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultTestRun();
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
        public void RefreshCrudeDefaultTestRun() {
            var defaultTestRun = new CrudeDefaultTestRunServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultTestRun.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,defaultTestRunResultRefCombo.Text
                            ,textBoxResult.Text
                            ,dateTimePickerStartDateTime.Checked ? Convert.ToDateTime(dateTimePickerStartDateTime.Value): DateTime.MinValue
                            ,dateTimePickerEndDateTime.Checked ? Convert.ToDateTime(dateTimePickerEndDateTime.Value): DateTime.MinValue
                            ,maskedTextBoxElapsedMilliseconds.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxElapsedMilliseconds.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultTestRun.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTestRun.DataSource = bindingSource;
                dataGridViewCrudeDefaultTestRun.AutoResizeColumns();
                dataGridViewCrudeDefaultTestRun.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultTestRun.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultTestRun() {
            try {
                dataGridViewCrudeDefaultTestRun.Columns.Clear();
                dataGridViewCrudeDefaultTestRun.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTestRun.Columns.Add("DefaultTestRunResultRcd","Default Test Run Result");
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestRunResultRcd"].DataPropertyName = "DefaultTestRunResultRcd";
                dataGridViewCrudeDefaultTestRun.Columns.Add("Result","Result");
                dataGridViewCrudeDefaultTestRun.Columns["Result"].DataPropertyName = "Result";
                dataGridViewCrudeDefaultTestRun.Columns.Add("ElapsedMilliseconds","Elapsed Milliseconds");
                dataGridViewCrudeDefaultTestRun.Columns["ElapsedMilliseconds"].DataPropertyName = "ElapsedMilliseconds";
                dataGridViewCrudeDefaultTestRun.Columns.Add("StartDateTime","Start Date Time");
                dataGridViewCrudeDefaultTestRun.Columns["StartDateTime"].DataPropertyName = "StartDateTime";
                dataGridViewCrudeDefaultTestRun.Columns.Add("EndDateTime","End Date Time");
                dataGridViewCrudeDefaultTestRun.Columns["EndDateTime"].DataPropertyName = "EndDateTime";
                dataGridViewCrudeDefaultTestRun.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultTestRun.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultTestRun.Columns.Add("DefaultTestRunId","Default Test Run");
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestRunId"].DataPropertyName = "DefaultTestRunId";
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestRunId"].Visible = false;
                dataGridViewCrudeDefaultTestRun.Columns.Add("DefaultTestId","Default Test");
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestId"].DataPropertyName = "DefaultTestId";
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestId"].Visible = false;
                dataGridViewCrudeDefaultTestRun.Columns.Add("UserId","User");
                dataGridViewCrudeDefaultTestRun.Columns["UserId"].DataPropertyName = "UserId";
                dataGridViewCrudeDefaultTestRun.Columns["UserId"].Visible = false;
                dataGridViewCrudeDefaultTestRun.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultTestRun.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultTestRun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultTestRun.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
