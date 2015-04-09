using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategoryMappingSearch : Form {
        
        private Guid _productCategoryId;
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductCategoryMappingSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryMapping();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productCategoryId, Guid productId, Guid userId) {
            _productCategoryId = productCategoryId;
            productCategoryPicker.SelectedValue = productCategoryId;
            _productId = productId;
            productPicker.SelectedValue = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;
            buttonSearch_Click(new object(), new EventArgs());
            base.Show();
        }
        
        public void ShowByProductCategoryId(Guid productCategoryId) {
            productCategoryPicker.SelectedValue = productCategoryId;
            buttonSearch_Click(new object(), new EventArgs());
            Show();
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
            var editForm = new CrudeProductCategoryMappingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryMapping.CurrentRow.Cells["ProductCategoryMappingId"].Value);
        }
        
        private void dataGridViewCrudeProductCategoryMapping_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryMappingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryMapping.CurrentRow.Cells["ProductCategoryMappingId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductCategoryMapping = new CrudeProductCategoryMappingService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductCategoryMapping.FetchWithFilter(                            
                     Guid.Empty
                    ,productCategoryPicker.SelectedValue
                    ,productPicker.SelectedValue
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductCategoryMapping.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryMapping.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryMapping.AutoResizeColumns();
                dataGridViewCrudeProductCategoryMapping.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductCategoryMapping.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryMappingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productCategoryId, _productId, _userId);
        }
        
        private void InitializeGridCrudeProductCategoryMapping() {
            dataGridViewCrudeProductCategoryMapping.Columns.Clear();
            dataGridViewCrudeProductCategoryMapping.AutoGenerateColumns = false;
            dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductCategoryMappingId","Product Category Mapping Id");
            dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductCategoryId","Product Category Id");
            dataGridViewCrudeProductCategoryMapping.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductCategoryMapping.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductCategoryMapping.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductCategoryMapping.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductCategoryMapping.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductCategoryMapping.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductCategoryMapping.AutoResizeColumns();
        }
    }
}
