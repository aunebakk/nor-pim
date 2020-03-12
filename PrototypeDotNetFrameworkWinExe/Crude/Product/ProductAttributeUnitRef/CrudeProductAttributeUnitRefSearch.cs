/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:40:48 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductAttributeUnitRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductAttributeUnitRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttributeUnitRef();
            this.AcceptButton = buttonCrudeProductAttributeUnitRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductAttributeUnitRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeUnitRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeUnitRef.CurrentRow.Cells["ProductAttributeUnitRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeUnitRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductAttributeUnitRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeUnitRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeUnitRef.CurrentRow.Cells["ProductAttributeUnitRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeUnitRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductAttributeUnitRef();
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
        
        public void RefreshCrudeProductAttributeUnitRef() {
            var productAttributeUnitRef = new CrudeProductAttributeUnitRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productAttributeUnitRef.FetchWithFilter(
                             textBoxProductAttributeUnit.Text
                            ,textBoxProductAttributeUnitName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductAttributeUnitRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeUnitRef.DataSource = bindingSource;
                dataGridViewCrudeProductAttributeUnitRef.AutoResizeColumns();
                dataGridViewCrudeProductAttributeUnitRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productAttributeUnitRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductAttributeUnitRef() {
            try {
                dataGridViewCrudeProductAttributeUnitRef.Columns.Clear();
                dataGridViewCrudeProductAttributeUnitRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ProductAttributeUnitName","Product Attribute Unit Name");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ProductAttributeUnitName"].DataPropertyName = "ProductAttributeUnitName";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ProductAttributeUnitRcd","Product Attribute Unit");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ProductAttributeUnitRcd"].DataPropertyName = "ProductAttributeUnitRcd";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductAttributeUnitRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductAttributeUnitRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductAttributeUnitRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductAttributeUnitRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
