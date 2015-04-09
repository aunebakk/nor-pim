using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeUserActivitySearch : Form {
        
        private Guid _userId;
        
        public CrudeUserActivitySearch() {
            InitializeComponent();
            InitializeGridCrudeUserActivity();
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
            var editForm = new CrudeUserActivityEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeUserActivity.CurrentRow.Cells["UserActivityId"].Value);
        }
        
        private void dataGridViewCrudeUserActivity_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeUserActivityEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeUserActivity.CurrentRow.Cells["UserActivityId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeUserActivity = new CrudeUserActivityService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeUserActivity.FetchWithFilter(                            
                     Guid.Empty
                    ,userActivityTypeRefCombo.Text
                    ,textBoxUserActivityNote.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    ,textBoxOriginatingAddress.Text
                    );

                dataGridViewCrudeUserActivity.AutoGenerateColumns = false;
                dataGridViewCrudeUserActivity.DataSource = bindingSource;
                dataGridViewCrudeUserActivity.AutoResizeColumns();
                dataGridViewCrudeUserActivity.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeUserActivity.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeUserActivityEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeUserActivity() {
            dataGridViewCrudeUserActivity.Columns.Clear();
            dataGridViewCrudeUserActivity.AutoGenerateColumns = false;
            dataGridViewCrudeUserActivity.Columns.Add("UserActivityId","User Activity Id");
            dataGridViewCrudeUserActivity.Columns.Add("UserActivityTypeRcd","User Activity Type");
            dataGridViewCrudeUserActivity.Columns.Add("UserActivityNote","User Activity Note");
            dataGridViewCrudeUserActivity.Columns.Add("UserId","User Id");
            dataGridViewCrudeUserActivity.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeUserActivity.Columns.Add("OriginatingAddress","Originating Address");
            dataGridViewCrudeUserActivity.Columns.Add("ExtensionData", "");
            dataGridViewCrudeUserActivity.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeUserActivity.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeUserActivity.AutoResizeColumns();
        }
    }
}
