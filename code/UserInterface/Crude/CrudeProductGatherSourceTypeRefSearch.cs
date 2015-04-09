using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductGatherSourceTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherSourceTypeRef();
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
            var editForm = new CrudeProductGatherSourceTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherSourceTypeRef.CurrentRow.Cells["ProductGatherSourceTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductGatherSourceTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherSourceTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherSourceTypeRef.CurrentRow.Cells["ProductGatherSourceTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductGatherSourceTypeRef = new CrudeProductGatherSourceTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductGatherSourceTypeRef.FetchWithFilter(                            
                     productGatherSourceTypeRefCombo.Text
                    ,textBoxProductGatherSourceTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductGatherSourceTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSourceTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductGatherSourceTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductGatherSourceTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductGatherSourceTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherSourceTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductGatherSourceTypeRef() {
            dataGridViewCrudeProductGatherSourceTypeRef.Columns.Clear();
            dataGridViewCrudeProductGatherSourceTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ProductGatherSourceTypeRcd","Product Gather Source Type");
            dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ProductGatherSourceTypeName","Product Gather Source Type Name");
            dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductGatherSourceTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductGatherSourceTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductGatherSourceTypeRef.AutoResizeColumns();
        }
    }
}
