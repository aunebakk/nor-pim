/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:19:19 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultStateRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultStateRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultStateRef();
            this.AcceptButton = buttonCrudeDefaultStateRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultStateRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultStateRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultStateRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultStateRef.CurrentRow.Cells["DefaultStateRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultStateRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultStateRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultStateRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultStateRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultStateRef.CurrentRow.Cells["DefaultStateRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultStateRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultStateRef();
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
        
        public void RefreshCrudeDefaultStateRef() {
            var defaultStateRef = new CrudeDefaultStateRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultStateRef.FetchWithFilter(
                             textBoxDefaultState.Text
                            ,textBoxDefaultStateName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultStateRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultStateRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultStateRef.AutoResizeColumns();
                dataGridViewCrudeDefaultStateRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultStateRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultStateRef() {
            try {
                dataGridViewCrudeDefaultStateRef.Columns.Clear();
                dataGridViewCrudeDefaultStateRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultStateRef.Columns.Add("DefaultStateName","Default State Name");
                dataGridViewCrudeDefaultStateRef.Columns["DefaultStateName"].DataPropertyName = "DefaultStateName";
                dataGridViewCrudeDefaultStateRef.Columns.Add("DefaultStateRcd","Default State");
                dataGridViewCrudeDefaultStateRef.Columns["DefaultStateRcd"].DataPropertyName = "DefaultStateRcd";
                dataGridViewCrudeDefaultStateRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultStateRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultStateRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultStateRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultStateRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultStateRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
