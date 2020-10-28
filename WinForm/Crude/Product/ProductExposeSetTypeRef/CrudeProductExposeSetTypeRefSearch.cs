/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 10:09:22 PM
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
    public partial class CrudeProductExposeSetTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductExposeSetTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposeSetTypeRef();
            this.AcceptButton = buttonCrudeProductExposeSetTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductExposeSetTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductExposeSetTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductExposeSetTypeRef.CurrentRow.Cells["ProductExposeSetTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductExposeSetTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetTypeRefEdit();
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
        private void dataGridViewCrudeProductExposeSetTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductExposeSetTypeRef.CurrentRow.Cells["ProductExposeSetTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductExposeSetTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExposeSetTypeRef();
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
        public void RefreshCrudeProductExposeSetTypeRef() {
            var productExposeSetTypeRef = new CrudeProductExposeSetTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExposeSetTypeRef.FetchWithFilter(
                             textBoxProductExposeSetType.Text
                            ,textBoxProductExposeSetTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExposeSetTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSetTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductExposeSetTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductExposeSetTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExposeSetTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductExposeSetTypeRef() {
            try {
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Clear();
                dataGridViewCrudeProductExposeSetTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ProductExposeSetTypeName","Product Expose Set Type Name");
                dataGridViewCrudeProductExposeSetTypeRef.Columns["ProductExposeSetTypeName"].DataPropertyName = "ProductExposeSetTypeName";
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
                dataGridViewCrudeProductExposeSetTypeRef.Columns["ProductExposeSetTypeRcd"].DataPropertyName = "ProductExposeSetTypeRcd";
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExposeSetTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExposeSetTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExposeSetTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExposeSetTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
