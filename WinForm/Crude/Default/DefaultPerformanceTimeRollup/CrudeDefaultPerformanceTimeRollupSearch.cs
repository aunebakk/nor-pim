/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:16:35 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultPerformanceTimeRollupSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultPerformanceTimeRollupSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultPerformanceTimeRollup();
            this.AcceptButton = buttonCrudeDefaultPerformanceTimeRollupSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultPerformanceTimeRollup();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceTimeRollupEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeRollupEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceTimeRollup.CurrentRow.Cells["DefaultPerformanceTimeRollupId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceTimeRollupAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeRollupEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultPerformanceTimeRollup_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeRollupEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceTimeRollup.CurrentRow.Cells["DefaultPerformanceTimeRollupId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceTimeRollupSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultPerformanceTimeRollup();
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
        
        public void RefreshCrudeDefaultPerformanceTimeRollup() {
            var defaultPerformanceTimeRollup = new CrudeDefaultPerformanceTimeRollupServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultPerformanceTimeRollup.FetchWithFilter(
                             Guid.Empty
                            ,textBoxCommandName.Text
                            ,maskedTextBoxMilliseconds.Text == String.Empty ? 0 : Convert.ToInt64(maskedTextBoxMilliseconds.Text)
                            ,maskedTextBoxHits.Text == String.Empty ? 0 : Convert.ToInt64(maskedTextBoxHits.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceTimeRollup.DataSource = bindingSource;
                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoResizeColumns();
                dataGridViewCrudeDefaultPerformanceTimeRollup.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultPerformanceTimeRollup.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultPerformanceTimeRollup() {
            try {
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Clear();
                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("CommandName","Command Name");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["CommandName"].DataPropertyName = "CommandName";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("Milliseconds","Milliseconds");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["Milliseconds"].DataPropertyName = "Milliseconds";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("Hits","Hits");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["Hits"].DataPropertyName = "Hits";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("DefaultPerformanceTimeRollupId","Default Performance Time Rollup");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["DefaultPerformanceTimeRollupId"].DataPropertyName = "DefaultPerformanceTimeRollupId";
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["DefaultPerformanceTimeRollupId"].Visible = false;
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultPerformanceTimeRollup.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultPerformanceTimeRollup.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
