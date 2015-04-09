using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeSystemSettingRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeSystemSettingRefSearch() {
            InitializeComponent();
            InitializeGridCrudeSystemSettingRef();
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
            var editForm = new CrudeSystemSettingRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeSystemSettingRef.CurrentRow.Cells["SystemSettingRcd"].Value);
        }
        
        private void dataGridViewCrudeSystemSettingRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeSystemSettingRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeSystemSettingRef.CurrentRow.Cells["SystemSettingRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeSystemSettingRef = new CrudeSystemSettingRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeSystemSettingRef.FetchWithFilter(                            
                     systemSettingRefCombo.Text
                    ,textBoxSystemSettingName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeSystemSettingRef.AutoGenerateColumns = false;
                dataGridViewCrudeSystemSettingRef.DataSource = bindingSource;
                dataGridViewCrudeSystemSettingRef.AutoResizeColumns();
                dataGridViewCrudeSystemSettingRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeSystemSettingRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeSystemSettingRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeSystemSettingRef() {
            dataGridViewCrudeSystemSettingRef.Columns.Clear();
            dataGridViewCrudeSystemSettingRef.AutoGenerateColumns = false;
            dataGridViewCrudeSystemSettingRef.Columns.Add("SystemSettingRcd","System Setting");
            dataGridViewCrudeSystemSettingRef.Columns.Add("SystemSettingName","System Setting Name");
            dataGridViewCrudeSystemSettingRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeSystemSettingRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeSystemSettingRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeSystemSettingRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeSystemSettingRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeSystemSettingRef.AutoResizeColumns();
        }
    }
}
