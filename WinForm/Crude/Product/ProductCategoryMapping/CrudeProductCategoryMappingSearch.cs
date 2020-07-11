/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:26:07 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductCategoryMappingSearch : Form {
        
        private System.Guid _productCategoryId;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        public CrudeProductCategoryMappingSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryMapping();
            this.AcceptButton = buttonCrudeProductCategoryMappingSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid productCategoryId, System.Guid productId, System.Guid userId) {
            try {
                _productCategoryId = productCategoryId;
                _productId = productId;
                _userId = userId;
                RefreshCrudeProductCategoryMapping();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryMappingEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryMappingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryMapping.CurrentRow.Cells["ProductCategoryMappingId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryMappingAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryMappingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductCategoryMapping_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryMappingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryMapping.CurrentRow.Cells["ProductCategoryMappingId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryMappingSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategoryMapping();
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
        
        public void RefreshCrudeProductCategoryMapping() {
            var productCategoryMapping = new CrudeProductCategoryMappingServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategoryMapping.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategoryMapping.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryMapping.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryMapping.AutoResizeColumns();
                dataGridViewCrudeProductCategoryMapping.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategoryMapping.Close();
            }
        }
        
        private void InitializeGridCrudeProductCategoryMapping() {
            try {
                dataGridViewCrudeProductCategoryMapping.Columns.Clear();
                dataGridViewCrudeProductCategoryMapping.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryMapping.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategoryMapping.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductCategoryMappingId","Product Category Mapping");
                dataGridViewCrudeProductCategoryMapping.Columns["ProductCategoryMappingId"].DataPropertyName = "ProductCategoryMappingId";
                dataGridViewCrudeProductCategoryMapping.Columns["ProductCategoryMappingId"].Visible = false;
                dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductCategoryId","Product Category");
                dataGridViewCrudeProductCategoryMapping.Columns["ProductCategoryId"].DataPropertyName = "ProductCategoryId";
                dataGridViewCrudeProductCategoryMapping.Columns["ProductCategoryId"].Visible = false;
                dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductCategoryMapping.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductCategoryMapping.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductCategoryMapping.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategoryMapping.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategoryMapping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategoryMapping.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
