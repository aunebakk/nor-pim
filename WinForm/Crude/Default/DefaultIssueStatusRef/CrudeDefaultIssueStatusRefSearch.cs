/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:26:06 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultIssueStatusRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultIssueStatusRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultIssueStatusRef();
            this.AcceptButton = buttonCrudeDefaultIssueStatusRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultIssueStatusRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueStatusRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueStatusRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultIssueStatusRef.CurrentRow.Cells["DefaultIssueStatusRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueStatusRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueStatusRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultIssueStatusRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueStatusRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultIssueStatusRef.CurrentRow.Cells["DefaultIssueStatusRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueStatusRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultIssueStatusRef();
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
        
        public void RefreshCrudeDefaultIssueStatusRef() {
            var defaultIssueStatusRef = new CrudeDefaultIssueStatusRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultIssueStatusRef.FetchWithFilter(
                             textBoxDefaultIssueStatus.Text
                            ,textBoxDefaultIssueStatusName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultIssueStatusRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssueStatusRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultIssueStatusRef.AutoResizeColumns();
                dataGridViewCrudeDefaultIssueStatusRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultIssueStatusRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultIssueStatusRef() {
            try {
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Clear();
                dataGridViewCrudeDefaultIssueStatusRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Add("DefaultIssueStatusName","Default Issue Status Name");
                dataGridViewCrudeDefaultIssueStatusRef.Columns["DefaultIssueStatusName"].DataPropertyName = "DefaultIssueStatusName";
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Add("DefaultIssueStatusRcd","Default Issue Status");
                dataGridViewCrudeDefaultIssueStatusRef.Columns["DefaultIssueStatusRcd"].DataPropertyName = "DefaultIssueStatusRcd";
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultIssueStatusRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultIssueStatusRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultIssueStatusRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultIssueStatusRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
