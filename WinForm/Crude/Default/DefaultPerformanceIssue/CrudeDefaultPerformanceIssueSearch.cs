/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:34:14 PM
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
    public partial class CrudeDefaultPerformanceIssueSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultPerformanceIssueSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultPerformanceIssue();
            this.AcceptButton = buttonCrudeDefaultPerformanceIssueSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultPerformanceIssue();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultPerformanceIssueEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceIssue.CurrentRow.Cells["DefaultPerformanceIssueId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultPerformanceIssueAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeDefaultPerformanceIssue_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceIssue.CurrentRow.Cells["DefaultPerformanceIssueId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultPerformanceIssueSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultPerformanceIssue();
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
        public void RefreshCrudeDefaultPerformanceIssue() {
            var defaultPerformanceIssue = new CrudeDefaultPerformanceIssueServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultPerformanceIssue.FetchWithFilter(
                             Guid.Empty
                            ,textBoxCommandName.Text
                            ,textBoxCommandText.Text
                            ,maskedTextBoxMilliseconds.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMilliseconds.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultPerformanceIssue.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceIssue.DataSource = bindingSource;
                dataGridViewCrudeDefaultPerformanceIssue.AutoResizeColumns();
                dataGridViewCrudeDefaultPerformanceIssue.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultPerformanceIssue.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultPerformanceIssue() {
            try {
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Clear();
                dataGridViewCrudeDefaultPerformanceIssue.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("CommandName","Command Name");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["CommandName"].DataPropertyName = "CommandName";
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("CommandText","Command Text");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["CommandText"].DataPropertyName = "CommandText";
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("Milliseconds","Milliseconds");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["Milliseconds"].DataPropertyName = "Milliseconds";
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("DefaultPerformanceIssueId","Default Performance Issue");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["DefaultPerformanceIssueId"].DataPropertyName = "DefaultPerformanceIssueId";
                dataGridViewCrudeDefaultPerformanceIssue.Columns["DefaultPerformanceIssueId"].Visible = false;
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultPerformanceIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultPerformanceIssue.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
