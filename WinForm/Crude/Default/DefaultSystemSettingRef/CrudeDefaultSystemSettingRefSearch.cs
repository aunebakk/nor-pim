/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:57:34 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemSettingRefSearch : Form {
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultSystemSettingRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultSystemSettingRef();
            this.AcceptButton = buttonCrudeDefaultSystemSettingRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultSystemSettingRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemSettingRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultSystemSettingRef.CurrentRow.Cells["DefaultSystemSettingRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemSettingRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultSystemSettingRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultSystemSettingRef.CurrentRow.Cells["DefaultSystemSettingRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemSettingRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultSystemSettingRef();
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
        
        public void RefreshCrudeDefaultSystemSettingRef() {
            var defaultSystemSettingRef = new CrudeDefaultSystemSettingRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultSystemSettingRef.FetchWithFilter(
                             textBoxDefaultSystemSetting.Text
                            ,textBoxDefaultSystemSettingName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultSystemSettingRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemSettingRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultSystemSettingRef.AutoResizeColumns();
                dataGridViewCrudeDefaultSystemSettingRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultSystemSettingRef.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultSystemSettingRef() {
            try {
                dataGridViewCrudeDefaultSystemSettingRef.Columns.Clear();
                dataGridViewCrudeDefaultSystemSettingRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemSettingRef.Columns.Add("DefaultSystemSettingName","Default System Setting Name");
                dataGridViewCrudeDefaultSystemSettingRef.Columns["DefaultSystemSettingName"].DataPropertyName = "DefaultSystemSettingName";
                dataGridViewCrudeDefaultSystemSettingRef.Columns.Add("DefaultSystemSettingRcd","Default System Setting");
                dataGridViewCrudeDefaultSystemSettingRef.Columns["DefaultSystemSettingRcd"].DataPropertyName = "DefaultSystemSettingRcd";
                dataGridViewCrudeDefaultSystemSettingRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultSystemSettingRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultSystemSettingRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultSystemSettingRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultSystemSettingRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultSystemSettingRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
