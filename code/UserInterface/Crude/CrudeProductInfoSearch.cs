using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductInfoSearch : Form {
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductInfoSearch() {
            InitializeComponent();
            InitializeGridCrudeProductInfo();
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
            var editForm = new CrudeProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
        }
        
        private void dataGridViewCrudeProductInfo_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductInfo = new CrudeProductInfoService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductInfo.FetchWithFilter(                            
                     Guid.Empty
                    ,productPicker.SelectedValue
                    ,productInfoRefCombo.Text
                    ,textBoxProductInfoValue.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductInfo.AutoGenerateColumns = false;
                dataGridViewCrudeProductInfo.DataSource = bindingSource;
                dataGridViewCrudeProductInfo.AutoResizeColumns();
                dataGridViewCrudeProductInfo.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductInfo.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productId, _userId);
        }
        
        private void InitializeGridCrudeProductInfo() {
            dataGridViewCrudeProductInfo.Columns.Clear();
            dataGridViewCrudeProductInfo.AutoGenerateColumns = false;
            dataGridViewCrudeProductInfo.Columns.Add("ProductInfoId","Product Info Id");
            dataGridViewCrudeProductInfo.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductInfo.Columns.Add("ProductInfoRcd","Product Info");
            dataGridViewCrudeProductInfo.Columns.Add("ProductInfoValue","Product Info Value");
            dataGridViewCrudeProductInfo.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductInfo.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductInfo.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductInfo.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductInfo.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductInfo.AutoResizeColumns();
        }
    }
}
