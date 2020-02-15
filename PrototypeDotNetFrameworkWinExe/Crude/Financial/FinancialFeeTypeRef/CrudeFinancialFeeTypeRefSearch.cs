/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:40:26 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialFeeTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialFeeTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialFeeTypeRef();
            this.AcceptButton = buttonCrudeFinancialFeeTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialFeeTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialFeeTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialFeeTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialFeeTypeRef.CurrentRow.Cells["FinancialFeeTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialFeeTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialFeeTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialFeeTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialFeeTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialFeeTypeRef.CurrentRow.Cells["FinancialFeeTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialFeeTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialFeeTypeRef();
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
        
        public void RefreshCrudeFinancialFeeTypeRef() {
            var financialFeeTypeRef = new CrudeFinancialFeeTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialFeeTypeRef.FetchWithFilter(
                             textBoxFinancialFeeType.Text
                            ,textBoxFinancialFeeTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialFeeTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialFeeTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialFeeTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialFeeTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialFeeTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialFeeTypeRef() {
            try {
                dataGridViewCrudeFinancialFeeTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialFeeTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialFeeTypeRef.Columns.Add("FinancialFeeTypeName","Financial Fee Type Name");
                dataGridViewCrudeFinancialFeeTypeRef.Columns["FinancialFeeTypeName"].DataPropertyName = "FinancialFeeTypeName";
                dataGridViewCrudeFinancialFeeTypeRef.Columns.Add("FinancialFeeTypeRcd","Financial Fee Type");
                dataGridViewCrudeFinancialFeeTypeRef.Columns["FinancialFeeTypeRcd"].DataPropertyName = "FinancialFeeTypeRcd";
                dataGridViewCrudeFinancialFeeTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialFeeTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialFeeTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialFeeTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialFeeTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialFeeTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
