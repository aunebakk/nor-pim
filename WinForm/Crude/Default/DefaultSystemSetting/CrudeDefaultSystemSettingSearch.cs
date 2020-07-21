/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:47:26 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemSettingSearch : Form {
        
        private string _defaultSystemSettingRcd;
        
        private System.Guid _defaultUserId;
        
        public CrudeDefaultSystemSettingSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultSystemSetting();
            this.AcceptButton = buttonCrudeDefaultSystemSettingSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string defaultSystemSettingRcd, System.Guid defaultUserId) {
            try {
                _defaultSystemSettingRcd = defaultSystemSettingRcd;
                _defaultUserId = defaultUserId;
                RefreshCrudeDefaultSystemSetting();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemSettingEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultSystemSetting.CurrentRow.Cells["DefaultSystemSettingId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemSettingAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeDefaultSystemSetting_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemSettingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultSystemSetting.CurrentRow.Cells["DefaultSystemSettingId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeDefaultSystemSettingSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultSystemSetting();
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
        
        public void RefreshCrudeDefaultSystemSetting() {
            var defaultSystemSetting = new CrudeDefaultSystemSettingServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultSystemSetting.FetchWithFilter(
                             Guid.Empty
                            ,defaultSystemSettingRefCombo.Text
                            ,textBoxDefaultSystemSettingValue.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultSystemSetting.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemSetting.DataSource = bindingSource;
                dataGridViewCrudeDefaultSystemSetting.AutoResizeColumns();
                dataGridViewCrudeDefaultSystemSetting.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultSystemSetting.Close();
            }
        }
        
        private void InitializeGridCrudeDefaultSystemSetting() {
            try {
                dataGridViewCrudeDefaultSystemSetting.Columns.Clear();
                dataGridViewCrudeDefaultSystemSetting.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("DefaultSystemSettingRcd","Default System Setting");
                dataGridViewCrudeDefaultSystemSetting.Columns["DefaultSystemSettingRcd"].DataPropertyName = "DefaultSystemSettingRcd";
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("DefaultSystemSettingValue","Default System Setting Value");
                dataGridViewCrudeDefaultSystemSetting.Columns["DefaultSystemSettingValue"].DataPropertyName = "DefaultSystemSettingValue";
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultSystemSetting.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("DefaultSystemSettingId","Default System Setting");
                dataGridViewCrudeDefaultSystemSetting.Columns["DefaultSystemSettingId"].DataPropertyName = "DefaultSystemSettingId";
                dataGridViewCrudeDefaultSystemSetting.Columns["DefaultSystemSettingId"].Visible = false;
                dataGridViewCrudeDefaultSystemSetting.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultSystemSetting.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultSystemSetting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultSystemSetting.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
