/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:03:24 AM
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
    public partial class CrudeProductInfoRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductInfoRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductInfoRef();
            this.AcceptButton = buttonCrudeProductInfoRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductInfoRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductInfoRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductInfoRef.CurrentRow.Cells["ProductInfoRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductInfoRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoRefEdit();
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
        private void dataGridViewCrudeProductInfoRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductInfoRef.CurrentRow.Cells["ProductInfoRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductInfoRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductInfoRef();
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
        public void RefreshCrudeProductInfoRef() {
            var productInfoRef = new CrudeProductInfoRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productInfoRef.FetchWithFilter(
                             textBoxProductInfo.Text
                            ,textBoxProductInfoName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductInfoRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductInfoRef.DataSource = bindingSource;
                dataGridViewCrudeProductInfoRef.AutoResizeColumns();
                dataGridViewCrudeProductInfoRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productInfoRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductInfoRef() {
            try {
                dataGridViewCrudeProductInfoRef.Columns.Clear();
                dataGridViewCrudeProductInfoRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductInfoRef.Columns.Add("ProductInfoName","Product Info Name");
                dataGridViewCrudeProductInfoRef.Columns["ProductInfoName"].DataPropertyName = "ProductInfoName";
                dataGridViewCrudeProductInfoRef.Columns.Add("ProductInfoRcd","Product Info");
                dataGridViewCrudeProductInfoRef.Columns["ProductInfoRcd"].DataPropertyName = "ProductInfoRcd";
                dataGridViewCrudeProductInfoRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductInfoRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductInfoRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductInfoRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductInfoRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductInfoRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
