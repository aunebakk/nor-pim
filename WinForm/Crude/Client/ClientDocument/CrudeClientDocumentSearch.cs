/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:51:00 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientDocumentSearch : Form {
        
        private string _clientDocumentTypeRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        public CrudeClientDocumentSearch() {
            InitializeComponent();
            InitializeGridCrudeClientDocument();
            this.AcceptButton = buttonCrudeClientDocumentSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string clientDocumentTypeRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientDocumentTypeRcd = clientDocumentTypeRcd;
                _clientId = clientId;
                _userId = userId;
                RefreshCrudeClientDocument();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientDocumentEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientDocument.CurrentRow.Cells["ClientDocumentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientDocumentAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientDocument_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientDocument.CurrentRow.Cells["ClientDocumentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientDocumentSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientDocument();
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
        
        public void RefreshCrudeClientDocument() {
            var clientDocument = new CrudeClientDocumentServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientDocument.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientDocumentTypeRefCombo.Text
                            ,textBoxDocumentName.Text
                            ,dateTimePickerDocumentDateTime.Checked ? Convert.ToDateTime(dateTimePickerDocumentDateTime.Value): DateTime.MinValue
                            ,dateTimePickerExpiryDateTime.Checked ? Convert.ToDateTime(dateTimePickerExpiryDateTime.Value): DateTime.MinValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientDocument.AutoGenerateColumns = false;
                dataGridViewCrudeClientDocument.DataSource = bindingSource;
                dataGridViewCrudeClientDocument.AutoResizeColumns();
                dataGridViewCrudeClientDocument.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientDocument.Close();
            }
        }
        
        private void InitializeGridCrudeClientDocument() {
            try {
                dataGridViewCrudeClientDocument.Columns.Clear();
                dataGridViewCrudeClientDocument.AutoGenerateColumns = false;
                dataGridViewCrudeClientDocument.Columns.Add("DocumentName","Document Name");
                dataGridViewCrudeClientDocument.Columns["DocumentName"].DataPropertyName = "DocumentName";
                dataGridViewCrudeClientDocument.Columns.Add("ClientDocumentTypeRcd","Client Document Type");
                dataGridViewCrudeClientDocument.Columns["ClientDocumentTypeRcd"].DataPropertyName = "ClientDocumentTypeRcd";
                dataGridViewCrudeClientDocument.Columns.Add("DocumentDateTime","Document Date Time");
                dataGridViewCrudeClientDocument.Columns["DocumentDateTime"].DataPropertyName = "DocumentDateTime";
                dataGridViewCrudeClientDocument.Columns.Add("ExpiryDateTime","Expiry Date Time");
                dataGridViewCrudeClientDocument.Columns["ExpiryDateTime"].DataPropertyName = "ExpiryDateTime";
                dataGridViewCrudeClientDocument.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientDocument.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientDocument.Columns.Add("ClientDocumentId","Client Document");
                dataGridViewCrudeClientDocument.Columns["ClientDocumentId"].DataPropertyName = "ClientDocumentId";
                dataGridViewCrudeClientDocument.Columns["ClientDocumentId"].Visible = false;
                dataGridViewCrudeClientDocument.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientDocument.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientDocument.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientDocument.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientDocument.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientDocument.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
