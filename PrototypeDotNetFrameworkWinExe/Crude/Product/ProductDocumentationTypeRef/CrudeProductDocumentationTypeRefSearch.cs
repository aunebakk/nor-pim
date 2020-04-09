/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:22:23 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductDocumentationTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductDocumentationTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductDocumentationTypeRef();
            this.AcceptButton = buttonCrudeProductDocumentationTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductDocumentationTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductDocumentationTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductDocumentationTypeRef.CurrentRow.Cells["ProductDocumentationTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductDocumentationTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductDocumentationTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductDocumentationTypeRef.CurrentRow.Cells["ProductDocumentationTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductDocumentationTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductDocumentationTypeRef();
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
        
        public void RefreshCrudeProductDocumentationTypeRef() {
            var productDocumentationTypeRef = new CrudeProductDocumentationTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productDocumentationTypeRef.FetchWithFilter(
                             textBoxProductDocumentationType.Text
                            ,textBoxProductDocumentationTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductDocumentationTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductDocumentationTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductDocumentationTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productDocumentationTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductDocumentationTypeRef() {
            try {
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Clear();
                dataGridViewCrudeProductDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ProductDocumentationTypeName","Product Documentation Type Name");
                dataGridViewCrudeProductDocumentationTypeRef.Columns["ProductDocumentationTypeName"].DataPropertyName = "ProductDocumentationTypeName";
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
                dataGridViewCrudeProductDocumentationTypeRef.Columns["ProductDocumentationTypeRcd"].DataPropertyName = "ProductDocumentationTypeRcd";
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductDocumentationTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductDocumentationTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductDocumentationTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductDocumentationTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
