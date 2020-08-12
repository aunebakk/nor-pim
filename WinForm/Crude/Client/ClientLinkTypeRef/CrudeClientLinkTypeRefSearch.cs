/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:45:53 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientLinkTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientLinkTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientLinkTypeRef();
            this.AcceptButton = buttonCrudeClientLinkTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientLinkTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientLinkTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientLinkTypeRef.CurrentRow.Cells["ClientLinkTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientLinkTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientLinkTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientLinkTypeRef.CurrentRow.Cells["ClientLinkTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientLinkTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientLinkTypeRef();
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
        
        public void RefreshCrudeClientLinkTypeRef() {
            var clientLinkTypeRef = new CrudeClientLinkTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientLinkTypeRef.FetchWithFilter(
                             textBoxClientLinkType.Text
                            ,textBoxClientLinkTypeName.Text
                            ,textBoxClientLinkTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientLinkTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientLinkTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientLinkTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientLinkTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientLinkTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientLinkTypeRef() {
            try {
                dataGridViewCrudeClientLinkTypeRef.Columns.Clear();
                dataGridViewCrudeClientLinkTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeName","Client Link Type Name");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeName"].DataPropertyName = "ClientLinkTypeName";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeRcd","Client Link Type");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeRcd"].DataPropertyName = "ClientLinkTypeRcd";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ClientLinkTypeDescription","Client Link Type Description");
                dataGridViewCrudeClientLinkTypeRef.Columns["ClientLinkTypeDescription"].DataPropertyName = "ClientLinkTypeDescription";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientLinkTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientLinkTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientLinkTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientLinkTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientLinkTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientLinkTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientLinkTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
