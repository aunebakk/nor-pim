/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:31:16 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceSearch : Form {
        
        private string _productGatherSourceTypeRcd;
        
        private System.Guid _productGatherId;
        
        private System.Guid _userId;
        
        public CrudeProductGatherSourceSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherSource();
            this.AcceptButton = buttonCrudeProductGatherSourceSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productGatherSourceTypeRcd, System.Guid productGatherId, System.Guid userId) {
            try {
                _productGatherSourceTypeRcd = productGatherSourceTypeRcd;
                _productGatherId = productGatherId;
                _userId = userId;
                RefreshCrudeProductGatherSource();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherSourceEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherSource.CurrentRow.Cells["ProductGatherSourceId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherSourceAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductGatherSource_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherSource.CurrentRow.Cells["ProductGatherSourceId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherSourceSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherSource();
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
        
        public void RefreshCrudeProductGatherSource() {
            var productGatherSource = new CrudeProductGatherSourceServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherSource.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productGatherSourceTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherSource.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSource.DataSource = bindingSource;
                dataGridViewCrudeProductGatherSource.AutoResizeColumns();
                dataGridViewCrudeProductGatherSource.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherSource.Close();
            }
        }
        
        private void InitializeGridCrudeProductGatherSource() {
            try {
                dataGridViewCrudeProductGatherSource.Columns.Clear();
                dataGridViewCrudeProductGatherSource.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherSourceTypeRcd","Product Gather Source Type");
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherSourceTypeRcd"].DataPropertyName = "ProductGatherSourceTypeRcd";
                dataGridViewCrudeProductGatherSource.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherSource.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherSourceId","Product Gather Source");
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherSourceId"].DataPropertyName = "ProductGatherSourceId";
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherSourceId"].Visible = false;
                dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherId","Product Gather");
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherId"].DataPropertyName = "ProductGatherId";
                dataGridViewCrudeProductGatherSource.Columns["ProductGatherId"].Visible = false;
                dataGridViewCrudeProductGatherSource.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherSource.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherSource.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherSource.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
