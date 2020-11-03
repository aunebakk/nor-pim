/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:47:58 AM
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
    public partial class CrudeProductCategoryImageSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _productCategoryImageTypeRcd;
        
        private System.Guid _productCategoryId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductCategoryImageSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryImage();
            this.AcceptButton = buttonCrudeProductCategoryImageSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string productCategoryImageTypeRcd, System.Guid productCategoryId, System.Guid userId) {
            try {
                _productCategoryImageTypeRcd = productCategoryImageTypeRcd;
                _productCategoryId = productCategoryId;
                _userId = userId;

                RefreshCrudeProductCategoryImage();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductCategoryImageEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryImage.CurrentRow.Cells["ProductCategoryImageId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductCategoryImageAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageEdit();
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
        private void dataGridViewCrudeProductCategoryImage_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryImage.CurrentRow.Cells["ProductCategoryImageId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductCategoryImageSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategoryImage();
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
        public void RefreshCrudeProductCategoryImage() {
            var productCategoryImage = new CrudeProductCategoryImageServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategoryImage.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productCategoryImageTypeRefCombo.Text
                            ,null
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategoryImage.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryImage.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryImage.AutoResizeColumns();
                dataGridViewCrudeProductCategoryImage.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategoryImage.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductCategoryImage() {
            try {
                dataGridViewCrudeProductCategoryImage.Columns.Clear();
                dataGridViewCrudeProductCategoryImage.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryImage.Columns.Add("ProductCategoryImageTypeRcd","Product Category Image Type");
                dataGridViewCrudeProductCategoryImage.Columns["ProductCategoryImageTypeRcd"].DataPropertyName = "ProductCategoryImageTypeRcd";
                dataGridViewCrudeProductCategoryImage.Columns.Add("Image","Image");
                dataGridViewCrudeProductCategoryImage.Columns["Image"].DataPropertyName = "Image";
                dataGridViewCrudeProductCategoryImage.Columns["Image"].Visible = false;
                dataGridViewCrudeProductCategoryImage.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategoryImage.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategoryImage.Columns.Add("ProductCategoryImageId","Product Category Image");
                dataGridViewCrudeProductCategoryImage.Columns["ProductCategoryImageId"].DataPropertyName = "ProductCategoryImageId";
                dataGridViewCrudeProductCategoryImage.Columns["ProductCategoryImageId"].Visible = false;
                dataGridViewCrudeProductCategoryImage.Columns.Add("ProductCategoryId","Product Category");
                dataGridViewCrudeProductCategoryImage.Columns["ProductCategoryId"].DataPropertyName = "ProductCategoryId";
                dataGridViewCrudeProductCategoryImage.Columns["ProductCategoryId"].Visible = false;
                dataGridViewCrudeProductCategoryImage.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategoryImage.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategoryImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategoryImage.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
