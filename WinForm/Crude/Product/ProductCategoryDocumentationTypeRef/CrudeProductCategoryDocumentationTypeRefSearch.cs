/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/25/2020 9:15:09 AM
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
    public partial class CrudeProductCategoryDocumentationTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductCategoryDocumentationTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryDocumentationTypeRef();
            this.AcceptButton = buttonCrudeProductCategoryDocumentationTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductCategoryDocumentationTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductCategoryDocumentationTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryDocumentationTypeRef.CurrentRow.Cells["ProductCategoryDocumentationTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductCategoryDocumentationTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
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
        private void dataGridViewCrudeProductCategoryDocumentationTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryDocumentationTypeRef.CurrentRow.Cells["ProductCategoryDocumentationTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductCategoryDocumentationTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategoryDocumentationTypeRef();
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
        public void RefreshCrudeProductCategoryDocumentationTypeRef() {
            var productCategoryDocumentationTypeRef = new CrudeProductCategoryDocumentationTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategoryDocumentationTypeRef.FetchWithFilter(
                             textBoxProductCategoryDocumentationType.Text
                            ,textBoxProductCategoryDocumentationTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategoryDocumentationTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductCategoryDocumentationTypeRef() {
            try {
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Clear();
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ProductCategoryDocumentationTypeName","Product Category Documentation Type Name");
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["ProductCategoryDocumentationTypeName"].DataPropertyName = "ProductCategoryDocumentationTypeName";
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ProductCategoryDocumentationTypeRcd","Product Category Documentation Type");
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["ProductCategoryDocumentationTypeRcd"].DataPropertyName = "ProductCategoryDocumentationTypeRcd";
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
