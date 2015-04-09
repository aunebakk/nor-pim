using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposePlanSearch : Form {
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductExposePlanSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposePlan();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productId, Guid userId) {
            _productId = productId;
            productPicker.SelectedValue = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;
            buttonSearch_Click(new object(), new EventArgs());
            base.Show();
        }
        
        public void ShowByProductId(Guid productId) {
            productPicker.SelectedValue = productId;
            buttonSearch_Click(new object(), new EventArgs());
            Show();
        }
        
        public void ShowByUserId(Guid userId) {
            userPicker.SelectedValue = userId;
            buttonSearch_Click(new object(), new EventArgs());
            Show();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductExposePlanEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposePlan.CurrentRow.Cells["ProductExposePlanId"].Value);
        }
        
        private void dataGridViewCrudeProductExposePlan_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductExposePlanEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposePlan.CurrentRow.Cells["ProductExposePlanId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductExposePlan = new CrudeProductExposePlanService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductExposePlan.FetchWithFilter(                            
                     Guid.Empty
                    ,productPicker.SelectedValue
                    ,productExposeSetTypeRefCombo.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductExposePlan.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposePlan.DataSource = bindingSource;
                dataGridViewCrudeProductExposePlan.AutoResizeColumns();
                dataGridViewCrudeProductExposePlan.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductExposePlan.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductExposePlanEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productId, _userId);
        }
        
        private void InitializeGridCrudeProductExposePlan() {
            dataGridViewCrudeProductExposePlan.Columns.Clear();
            dataGridViewCrudeProductExposePlan.AutoGenerateColumns = false;
            dataGridViewCrudeProductExposePlan.Columns.Add("ProductExposePlanId","Product Expose Plan Id");
            dataGridViewCrudeProductExposePlan.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductExposePlan.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
            dataGridViewCrudeProductExposePlan.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductExposePlan.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductExposePlan.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductExposePlan.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductExposePlan.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductExposePlan.AutoResizeColumns();
        }
    }
}
