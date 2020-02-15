/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:40:13 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultUserActivityTypeRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultUserActivityTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultUserActivityTypeRef();
            this.AcceptButton = buttonCrudeDefaultUserActivityTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultUserActivityTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultUserActivityTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultUserActivityTypeRef.CurrentRow.Cells["DefaultUserActivityTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultUserActivityTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultUserActivityTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultUserActivityTypeRef.CurrentRow.Cells["DefaultUserActivityTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultUserActivityTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultUserActivityTypeRef();
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
        
        public void RefreshCrudeDefaultUserActivityTypeRef() {
            var defaultUserActivityTypeRef = new CrudeDefaultUserActivityTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultUserActivityTypeRef.FetchWithFilter(
                             textBoxDefaultUserActivityType.Text
                            ,textBoxDefaultUserActivityTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultUserActivityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultUserActivityTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultUserActivityTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultUserActivityTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultUserActivityTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultUserActivityTypeRef() {
            try {
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultUserActivityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Add("DefaultUserActivityTypeName","Default User Activity Type Name");
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns["DefaultUserActivityTypeName"].DataPropertyName = "DefaultUserActivityTypeName";
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Add("DefaultUserActivityTypeRcd","Default User Activity Type");
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns["DefaultUserActivityTypeRcd"].DataPropertyName = "DefaultUserActivityTypeRcd";
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultUserActivityTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultUserActivityTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
