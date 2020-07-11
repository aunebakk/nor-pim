/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:41:41 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductImageTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductImageTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductImageTypeRef();
            this.AcceptButton = buttonCrudeProductImageTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductImageTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductImageTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductImageTypeRef.CurrentRow.Cells["ProductImageTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductImageTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductImageTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductImageTypeRef.CurrentRow.Cells["ProductImageTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductImageTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductImageTypeRef();
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
        
        public void RefreshCrudeProductImageTypeRef() {
            var productImageTypeRef = new CrudeProductImageTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productImageTypeRef.FetchWithFilter(
                             textBoxProductImageType.Text
                            ,textBoxProductImageTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductImageTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductImageTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductImageTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productImageTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductImageTypeRef() {
            try {
                dataGridViewCrudeProductImageTypeRef.Columns.Clear();
                dataGridViewCrudeProductImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductImageTypeRef.Columns.Add("ProductImageTypeName","Product Image Type Name");
                dataGridViewCrudeProductImageTypeRef.Columns["ProductImageTypeName"].DataPropertyName = "ProductImageTypeName";
                dataGridViewCrudeProductImageTypeRef.Columns.Add("ProductImageTypeRcd","Product Image Type");
                dataGridViewCrudeProductImageTypeRef.Columns["ProductImageTypeRcd"].DataPropertyName = "ProductImageTypeRcd";
                dataGridViewCrudeProductImageTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductImageTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductImageTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductImageTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductImageTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductImageTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
