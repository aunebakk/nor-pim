/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:20 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialBankAccountNumberTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialBankAccountNumberTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialBankAccountNumberTypeRef();
            this.AcceptButton = buttonCrudeFinancialBankAccountNumberTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialBankAccountNumberTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialBankAccountNumberTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialBankAccountNumberTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialBankAccountNumberTypeRef.CurrentRow.Cells["FinancialBankAccountNumberTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialBankAccountNumberTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialBankAccountNumberTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialBankAccountNumberTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialBankAccountNumberTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialBankAccountNumberTypeRef.CurrentRow.Cells["FinancialBankAccountNumberTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialBankAccountNumberTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialBankAccountNumberTypeRef();
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
        
        public void RefreshCrudeFinancialBankAccountNumberTypeRef() {
            var financialBankAccountNumberTypeRef = new CrudeFinancialBankAccountNumberTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialBankAccountNumberTypeRef.FetchWithFilter(
                             textBoxFinancialBankAccountNumberType.Text
                            ,textBoxFinancialBankAccountNumberTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialBankAccountNumberTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialBankAccountNumberTypeRef() {
            try {
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns.Add("FinancialBankAccountNumberTypeName","Financial Bank Account Number Type Name");
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns["FinancialBankAccountNumberTypeName"].DataPropertyName = "FinancialBankAccountNumberTypeName";
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns.Add("FinancialBankAccountNumberTypeRcd","Financial Bank Account Number Type");
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns["FinancialBankAccountNumberTypeRcd"].DataPropertyName = "FinancialBankAccountNumberTypeRcd";
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialBankAccountNumberTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialBankAccountNumberTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
