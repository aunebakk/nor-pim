/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:41:22 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductExposeSetTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductExposeSetTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposeSetTypeRef();
            this.AcceptButton = buttonCrudeProductExposeSetTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductExposeSetTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposeSetTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductExposeSetTypeRef.CurrentRow.Cells["ProductExposeSetTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposeSetTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductExposeSetTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductExposeSetTypeRef.CurrentRow.Cells["ProductExposeSetTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductExposeSetTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExposeSetTypeRef();
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
        
        public void RefreshCrudeProductExposeSetTypeRef() {
            var productExposeSetTypeRef = new CrudeProductExposeSetTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExposeSetTypeRef.FetchWithFilter(
                             textBoxProductExposeSetType.Text
                            ,textBoxProductExposeSetTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExposeSetTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSetTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductExposeSetTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductExposeSetTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExposeSetTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductExposeSetTypeRef() {
            try {
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Clear();
                dataGridViewCrudeProductExposeSetTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ProductExposeSetTypeName","Product Expose Set Type Name");
                dataGridViewCrudeProductExposeSetTypeRef.Columns["ProductExposeSetTypeName"].DataPropertyName = "ProductExposeSetTypeName";
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
                dataGridViewCrudeProductExposeSetTypeRef.Columns["ProductExposeSetTypeRcd"].DataPropertyName = "ProductExposeSetTypeRcd";
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExposeSetTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExposeSetTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExposeSetTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExposeSetTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
