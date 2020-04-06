/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:26:16 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductExposeSetSearch : Form {
        
        private string _productExposeSetTypeRcd;
        
        private System.Guid _userId;
        
        public CrudeProductExposeSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposeSet();
            this.AcceptButton = buttonCrudeProductExposeSetSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productExposeSetTypeRcd, System.Guid userId) {
            try {
                _productExposeSetTypeRcd = productExposeSetTypeRcd;
                _userId = userId;
                RefreshCrudeProductExposeSet();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposeSetEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposeSet.CurrentRow.Cells["ProductExposeSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposeSetAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductExposeSet_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposeSet.CurrentRow.Cells["ProductExposeSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposeSetSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExposeSet();
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
        
        public void RefreshCrudeProductExposeSet() {
            var productExposeSet = new CrudeProductExposeSetServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExposeSet.FetchWithFilter(
                             Guid.Empty
                            ,productExposeSetTypeRefCombo.Text
                            ,textBoxProductExposeSetName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExposeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSet.DataSource = bindingSource;
                dataGridViewCrudeProductExposeSet.AutoResizeColumns();
                dataGridViewCrudeProductExposeSet.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExposeSet.Close();
            }
        }
        
        private void InitializeGridCrudeProductExposeSet() {
            try {
                dataGridViewCrudeProductExposeSet.Columns.Clear();
                dataGridViewCrudeProductExposeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetName","Product Expose Set Name");
                dataGridViewCrudeProductExposeSet.Columns["ProductExposeSetName"].DataPropertyName = "ProductExposeSetName";
                dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
                dataGridViewCrudeProductExposeSet.Columns["ProductExposeSetTypeRcd"].DataPropertyName = "ProductExposeSetTypeRcd";
                dataGridViewCrudeProductExposeSet.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExposeSet.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetId","Product Expose Set");
                dataGridViewCrudeProductExposeSet.Columns["ProductExposeSetId"].DataPropertyName = "ProductExposeSetId";
                dataGridViewCrudeProductExposeSet.Columns["ProductExposeSetId"].Visible = false;
                dataGridViewCrudeProductExposeSet.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExposeSet.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExposeSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExposeSet.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
