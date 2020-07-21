/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:16:34 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientEventTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientEventTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientEventTypeRef();
            this.AcceptButton = buttonCrudeClientEventTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientEventTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientEventTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientEventTypeRef.CurrentRow.Cells["ClientEventTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientEventTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientEventTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientEventTypeRef.CurrentRow.Cells["ClientEventTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientEventTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientEventTypeRef();
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
        
        public void RefreshCrudeClientEventTypeRef() {
            var clientEventTypeRef = new CrudeClientEventTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientEventTypeRef.FetchWithFilter(
                             textBoxClientEventType.Text
                            ,textBoxClientEventTypeName.Text
                            ,textBoxClientEventTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientEventTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientEventTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientEventTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientEventTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientEventTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientEventTypeRef() {
            try {
                dataGridViewCrudeClientEventTypeRef.Columns.Clear();
                dataGridViewCrudeClientEventTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ClientEventTypeName","Client Event Type Name");
                dataGridViewCrudeClientEventTypeRef.Columns["ClientEventTypeName"].DataPropertyName = "ClientEventTypeName";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ClientEventTypeRcd","Client Event Type");
                dataGridViewCrudeClientEventTypeRef.Columns["ClientEventTypeRcd"].DataPropertyName = "ClientEventTypeRcd";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ClientEventTypeDescription","Client Event Type Description");
                dataGridViewCrudeClientEventTypeRef.Columns["ClientEventTypeDescription"].DataPropertyName = "ClientEventTypeDescription";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientEventTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientEventTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientEventTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientEventTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientEventTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientEventTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientEventTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
