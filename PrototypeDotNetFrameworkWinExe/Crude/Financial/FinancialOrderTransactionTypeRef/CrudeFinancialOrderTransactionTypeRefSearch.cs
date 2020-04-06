/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:37:55 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderTransactionTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialOrderTransactionTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrderTransactionTypeRef();
            this.AcceptButton = buttonCrudeFinancialOrderTransactionTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialOrderTransactionTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderTransactionTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderTransactionTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialOrderTransactionTypeRef.CurrentRow.Cells["FinancialOrderTransactionTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderTransactionTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderTransactionTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialOrderTransactionTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderTransactionTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialOrderTransactionTypeRef.CurrentRow.Cells["FinancialOrderTransactionTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderTransactionTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrderTransactionTypeRef();
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
        
        public void RefreshCrudeFinancialOrderTransactionTypeRef() {
            var financialOrderTransactionTypeRef = new CrudeFinancialOrderTransactionTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrderTransactionTypeRef.FetchWithFilter(
                             textBoxFinancialOrderTransactionType.Text
                            ,textBoxFinancialOrderTransactionTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialOrderTransactionTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderTransactionTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrderTransactionTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrderTransactionTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialOrderTransactionTypeRef() {
            try {
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialOrderTransactionTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns.Add("FinancialOrderTransactionTypeName","Financial Order Transaction Type Name");
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns["FinancialOrderTransactionTypeName"].DataPropertyName = "FinancialOrderTransactionTypeName";
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns.Add("FinancialOrderTransactionTypeRcd","Financial Order Transaction Type");
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns["FinancialOrderTransactionTypeRcd"].DataPropertyName = "FinancialOrderTransactionTypeRcd";
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrderTransactionTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrderTransactionTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrderTransactionTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
