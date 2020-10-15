/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 8:58:44 AM
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
    public partial class CrudeProductAttributeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductAttributeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttributeRef();
            this.AcceptButton = buttonCrudeProductAttributeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductAttributeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductAttributeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeRef.CurrentRow.Cells["ProductAttributeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductAttributeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeRefEdit();
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
        private void dataGridViewCrudeProductAttributeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeRef.CurrentRow.Cells["ProductAttributeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductAttributeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductAttributeRef();
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
        public void RefreshCrudeProductAttributeRef() {
            var productAttributeRef = new CrudeProductAttributeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productAttributeRef.FetchWithFilter(
                             textBoxProductAttribute.Text
                            ,textBoxProductAttributeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductAttributeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeRef.DataSource = bindingSource;
                dataGridViewCrudeProductAttributeRef.AutoResizeColumns();
                dataGridViewCrudeProductAttributeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productAttributeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductAttributeRef() {
            try {
                dataGridViewCrudeProductAttributeRef.Columns.Clear();
                dataGridViewCrudeProductAttributeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeRef.Columns.Add("ProductAttributeName","Product Attribute Name");
                dataGridViewCrudeProductAttributeRef.Columns["ProductAttributeName"].DataPropertyName = "ProductAttributeName";
                dataGridViewCrudeProductAttributeRef.Columns.Add("ProductAttributeRcd","Product Attribute");
                dataGridViewCrudeProductAttributeRef.Columns["ProductAttributeRcd"].DataPropertyName = "ProductAttributeRcd";
                dataGridViewCrudeProductAttributeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductAttributeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductAttributeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductAttributeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductAttributeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductAttributeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
