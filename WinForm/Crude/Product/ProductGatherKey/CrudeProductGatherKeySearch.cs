/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 1:46:17 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherKeySearch : Form {
        
        private System.Guid _productGatherId;
        
        private System.Guid _userId;
        
        public CrudeProductGatherKeySearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherKey();
            this.AcceptButton = buttonCrudeProductGatherKeySearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid productGatherId, System.Guid userId) {
            try {
                _productGatherId = productGatherId;
                _userId = userId;
                RefreshCrudeProductGatherKey();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherKeyEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherKeyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherKey.CurrentRow.Cells["ProductGatherKeyId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherKeyAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherKeyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductGatherKey_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherKeyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherKey.CurrentRow.Cells["ProductGatherKeyId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherKeySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherKey();
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
        
        public void RefreshCrudeProductGatherKey() {
            var productGatherKey = new CrudeProductGatherKeyServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherKey.FetchWithFilter(
                             Guid.Empty
                            ,textBoxProductGatherKeyValue.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherKey.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherKey.DataSource = bindingSource;
                dataGridViewCrudeProductGatherKey.AutoResizeColumns();
                dataGridViewCrudeProductGatherKey.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherKey.Close();
            }
        }
        
        private void InitializeGridCrudeProductGatherKey() {
            try {
                dataGridViewCrudeProductGatherKey.Columns.Clear();
                dataGridViewCrudeProductGatherKey.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherKeyValue","Product Gather Key Value");
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherKeyValue"].DataPropertyName = "ProductGatherKeyValue";
                dataGridViewCrudeProductGatherKey.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherKey.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherKeyId","Product Gather Key");
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherKeyId"].DataPropertyName = "ProductGatherKeyId";
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherKeyId"].Visible = false;
                dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherId","Product Gather");
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherId"].DataPropertyName = "ProductGatherId";
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherId"].Visible = false;
                dataGridViewCrudeProductGatherKey.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherKey.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherKey.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherKey.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
