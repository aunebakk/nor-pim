/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 6:15:33 PM
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
    public partial class CrudeProductInfoSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _productInfoRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductInfoSearch() {
            InitializeComponent();
            InitializeGridCrudeProductInfo();
            this.AcceptButton = buttonCrudeProductInfoSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string productInfoRcd, System.Guid productId, System.Guid userId) {
            try {
                _productInfoRcd = productInfoRcd;
                _productId = productId;
                _userId = userId;

                RefreshCrudeProductInfo();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductInfoEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductInfoAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoEdit();
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
        private void dataGridViewCrudeProductInfo_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductInfoEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductInfoSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductInfo();
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
        public void RefreshCrudeProductInfo() {
            var productInfo = new CrudeProductInfoServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productInfo.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productInfoRefCombo.Text
                            ,textBoxProductInfoValue.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductInfo.AutoGenerateColumns = false;
                dataGridViewCrudeProductInfo.DataSource = bindingSource;
                dataGridViewCrudeProductInfo.AutoResizeColumns();
                dataGridViewCrudeProductInfo.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productInfo.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductInfo() {
            try {
                dataGridViewCrudeProductInfo.Columns.Clear();
                dataGridViewCrudeProductInfo.AutoGenerateColumns = false;
                dataGridViewCrudeProductInfo.Columns.Add("ProductInfoRcd","Product Info");
                dataGridViewCrudeProductInfo.Columns["ProductInfoRcd"].DataPropertyName = "ProductInfoRcd";
                dataGridViewCrudeProductInfo.Columns.Add("ProductInfoValue","Product Info Value");
                dataGridViewCrudeProductInfo.Columns["ProductInfoValue"].DataPropertyName = "ProductInfoValue";
                dataGridViewCrudeProductInfo.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductInfo.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductInfo.Columns.Add("ProductInfoId","Product Info");
                dataGridViewCrudeProductInfo.Columns["ProductInfoId"].DataPropertyName = "ProductInfoId";
                dataGridViewCrudeProductInfo.Columns["ProductInfoId"].Visible = false;
                dataGridViewCrudeProductInfo.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductInfo.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductInfo.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductInfo.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductInfo.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductInfo.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
