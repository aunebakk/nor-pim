using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductAttributeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductAttributeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductAttributeRef();
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
            var editForm = new CrudeProductAttributeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeRef.CurrentRow.Cells["ProductAttributeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductAttributeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductAttributeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductAttributeRef.CurrentRow.Cells["ProductAttributeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductAttributeRef = new CrudeProductAttributeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductAttributeRef.FetchWithFilter(                            
                     productAttributeRefCombo.Text
                    ,textBoxProductAttributeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductAttributeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductAttributeRef.DataSource = bindingSource;
                dataGridViewCrudeProductAttributeRef.AutoResizeColumns();
                dataGridViewCrudeProductAttributeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductAttributeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductAttributeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductAttributeRef() {
            dataGridViewCrudeProductAttributeRef.Columns.Clear();
            dataGridViewCrudeProductAttributeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductAttributeRef.Columns.Add("ProductAttributeRcd","Product Attribute");
            dataGridViewCrudeProductAttributeRef.Columns.Add("ProductAttributeName","Product Attribute Name");
            dataGridViewCrudeProductAttributeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductAttributeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductAttributeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductAttributeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductAttributeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductAttributeRef.AutoResizeColumns();
        }
    }
}
