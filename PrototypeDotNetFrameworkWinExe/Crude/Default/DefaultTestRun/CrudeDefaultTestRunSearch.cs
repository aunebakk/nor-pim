/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:19:22 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultTestRunSearch : Form {
        
        private string _defaultTestRunResultRcd;
        
        private System.Guid _defaultTestId;
        
        public CrudeDefaultTestRunSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultTestRun();
            this.AcceptButton = buttonCrudeDefaultTestRunSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string defaultTestRunResultRcd, System.Guid defaultTestId) {
            try {
                _defaultTestRunResultRcd = defaultTestRunResultRcd;
                _defaultTestId = defaultTestId;
                RefreshCrudeDefaultTestRun();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestRunEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultTestRun.CurrentRow.Cells["DefaultTestRunId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestRunAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAdd();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultTestRun_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultTestRun.CurrentRow.Cells["DefaultTestRunId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestRunSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultTestRun();
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
        
        public void RefreshCrudeDefaultTestRun() {
            var defaultTestRun = new CrudeDefaultTestRunServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultTestRun.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,defaultTestRunResultRefCombo.Text
                            ,textBoxResult.Text
                            ,dateTimePickerStartDateTime.Checked ? Convert.ToDateTime(dateTimePickerStartDateTime.Value): DateTime.MinValue
                            ,dateTimePickerEndDateTime.Checked ? Convert.ToDateTime(dateTimePickerEndDateTime.Value): DateTime.MinValue
                            ,maskedTextBoxElapsedMilliseconds.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxElapsedMilliseconds.Text)
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultTestRun.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTestRun.DataSource = bindingSource;
                dataGridViewCrudeDefaultTestRun.AutoResizeColumns();
                dataGridViewCrudeDefaultTestRun.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultTestRun.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultTestRun() {
            try {
                dataGridViewCrudeDefaultTestRun.Columns.Clear();
                dataGridViewCrudeDefaultTestRun.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTestRun.Columns.Add("DefaultTestRunResultRcd","Default Test Run Result");
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestRunResultRcd"].DataPropertyName = "DefaultTestRunResultRcd";
                dataGridViewCrudeDefaultTestRun.Columns.Add("Result","Result");
                dataGridViewCrudeDefaultTestRun.Columns["Result"].DataPropertyName = "Result";
                dataGridViewCrudeDefaultTestRun.Columns.Add("ElapsedMilliseconds","Elapsed Milliseconds");
                dataGridViewCrudeDefaultTestRun.Columns["ElapsedMilliseconds"].DataPropertyName = "ElapsedMilliseconds";
                dataGridViewCrudeDefaultTestRun.Columns.Add("StartDateTime","Start Date Time");
                dataGridViewCrudeDefaultTestRun.Columns["StartDateTime"].DataPropertyName = "StartDateTime";
                dataGridViewCrudeDefaultTestRun.Columns.Add("EndDateTime","End Date Time");
                dataGridViewCrudeDefaultTestRun.Columns["EndDateTime"].DataPropertyName = "EndDateTime";
                dataGridViewCrudeDefaultTestRun.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultTestRun.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultTestRun.Columns.Add("DefaultTestRunId","Default Test Run");
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestRunId"].DataPropertyName = "DefaultTestRunId";
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestRunId"].Visible = false;
                dataGridViewCrudeDefaultTestRun.Columns.Add("DefaultTestId","Default Test");
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestId"].DataPropertyName = "DefaultTestId";
                dataGridViewCrudeDefaultTestRun.Columns["DefaultTestId"].Visible = false;
                dataGridViewCrudeDefaultTestRun.Columns.Add("UserId","User");
                dataGridViewCrudeDefaultTestRun.Columns["UserId"].DataPropertyName = "UserId";
                dataGridViewCrudeDefaultTestRun.Columns["UserId"].Visible = false;
                dataGridViewCrudeDefaultTestRun.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultTestRun.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultTestRun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultTestRun.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
