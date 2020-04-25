/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:25 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategoryImageTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductCategoryImageTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryImageTypeRef();
            this.AcceptButton = buttonCrudeProductCategoryImageTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductCategoryImageTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryImageTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryImageTypeRef.CurrentRow.Cells["ProductCategoryImageTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryImageTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductCategoryImageTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductCategoryImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryImageTypeRef.CurrentRow.Cells["ProductCategoryImageTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductCategoryImageTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductCategoryImageTypeRef();
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
        
        public void RefreshCrudeProductCategoryImageTypeRef() {
            var productCategoryImageTypeRef = new CrudeProductCategoryImageTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productCategoryImageTypeRef.FetchWithFilter(
                             textBoxProductCategoryImageType.Text
                            ,textBoxProductCategoryImageTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductCategoryImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryImageTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryImageTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductCategoryImageTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productCategoryImageTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductCategoryImageTypeRef() {
            try {
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Clear();
                dataGridViewCrudeProductCategoryImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ProductCategoryImageTypeName","Product Category Image Type Name");
                dataGridViewCrudeProductCategoryImageTypeRef.Columns["ProductCategoryImageTypeName"].DataPropertyName = "ProductCategoryImageTypeName";
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ProductCategoryImageTypeRcd","Product Category Image Type");
                dataGridViewCrudeProductCategoryImageTypeRef.Columns["ProductCategoryImageTypeRcd"].DataPropertyName = "ProductCategoryImageTypeRcd";
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductCategoryImageTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductCategoryImageTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductCategoryImageTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductCategoryImageTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
