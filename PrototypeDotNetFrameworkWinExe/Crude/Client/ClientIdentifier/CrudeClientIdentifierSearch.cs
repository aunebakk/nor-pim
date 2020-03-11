/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:59:06 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientIdentifierSearch : Form {
        
        private string _clientIdentifierTypeRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        public CrudeClientIdentifierSearch() {
            InitializeComponent();
            InitializeGridCrudeClientIdentifier();
            this.AcceptButton = buttonCrudeClientIdentifierSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string clientIdentifierTypeRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientIdentifierTypeRcd = clientIdentifierTypeRcd;
                _clientId = clientId;
                _userId = userId;
                RefreshCrudeClientIdentifier();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientIdentifierEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientIdentifier.CurrentRow.Cells["ClientIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientIdentifierAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientIdentifier_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientIdentifier.CurrentRow.Cells["ClientIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientIdentifierSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientIdentifier();
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
        
        public void RefreshCrudeClientIdentifier() {
            var clientIdentifier = new CrudeClientIdentifierServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientIdentifier.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientIdentifierTypeRefCombo.Text
                            ,textBoxClientIdentifierCode.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeClientIdentifier.DataSource = bindingSource;
                dataGridViewCrudeClientIdentifier.AutoResizeColumns();
                dataGridViewCrudeClientIdentifier.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientIdentifier.Close();
            }
        }
        
        private void InitializeGridCrudeClientIdentifier() {
            try {
                dataGridViewCrudeClientIdentifier.Columns.Clear();
                dataGridViewCrudeClientIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeClientIdentifier.Columns.Add("ClientIdentifierTypeRcd","Client Identifier Type");
                dataGridViewCrudeClientIdentifier.Columns["ClientIdentifierTypeRcd"].DataPropertyName = "ClientIdentifierTypeRcd";
                dataGridViewCrudeClientIdentifier.Columns.Add("ClientIdentifierCode","Client Identifier Code");
                dataGridViewCrudeClientIdentifier.Columns["ClientIdentifierCode"].DataPropertyName = "ClientIdentifierCode";
                dataGridViewCrudeClientIdentifier.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientIdentifier.Columns.Add("ClientIdentifierId","Client Identifier");
                dataGridViewCrudeClientIdentifier.Columns["ClientIdentifierId"].DataPropertyName = "ClientIdentifierId";
                dataGridViewCrudeClientIdentifier.Columns["ClientIdentifierId"].Visible = false;
                dataGridViewCrudeClientIdentifier.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientIdentifier.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientIdentifier.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientIdentifier.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientIdentifier.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
