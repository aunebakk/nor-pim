using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategorySearch : Form {
        
        private Guid _userId;
        
        public CrudeProductCategorySearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategory();
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
            var editForm = new CrudeProductCategoryEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategory.CurrentRow.Cells["ProductCategoryId"].Value);
        }
        
        private void dataGridViewCrudeProductCategory_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategory.CurrentRow.Cells["ProductCategoryId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductCategory = new CrudeProductCategoryService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductCategory.FetchWithFilter(                            
                     Guid.Empty
                    ,Guid.Empty
                    ,Guid.Empty
                    ,textBoxProductCategoryCode.Text
                    ,textBoxProductCategoryName.Text
                    ,maskedTextBoxProductCategoryPosition.Text == "" ? 0 : Convert.ToInt32(maskedTextBoxProductCategoryPosition.Text)
                    ,stateRefCombo.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductCategory.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategory.DataSource = bindingSource;
                dataGridViewCrudeProductCategory.AutoResizeColumns();
                dataGridViewCrudeProductCategory.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductCategory.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductCategory() {
            dataGridViewCrudeProductCategory.Columns.Clear();
            dataGridViewCrudeProductCategory.AutoGenerateColumns = false;
            dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryId","Product Category Id");
            dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryCode","Product Category Code");
            dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryName","Product Category Name");
            dataGridViewCrudeProductCategory.Columns.Add("ProductCategoryPosition","Product Category Position");
            dataGridViewCrudeProductCategory.Columns.Add("StateRcd","State");
            dataGridViewCrudeProductCategory.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductCategory.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductCategory.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductCategory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductCategory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductCategory.AutoResizeColumns();
        }
    }
}
