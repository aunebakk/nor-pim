/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:40:41 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientContactMethodRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientContactMethodRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientContactMethodRef();
            this.AcceptButton = buttonCrudeClientContactMethodRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientContactMethodRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientContactMethodRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientContactMethodRef.CurrentRow.Cells["ClientContactMethodRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientContactMethodRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientContactMethodRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientContactMethodRef.CurrentRow.Cells["ClientContactMethodRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientContactMethodRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientContactMethodRef();
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
        
        public void RefreshCrudeClientContactMethodRef() {
            var clientContactMethodRef = new CrudeClientContactMethodRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientContactMethodRef.FetchWithFilter(
                             textBoxClientContactMethod.Text
                            ,textBoxClientContactMethodName.Text
                            ,textBoxClientContactMethodDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientContactMethodRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientContactMethodRef.DataSource = bindingSource;
                dataGridViewCrudeClientContactMethodRef.AutoResizeColumns();
                dataGridViewCrudeClientContactMethodRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientContactMethodRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientContactMethodRef() {
            try {
                dataGridViewCrudeClientContactMethodRef.Columns.Clear();
                dataGridViewCrudeClientContactMethodRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ClientContactMethodName","Client Contact Method Name");
                dataGridViewCrudeClientContactMethodRef.Columns["ClientContactMethodName"].DataPropertyName = "ClientContactMethodName";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ClientContactMethodRcd","Client Contact Method");
                dataGridViewCrudeClientContactMethodRef.Columns["ClientContactMethodRcd"].DataPropertyName = "ClientContactMethodRcd";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ClientContactMethodDescription","Client Contact Method Description");
                dataGridViewCrudeClientContactMethodRef.Columns["ClientContactMethodDescription"].DataPropertyName = "ClientContactMethodDescription";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientContactMethodRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientContactMethodRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientContactMethodRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientContactMethodRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientContactMethodRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientContactMethodRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientContactMethodRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
