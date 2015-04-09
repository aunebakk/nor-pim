using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductAttributeUnitRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductAttributeUnitRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttributeUnitRef();
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
            var editForm = new CrudeProductAttributeUnitRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeUnitRef.CurrentRow.Cells["ProductAttributeUnitRcd"].Value);
        }
        
        private void dataGridViewCrudeProductAttributeUnitRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductAttributeUnitRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeUnitRef.CurrentRow.Cells["ProductAttributeUnitRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductAttributeUnitRef = new CrudeProductAttributeUnitRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductAttributeUnitRef.FetchWithFilter(                            
                     productAttributeUnitRefCombo.Text
                    ,textBoxProductAttributeUnitName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductAttributeUnitRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeUnitRef.DataSource = bindingSource;
                dataGridViewCrudeProductAttributeUnitRef.AutoResizeColumns();
                dataGridViewCrudeProductAttributeUnitRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductAttributeUnitRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductAttributeUnitRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductAttributeUnitRef() {
            dataGridViewCrudeProductAttributeUnitRef.Columns.Clear();
            dataGridViewCrudeProductAttributeUnitRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ProductAttributeUnitRcd","Product Attribute Unit");
            dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ProductAttributeUnitName","Product Attribute Unit Name");
            dataGridViewCrudeProductAttributeUnitRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductAttributeUnitRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductAttributeUnitRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductAttributeUnitRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductAttributeUnitRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductAttributeUnitRef.AutoResizeColumns();
        }
    }
}
