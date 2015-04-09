using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductSearch() {
            InitializeComponent();
            InitializeGridCrudeProduct();
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
            var editForm = new CrudeProductEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProduct.CurrentRow.Cells["ProductId"].Value);
        }
        
        private void dataGridViewCrudeProduct_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProduct.CurrentRow.Cells["ProductId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProduct = new CrudeProductService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProduct.FetchWithFilter(                            
                     Guid.Empty
                    ,Guid.Empty
                    ,textBoxProductName.Text
                    ,stateRefCombo.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProduct.AutoGenerateColumns = false;
                dataGridViewCrudeProduct.DataSource = bindingSource;
                dataGridViewCrudeProduct.AutoResizeColumns();
                dataGridViewCrudeProduct.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProduct.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProduct() {
            dataGridViewCrudeProduct.Columns.Clear();
            dataGridViewCrudeProduct.AutoGenerateColumns = false;
            dataGridViewCrudeProduct.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProduct.Columns.Add("ProductName","Product Name");
            dataGridViewCrudeProduct.Columns.Add("StateRcd","State");
            dataGridViewCrudeProduct.Columns.Add("UserId","User Id");
            dataGridViewCrudeProduct.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProduct.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProduct.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProduct.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProduct.AutoResizeColumns();
        }
    }
}
