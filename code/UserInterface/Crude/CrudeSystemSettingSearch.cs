using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeSystemSettingSearch : Form {
        
        private Guid _userId;
        
        public CrudeSystemSettingSearch() {
            InitializeComponent();
            InitializeGridCrudeSystemSetting();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid userId) {
            _userId = userId;
            userPicker.SelectedValue = userId;
            buttonSearch_Click(new object(), new EventArgs());
            base.Show();
        }
        
        public void ShowByUserId(Guid userId) {
            userPicker.SelectedValue = userId;
            buttonSearch_Click(new object(), new EventArgs());
            Show();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeSystemSettingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeSystemSetting.CurrentRow.Cells["SystemSettingId"].Value);
        }
        
        private void dataGridViewCrudeSystemSetting_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeSystemSettingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeSystemSetting.CurrentRow.Cells["SystemSettingId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeSystemSetting = new CrudeSystemSettingService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeSystemSetting.FetchWithFilter(                            
                     Guid.Empty
                    ,systemSettingRefCombo.Text
                    ,textBoxSystemSettingValue.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeSystemSetting.AutoGenerateColumns = false;
                dataGridViewCrudeSystemSetting.DataSource = bindingSource;
                dataGridViewCrudeSystemSetting.AutoResizeColumns();
                dataGridViewCrudeSystemSetting.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeSystemSetting.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeSystemSettingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeSystemSetting() {
            dataGridViewCrudeSystemSetting.Columns.Clear();
            dataGridViewCrudeSystemSetting.AutoGenerateColumns = false;
            dataGridViewCrudeSystemSetting.Columns.Add("SystemSettingId","System Setting Id");
            dataGridViewCrudeSystemSetting.Columns.Add("SystemSettingRcd","System Setting");
            dataGridViewCrudeSystemSetting.Columns.Add("SystemSettingValue","System Setting Value");
            dataGridViewCrudeSystemSetting.Columns.Add("UserId","User Id");
            dataGridViewCrudeSystemSetting.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeSystemSetting.Columns.Add("ExtensionData", "");
            dataGridViewCrudeSystemSetting.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeSystemSetting.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeSystemSetting.AutoResizeColumns();
        }
    }
}
