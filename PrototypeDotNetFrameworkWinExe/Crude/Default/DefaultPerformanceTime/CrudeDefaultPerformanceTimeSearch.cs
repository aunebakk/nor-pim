/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:23:57 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultPerformanceTimeSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultPerformanceTimeSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultPerformanceTime();
            this.AcceptButton = buttonCrudeDefaultPerformanceTimeSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultPerformanceTime();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceTimeEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceTime.CurrentRow.Cells["DefaultPerformanceTimeId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceTimeAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultPerformanceTime_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultPerformanceTimeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultPerformanceTime.CurrentRow.Cells["DefaultPerformanceTimeId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultPerformanceTimeSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultPerformanceTime();
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
        
        public void RefreshCrudeDefaultPerformanceTime() {
            var defaultPerformanceTime = new CrudeDefaultPerformanceTimeServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultPerformanceTime.FetchWithFilter(
                             Guid.Empty
                            ,textBoxCommandName.Text
                            ,maskedTextBoxMilliseconds.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMilliseconds.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultPerformanceTime.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceTime.DataSource = bindingSource;
                dataGridViewCrudeDefaultPerformanceTime.AutoResizeColumns();
                dataGridViewCrudeDefaultPerformanceTime.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultPerformanceTime.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultPerformanceTime() {
            try {
                dataGridViewCrudeDefaultPerformanceTime.Columns.Clear();
                dataGridViewCrudeDefaultPerformanceTime.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("CommandName","Command Name");
                dataGridViewCrudeDefaultPerformanceTime.Columns["CommandName"].DataPropertyName = "CommandName";
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("Milliseconds","Milliseconds");
                dataGridViewCrudeDefaultPerformanceTime.Columns["Milliseconds"].DataPropertyName = "Milliseconds";
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultPerformanceTime.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("DefaultPerformanceTimeId","Default Performance Time");
                dataGridViewCrudeDefaultPerformanceTime.Columns["DefaultPerformanceTimeId"].DataPropertyName = "DefaultPerformanceTimeId";
                dataGridViewCrudeDefaultPerformanceTime.Columns["DefaultPerformanceTimeId"].Visible = false;
                dataGridViewCrudeDefaultPerformanceTime.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultPerformanceTime.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultPerformanceTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultPerformanceTime.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
