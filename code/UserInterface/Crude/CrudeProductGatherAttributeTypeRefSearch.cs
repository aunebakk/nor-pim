using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherAttributeTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductGatherAttributeTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherAttributeTypeRef();
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
            var editForm = new CrudeProductGatherAttributeTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherAttributeTypeRef.CurrentRow.Cells["ProductGatherAttributeTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductGatherAttributeTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherAttributeTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherAttributeTypeRef.CurrentRow.Cells["ProductGatherAttributeTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductGatherAttributeTypeRef = new CrudeProductGatherAttributeTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductGatherAttributeTypeRef.FetchWithFilter(                            
                     productGatherAttributeTypeRefCombo.Text
                    ,textBoxProductGatherAttributeTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductGatherAttributeTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttributeTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductGatherAttributeTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductGatherAttributeTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherAttributeTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductGatherAttributeTypeRef() {
            dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Clear();
            dataGridViewCrudeProductGatherAttributeTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ProductGatherAttributeTypeRcd","Product Gather Attribute Type");
            dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ProductGatherAttributeTypeName","Product Gather Attribute Type Name");
            dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductGatherAttributeTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductGatherAttributeTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductGatherAttributeTypeRef.AutoResizeColumns();
        }
    }
}
