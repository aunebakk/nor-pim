using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeUserActivityTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeUserActivityTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeUserActivityTypeRef();
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
            var editForm = new CrudeUserActivityTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeUserActivityTypeRef.CurrentRow.Cells["UserActivityTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeUserActivityTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeUserActivityTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeUserActivityTypeRef.CurrentRow.Cells["UserActivityTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeUserActivityTypeRef = new CrudeUserActivityTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeUserActivityTypeRef.FetchWithFilter(                            
                     userActivityTypeRefCombo.Text
                    ,textBoxUserActivityTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeUserActivityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeUserActivityTypeRef.DataSource = bindingSource;
                dataGridViewCrudeUserActivityTypeRef.AutoResizeColumns();
                dataGridViewCrudeUserActivityTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeUserActivityTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeUserActivityTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeUserActivityTypeRef() {
            dataGridViewCrudeUserActivityTypeRef.Columns.Clear();
            dataGridViewCrudeUserActivityTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeUserActivityTypeRef.Columns.Add("UserActivityTypeRcd","User Activity Type");
            dataGridViewCrudeUserActivityTypeRef.Columns.Add("UserActivityTypeName","User Activity Type Name");
            dataGridViewCrudeUserActivityTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeUserActivityTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeUserActivityTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeUserActivityTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeUserActivityTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeUserActivityTypeRef.AutoResizeColumns();
        }
    }
}
