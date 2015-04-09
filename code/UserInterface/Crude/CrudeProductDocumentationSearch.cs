using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductDocumentationSearch : Form {
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductDocumentationSearch() {
            InitializeComponent();
            InitializeGridCrudeProductDocumentation();
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
            var editForm = new CrudeProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
        }
        
        private void dataGridViewCrudeProductDocumentation_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductDocumentation = new CrudeProductDocumentationService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductDocumentation.FetchWithFilter(                            
                     Guid.Empty
                    ,productPicker.SelectedValue
                    ,productDocumentationTypeRefCombo.Text
                    ,textBoxDocumentation.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductDocumentation.AutoGenerateColumns = false;
                dataGridViewCrudeProductDocumentation.DataSource = bindingSource;
                dataGridViewCrudeProductDocumentation.AutoResizeColumns();
                dataGridViewCrudeProductDocumentation.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductDocumentation.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productId, _userId);
        }
        
        private void InitializeGridCrudeProductDocumentation() {
            dataGridViewCrudeProductDocumentation.Columns.Clear();
            dataGridViewCrudeProductDocumentation.AutoGenerateColumns = false;
            dataGridViewCrudeProductDocumentation.Columns.Add("ProductDocumentationId","Product Documentation Id");
            dataGridViewCrudeProductDocumentation.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductDocumentation.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
            dataGridViewCrudeProductDocumentation.Columns.Add("Documentation","Documentation");
            dataGridViewCrudeProductDocumentation.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductDocumentation.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductDocumentation.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductDocumentation.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductDocumentation.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductDocumentation.AutoResizeColumns();
        }
    }
}
