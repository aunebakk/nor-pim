/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:43:31 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductInfoSearch : Form {
        
        private string _productInfoRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        public CrudeProductInfoSearch() {
            InitializeComponent();
            InitializeGridCrudeProductInfo();
            this.AcceptButton = buttonCrudeProductInfoSearch;
            this.CancelButton = buttonClose;

        }
        
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
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
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
