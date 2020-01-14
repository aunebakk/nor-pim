/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:44:04 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialTaxTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialTaxTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialTaxTypeRef();
            this.AcceptButton = buttonCrudeFinancialTaxTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialTaxTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialTaxTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialTaxTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialTaxTypeRef.CurrentRow.Cells["FinancialTaxTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialTaxTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialTaxTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialTaxTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialTaxTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialTaxTypeRef.CurrentRow.Cells["FinancialTaxTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialTaxTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialTaxTypeRef();
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
        
        public void RefreshCrudeFinancialTaxTypeRef() {
            var financialTaxTypeRef = new CrudeFinancialTaxTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialTaxTypeRef.FetchWithFilter(
                             textBoxFinancialTaxTypeName.Text
                            ,textBoxFinancialTaxType.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialTaxTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialTaxTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialTaxTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialTaxTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialTaxTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialTaxTypeRef() {
            try {
                dataGridViewCrudeFinancialTaxTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialTaxTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialTaxTypeRef.Columns.Add("FinancialTaxTypeName","Financial Tax Type Name");
                dataGridViewCrudeFinancialTaxTypeRef.Columns["FinancialTaxTypeName"].DataPropertyName = "FinancialTaxTypeName";
                dataGridViewCrudeFinancialTaxTypeRef.Columns.Add("FinancialTaxTypeRcd","Financial Tax Type");
                dataGridViewCrudeFinancialTaxTypeRef.Columns["FinancialTaxTypeRcd"].DataPropertyName = "FinancialTaxTypeRcd";
                dataGridViewCrudeFinancialTaxTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialTaxTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialTaxTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialTaxTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialTaxTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialTaxTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
