/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:20:15 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialAdjustmentTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialAdjustmentTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialAdjustmentTypeRef();
            this.AcceptButton = buttonCrudeFinancialAdjustmentTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialAdjustmentTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialAdjustmentTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialAdjustmentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialAdjustmentTypeRef.CurrentRow.Cells["FinancialAdjustmentTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialAdjustmentTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialAdjustmentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialAdjustmentTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialAdjustmentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialAdjustmentTypeRef.CurrentRow.Cells["FinancialAdjustmentTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialAdjustmentTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialAdjustmentTypeRef();
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
        
        public void RefreshCrudeFinancialAdjustmentTypeRef() {
            var financialAdjustmentTypeRef = new CrudeFinancialAdjustmentTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialAdjustmentTypeRef.FetchWithFilter(
                             textBoxFinancialAdjustmentType.Text
                            ,textBoxFinancialAdjustmentTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialAdjustmentTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialAdjustmentTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialAdjustmentTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialAdjustmentTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialAdjustmentTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialAdjustmentTypeRef() {
            try {
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialAdjustmentTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns.Add("FinancialAdjustmentTypeName","Financial Adjustment Type Name");
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns["FinancialAdjustmentTypeName"].DataPropertyName = "FinancialAdjustmentTypeName";
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns.Add("FinancialAdjustmentTypeRcd","Financial Adjustment Type");
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns["FinancialAdjustmentTypeRcd"].DataPropertyName = "FinancialAdjustmentTypeRcd";
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialAdjustmentTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialAdjustmentTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialAdjustmentTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
