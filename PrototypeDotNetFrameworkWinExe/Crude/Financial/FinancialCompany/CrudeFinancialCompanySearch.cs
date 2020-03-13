/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:42:08 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCompanySearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialCompanySearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialCompany();
            this.AcceptButton = buttonCrudeFinancialCompanySearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialCompany();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCompanyEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCompanyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCompany.CurrentRow.Cells["FinancialCompanyId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCompanyAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCompanyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialCompany_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCompanyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCompany.CurrentRow.Cells["FinancialCompanyId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCompanySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialCompany();
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
        
        public void RefreshCrudeFinancialCompany() {
            var financialCompany = new CrudeFinancialCompanyServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialCompany.FetchWithFilter(
                             Guid.Empty
                            ,textBoxFinancialCompanyName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialCompany.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCompany.DataSource = bindingSource;
                dataGridViewCrudeFinancialCompany.AutoResizeColumns();
                dataGridViewCrudeFinancialCompany.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialCompany.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialCompany() {
            try {
                dataGridViewCrudeFinancialCompany.Columns.Clear();
                dataGridViewCrudeFinancialCompany.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCompany.Columns.Add("FinancialCompanyName","Financial Company Name");
                dataGridViewCrudeFinancialCompany.Columns["FinancialCompanyName"].DataPropertyName = "FinancialCompanyName";
                dataGridViewCrudeFinancialCompany.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialCompany.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialCompany.Columns.Add("FinancialCompanyId","Financial Company");
                dataGridViewCrudeFinancialCompany.Columns["FinancialCompanyId"].DataPropertyName = "FinancialCompanyId";
                dataGridViewCrudeFinancialCompany.Columns["FinancialCompanyId"].Visible = false;
                dataGridViewCrudeFinancialCompany.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialCompany.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialCompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialCompany.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
