/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:13:17 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductCategorySearch : Form {
        
        private System.Guid _productCategoryBecameId;
        
        private System.Guid _productCategoryParentId;
        
        private System.Guid _userId;
        
        public CrudeProductCategorySearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategory();
            this.AcceptButton = buttonCrudeProductCategorySearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid productCategoryBecameId, System.Guid productCategoryParentId, System.Guid userId) {
            try {
                _productCategoryBecameId = productCategoryBecameId;
                _productCategoryParentId = productCategoryParentId;
                _userId = userId;
                RefreshCrudeProductCategory();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategory.CurrentRow.Cells["ProductCategoryId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductCategory_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategory.CurrentRow.Cells["ProductCategoryId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategorySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategory();
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
        
        public void RefreshCrudeProductCategory() {
            var productCategory = new CrudeProductCategoryServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategory.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,textBoxProductCategoryCode.Text
                            ,textBoxProductCategoryName.Text
                            ,maskedTextBoxProductCategoryPosition.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxProductCategoryPosition.Text)
                            ,textBoxState.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategory.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategory.DataSource = bindingSource;
                dataGridViewCrudeProductCategory.AutoResizeColumns();
                dataGridViewCrudeProductCategory.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategory.Close();
            }
        }
        
        private void InitializeGridCrudeProductCategory() {
            try {
                dataGridViewCrudeProductCategory.Columns.Clear();
                dataGridViewCrudeProductCategory.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryName","Product Category Name");
                dataGridViewCrudeProductCategory.Columns["ProductCategoryName"].DataPropertyName = "ProductCategoryName";
                dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryCode","Product Category Code");
                dataGridViewCrudeProductCategory.Columns["ProductCategoryCode"].DataPropertyName = "ProductCategoryCode";
                dataGridViewCrudeProductCategory.Columns.Add("StateRcd","State");
                dataGridViewCrudeProductCategory.Columns["StateRcd"].DataPropertyName = "StateRcd";
                dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryPosition","Product Category Position");
                dataGridViewCrudeProductCategory.Columns["ProductCategoryPosition"].DataPropertyName = "ProductCategoryPosition";
                dataGridViewCrudeProductCategory.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategory.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryId","Product Category");
                dataGridViewCrudeProductCategory.Columns["ProductCategoryId"].DataPropertyName = "ProductCategoryId";
                dataGridViewCrudeProductCategory.Columns["ProductCategoryId"].Visible = false;
                dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryBecameId","Product Category Became");
                dataGridViewCrudeProductCategory.Columns["ProductCategoryBecameId"].DataPropertyName = "ProductCategoryBecameId";
                dataGridViewCrudeProductCategory.Columns["ProductCategoryBecameId"].Visible = false;
                dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryParentId","Product Category Parent");
                dataGridViewCrudeProductCategory.Columns["ProductCategoryParentId"].DataPropertyName = "ProductCategoryParentId";
                dataGridViewCrudeProductCategory.Columns["ProductCategoryParentId"].Visible = false;
                dataGridViewCrudeProductCategory.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategory.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategory.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
