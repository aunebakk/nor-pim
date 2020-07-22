/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:31 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultIssueTypeRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultIssueTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultIssueTypeRef();
            this.AcceptButton = buttonCrudeDefaultIssueTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultIssueTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultIssueTypeRef.CurrentRow.Cells["DefaultIssueTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultIssueTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultIssueTypeRef.CurrentRow.Cells["DefaultIssueTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultIssueTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultIssueTypeRef();
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
        
        public void RefreshCrudeDefaultIssueTypeRef() {
            var defaultIssueTypeRef = new CrudeDefaultIssueTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultIssueTypeRef.FetchWithFilter(
                             textBoxDefaultIssueType.Text
                            ,textBoxDefaultIssueTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultIssueTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssueTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultIssueTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultIssueTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultIssueTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultIssueTypeRef() {
            try {
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultIssueTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Add("DefaultIssueTypeName","Default Issue Type Name");
                dataGridViewCrudeDefaultIssueTypeRef.Columns["DefaultIssueTypeName"].DataPropertyName = "DefaultIssueTypeName";
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Add("DefaultIssueTypeRcd","Default Issue Type");
                dataGridViewCrudeDefaultIssueTypeRef.Columns["DefaultIssueTypeRcd"].DataPropertyName = "DefaultIssueTypeRcd";
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultIssueTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultIssueTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultIssueTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultIssueTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
