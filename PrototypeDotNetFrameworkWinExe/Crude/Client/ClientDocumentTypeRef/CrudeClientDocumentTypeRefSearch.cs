/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:58:58 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientDocumentTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientDocumentTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientDocumentTypeRef();
            this.AcceptButton = buttonCrudeClientDocumentTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientDocumentTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientDocumentTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientDocumentTypeRef.CurrentRow.Cells["ClientDocumentTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientDocumentTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientDocumentTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientDocumentTypeRef.CurrentRow.Cells["ClientDocumentTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientDocumentTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientDocumentTypeRef();
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
        
        public void RefreshCrudeClientDocumentTypeRef() {
            var clientDocumentTypeRef = new CrudeClientDocumentTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientDocumentTypeRef.FetchWithFilter(
                             textBoxClientDocumentType.Text
                            ,textBoxClientDocumentTypeName.Text
                            ,textBoxClientDocumentTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientDocumentTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientDocumentTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientDocumentTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientDocumentTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientDocumentTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientDocumentTypeRef() {
            try {
                dataGridViewCrudeClientDocumentTypeRef.Columns.Clear();
                dataGridViewCrudeClientDocumentTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ClientDocumentTypeName","Client Document Type Name");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ClientDocumentTypeName"].DataPropertyName = "ClientDocumentTypeName";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ClientDocumentTypeRcd","Client Document Type");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ClientDocumentTypeRcd"].DataPropertyName = "ClientDocumentTypeRcd";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ClientDocumentTypeDescription","Client Document Type Description");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ClientDocumentTypeDescription"].DataPropertyName = "ClientDocumentTypeDescription";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientDocumentTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientDocumentTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientDocumentTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientDocumentTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientDocumentTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientDocumentTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
