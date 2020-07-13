/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:13:17 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductFieldSetSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeProductFieldSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductFieldSet();
            this.AcceptButton = buttonCrudeProductFieldSetSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeProductFieldSet();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductFieldSetEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSet.CurrentRow.Cells["ProductFieldSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductFieldSetAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductFieldSet_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSet.CurrentRow.Cells["ProductFieldSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductFieldSetSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductFieldSet();
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
        
        public void RefreshCrudeProductFieldSet() {
            var productFieldSet = new CrudeProductFieldSetServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productFieldSet.FetchWithFilter(
                             Guid.Empty
                            ,textBoxProductFieldSetName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductFieldSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductFieldSet.DataSource = bindingSource;
                dataGridViewCrudeProductFieldSet.AutoResizeColumns();
                dataGridViewCrudeProductFieldSet.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productFieldSet.Close();
            }
        }
        
        private void InitializeGridCrudeProductFieldSet() {
            try {
                dataGridViewCrudeProductFieldSet.Columns.Clear();
                dataGridViewCrudeProductFieldSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductFieldSet.Columns.Add("ProductFieldSetName","Product Field Set Name");
                dataGridViewCrudeProductFieldSet.Columns["ProductFieldSetName"].DataPropertyName = "ProductFieldSetName";
                dataGridViewCrudeProductFieldSet.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductFieldSet.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductFieldSet.Columns.Add("ProductFieldSetId","Product Field Set");
                dataGridViewCrudeProductFieldSet.Columns["ProductFieldSetId"].DataPropertyName = "ProductFieldSetId";
                dataGridViewCrudeProductFieldSet.Columns["ProductFieldSetId"].Visible = false;
                dataGridViewCrudeProductFieldSet.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductFieldSet.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductFieldSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductFieldSet.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
