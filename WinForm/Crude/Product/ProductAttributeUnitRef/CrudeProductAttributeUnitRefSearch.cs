/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 2:55:36 PM
  From Machine: DESKTOP-517I8BU
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
    public partial class CrudeProductAttributeUnitRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductAttributeUnitRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttributeUnitRef();
            this.AcceptButton = buttonCrudeProductAttributeUnitRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductAttributeUnitRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductAttributeUnitRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeUnitRef.CurrentRow.Cells["ProductAttributeUnitRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductAttributeUnitRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
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
        private void dataGridViewCrudeProductAttributeUnitRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeUnitRef.CurrentRow.Cells["ProductAttributeUnitRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductAttributeUnitRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductAttributeUnitRef();
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
        public void RefreshCrudeProductAttributeUnitRef() {
            var productAttributeUnitRef = new CrudeProductAttributeUnitRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productAttributeUnitRef.FetchWithFilter(
                             textBoxProductAttributeUnit.Text
                            ,textBoxProductAttributeUnitName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductAttributeUnitRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeUnitRef.DataSource = bindingSource;
                dataGridViewCrudeProductAttributeUnitRef.AutoResizeColumns();
                dataGridViewCrudeProductAttributeUnitRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productAttributeUnitRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductAttributeUnitRef() {
            try {
                dataGridViewCrudeProductAttributeUnitRef.Columns.Clear();
                dataGridViewCrudeProductAttributeUnitRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ProductAttributeUnitName","Product Attribute Unit Name");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ProductAttributeUnitName"].DataPropertyName = "ProductAttributeUnitName";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ProductAttributeUnitRcd","Product Attribute Unit");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ProductAttributeUnitRcd"].DataPropertyName = "ProductAttributeUnitRcd";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductAttributeUnitRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductAttributeUnitRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductAttributeUnitRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
