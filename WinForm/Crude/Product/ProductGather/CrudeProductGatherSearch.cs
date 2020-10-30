/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 7:42:08 AM
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
    public partial class CrudeProductGatherSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductGatherSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGather();
            this.AcceptButton = buttonCrudeProductGatherSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductGather();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductGatherEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGather.CurrentRow.Cells["ProductGatherId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductGatherAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeProductGather_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGather.CurrentRow.Cells["ProductGatherId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductGatherSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGather();
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
        public void RefreshCrudeProductGather() {
            var productGather = new CrudeProductGatherServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGather.FetchWithFilter(
                             Guid.Empty
                            ,dateTimePickerStartDateTime.Checked ? Convert.ToDateTime(dateTimePickerStartDateTime.Value): DateTime.MinValue
                            ,dateTimePickerFinishDateTime.Checked ? Convert.ToDateTime(dateTimePickerFinishDateTime.Value): DateTime.MinValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGather.AutoGenerateColumns = false;
                dataGridViewCrudeProductGather.DataSource = bindingSource;
                dataGridViewCrudeProductGather.AutoResizeColumns();
                dataGridViewCrudeProductGather.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGather.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductGather() {
            try {
                dataGridViewCrudeProductGather.Columns.Clear();
                dataGridViewCrudeProductGather.AutoGenerateColumns = false;
                dataGridViewCrudeProductGather.Columns.Add("StartDateTime","Start Date Time");
                dataGridViewCrudeProductGather.Columns["StartDateTime"].DataPropertyName = "StartDateTime";
                dataGridViewCrudeProductGather.Columns.Add("FinishDateTime","Finish Date Time");
                dataGridViewCrudeProductGather.Columns["FinishDateTime"].DataPropertyName = "FinishDateTime";
                dataGridViewCrudeProductGather.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGather.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGather.Columns.Add("ProductGatherId","Product Gather");
                dataGridViewCrudeProductGather.Columns["ProductGatherId"].DataPropertyName = "ProductGatherId";
                dataGridViewCrudeProductGather.Columns["ProductGatherId"].Visible = false;
                dataGridViewCrudeProductGather.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGather.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGather.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGather.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
