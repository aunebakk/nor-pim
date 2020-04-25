/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:25 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductChangeSetSearch : Form {
        
        private System.Guid _productId;
        
        private System.Guid _productGatherKeyId;
        
        private System.Guid _userId;
        
        public CrudeProductChangeSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductChangeSet();
            this.AcceptButton = buttonCrudeProductChangeSetSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid productId, System.Guid productGatherKeyId, System.Guid userId) {
            try {
                _productId = productId;
                _productGatherKeyId = productGatherKeyId;
                _userId = userId;
                RefreshCrudeProductChangeSet();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductChangeSetEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductChangeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductChangeSet.CurrentRow.Cells["ProductChangeSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductChangeSetAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductChangeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductChangeSet_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductChangeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductChangeSet.CurrentRow.Cells["ProductChangeSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductChangeSetSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductChangeSet();
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
        
        public void RefreshCrudeProductChangeSet() {
            var productChangeSet = new CrudeProductChangeSetServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productChangeSet.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductChangeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductChangeSet.DataSource = bindingSource;
                dataGridViewCrudeProductChangeSet.AutoResizeColumns();
                dataGridViewCrudeProductChangeSet.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productChangeSet.Close();
            }
        }
        
        private void InitializeGridCrudeProductChangeSet() {
            try {
                dataGridViewCrudeProductChangeSet.Columns.Clear();
                dataGridViewCrudeProductChangeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductChangeSet.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductChangeSet.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductChangeSet.Columns.Add("ProductChangeSetId","Product Change Set");
                dataGridViewCrudeProductChangeSet.Columns["ProductChangeSetId"].DataPropertyName = "ProductChangeSetId";
                dataGridViewCrudeProductChangeSet.Columns["ProductChangeSetId"].Visible = false;
                dataGridViewCrudeProductChangeSet.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductChangeSet.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductChangeSet.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductChangeSet.Columns.Add("ProductGatherKeyId","Product Gather Key");
                dataGridViewCrudeProductChangeSet.Columns["ProductGatherKeyId"].DataPropertyName = "ProductGatherKeyId";
                dataGridViewCrudeProductChangeSet.Columns["ProductGatherKeyId"].Visible = false;
                dataGridViewCrudeProductChangeSet.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductChangeSet.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductChangeSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductChangeSet.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
