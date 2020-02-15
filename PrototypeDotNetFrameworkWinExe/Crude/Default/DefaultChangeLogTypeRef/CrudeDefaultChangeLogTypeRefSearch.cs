/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:39:56 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultChangeLogTypeRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultChangeLogTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultChangeLogTypeRef();
            this.AcceptButton = buttonCrudeDefaultChangeLogTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultChangeLogTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultChangeLogTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultChangeLogTypeRef.CurrentRow.Cells["DefaultChangeLogTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultChangeLogTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultChangeLogTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultChangeLogTypeRef.CurrentRow.Cells["DefaultChangeLogTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultChangeLogTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultChangeLogTypeRef();
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
        
        public void RefreshCrudeDefaultChangeLogTypeRef() {
            var defaultChangeLogTypeRef = new CrudeDefaultChangeLogTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultChangeLogTypeRef.FetchWithFilter(
                             textBoxDefaultChangeLogType.Text
                            ,textBoxDefaultChangeLogTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultChangeLogTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultChangeLogTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultChangeLogTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultChangeLogTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultChangeLogTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultChangeLogTypeRef() {
            try {
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultChangeLogTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Add("DefaultChangeLogTypeName","Default Change Log Type Name");
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns["DefaultChangeLogTypeName"].DataPropertyName = "DefaultChangeLogTypeName";
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Add("DefaultChangeLogTypeRcd","Default Change Log Type");
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns["DefaultChangeLogTypeRcd"].DataPropertyName = "DefaultChangeLogTypeRcd";
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultChangeLogTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultChangeLogTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
