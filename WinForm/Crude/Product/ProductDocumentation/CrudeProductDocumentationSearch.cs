/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:45:54 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductDocumentationSearch : Form {
        
        private string _productDocumentationTypeRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        public CrudeProductDocumentationSearch() {
            InitializeComponent();
            InitializeGridCrudeProductDocumentation();
            this.AcceptButton = buttonCrudeProductDocumentationSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productDocumentationTypeRcd, System.Guid productId, System.Guid userId) {
            try {
                _productDocumentationTypeRcd = productDocumentationTypeRcd;
                _productId = productId;
                _userId = userId;
                RefreshCrudeProductDocumentation();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductDocumentationEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductDocumentationAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductDocumentation_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductDocumentationEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductDocumentationSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductDocumentation();
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
        
        public void RefreshCrudeProductDocumentation() {
            var productDocumentation = new CrudeProductDocumentationServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productDocumentation.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productDocumentationTypeRefCombo.Text
                            ,textBoxDocumentation.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductDocumentation.AutoGenerateColumns = false;
                dataGridViewCrudeProductDocumentation.DataSource = bindingSource;
                dataGridViewCrudeProductDocumentation.AutoResizeColumns();
                dataGridViewCrudeProductDocumentation.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productDocumentation.Close();
            }
        }
        
        private void InitializeGridCrudeProductDocumentation() {
            try {
                dataGridViewCrudeProductDocumentation.Columns.Clear();
                dataGridViewCrudeProductDocumentation.AutoGenerateColumns = false;
                dataGridViewCrudeProductDocumentation.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
                dataGridViewCrudeProductDocumentation.Columns["ProductDocumentationTypeRcd"].DataPropertyName = "ProductDocumentationTypeRcd";
                dataGridViewCrudeProductDocumentation.Columns.Add("Documentation","Documentation");
                dataGridViewCrudeProductDocumentation.Columns["Documentation"].DataPropertyName = "Documentation";
                dataGridViewCrudeProductDocumentation.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductDocumentation.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductDocumentation.Columns.Add("ProductDocumentationId","Product Documentation");
                dataGridViewCrudeProductDocumentation.Columns["ProductDocumentationId"].DataPropertyName = "ProductDocumentationId";
                dataGridViewCrudeProductDocumentation.Columns["ProductDocumentationId"].Visible = false;
                dataGridViewCrudeProductDocumentation.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductDocumentation.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductDocumentation.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductDocumentation.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductDocumentation.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductDocumentation.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
