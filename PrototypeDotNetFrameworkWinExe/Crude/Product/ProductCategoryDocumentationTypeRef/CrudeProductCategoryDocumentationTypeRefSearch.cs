/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:20:17 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategoryDocumentationTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductCategoryDocumentationTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryDocumentationTypeRef();
            this.AcceptButton = buttonCrudeProductCategoryDocumentationTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductCategoryDocumentationTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryDocumentationTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryDocumentationTypeRef.CurrentRow.Cells["ProductCategoryDocumentationTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryDocumentationTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductCategoryDocumentationTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryDocumentationTypeRef.CurrentRow.Cells["ProductCategoryDocumentationTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryDocumentationTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategoryDocumentationTypeRef();
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
        
        public void RefreshCrudeProductCategoryDocumentationTypeRef() {
            var productCategoryDocumentationTypeRef = new CrudeProductCategoryDocumentationTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategoryDocumentationTypeRef.FetchWithFilter(
                             textBoxProductCategoryDocumentationType.Text
                            ,textBoxProductCategoryDocumentationTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategoryDocumentationTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductCategoryDocumentationTypeRef() {
            try {
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Clear();
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ProductCategoryDocumentationTypeName","Product Category Documentation Type Name");
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["ProductCategoryDocumentationTypeName"].DataPropertyName = "ProductCategoryDocumentationTypeName";
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ProductCategoryDocumentationTypeRcd","Product Category Documentation Type");
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["ProductCategoryDocumentationTypeRcd"].DataPropertyName = "ProductCategoryDocumentationTypeRcd";
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
