using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategoryImageSearch : Form {
        
        private Guid _productCategoryId;
        
        private Guid _userId;
        
        public CrudeProductCategoryImageSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryImage();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productCategoryId, Guid userId) {
            _productCategoryId = productCategoryId;
            productCategoryPicker.SelectedValue = productCategoryId;
            _userId = userId;
            userPicker.SelectedValue = userId;
            buttonSearch_Click(new object(), new EventArgs());
            base.Show();
        }
        
        public void ShowByProductCategoryId(Guid productCategoryId) {
            productCategoryPicker.SelectedValue = productCategoryId;
            buttonSearch_Click(new object(), new EventArgs());
            Show();
        }
        
        public void ShowByUserId(Guid userId) {
            userPicker.SelectedValue = userId;
            buttonSearch_Click(new object(), new EventArgs());
            Show();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryImage.CurrentRow.Cells["ProductCategoryImageId"].Value);
        }
        
        private void dataGridViewCrudeProductCategoryImage_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryImage.CurrentRow.Cells["ProductCategoryImageId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductCategoryImage = new CrudeProductCategoryImageService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductCategoryImage.FetchWithFilter(                            
                     Guid.Empty
                    ,productCategoryPicker.SelectedValue
                    ,productCategoryImageTypeRefCombo.Text
                    ,null
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductCategoryImage.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryImage.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryImage.AutoResizeColumns();
                dataGridViewCrudeProductCategoryImage.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductCategoryImage.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productCategoryId, _userId);
        }
        
        private void InitializeGridCrudeProductCategoryImage() {
            dataGridViewCrudeProductCategoryImage.Columns.Clear();
            dataGridViewCrudeProductCategoryImage.AutoGenerateColumns = false;
            dataGridViewCrudeProductCategoryImage.Columns.Add("ProductCategoryImageId","Product Category Image Id");
            dataGridViewCrudeProductCategoryImage.Columns.Add("ProductCategoryId","Product Category Id");
            dataGridViewCrudeProductCategoryImage.Columns.Add("ProductCategoryImageTypeRcd","Product Category Image Type");
            dataGridViewCrudeProductCategoryImage.Columns.Add("Image","Image");
            dataGridViewCrudeProductCategoryImage.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductCategoryImage.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductCategoryImage.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductCategoryImage.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductCategoryImage.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductCategoryImage.AutoResizeColumns();
        }
    }
}
