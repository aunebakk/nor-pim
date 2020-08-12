/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:31 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientLinkSearch : Form {
        
        private string _clientLinkTypeRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        public CrudeClientLinkSearch() {
            InitializeComponent();
            InitializeGridCrudeClientLink();
            this.AcceptButton = buttonCrudeClientLinkSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string clientLinkTypeRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientLinkTypeRcd = clientLinkTypeRcd;
                _clientId = clientId;
                _userId = userId;
                RefreshCrudeClientLink();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientLinkEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientLink.CurrentRow.Cells["ClientLinkId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientLinkAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientLink_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientLink.CurrentRow.Cells["ClientLinkId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientLinkSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientLink();
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
        
        public void RefreshCrudeClientLink() {
            var clientLink = new CrudeClientLinkServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientLink.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientLinkTypeRefCombo.Text
                            ,textBoxLinkName.Text
                            ,textBoxLink.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientLink.AutoGenerateColumns = false;
                dataGridViewCrudeClientLink.DataSource = bindingSource;
                dataGridViewCrudeClientLink.AutoResizeColumns();
                dataGridViewCrudeClientLink.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientLink.Close();
            }
        }
        
        private void InitializeGridCrudeClientLink() {
            try {
                dataGridViewCrudeClientLink.Columns.Clear();
                dataGridViewCrudeClientLink.AutoGenerateColumns = false;
                dataGridViewCrudeClientLink.Columns.Add("LinkName","Link Name");
                dataGridViewCrudeClientLink.Columns["LinkName"].DataPropertyName = "LinkName";
                dataGridViewCrudeClientLink.Columns.Add("ClientLinkTypeRcd","Client Link Type");
                dataGridViewCrudeClientLink.Columns["ClientLinkTypeRcd"].DataPropertyName = "ClientLinkTypeRcd";
                dataGridViewCrudeClientLink.Columns.Add("Link","Link");
                dataGridViewCrudeClientLink.Columns["Link"].DataPropertyName = "Link";
                dataGridViewCrudeClientLink.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientLink.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientLink.Columns.Add("ClientLinkId","Client Link");
                dataGridViewCrudeClientLink.Columns["ClientLinkId"].DataPropertyName = "ClientLinkId";
                dataGridViewCrudeClientLink.Columns["ClientLinkId"].Visible = false;
                dataGridViewCrudeClientLink.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientLink.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientLink.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientLink.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientLink.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientLink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientLink.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
