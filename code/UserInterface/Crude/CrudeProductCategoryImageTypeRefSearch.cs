using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategoryImageTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductCategoryImageTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductCategoryImageTypeRef();
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
            var editForm = new CrudeProductCategoryImageTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryImageTypeRef.CurrentRow.Cells["ProductCategoryImageTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductCategoryImageTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryImageTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductCategoryImageTypeRef.CurrentRow.Cells["ProductCategoryImageTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductCategoryImageTypeRef = new CrudeProductCategoryImageTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductCategoryImageTypeRef.FetchWithFilter(                            
                     productCategoryImageTypeRefCombo.Text
                    ,textBoxProductCategoryImageTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductCategoryImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductCategoryImageTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductCategoryImageTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductCategoryImageTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductCategoryImageTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductCategoryImageTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductCategoryImageTypeRef() {
            dataGridViewCrudeProductCategoryImageTypeRef.Columns.Clear();
            dataGridViewCrudeProductCategoryImageTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ProductCategoryImageTypeRcd","Product Category Image Type");
            dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ProductCategoryImageTypeName","Product Category Image Type Name");
            dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductCategoryImageTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductCategoryImageTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductCategoryImageTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductCategoryImageTypeRef.AutoResizeColumns();
        }
    }
}
