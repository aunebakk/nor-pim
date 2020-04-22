/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:52:39 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderIdentifierSearch : Form {
        
        private string _financialOrderIdentifierTypeRcd;
        
        private System.Guid _financialOrderId;
        
        private System.Guid _userId;
        
        public CrudeFinancialOrderIdentifierSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrderIdentifier();
            this.AcceptButton = buttonCrudeFinancialOrderIdentifierSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialOrderIdentifierTypeRcd, System.Guid financialOrderId, System.Guid userId) {
            try {
                _financialOrderIdentifierTypeRcd = financialOrderIdentifierTypeRcd;
                _financialOrderId = financialOrderId;
                _userId = userId;
                RefreshCrudeFinancialOrderIdentifier();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderIdentifierEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrderIdentifier.CurrentRow.Cells["FinancialOrderIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderIdentifierAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialOrderIdentifier_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrderIdentifier.CurrentRow.Cells["FinancialOrderIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderIdentifierSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrderIdentifier();
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
        
        public void RefreshCrudeFinancialOrderIdentifier() {
            var financialOrderIdentifier = new CrudeFinancialOrderIdentifierServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrderIdentifier.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,financialOrderIdentifierTypeRefCombo.Text
                            ,textBoxFinancialOrderIdentifierCode.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialOrderIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderIdentifier.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrderIdentifier.AutoResizeColumns();
                dataGridViewCrudeFinancialOrderIdentifier.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrderIdentifier.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialOrderIdentifier() {
            try {
                dataGridViewCrudeFinancialOrderIdentifier.Columns.Clear();
                dataGridViewCrudeFinancialOrderIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderIdentifier.Columns.Add("FinancialOrderIdentifierTypeRcd","Financial Order Identifier Type");
                dataGridViewCrudeFinancialOrderIdentifier.Columns["FinancialOrderIdentifierTypeRcd"].DataPropertyName = "FinancialOrderIdentifierTypeRcd";
                dataGridViewCrudeFinancialOrderIdentifier.Columns.Add("FinancialOrderIdentifierCode","Financial Order Identifier Code");
                dataGridViewCrudeFinancialOrderIdentifier.Columns["FinancialOrderIdentifierCode"].DataPropertyName = "FinancialOrderIdentifierCode";
                dataGridViewCrudeFinancialOrderIdentifier.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrderIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrderIdentifier.Columns.Add("FinancialOrderIdentifierId","Financial Order Identifier");
                dataGridViewCrudeFinancialOrderIdentifier.Columns["FinancialOrderIdentifierId"].DataPropertyName = "FinancialOrderIdentifierId";
                dataGridViewCrudeFinancialOrderIdentifier.Columns["FinancialOrderIdentifierId"].Visible = false;
                dataGridViewCrudeFinancialOrderIdentifier.Columns.Add("FinancialOrderId","Financial Order");
                dataGridViewCrudeFinancialOrderIdentifier.Columns["FinancialOrderId"].DataPropertyName = "FinancialOrderId";
                dataGridViewCrudeFinancialOrderIdentifier.Columns["FinancialOrderId"].Visible = false;
                dataGridViewCrudeFinancialOrderIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrderIdentifier.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrderIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrderIdentifier.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
