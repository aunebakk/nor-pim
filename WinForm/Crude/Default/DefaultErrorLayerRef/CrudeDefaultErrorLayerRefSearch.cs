/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:41:21 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultErrorLayerRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultErrorLayerRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultErrorLayerRef();
            this.AcceptButton = buttonCrudeDefaultErrorLayerRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultErrorLayerRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultErrorLayerRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorLayerRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultErrorLayerRef.CurrentRow.Cells["DefaultErrorLayerRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultErrorLayerRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorLayerRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultErrorLayerRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorLayerRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultErrorLayerRef.CurrentRow.Cells["DefaultErrorLayerRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultErrorLayerRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultErrorLayerRef();
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
        
        public void RefreshCrudeDefaultErrorLayerRef() {
            var defaultErrorLayerRef = new CrudeDefaultErrorLayerRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultErrorLayerRef.FetchWithFilter(
                             textBoxDefaultErrorLayer.Text
                            ,textBoxDefaultErrorLayerName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultErrorLayerRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultErrorLayerRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultErrorLayerRef.AutoResizeColumns();
                dataGridViewCrudeDefaultErrorLayerRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultErrorLayerRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultErrorLayerRef() {
            try {
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Clear();
                dataGridViewCrudeDefaultErrorLayerRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Add("DefaultErrorLayerName","Default Error Layer Name");
                dataGridViewCrudeDefaultErrorLayerRef.Columns["DefaultErrorLayerName"].DataPropertyName = "DefaultErrorLayerName";
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Add("DefaultErrorLayerRcd","Default Error Layer");
                dataGridViewCrudeDefaultErrorLayerRef.Columns["DefaultErrorLayerRcd"].DataPropertyName = "DefaultErrorLayerRcd";
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultErrorLayerRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultErrorLayerRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultErrorLayerRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultErrorLayerRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultErrorLayerRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
