/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 12:53:05 PM
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
    public partial class CrudeProductDocumentationTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductDocumentationTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductDocumentationTypeRef();
            this.AcceptButton = buttonCrudeProductDocumentationTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductDocumentationTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductDocumentationTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductDocumentationTypeRef.CurrentRow.Cells["ProductDocumentationTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductDocumentationTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationTypeRefEdit();
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
        private void dataGridViewCrudeProductDocumentationTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductDocumentationTypeRef.CurrentRow.Cells["ProductDocumentationTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductDocumentationTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductDocumentationTypeRef();
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
        public void RefreshCrudeProductDocumentationTypeRef() {
            var productDocumentationTypeRef = new CrudeProductDocumentationTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productDocumentationTypeRef.FetchWithFilter(
                             textBoxProductDocumentationType.Text
                            ,textBoxProductDocumentationTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductDocumentationTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductDocumentationTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductDocumentationTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productDocumentationTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductDocumentationTypeRef() {
            try {
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Clear();
                dataGridViewCrudeProductDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ProductDocumentationTypeName","Product Documentation Type Name");
                dataGridViewCrudeProductDocumentationTypeRef.Columns["ProductDocumentationTypeName"].DataPropertyName = "ProductDocumentationTypeName";
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
                dataGridViewCrudeProductDocumentationTypeRef.Columns["ProductDocumentationTypeRcd"].DataPropertyName = "ProductDocumentationTypeRcd";
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductDocumentationTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductDocumentationTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductDocumentationTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductDocumentationTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
