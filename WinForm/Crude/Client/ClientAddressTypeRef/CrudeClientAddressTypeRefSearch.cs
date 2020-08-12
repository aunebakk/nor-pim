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

    public partial class CrudeClientAddressTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientAddressTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientAddressTypeRef();
            this.AcceptButton = buttonCrudeClientAddressTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientAddressTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientAddressTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientAddressTypeRef.CurrentRow.Cells["ClientAddressTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientAddressTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientAddressTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientAddressTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientAddressTypeRef.CurrentRow.Cells["ClientAddressTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientAddressTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientAddressTypeRef();
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
        
        public void RefreshCrudeClientAddressTypeRef() {
            var clientAddressTypeRef = new CrudeClientAddressTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientAddressTypeRef.FetchWithFilter(
                             textBoxClientAddressType.Text
                            ,textBoxClientAddressTypeName.Text
                            ,textBoxClientAddressTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientAddressTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientAddressTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientAddressTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientAddressTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientAddressTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientAddressTypeRef() {
            try {
                dataGridViewCrudeClientAddressTypeRef.Columns.Clear();
                dataGridViewCrudeClientAddressTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ClientAddressTypeName","Client Address Type Name");
                dataGridViewCrudeClientAddressTypeRef.Columns["ClientAddressTypeName"].DataPropertyName = "ClientAddressTypeName";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ClientAddressTypeRcd","Client Address Type");
                dataGridViewCrudeClientAddressTypeRef.Columns["ClientAddressTypeRcd"].DataPropertyName = "ClientAddressTypeRcd";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ClientAddressTypeDescription","Client Address Type Description");
                dataGridViewCrudeClientAddressTypeRef.Columns["ClientAddressTypeDescription"].DataPropertyName = "ClientAddressTypeDescription";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientAddressTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientAddressTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientAddressTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientAddressTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientAddressTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientAddressTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientAddressTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
