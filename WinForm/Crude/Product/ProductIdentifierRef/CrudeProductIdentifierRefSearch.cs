/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:32 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductIdentifierRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductIdentifierRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductIdentifierRef();
            this.AcceptButton = buttonCrudeProductIdentifierRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductIdentifierRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductIdentifierRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductIdentifierRef.CurrentRow.Cells["ProductIdentifierRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductIdentifierRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductIdentifierRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductIdentifierRef.CurrentRow.Cells["ProductIdentifierRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductIdentifierRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductIdentifierRef();
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
        
        public void RefreshCrudeProductIdentifierRef() {
            var productIdentifierRef = new CrudeProductIdentifierRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productIdentifierRef.FetchWithFilter(
                             textBoxProductIdentifier.Text
                            ,textBoxProductIdentifierName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductIdentifierRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifierRef.DataSource = bindingSource;
                dataGridViewCrudeProductIdentifierRef.AutoResizeColumns();
                dataGridViewCrudeProductIdentifierRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productIdentifierRef.Close();
            }
        }
        
        private void InitializeGridCrudeProductIdentifierRef() {
            try {
                dataGridViewCrudeProductIdentifierRef.Columns.Clear();
                dataGridViewCrudeProductIdentifierRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifierRef.Columns.Add("ProductIdentifierName","Product Identifier Name");
                dataGridViewCrudeProductIdentifierRef.Columns["ProductIdentifierName"].DataPropertyName = "ProductIdentifierName";
                dataGridViewCrudeProductIdentifierRef.Columns.Add("ProductIdentifierRcd","Product Identifier");
                dataGridViewCrudeProductIdentifierRef.Columns["ProductIdentifierRcd"].DataPropertyName = "ProductIdentifierRcd";
                dataGridViewCrudeProductIdentifierRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductIdentifierRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductIdentifierRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductIdentifierRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductIdentifierRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductIdentifierRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
