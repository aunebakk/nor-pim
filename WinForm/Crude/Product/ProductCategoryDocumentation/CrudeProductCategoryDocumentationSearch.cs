/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 8:05:19 PM
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
    public partial class CrudeProductCategoryDocumentationSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _productCategoryDocumentationTypeRcd;
        
        private System.Guid _productCategoryId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductCategoryDocumentationSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryDocumentation();
            this.AcceptButton = buttonCrudeProductCategoryDocumentationSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, System.Guid userId) {
            try {
                _productCategoryDocumentationTypeRcd = productCategoryDocumentationTypeRcd;
                _productCategoryId = productCategoryId;
                _userId = userId;

                RefreshCrudeProductCategoryDocumentation();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductCategoryDocumentationEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryDocumentation.CurrentRow.Cells["ProductCategoryDocumentationId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductCategoryDocumentationAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationEdit();
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
        private void dataGridViewCrudeProductCategoryDocumentation_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryDocumentation.CurrentRow.Cells["ProductCategoryDocumentationId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductCategoryDocumentationSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategoryDocumentation();
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
        public void RefreshCrudeProductCategoryDocumentation() {
            var productCategoryDocumentation = new CrudeProductCategoryDocumentationServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategoryDocumentation.FetchWithFilter(
                             Guid.Empty
                            ,productCategoryDocumentationTypeRefCombo.Text
                            ,Guid.Empty
                            ,textBoxDocumentation.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryDocumentation.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryDocumentation.AutoResizeColumns();
                dataGridViewCrudeProductCategoryDocumentation.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategoryDocumentation.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductCategoryDocumentation() {
            try {
                dataGridViewCrudeProductCategoryDocumentation.Columns.Clear();
                dataGridViewCrudeProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationTypeRcd","Product Category Documentation Type");
                dataGridViewCrudeProductCategoryDocumentation.Columns["ProductCategoryDocumentationTypeRcd"].DataPropertyName = "ProductCategoryDocumentationTypeRcd";
                dataGridViewCrudeProductCategoryDocumentation.Columns.Add("Documentation","Documentation");
                dataGridViewCrudeProductCategoryDocumentation.Columns["Documentation"].DataPropertyName = "Documentation";
                dataGridViewCrudeProductCategoryDocumentation.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategoryDocumentation.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationId","Product Category Documentation");
                dataGridViewCrudeProductCategoryDocumentation.Columns["ProductCategoryDocumentationId"].DataPropertyName = "ProductCategoryDocumentationId";
                dataGridViewCrudeProductCategoryDocumentation.Columns["ProductCategoryDocumentationId"].Visible = false;
                dataGridViewCrudeProductCategoryDocumentation.Columns.Add("ProductCategoryId","Product Category");
                dataGridViewCrudeProductCategoryDocumentation.Columns["ProductCategoryId"].DataPropertyName = "ProductCategoryId";
                dataGridViewCrudeProductCategoryDocumentation.Columns["ProductCategoryId"].Visible = false;
                dataGridViewCrudeProductCategoryDocumentation.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategoryDocumentation.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategoryDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategoryDocumentation.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
