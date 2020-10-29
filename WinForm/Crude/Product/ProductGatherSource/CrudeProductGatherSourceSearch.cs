/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:45:12 PM
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
    public partial class CrudeProductGatherSourceSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _productGatherSourceTypeRcd;
        
        private System.Guid _productGatherId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductGatherSourceSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherSource();
            this.AcceptButton = buttonCrudeProductGatherSourceSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string productGatherSourceTypeRcd, System.Guid productGatherId, System.Guid userId) {
            try {
                _productGatherSourceTypeRcd = productGatherSourceTypeRcd;
                _productGatherId = productGatherId;
                _userId = userId;

                RefreshCrudeProductGatherSource();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductGatherSourceEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherSource.CurrentRow.Cells["ProductGatherSourceId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductGatherSourceAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceEdit();
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
        private void dataGridViewCrudeProductGatherSource_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherSource.CurrentRow.Cells["ProductGatherSourceId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductGatherSourceSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherSource();
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
        public void RefreshCrudeProductGatherSource() {
            var productGatherSource = new CrudeProductGatherSourceServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherSource.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productGatherSourceTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherSource.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSource.DataSource = bindingSource;
                dataGridViewCrudeProductGatherSource.AutoResizeColumns();
                dataGridViewCrudeProductGatherSource.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherSource.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductGatherSource() {
            try {
                dataGridViewCrudeProductGatherSource.Columns.Clear();
                dataGridViewCrudeProductGatherSource.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherSourceTypeRcd","Product Gather Source Type");
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherSourceTypeRcd"].DataPropertyName = "ProductGatherSourceTypeRcd";
                dataGridViewCrudeProductGatherSource.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherSource.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherSourceId","Product Gather Source");
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherSourceId"].DataPropertyName = "ProductGatherSourceId";
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherSourceId"].Visible = false;
                dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherId","Product Gather");
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherId"].DataPropertyName = "ProductGatherId";
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherId"].Visible = false;
                dataGridViewCrudeProductGatherSource.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherSource.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherSource.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherSource.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
