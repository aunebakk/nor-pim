/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:34:54 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultErrorTypeRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultErrorTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultErrorTypeRef();
            this.AcceptButton = buttonCrudeDefaultErrorTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultErrorTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultErrorTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultErrorTypeRef.CurrentRow.Cells["DefaultErrorTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultErrorTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultErrorTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultErrorTypeRef.CurrentRow.Cells["DefaultErrorTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultErrorTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultErrorTypeRef();
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
        
        public void RefreshCrudeDefaultErrorTypeRef() {
            var defaultErrorTypeRef = new CrudeDefaultErrorTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultErrorTypeRef.FetchWithFilter(
                             textBoxDefaultErrorType.Text
                            ,textBoxDefaultErrorTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultErrorTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultErrorTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultErrorTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultErrorTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultErrorTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultErrorTypeRef() {
            try {
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultErrorTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Add("DefaultErrorTypeName","Default Error Type Name");
                dataGridViewCrudeDefaultErrorTypeRef.Columns["DefaultErrorTypeName"].DataPropertyName = "DefaultErrorTypeName";
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Add("DefaultErrorTypeRcd","Default Error Type");
                dataGridViewCrudeDefaultErrorTypeRef.Columns["DefaultErrorTypeRcd"].DataPropertyName = "DefaultErrorTypeRcd";
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultErrorTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultErrorTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultErrorTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultErrorTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
