/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:34:51 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeClientTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientTypeRef();
            this.AcceptButton = buttonCrudeClientTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeClientTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTypeRef.CurrentRow.Cells["ClientTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeClientTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientTypeRef.CurrentRow.Cells["ClientTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeClientTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientTypeRef();
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
        
        public void RefreshCrudeClientTypeRef() {
            var clientTypeRef = new CrudeClientTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientTypeRef.FetchWithFilter(
                             textBoxClientType.Text
                            ,textBoxClientTypeName.Text
                            ,textBoxClientTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeClientTypeRef() {
            try {
                dataGridViewCrudeClientTypeRef.Columns.Clear();
                dataGridViewCrudeClientTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeName","Client Type Name");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeName"].DataPropertyName = "ClientTypeName";
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeRcd","Client Type");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeRcd"].DataPropertyName = "ClientTypeRcd";
                dataGridViewCrudeClientTypeRef.Columns.Add("ClientTypeDescription","Client Type Description");
                dataGridViewCrudeClientTypeRef.Columns["ClientTypeDescription"].DataPropertyName = "ClientTypeDescription";
                dataGridViewCrudeClientTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
