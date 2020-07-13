/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 1:46:17 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherAttributeSearch : Form {
        
        private string _productGatherAttributeTypeRcd;
        
        private System.Guid _productGatherKeyId;
        
        private System.Guid _userId;
        
        public CrudeProductGatherAttributeSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherAttribute();
            this.AcceptButton = buttonCrudeProductGatherAttributeSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId) {
            try {
                _productGatherAttributeTypeRcd = productGatherAttributeTypeRcd;
                _productGatherKeyId = productGatherKeyId;
                _userId = userId;
                RefreshCrudeProductGatherAttribute();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherAttributeEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherAttribute.CurrentRow.Cells["ProductGatherAttributeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherAttributeAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductGatherAttribute_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherAttributeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherAttribute.CurrentRow.Cells["ProductGatherAttributeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductGatherAttributeSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherAttribute();
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
        
        public void RefreshCrudeProductGatherAttribute() {
            var productGatherAttribute = new CrudeProductGatherAttributeServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherAttribute.FetchWithFilter(
                             Guid.Empty
                            ,textBoxProductGatherAttributeValue.Text
                            ,productGatherAttributeTypeRefCombo.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherAttribute.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttribute.DataSource = bindingSource;
                dataGridViewCrudeProductGatherAttribute.AutoResizeColumns();
                dataGridViewCrudeProductGatherAttribute.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherAttribute.Close();
            }
        }
        
        private void InitializeGridCrudeProductGatherAttribute() {
            try {
                dataGridViewCrudeProductGatherAttribute.Columns.Clear();
                dataGridViewCrudeProductGatherAttribute.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeValue","Product Gather Attribute Value");
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherAttributeValue"].DataPropertyName = "ProductGatherAttributeValue";
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeTypeRcd","Product Gather Attribute Type");
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherAttributeTypeRcd"].DataPropertyName = "ProductGatherAttributeTypeRcd";
                dataGridViewCrudeProductGatherAttribute.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherAttribute.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeId","Product Gather Attribute");
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherAttributeId"].DataPropertyName = "ProductGatherAttributeId";
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherAttributeId"].Visible = false;
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherKeyId","Product Gather Key");
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherKeyId"].DataPropertyName = "ProductGatherKeyId";
                dataGridViewCrudeProductGatherAttribute.Columns["ProductGatherKeyId"].Visible = false;
                dataGridViewCrudeProductGatherAttribute.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherAttribute.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherAttribute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherAttribute.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
