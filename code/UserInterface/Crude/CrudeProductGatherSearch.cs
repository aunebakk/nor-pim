using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductGatherSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGather();
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
            var editForm = new CrudeProductGatherEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGather.CurrentRow.Cells["ProductGatherId"].Value);
        }
        
        private void dataGridViewCrudeProductGather_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGather.CurrentRow.Cells["ProductGatherId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductGather = new CrudeProductGatherService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductGather.FetchWithFilter(                            
                     Guid.Empty
                    ,dateTimePickerStartDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerStartDateTime.Value)
                    ,dateTimePickerFinishDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerFinishDateTime.Value)
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductGather.AutoGenerateColumns = false;
                dataGridViewCrudeProductGather.DataSource = bindingSource;
                dataGridViewCrudeProductGather.AutoResizeColumns();
                dataGridViewCrudeProductGather.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductGather.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductGather() {
            dataGridViewCrudeProductGather.Columns.Clear();
            dataGridViewCrudeProductGather.AutoGenerateColumns = false;
            dataGridViewCrudeProductGather.Columns.Add("ProductGatherId","Product Gather Id");
            dataGridViewCrudeProductGather.Columns.Add("StartDateTime","Start Date Time");
            dataGridViewCrudeProductGather.Columns.Add("FinishDateTime","Finish Date Time");
            dataGridViewCrudeProductGather.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductGather.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductGather.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductGather.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductGather.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductGather.AutoResizeColumns();
        }
    }
}
