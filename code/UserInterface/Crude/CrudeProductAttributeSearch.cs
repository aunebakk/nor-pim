using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductAttributeSearch : Form {
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductAttributeSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttribute();
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
            var editForm = new CrudeProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
        }
        
        private void dataGridViewCrudeProductAttribute_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductAttribute = new CrudeProductAttributeService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductAttribute.FetchWithFilter(                            
                     Guid.Empty
                    ,productPicker.SelectedValue
                    ,productAttributeRefCombo.Text
                    ,productAttributeUnitRefCombo.Text
                    ,textBoxValue.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductAttribute.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttribute.DataSource = bindingSource;
                dataGridViewCrudeProductAttribute.AutoResizeColumns();
                dataGridViewCrudeProductAttribute.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductAttribute.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productId, _userId);
        }
        
        private void InitializeGridCrudeProductAttribute() {
            dataGridViewCrudeProductAttribute.Columns.Clear();
            dataGridViewCrudeProductAttribute.AutoGenerateColumns = false;
            dataGridViewCrudeProductAttribute.Columns.Add("ProductAttributeId","Product Attribute Id");
            dataGridViewCrudeProductAttribute.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductAttribute.Columns.Add("ProductAttributeRcd","Product Attribute");
            dataGridViewCrudeProductAttribute.Columns.Add("ProductAttributeUnitRcd","Product Attribute Unit");
            dataGridViewCrudeProductAttribute.Columns.Add("Value","Value");
            dataGridViewCrudeProductAttribute.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductAttribute.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductAttribute.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductAttribute.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductAttribute.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductAttribute.AutoResizeColumns();
        }
    }
}
