using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductFieldSetMappingSearch : Form {
        
        private Guid _productFieldSetId;
        
        private Guid _userId;
        
        public CrudeProductFieldSetMappingSearch() {
            InitializeComponent();
            InitializeGridCrudeProductFieldSetMapping();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productFieldSetId, Guid userId) {
            _productFieldSetId = productFieldSetId;
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
            var editForm = new CrudeProductFieldSetMappingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSetMapping.CurrentRow.Cells["ProductFieldSetMappingId"].Value);
        }
        
        private void dataGridViewCrudeProductFieldSetMapping_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductFieldSetMappingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSetMapping.CurrentRow.Cells["ProductFieldSetMappingId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductFieldSetMapping = new CrudeProductFieldSetMappingService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductFieldSetMapping.FetchWithFilter(                            
                     Guid.Empty
                    ,Guid.Empty
                    ,productIdentifierRefCombo.Text
                    ,productAttributeRefCombo.Text
                    ,productInfoRefCombo.Text
                    ,productImageTypeRefCombo.Text
                    ,productDocumentationTypeRefCombo.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductFieldSetMapping.AutoGenerateColumns = false;
                dataGridViewCrudeProductFieldSetMapping.DataSource = bindingSource;
                dataGridViewCrudeProductFieldSetMapping.AutoResizeColumns();
                dataGridViewCrudeProductFieldSetMapping.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductFieldSetMapping.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductFieldSetMappingEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productFieldSetId, _userId);
        }
        
        private void InitializeGridCrudeProductFieldSetMapping() {
            dataGridViewCrudeProductFieldSetMapping.Columns.Clear();
            dataGridViewCrudeProductFieldSetMapping.AutoGenerateColumns = false;
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductFieldSetMappingId","Product Field Set Mapping Id");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductFieldSetId","Product Field Set Id");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductIdentifierRcd","Product Identifier");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductAttributeRcd","Product Attribute");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductInfoRcd","Product Info");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductImageTypeRcd","Product Image Type");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductFieldSetMapping.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductFieldSetMapping.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductFieldSetMapping.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductFieldSetMapping.AutoResizeColumns();
        }
    }
}
