/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:48:42 PM
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
    public partial class CrudeProductCategoryMappingSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _productCategoryId;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductCategoryMappingSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryMapping();
            this.AcceptButton = buttonCrudeProductCategoryMappingSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid productCategoryId, System.Guid productId, System.Guid userId) {
            try {
                _productCategoryId = productCategoryId;
                _productId = productId;
                _userId = userId;

                RefreshCrudeProductCategoryMapping();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductCategoryMappingEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryMappingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryMapping.CurrentRow.Cells["ProductCategoryMappingId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductCategoryMappingAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryMappingEdit();
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
        private void dataGridViewCrudeProductCategoryMapping_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryMappingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryMapping.CurrentRow.Cells["ProductCategoryMappingId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductCategoryMappingSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategoryMapping();
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
        public void RefreshCrudeProductCategoryMapping() {
            var productCategoryMapping = new CrudeProductCategoryMappingServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategoryMapping.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategoryMapping.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryMapping.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryMapping.AutoResizeColumns();
                dataGridViewCrudeProductCategoryMapping.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategoryMapping.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductCategoryMapping() {
            try {
                dataGridViewCrudeProductCategoryMapping.Columns.Clear();
                dataGridViewCrudeProductCategoryMapping.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryMapping.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategoryMapping.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductCategoryMappingId","Product Category Mapping");
                dataGridViewCrudeProductCategoryMapping.Columns["ProductCategoryMappingId"].DataPropertyName = "ProductCategoryMappingId";
                dataGridViewCrudeProductCategoryMapping.Columns["ProductCategoryMappingId"].Visible = false;
                dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductCategoryId","Product Category");
                dataGridViewCrudeProductCategoryMapping.Columns["ProductCategoryId"].DataPropertyName = "ProductCategoryId";
                dataGridViewCrudeProductCategoryMapping.Columns["ProductCategoryId"].Visible = false;
                dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductCategoryMapping.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductCategoryMapping.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductCategoryMapping.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategoryMapping.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategoryMapping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategoryMapping.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
