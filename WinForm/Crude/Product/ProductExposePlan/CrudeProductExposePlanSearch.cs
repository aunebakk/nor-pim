/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:45:11 PM
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
    public partial class CrudeProductExposePlanSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _productExposeSetTypeRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductExposePlanSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposePlan();
            this.AcceptButton = buttonCrudeProductExposePlanSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string productExposeSetTypeRcd, System.Guid productId, System.Guid userId) {
            try {
                _productExposeSetTypeRcd = productExposeSetTypeRcd;
                _productId = productId;
                _userId = userId;

                RefreshCrudeProductExposePlan();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductExposePlanEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposePlanEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposePlan.CurrentRow.Cells["ProductExposePlanId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductExposePlanAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposePlanEdit();
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
        private void dataGridViewCrudeProductExposePlan_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposePlanEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposePlan.CurrentRow.Cells["ProductExposePlanId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductExposePlanSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExposePlan();
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
        public void RefreshCrudeProductExposePlan() {
            var productExposePlan = new CrudeProductExposePlanServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExposePlan.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productExposeSetTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExposePlan.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposePlan.DataSource = bindingSource;
                dataGridViewCrudeProductExposePlan.AutoResizeColumns();
                dataGridViewCrudeProductExposePlan.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExposePlan.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductExposePlan() {
            try {
                dataGridViewCrudeProductExposePlan.Columns.Clear();
                dataGridViewCrudeProductExposePlan.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposePlan.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
                dataGridViewCrudeProductExposePlan.Columns["ProductExposeSetTypeRcd"].DataPropertyName = "ProductExposeSetTypeRcd";
                dataGridViewCrudeProductExposePlan.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExposePlan.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExposePlan.Columns.Add("ProductExposePlanId","Product Expose Plan");
                dataGridViewCrudeProductExposePlan.Columns["ProductExposePlanId"].DataPropertyName = "ProductExposePlanId";
                dataGridViewCrudeProductExposePlan.Columns["ProductExposePlanId"].Visible = false;
                dataGridViewCrudeProductExposePlan.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductExposePlan.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductExposePlan.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductExposePlan.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExposePlan.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExposePlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExposePlan.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
