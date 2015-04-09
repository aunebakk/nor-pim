using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductImageSearch : Form {
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductImageSearch() {
            InitializeComponent();
            InitializeGridCrudeProductImage();
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
            var editForm = new CrudeProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductImage.CurrentRow.Cells["ProductImageId"].Value);
        }
        
        private void dataGridViewCrudeProductImage_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductImage.CurrentRow.Cells["ProductImageId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductImage = new CrudeProductImageService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductImage.FetchWithFilter(                            
                     Guid.Empty
                    ,productPicker.SelectedValue
                    ,productImageTypeRefCombo.Text
                    ,null
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    ,textBoxImageFileName.Text
                    );

                dataGridViewCrudeProductImage.AutoGenerateColumns = false;
                dataGridViewCrudeProductImage.DataSource = bindingSource;
                dataGridViewCrudeProductImage.AutoResizeColumns();
                dataGridViewCrudeProductImage.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductImage.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productId, _userId);
        }
        
        private void InitializeGridCrudeProductImage() {
            dataGridViewCrudeProductImage.Columns.Clear();
            dataGridViewCrudeProductImage.AutoGenerateColumns = false;
            dataGridViewCrudeProductImage.Columns.Add("ProductImageId","Product Image Id");
            dataGridViewCrudeProductImage.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductImage.Columns.Add("ProductImageTypeRcd","Product Image Type");
            dataGridViewCrudeProductImage.Columns.Add("Image","Image");
            dataGridViewCrudeProductImage.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductImage.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductImage.Columns.Add("ImageFileName","Image File Name");
            dataGridViewCrudeProductImage.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductImage.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductImage.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductImage.AutoResizeColumns();
        }
    }
}
