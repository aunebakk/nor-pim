using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategoryDocumentationSearch : Form {
        
        private Guid _productCategoryId;
        
        private Guid _userId;
        
        public CrudeProductCategoryDocumentationSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryDocumentation();
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
            var editForm = new CrudeProductCategoryDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryDocumentation.CurrentRow.Cells["ProductCategoryDocumentationId"].Value);
        }
        
        private void dataGridViewCrudeProductCategoryDocumentation_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductCategoryDocumentation.CurrentRow.Cells["ProductCategoryDocumentationId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductCategoryDocumentation = new CrudeProductCategoryDocumentationService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductCategoryDocumentation.FetchWithFilter(                            
                     Guid.Empty
                    ,productCategoryDocumentationTypeRefCombo.Text
                    ,productCategoryPicker.SelectedValue
                    ,textBoxDocumentation.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductCategoryDocumentation.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryDocumentation.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryDocumentation.AutoResizeColumns();
                dataGridViewCrudeProductCategoryDocumentation.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductCategoryDocumentation.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productCategoryId, _userId);
        }
        
        private void InitializeGridCrudeProductCategoryDocumentation() {
            dataGridViewCrudeProductCategoryDocumentation.Columns.Clear();
            dataGridViewCrudeProductCategoryDocumentation.AutoGenerateColumns = false;
            dataGridViewCrudeProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationId","Product Category Documentation Id");
            dataGridViewCrudeProductCategoryDocumentation.Columns.Add("ProductCategoryDocumentationTypeRcd","Product Category Documentation Type");
            dataGridViewCrudeProductCategoryDocumentation.Columns.Add("ProductCategoryId","Product Category Id");
            dataGridViewCrudeProductCategoryDocumentation.Columns.Add("Documentation","Documentation");
            dataGridViewCrudeProductCategoryDocumentation.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductCategoryDocumentation.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductCategoryDocumentation.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductCategoryDocumentation.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductCategoryDocumentation.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductCategoryDocumentation.AutoResizeColumns();
        }
    }
}
