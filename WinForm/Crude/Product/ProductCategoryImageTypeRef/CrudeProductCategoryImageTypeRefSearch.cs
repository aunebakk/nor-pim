/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:34:15 PM
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
    public partial class CrudeProductCategoryImageTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductCategoryImageTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryImageTypeRef();
            this.AcceptButton = buttonCrudeProductCategoryImageTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductCategoryImageTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductCategoryImageTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryImageTypeRef.CurrentRow.Cells["ProductCategoryImageTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductCategoryImageTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageTypeRefEdit();
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
        private void dataGridViewCrudeProductCategoryImageTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryImageTypeRef.CurrentRow.Cells["ProductCategoryImageTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductCategoryImageTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategoryImageTypeRef();
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
        public void RefreshCrudeProductCategoryImageTypeRef() {
            var productCategoryImageTypeRef = new CrudeProductCategoryImageTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategoryImageTypeRef.FetchWithFilter(
                             textBoxProductCategoryImageType.Text
                            ,textBoxProductCategoryImageTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategoryImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryImageTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryImageTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductCategoryImageTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategoryImageTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductCategoryImageTypeRef() {
            try {
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Clear();
                dataGridViewCrudeProductCategoryImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ProductCategoryImageTypeName","Product Category Image Type Name");
                dataGridViewCrudeProductCategoryImageTypeRef.Columns["ProductCategoryImageTypeName"].DataPropertyName = "ProductCategoryImageTypeName";
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ProductCategoryImageTypeRcd","Product Category Image Type");
                dataGridViewCrudeProductCategoryImageTypeRef.Columns["ProductCategoryImageTypeRcd"].DataPropertyName = "ProductCategoryImageTypeRcd";
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategoryImageTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategoryImageTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategoryImageTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategoryImageTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
