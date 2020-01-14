/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:42:40 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultTestSearch : Form {
        
        public CrudeDefaultTestSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultTest();
            this.AcceptButton = buttonCrudeDefaultTestSearch;
            this.CancelButton = buttonClose;

        }
        
        public new void Show() {
            try {
                RefreshCrudeDefaultTest();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultTest.CurrentRow.Cells["DefaultTestId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAdd();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultTest_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultTest.CurrentRow.Cells["DefaultTestId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultTestSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultTest();
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
        
        public void RefreshCrudeDefaultTest() {
            var defaultTest = new CrudeDefaultTestServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultTest.FetchWithFilter(
                             Guid.Empty
                            ,textBoxSystemName.Text
                            ,textBoxTestArea.Text
                            ,textBoxTestSubArea.Text
                            ,textBoxTestAddress.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultTest.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTest.DataSource = bindingSource;
                dataGridViewCrudeDefaultTest.AutoResizeColumns();
                dataGridViewCrudeDefaultTest.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultTest.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultTest() {
            try {
                dataGridViewCrudeDefaultTest.Columns.Clear();
                dataGridViewCrudeDefaultTest.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTest.Columns.Add("SystemName","System Name");
                dataGridViewCrudeDefaultTest.Columns["SystemName"].DataPropertyName = "SystemName";
                dataGridViewCrudeDefaultTest.Columns.Add("TestArea","Test Area");
                dataGridViewCrudeDefaultTest.Columns["TestArea"].DataPropertyName = "TestArea";
                dataGridViewCrudeDefaultTest.Columns.Add("TestSubArea","Test Sub Area");
                dataGridViewCrudeDefaultTest.Columns["TestSubArea"].DataPropertyName = "TestSubArea";
                dataGridViewCrudeDefaultTest.Columns.Add("TestAddress","Test Address");
                dataGridViewCrudeDefaultTest.Columns["TestAddress"].DataPropertyName = "TestAddress";
                dataGridViewCrudeDefaultTest.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultTest.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultTest.Columns.Add("DefaultTestId","Default Test");
                dataGridViewCrudeDefaultTest.Columns["DefaultTestId"].DataPropertyName = "DefaultTestId";
                dataGridViewCrudeDefaultTest.Columns["DefaultTestId"].Visible = false;
                dataGridViewCrudeDefaultTest.Columns.Add("UserId","User");
                dataGridViewCrudeDefaultTest.Columns["UserId"].DataPropertyName = "UserId";
                dataGridViewCrudeDefaultTest.Columns["UserId"].Visible = false;
                dataGridViewCrudeDefaultTest.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultTest.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultTest.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
