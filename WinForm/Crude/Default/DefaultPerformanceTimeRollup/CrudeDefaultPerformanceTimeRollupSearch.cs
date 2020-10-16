/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:58:16 AM
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
    public partial class CrudeDefaultPerformanceTimeRollupSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultPerformanceTimeRollupSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultPerformanceTimeRollup();
            this.AcceptButton = buttonCrudeDefaultPerformanceTimeRollupSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultPerformanceTimeRollup();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultPerformanceTimeRollupEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeRollupEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceTimeRollup.CurrentRow.Cells["DefaultPerformanceTimeRollupId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultPerformanceTimeRollupAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeRollupEdit();
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
        private void dataGridViewCrudeDefaultPerformanceTimeRollup_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeRollupEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceTimeRollup.CurrentRow.Cells["DefaultPerformanceTimeRollupId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultPerformanceTimeRollupSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultPerformanceTimeRollup();
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
        public void RefreshCrudeDefaultPerformanceTimeRollup() {
            var defaultPerformanceTimeRollup = new CrudeDefaultPerformanceTimeRollupServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultPerformanceTimeRollup.FetchWithFilter(
                             Guid.Empty
                            ,textBoxCommandName.Text
                            ,maskedTextBoxMilliseconds.Text == String.Empty ? 0 : Convert.ToInt64(maskedTextBoxMilliseconds.Text)
                            ,maskedTextBoxHits.Text == String.Empty ? 0 : Convert.ToInt64(maskedTextBoxHits.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceTimeRollup.DataSource = bindingSource;
                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoResizeColumns();
                dataGridViewCrudeDefaultPerformanceTimeRollup.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultPerformanceTimeRollup.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultPerformanceTimeRollup() {
            try {
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Clear();
                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("CommandName","Command Name");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["CommandName"].DataPropertyName = "CommandName";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("Milliseconds","Milliseconds");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["Milliseconds"].DataPropertyName = "Milliseconds";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("Hits","Hits");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["Hits"].DataPropertyName = "Hits";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("DefaultPerformanceTimeRollupId","Default Performance Time Rollup");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["DefaultPerformanceTimeRollupId"].DataPropertyName = "DefaultPerformanceTimeRollupId";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["DefaultPerformanceTimeRollupId"].Visible = false;
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
