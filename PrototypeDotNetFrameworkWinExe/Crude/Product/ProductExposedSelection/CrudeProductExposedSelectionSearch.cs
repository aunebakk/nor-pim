/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:23 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductExposedSelectionSearch : Form {
        
        private System.Guid _productExposeId;
        
        private System.Guid _userId;
        
        public CrudeProductExposedSelectionSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposedSelection();
            this.AcceptButton = buttonCrudeProductExposedSelectionSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid productExposeId, System.Guid userId) {
            try {
                _productExposeId = productExposeId;
                _userId = userId;
                RefreshCrudeProductExposedSelection();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposedSelectionEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposedSelectionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposedSelection.CurrentRow.Cells["ProductExposedSelectionId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposedSelectionAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposedSelectionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductExposedSelection_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposedSelectionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposedSelection.CurrentRow.Cells["ProductExposedSelectionId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposedSelectionSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExposedSelection();
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
        
        public void RefreshCrudeProductExposedSelection() {
            var productExposedSelection = new CrudeProductExposedSelectionServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExposedSelection.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExposedSelection.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposedSelection.DataSource = bindingSource;
                dataGridViewCrudeProductExposedSelection.AutoResizeColumns();
                dataGridViewCrudeProductExposedSelection.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExposedSelection.Close();
            }
        }
        
        private void InitializeGridCrudeProductExposedSelection() {
            try {
                dataGridViewCrudeProductExposedSelection.Columns.Clear();
                dataGridViewCrudeProductExposedSelection.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposedSelection.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExposedSelection.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExposedSelection.Columns.Add("ProductExposedSelectionId","Product Exposed Selection");
                dataGridViewCrudeProductExposedSelection.Columns["ProductExposedSelectionId"].DataPropertyName = "ProductExposedSelectionId";
                dataGridViewCrudeProductExposedSelection.Columns["ProductExposedSelectionId"].Visible = false;
                dataGridViewCrudeProductExposedSelection.Columns.Add("ProductExposeId","Product Expose");
                dataGridViewCrudeProductExposedSelection.Columns["ProductExposeId"].DataPropertyName = "ProductExposeId";
                dataGridViewCrudeProductExposedSelection.Columns["ProductExposeId"].Visible = false;
                dataGridViewCrudeProductExposedSelection.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExposedSelection.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExposedSelection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExposedSelection.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
