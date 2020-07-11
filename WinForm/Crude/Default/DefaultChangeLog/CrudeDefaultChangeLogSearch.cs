/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:26:05 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultChangeLogSearch : Form {
        
        private string _defaultChangeLogTypeRcd;
        
        private System.Guid _defaultUserId;
        
        private System.Guid _defaultIssueId;
        
        public CrudeDefaultChangeLogSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultChangeLog();
            this.AcceptButton = buttonCrudeDefaultChangeLogSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string defaultChangeLogTypeRcd, System.Guid defaultUserId, System.Guid defaultIssueId) {
            try {
                _defaultChangeLogTypeRcd = defaultChangeLogTypeRcd;
                _defaultUserId = defaultUserId;
                _defaultIssueId = defaultIssueId;
                RefreshCrudeDefaultChangeLog();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultChangeLogEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultChangeLog.CurrentRow.Cells["DefaultChangeLogId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultChangeLogAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultChangeLog_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultChangeLog.CurrentRow.Cells["DefaultChangeLogId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultChangeLogSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultChangeLog();
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
        
        public void RefreshCrudeDefaultChangeLog() {
            var defaultChangeLog = new CrudeDefaultChangeLogServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultChangeLog.FetchWithFilter(
                             Guid.Empty
                            ,textBoxDefaultChangeName.Text
                            ,textBoxDefaultChangeDescription.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            ,defaultChangeLogTypeRefCombo.Text
                            ,Guid.Empty
                            );
                dataGridViewCrudeDefaultChangeLog.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultChangeLog.DataSource = bindingSource;
                dataGridViewCrudeDefaultChangeLog.AutoResizeColumns();
                dataGridViewCrudeDefaultChangeLog.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultChangeLog.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultChangeLog() {
            try {
                dataGridViewCrudeDefaultChangeLog.Columns.Clear();
                dataGridViewCrudeDefaultChangeLog.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultChangeLog.Columns.Add("DefaultChangeName","Default Change Name");
                dataGridViewCrudeDefaultChangeLog.Columns["DefaultChangeName"].DataPropertyName = "DefaultChangeName";
                dataGridViewCrudeDefaultChangeLog.Columns.Add("DefaultChangeDescription","Default Change Description");
                dataGridViewCrudeDefaultChangeLog.Columns["DefaultChangeDescription"].DataPropertyName = "DefaultChangeDescription";
                dataGridViewCrudeDefaultChangeLog.Columns.Add("DefaultChangeLogTypeRcd","Default Change Log Type");
                dataGridViewCrudeDefaultChangeLog.Columns["DefaultChangeLogTypeRcd"].DataPropertyName = "DefaultChangeLogTypeRcd";
                dataGridViewCrudeDefaultChangeLog.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultChangeLog.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultChangeLog.Columns.Add("DefaultChangeLogId","Default Change Log");
                dataGridViewCrudeDefaultChangeLog.Columns["DefaultChangeLogId"].DataPropertyName = "DefaultChangeLogId";
                dataGridViewCrudeDefaultChangeLog.Columns["DefaultChangeLogId"].Visible = false;
                dataGridViewCrudeDefaultChangeLog.Columns.Add("DefaultIssueId","Default Issue");
                dataGridViewCrudeDefaultChangeLog.Columns["DefaultIssueId"].DataPropertyName = "DefaultIssueId";
                dataGridViewCrudeDefaultChangeLog.Columns["DefaultIssueId"].Visible = false;
                dataGridViewCrudeDefaultChangeLog.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultChangeLog.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultChangeLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultChangeLog.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
