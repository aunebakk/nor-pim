/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:26:05 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductGatherSourceTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherSourceTypeRef();
            this.AcceptButton = buttonCrudeProductGatherSourceTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductGatherSourceTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherSourceTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherSourceTypeRef.CurrentRow.Cells["ProductGatherSourceTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherSourceTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductGatherSourceTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherSourceTypeRef.CurrentRow.Cells["ProductGatherSourceTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherSourceTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherSourceTypeRef();
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
        
        public void RefreshCrudeProductGatherSourceTypeRef() {
            var productGatherSourceTypeRef = new CrudeProductGatherSourceTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherSourceTypeRef.FetchWithFilter(
                             textBoxProductGatherSourceType.Text
                            ,textBoxProductGatherSourceTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherSourceTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSourceTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductGatherSourceTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductGatherSourceTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherSourceTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductGatherSourceTypeRef() {
            try {
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Clear();
                dataGridViewCrudeProductGatherSourceTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ProductGatherSourceTypeName","Product Gather Source Type Name");
                dataGridViewCrudeProductGatherSourceTypeRef.Columns["ProductGatherSourceTypeName"].DataPropertyName = "ProductGatherSourceTypeName";
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ProductGatherSourceTypeRcd","Product Gather Source Type");
                dataGridViewCrudeProductGatherSourceTypeRef.Columns["ProductGatherSourceTypeRcd"].DataPropertyName = "ProductGatherSourceTypeRcd";
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherSourceTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherSourceTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherSourceTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherSourceTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
