/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:57:33 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemReferenceTableSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultSystemReferenceTableSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultSystemReferenceTable();
            this.AcceptButton = buttonCrudeDefaultSystemReferenceTableSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultSystemReferenceTable();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemReferenceTableEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemReferenceTableEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultSystemReferenceTable.CurrentRow.Cells["DefaultSystemReferenceTableId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemReferenceTableAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemReferenceTableEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultSystemReferenceTable_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemReferenceTableEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultSystemReferenceTable.CurrentRow.Cells["DefaultSystemReferenceTableId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemReferenceTableSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultSystemReferenceTable();
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
        
        public void RefreshCrudeDefaultSystemReferenceTable() {
            var defaultSystemReferenceTable = new CrudeDefaultSystemReferenceTableServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultSystemReferenceTable.FetchWithFilter(
                             Guid.Empty
                            ,textBoxDefaultSystemReferenceTableName.Text
                            ,textBoxDefaultSystemReferenceDisplayName.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultSystemReferenceTable.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemReferenceTable.DataSource = bindingSource;
                dataGridViewCrudeDefaultSystemReferenceTable.AutoResizeColumns();
                dataGridViewCrudeDefaultSystemReferenceTable.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultSystemReferenceTable.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultSystemReferenceTable() {
            try {
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Clear();
                dataGridViewCrudeDefaultSystemReferenceTable.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceTableName","Default System Reference Table Name");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceTableName"].DataPropertyName = "DefaultSystemReferenceTableName";
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceDisplayName","Default System Reference Display Name");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceDisplayName"].DataPropertyName = "DefaultSystemReferenceDisplayName";
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceTableId","Default System Reference Table");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceTableId"].DataPropertyName = "DefaultSystemReferenceTableId";
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceTableId"].Visible = false;
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultSystemReferenceTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultSystemReferenceTable.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
