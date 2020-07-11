/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:41:39 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultTestRunResultRefSearch : Form {
        
        public CrudeDefaultTestRunResultRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultTestRunResultRef();
            this.AcceptButton = buttonCrudeDefaultTestRunResultRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public new void Show() {
            try {
                RefreshCrudeDefaultTestRunResultRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestRunResultRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunResultRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultTestRunResultRef.CurrentRow.Cells["DefaultTestRunResultRcd"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestRunResultRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunResultRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAdd();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultTestRunResultRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunResultRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultTestRunResultRef.CurrentRow.Cells["DefaultTestRunResultRcd"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestRunResultRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultTestRunResultRef();
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
        
        public void RefreshCrudeDefaultTestRunResultRef() {
            var defaultTestRunResultRef = new CrudeDefaultTestRunResultRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultTestRunResultRef.FetchWithFilter(
                             textBoxDefaultTestRunResult.Text
                            ,textBoxDefaultTestRunResultName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultTestRunResultRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTestRunResultRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultTestRunResultRef.AutoResizeColumns();
                dataGridViewCrudeDefaultTestRunResultRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultTestRunResultRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultTestRunResultRef() {
            try {
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Clear();
                dataGridViewCrudeDefaultTestRunResultRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("DefaultTestRunResultName","Default Test Run Result Name");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["DefaultTestRunResultName"].DataPropertyName = "DefaultTestRunResultName";
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("DefaultTestRunResultRcd","Default Test Run Result");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["DefaultTestRunResultRcd"].DataPropertyName = "DefaultTestRunResultRcd";
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("UserId","User");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["UserId"].DataPropertyName = "UserId";
                dataGridViewCrudeDefaultTestRunResultRef.Columns["UserId"].Visible = false;
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultTestRunResultRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultTestRunResultRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
