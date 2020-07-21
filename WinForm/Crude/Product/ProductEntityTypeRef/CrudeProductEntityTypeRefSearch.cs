/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:16:36 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductEntityTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductEntityTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductEntityTypeRef();
            this.AcceptButton = buttonCrudeProductEntityTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductEntityTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductEntityTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEntityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductEntityTypeRef.CurrentRow.Cells["ProductEntityTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductEntityTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEntityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductEntityTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEntityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductEntityTypeRef.CurrentRow.Cells["ProductEntityTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductEntityTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductEntityTypeRef();
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
        
        public void RefreshCrudeProductEntityTypeRef() {
            var productEntityTypeRef = new CrudeProductEntityTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productEntityTypeRef.FetchWithFilter(
                             textBoxProductEntityType.Text
                            ,textBoxProductEntityTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductEntityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductEntityTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductEntityTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductEntityTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productEntityTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductEntityTypeRef() {
            try {
                dataGridViewCrudeProductEntityTypeRef.Columns.Clear();
                dataGridViewCrudeProductEntityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductEntityTypeRef.Columns.Add("ProductEntityTypeName","Product Entity Type Name");
                dataGridViewCrudeProductEntityTypeRef.Columns["ProductEntityTypeName"].DataPropertyName = "ProductEntityTypeName";
                dataGridViewCrudeProductEntityTypeRef.Columns.Add("ProductEntityTypeRcd","Product Entity Type");
                dataGridViewCrudeProductEntityTypeRef.Columns["ProductEntityTypeRcd"].DataPropertyName = "ProductEntityTypeRcd";
                dataGridViewCrudeProductEntityTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductEntityTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductEntityTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductEntityTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductEntityTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductEntityTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
