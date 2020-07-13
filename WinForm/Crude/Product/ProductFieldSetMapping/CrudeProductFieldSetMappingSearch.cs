/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:53:32 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductFieldSetMappingSearch : Form {
        
        private string _productIdentifierRcd;
        
        private string _productAttributeRcd;
        
        private string _productInfoRcd;
        
        private string _productImageTypeRcd;
        
        private string _productDocumentationTypeRcd;
        
        private System.Guid _productFieldSetId;
        
        private System.Guid _userId;
        
        public CrudeProductFieldSetMappingSearch() {
            InitializeComponent();
            InitializeGridCrudeProductFieldSetMapping();
            this.AcceptButton = buttonCrudeProductFieldSetMappingSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid productFieldSetId, System.Guid userId) {
            try {
                _productIdentifierRcd = productIdentifierRcd;
                _productAttributeRcd = productAttributeRcd;
                _productInfoRcd = productInfoRcd;
                _productImageTypeRcd = productImageTypeRcd;
                _productDocumentationTypeRcd = productDocumentationTypeRcd;
                _productFieldSetId = productFieldSetId;
                _userId = userId;
                RefreshCrudeProductFieldSetMapping();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductFieldSetMappingEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetMappingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSetMapping.CurrentRow.Cells["ProductFieldSetMappingId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductFieldSetMappingAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetMappingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductFieldSetMapping_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetMappingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSetMapping.CurrentRow.Cells["ProductFieldSetMappingId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductFieldSetMappingSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductFieldSetMapping();
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
        
        public void RefreshCrudeProductFieldSetMapping() {
            var productFieldSetMapping = new CrudeProductFieldSetMappingServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productFieldSetMapping.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productIdentifierRefCombo.Text
                            ,productAttributeRefCombo.Text
                            ,productInfoRefCombo.Text
                            ,productImageTypeRefCombo.Text
                            ,productDocumentationTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductFieldSetMapping.AutoGenerateColumns = false;
                dataGridViewCrudeProductFieldSetMapping.DataSource = bindingSource;
                dataGridViewCrudeProductFieldSetMapping.AutoResizeColumns();
                dataGridViewCrudeProductFieldSetMapping.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productFieldSetMapping.Close();
            }
        }
        
        private void InitializeGridCrudeProductFieldSetMapping() {
            try {
                dataGridViewCrudeProductFieldSetMapping.Columns.Clear();
                dataGridViewCrudeProductFieldSetMapping.AutoGenerateColumns = false;
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductIdentifierRcd","Product Identifier");
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductIdentifierRcd"].DataPropertyName = "ProductIdentifierRcd";
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductAttributeRcd","Product Attribute");
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductAttributeRcd"].DataPropertyName = "ProductAttributeRcd";
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductInfoRcd","Product Info");
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductInfoRcd"].DataPropertyName = "ProductInfoRcd";
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductImageTypeRcd","Product Image Type");
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductImageTypeRcd"].DataPropertyName = "ProductImageTypeRcd";
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductDocumentationTypeRcd"].DataPropertyName = "ProductDocumentationTypeRcd";
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductFieldSetMapping.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductFieldSetMappingId","Product Field Set Mapping");
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductFieldSetMappingId"].DataPropertyName = "ProductFieldSetMappingId";
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductFieldSetMappingId"].Visible = false;
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductFieldSetId","Product Field Set");
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductFieldSetId"].DataPropertyName = "ProductFieldSetId";
                dataGridViewCrudeProductFieldSetMapping.Columns["ProductFieldSetId"].Visible = false;
                dataGridViewCrudeProductFieldSetMapping.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductFieldSetMapping.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductFieldSetMapping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductFieldSetMapping.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
