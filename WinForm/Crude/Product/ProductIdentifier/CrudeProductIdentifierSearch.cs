/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:07:08 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductIdentifierSearch : Form {
        
        private string _productIdentifierRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        public CrudeProductIdentifierSearch() {
            InitializeComponent();
            InitializeGridCrudeProductIdentifier();
            this.AcceptButton = buttonCrudeProductIdentifierSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string productIdentifierRcd, System.Guid productId, System.Guid userId) {
            try {
                _productIdentifierRcd = productIdentifierRcd;
                _productId = productId;
                _userId = userId;
                RefreshCrudeProductIdentifier();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductIdentifierEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductIdentifierAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductIdentifier_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductIdentifierSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductIdentifier();
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
        
        public void RefreshCrudeProductIdentifier() {
            var productIdentifier = new CrudeProductIdentifierServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productIdentifier.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productIdentifierRefCombo.Text
                            ,textBoxIdentifier.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifier.DataSource = bindingSource;
                dataGridViewCrudeProductIdentifier.AutoResizeColumns();
                dataGridViewCrudeProductIdentifier.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productIdentifier.Close();
            }
        }
        
        private void InitializeGridCrudeProductIdentifier() {
            try {
                dataGridViewCrudeProductIdentifier.Columns.Clear();
                dataGridViewCrudeProductIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifier.Columns.Add("ProductIdentifierRcd","Product Identifier");
                dataGridViewCrudeProductIdentifier.Columns["ProductIdentifierRcd"].DataPropertyName = "ProductIdentifierRcd";
                dataGridViewCrudeProductIdentifier.Columns.Add("Identifier","Identifier");
                dataGridViewCrudeProductIdentifier.Columns["Identifier"].DataPropertyName = "Identifier";
                dataGridViewCrudeProductIdentifier.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductIdentifier.Columns.Add("ProductIdentifierId","Product Identifier");
                dataGridViewCrudeProductIdentifier.Columns["ProductIdentifierId"].DataPropertyName = "ProductIdentifierId";
                dataGridViewCrudeProductIdentifier.Columns["ProductIdentifierId"].Visible = false;
                dataGridViewCrudeProductIdentifier.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductIdentifier.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductIdentifier.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductIdentifier.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductIdentifier.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
