using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategoryDocumentationTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductCategoryDocumentationTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryDocumentationTypeRef();
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
            var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryDocumentationTypeRef.CurrentRow.Cells["ProductCategoryDocumentationTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductCategoryDocumentationTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryDocumentationTypeRef.CurrentRow.Cells["ProductCategoryDocumentationTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductCategoryDocumentationTypeRef = new CrudeProductCategoryDocumentationTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductCategoryDocumentationTypeRef.FetchWithFilter(                            
                     productCategoryDocumentationTypeRefCombo.Text
                    ,textBoxProductCategoryDocumentationTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductCategoryDocumentationTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductCategoryDocumentationTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryDocumentationTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductCategoryDocumentationTypeRef() {
            dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Clear();
            dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ProductCategoryDocumentationTypeRcd","Product Category Documentation Type");
            dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ProductCategoryDocumentationTypeName","Product Category Documentation Type Name");
            dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductCategoryDocumentationTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductCategoryDocumentationTypeRef.AutoResizeColumns();
        }
    }
}
