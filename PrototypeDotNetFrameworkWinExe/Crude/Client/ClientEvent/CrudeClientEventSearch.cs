/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:23:42 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientEventSearch : Form {
        
        private string _clientEventTypeRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        public CrudeClientEventSearch() {
            InitializeComponent();
            InitializeGridCrudeClientEvent();
            this.AcceptButton = buttonCrudeClientEventSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string clientEventTypeRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientEventTypeRcd = clientEventTypeRcd;
                _clientId = clientId;
                _userId = userId;
                RefreshCrudeClientEvent();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientEventEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientEvent.CurrentRow.Cells["ClientEventId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientEventAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientEvent_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientEvent.CurrentRow.Cells["ClientEventId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientEventSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientEvent();
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
        
        public void RefreshCrudeClientEvent() {
            var clientEvent = new CrudeClientEventServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientEvent.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientEventTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientEvent.AutoGenerateColumns = false;
                dataGridViewCrudeClientEvent.DataSource = bindingSource;
                dataGridViewCrudeClientEvent.AutoResizeColumns();
                dataGridViewCrudeClientEvent.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientEvent.Close();
            }
        }
        
        private void InitializeGridCrudeClientEvent() {
            try {
                dataGridViewCrudeClientEvent.Columns.Clear();
                dataGridViewCrudeClientEvent.AutoGenerateColumns = false;
                dataGridViewCrudeClientEvent.Columns.Add("ClientEventTypeRcd","Client Event Type");
                dataGridViewCrudeClientEvent.Columns["ClientEventTypeRcd"].DataPropertyName = "ClientEventTypeRcd";
                dataGridViewCrudeClientEvent.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientEvent.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientEvent.Columns.Add("ClientEventId","Client Event");
                dataGridViewCrudeClientEvent.Columns["ClientEventId"].DataPropertyName = "ClientEventId";
                dataGridViewCrudeClientEvent.Columns["ClientEventId"].Visible = false;
                dataGridViewCrudeClientEvent.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientEvent.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientEvent.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientEvent.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientEvent.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientEvent.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
