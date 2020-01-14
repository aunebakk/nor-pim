/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:25:25 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCostcentreSearch : Form {
        
        private System.Guid _financialCompanyId;
        
        private System.Guid _userId;
        
        public CrudeFinancialCostcentreSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialCostcentre();
            this.AcceptButton = buttonCrudeFinancialCostcentreSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid financialCompanyId, System.Guid userId) {
            try {
                _financialCompanyId = financialCompanyId;
                _userId = userId;
                RefreshCrudeFinancialCostcentre();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCostcentreEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCostcentreEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCostcentre.CurrentRow.Cells["FinancialCostcentreId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCostcentreAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCostcentreEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialCostcentre_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCostcentreEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCostcentre.CurrentRow.Cells["FinancialCostcentreId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCostcentreSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialCostcentre();
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
        
        public void RefreshCrudeFinancialCostcentre() {
            var financialCostcentre = new CrudeFinancialCostcentreServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialCostcentre.FetchWithFilter(
                             Guid.Empty
                            ,textBoxFinancialCostcentreName.Text
                            ,textBoxFinancialCostcentreCode.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialCostcentre.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCostcentre.DataSource = bindingSource;
                dataGridViewCrudeFinancialCostcentre.AutoResizeColumns();
                dataGridViewCrudeFinancialCostcentre.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialCostcentre.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialCostcentre() {
            try {
                dataGridViewCrudeFinancialCostcentre.Columns.Clear();
                dataGridViewCrudeFinancialCostcentre.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCostcentre.Columns.Add("FinancialCostcentreName","Financial Costcentre Name");
                dataGridViewCrudeFinancialCostcentre.Columns["FinancialCostcentreName"].DataPropertyName = "FinancialCostcentreName";
                dataGridViewCrudeFinancialCostcentre.Columns.Add("FinancialCostcentreCode","Financial Costcentre Code");
                dataGridViewCrudeFinancialCostcentre.Columns["FinancialCostcentreCode"].DataPropertyName = "FinancialCostcentreCode";
                dataGridViewCrudeFinancialCostcentre.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialCostcentre.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialCostcentre.Columns.Add("FinancialCostcentreId","Financial Costcentre");
                dataGridViewCrudeFinancialCostcentre.Columns["FinancialCostcentreId"].DataPropertyName = "FinancialCostcentreId";
                dataGridViewCrudeFinancialCostcentre.Columns["FinancialCostcentreId"].Visible = false;
                dataGridViewCrudeFinancialCostcentre.Columns.Add("FinancialCompanyId","Financial Company");
                dataGridViewCrudeFinancialCostcentre.Columns["FinancialCompanyId"].DataPropertyName = "FinancialCompanyId";
                dataGridViewCrudeFinancialCostcentre.Columns["FinancialCompanyId"].Visible = false;
                dataGridViewCrudeFinancialCostcentre.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialCostcentre.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialCostcentre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialCostcentre.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
