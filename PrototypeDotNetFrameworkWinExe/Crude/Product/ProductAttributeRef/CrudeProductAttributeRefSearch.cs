/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:25:48 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductAttributeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductAttributeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttributeRef();
            this.AcceptButton = buttonCrudeProductAttributeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductAttributeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeRef.CurrentRow.Cells["ProductAttributeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductAttributeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeRef.CurrentRow.Cells["ProductAttributeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductAttributeRef();
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
        
        public void RefreshCrudeProductAttributeRef() {
            var productAttributeRef = new CrudeProductAttributeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productAttributeRef.FetchWithFilter(
                             textBoxProductAttribute.Text
                            ,textBoxProductAttributeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductAttributeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeRef.DataSource = bindingSource;
                dataGridViewCrudeProductAttributeRef.AutoResizeColumns();
                dataGridViewCrudeProductAttributeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productAttributeRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductAttributeRef() {
            try {
                dataGridViewCrudeProductAttributeRef.Columns.Clear();
                dataGridViewCrudeProductAttributeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeRef.Columns.Add("ProductAttributeName","Product Attribute Name");
                dataGridViewCrudeProductAttributeRef.Columns["ProductAttributeName"].DataPropertyName = "ProductAttributeName";
                dataGridViewCrudeProductAttributeRef.Columns.Add("ProductAttributeRcd","Product Attribute");
                dataGridViewCrudeProductAttributeRef.Columns["ProductAttributeRcd"].DataPropertyName = "ProductAttributeRcd";
                dataGridViewCrudeProductAttributeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductAttributeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductAttributeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductAttributeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductAttributeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductAttributeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
