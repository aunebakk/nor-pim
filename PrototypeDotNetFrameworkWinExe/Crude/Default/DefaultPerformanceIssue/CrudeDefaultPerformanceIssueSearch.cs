/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:58:27 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultPerformanceIssueSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultPerformanceIssueSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultPerformanceIssue();
            this.AcceptButton = buttonCrudeDefaultPerformanceIssueSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultPerformanceIssue();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceIssueEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceIssue.CurrentRow.Cells["DefaultPerformanceIssueId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceIssueAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultPerformanceIssue_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceIssueEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceIssue.CurrentRow.Cells["DefaultPerformanceIssueId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceIssueSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultPerformanceIssue();
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
        
        public void RefreshCrudeDefaultPerformanceIssue() {
            var defaultPerformanceIssue = new CrudeDefaultPerformanceIssueServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultPerformanceIssue.FetchWithFilter(
                             Guid.Empty
                            ,textBoxCommandName.Text
                            ,textBoxCommandText.Text
                            ,maskedTextBoxMilliseconds.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMilliseconds.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultPerformanceIssue.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceIssue.DataSource = bindingSource;
                dataGridViewCrudeDefaultPerformanceIssue.AutoResizeColumns();
                dataGridViewCrudeDefaultPerformanceIssue.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultPerformanceIssue.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultPerformanceIssue() {
            try {
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Clear();
                dataGridViewCrudeDefaultPerformanceIssue.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("CommandName","Command Name");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["CommandName"].DataPropertyName = "CommandName";
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("CommandText","Command Text");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["CommandText"].DataPropertyName = "CommandText";
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("Milliseconds","Milliseconds");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["Milliseconds"].DataPropertyName = "Milliseconds";
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("DefaultPerformanceIssueId","Default Performance Issue");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["DefaultPerformanceIssueId"].DataPropertyName = "DefaultPerformanceIssueId";
                dataGridViewCrudeDefaultPerformanceIssue.Columns["DefaultPerformanceIssueId"].Visible = false;
                dataGridViewCrudeDefaultPerformanceIssue.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultPerformanceIssue.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultPerformanceIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultPerformanceIssue.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
