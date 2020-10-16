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
    public partial class CrudeDefaultPerformanceTimeSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultPerformanceTimeSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultPerformanceTime();
            this.AcceptButton = buttonCrudeDefaultPerformanceTimeSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultPerformanceTime();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultPerformanceTimeEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceTime.CurrentRow.Cells["DefaultPerformanceTimeId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultPerformanceTimeAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeEdit();
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
        private void dataGridViewCrudeDefaultPerformanceTime_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceTime.CurrentRow.Cells["DefaultPerformanceTimeId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultPerformanceTimeSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultPerformanceTime();
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
        public void RefreshCrudeDefaultPerformanceTime() {
            var defaultPerformanceTime = new CrudeDefaultPerformanceTimeServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultPerformanceTime.FetchWithFilter(
                             Guid.Empty
                            ,textBoxCommandName.Text
                            ,maskedTextBoxMilliseconds.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMilliseconds.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultPerformanceTime.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceTime.DataSource = bindingSource;
                dataGridViewCrudeDefaultPerformanceTime.AutoResizeColumns();
                dataGridViewCrudeDefaultPerformanceTime.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultPerformanceTime.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultPerformanceTime() {
            try {
                dataGridViewCrudeDefaultPerformanceTime.Columns.Clear();
                dataGridViewCrudeDefaultPerformanceTime.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("CommandName","Command Name");
                dataGridViewCrudeDefaultPerformanceTime.Columns["CommandName"].DataPropertyName = "CommandName";
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("Milliseconds","Milliseconds");
                dataGridViewCrudeDefaultPerformanceTime.Columns["Milliseconds"].DataPropertyName = "Milliseconds";
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultPerformanceTime.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("DefaultPerformanceTimeId","Default Performance Time");
                dataGridViewCrudeDefaultPerformanceTime.Columns["DefaultPerformanceTimeId"].DataPropertyName = "DefaultPerformanceTimeId";
                dataGridViewCrudeDefaultPerformanceTime.Columns["DefaultPerformanceTimeId"].Visible = false;
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultPerformanceTime.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultPerformanceTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultPerformanceTime.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
