/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:38:27 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductImageSearch : Form {
        
        private string _productImageTypeRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        public CrudeProductImageSearch() {
            InitializeComponent();
            InitializeGridCrudeProductImage();
            this.AcceptButton = buttonCrudeProductImageSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productImageTypeRcd, System.Guid productId, System.Guid userId) {
            try {
                _productImageTypeRcd = productImageTypeRcd;
                _productId = productId;
                _userId = userId;
                RefreshCrudeProductImage();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductImageEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductImage.CurrentRow.Cells["ProductImageId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductImageAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductImage_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductImage.CurrentRow.Cells["ProductImageId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductImageSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductImage();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshCrudeProductImage() {
            var productImage = new CrudeProductImageServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productImage.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productImageTypeRefCombo.Text
                            ,textBoxImageFileName.Text
                            ,null
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductImage.AutoGenerateColumns = false;
                dataGridViewCrudeProductImage.DataSource = bindingSource;
                dataGridViewCrudeProductImage.AutoResizeColumns();
                dataGridViewCrudeProductImage.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productImage.Close();
            }
        }
        
        private void InitializeGridCrudeProductImage() {
            try {
                dataGridViewCrudeProductImage.Columns.Clear();
                dataGridViewCrudeProductImage.AutoGenerateColumns = false;
                dataGridViewCrudeProductImage.Columns.Add("ImageFileName","Image File Name");
                dataGridViewCrudeProductImage.Columns["ImageFileName"].DataPropertyName = "ImageFileName";
                dataGridViewCrudeProductImage.Columns.Add("ProductImageTypeRcd","Product Image Type");
                dataGridViewCrudeProductImage.Columns["ProductImageTypeRcd"].DataPropertyName = "ProductImageTypeRcd";
                dataGridViewCrudeProductImage.Columns.Add("Image","Image");
                dataGridViewCrudeProductImage.Columns["Image"].DataPropertyName = "Image";
                dataGridViewCrudeProductImage.Columns["Image"].Visible = false;
                dataGridViewCrudeProductImage.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductImage.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductImage.Columns.Add("ProductImageId","Product Image");
                dataGridViewCrudeProductImage.Columns["ProductImageId"].DataPropertyName = "ProductImageId";
                dataGridViewCrudeProductImage.Columns["ProductImageId"].Visible = false;
                dataGridViewCrudeProductImage.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductImage.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductImage.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductImage.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductImage.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductImage.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
