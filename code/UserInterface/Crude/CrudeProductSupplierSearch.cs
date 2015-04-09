using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductSupplierSearch : Form {
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductSupplierSearch() {
            InitializeComponent();
            InitializeGridCrudeProductSupplier();
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
            var editForm = new CrudeProductSupplierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductSupplier.CurrentRow.Cells["ProductSupplierId"].Value);
        }
        
        private void dataGridViewCrudeProductSupplier_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductSupplierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductSupplier.CurrentRow.Cells["ProductSupplierId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductSupplier = new CrudeProductSupplierService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductSupplier.FetchWithFilter(                            
                     Guid.Empty
                    ,productPicker.SelectedValue
                    ,textBoxSupplierName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductSupplier.AutoGenerateColumns = false;
                dataGridViewCrudeProductSupplier.DataSource = bindingSource;
                dataGridViewCrudeProductSupplier.AutoResizeColumns();
                dataGridViewCrudeProductSupplier.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductSupplier.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductSupplierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productId, _userId);
        }
        
        private void InitializeGridCrudeProductSupplier() {
            dataGridViewCrudeProductSupplier.Columns.Clear();
            dataGridViewCrudeProductSupplier.AutoGenerateColumns = false;
            dataGridViewCrudeProductSupplier.Columns.Add("ProductSupplierId","Product Supplier Id");
            dataGridViewCrudeProductSupplier.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductSupplier.Columns.Add("SupplierName","Supplier Name");
            dataGridViewCrudeProductSupplier.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductSupplier.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductSupplier.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductSupplier.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductSupplier.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductSupplier.AutoResizeColumns();
        }
    }
}
