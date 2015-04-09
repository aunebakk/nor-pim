using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherAttributeSearch : Form {
        
        private Guid _productGatherKeyId;
        
        private Guid _userId;
        
        public CrudeProductGatherAttributeSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherAttribute();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productGatherKeyId, Guid userId) {
            _productGatherKeyId = productGatherKeyId;
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
            var editForm = new CrudeProductGatherAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherAttribute.CurrentRow.Cells["ProductGatherAttributeId"].Value);
        }
        
        private void dataGridViewCrudeProductGatherAttribute_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherAttribute.CurrentRow.Cells["ProductGatherAttributeId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductGatherAttribute = new CrudeProductGatherAttributeService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductGatherAttribute.FetchWithFilter(                            
                     Guid.Empty
                    ,textBoxProductGatherAttributeValue.Text
                    ,productGatherAttributeTypeRefCombo.Text
                    ,Guid.Empty
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductGatherAttribute.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttribute.DataSource = bindingSource;
                dataGridViewCrudeProductGatherAttribute.AutoResizeColumns();
                dataGridViewCrudeProductGatherAttribute.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductGatherAttribute.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productGatherKeyId, _userId);
        }
        
        private void InitializeGridCrudeProductGatherAttribute() {
            dataGridViewCrudeProductGatherAttribute.Columns.Clear();
            dataGridViewCrudeProductGatherAttribute.AutoGenerateColumns = false;
            dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeId","Product Gather Attribute Id");
            dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeValue","Product Gather Attribute Value");
            dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherAttributeTypeRcd","Product Gather Attribute Type");
            dataGridViewCrudeProductGatherAttribute.Columns.Add("ProductGatherKeyId","Product Gather Key Id");
            dataGridViewCrudeProductGatherAttribute.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductGatherAttribute.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductGatherAttribute.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductGatherAttribute.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductGatherAttribute.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductGatherAttribute.AutoResizeColumns();
        }
    }
}
