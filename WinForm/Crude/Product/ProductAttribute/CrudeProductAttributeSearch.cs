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

    public partial class CrudeProductAttributeSearch : Form {
        
        private string _productAttributeRcd;
        
        private string _productAttributeUnitRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        public CrudeProductAttributeSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttribute();
            this.AcceptButton = buttonCrudeProductAttributeSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productAttributeRcd, string productAttributeUnitRcd, System.Guid productId, System.Guid userId) {
            try {
                _productAttributeRcd = productAttributeRcd;
                _productAttributeUnitRcd = productAttributeUnitRcd;
                _productId = productId;
                _userId = userId;
                RefreshCrudeProductAttribute();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductAttribute_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAttributeSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductAttribute();
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
        
        public void RefreshCrudeProductAttribute() {
            var productAttribute = new CrudeProductAttributeServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productAttribute.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productAttributeRefCombo.Text
                            ,productAttributeUnitRefCombo.Text
                            ,textBoxValue.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductAttribute.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttribute.DataSource = bindingSource;
                dataGridViewCrudeProductAttribute.AutoResizeColumns();
                dataGridViewCrudeProductAttribute.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productAttribute.Close();
            }
        }
        
        private void InitializeGridCrudeProductAttribute() {
            try {
                dataGridViewCrudeProductAttribute.Columns.Clear();
                dataGridViewCrudeProductAttribute.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttribute.Columns.Add("ProductAttributeRcd","Product Attribute");
                dataGridViewCrudeProductAttribute.Columns["ProductAttributeRcd"].DataPropertyName = "ProductAttributeRcd";
                dataGridViewCrudeProductAttribute.Columns.Add("ProductAttributeUnitRcd","Product Attribute Unit");
                dataGridViewCrudeProductAttribute.Columns["ProductAttributeUnitRcd"].DataPropertyName = "ProductAttributeUnitRcd";
                dataGridViewCrudeProductAttribute.Columns.Add("Value","Value");
                dataGridViewCrudeProductAttribute.Columns["Value"].DataPropertyName = "Value";
                dataGridViewCrudeProductAttribute.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductAttribute.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductAttribute.Columns.Add("ProductAttributeId","Product Attribute");
                dataGridViewCrudeProductAttribute.Columns["ProductAttributeId"].DataPropertyName = "ProductAttributeId";
                dataGridViewCrudeProductAttribute.Columns["ProductAttributeId"].Visible = false;
                dataGridViewCrudeProductAttribute.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductAttribute.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductAttribute.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductAttribute.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductAttribute.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductAttribute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductAttribute.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
