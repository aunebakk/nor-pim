using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposedSelectionSearch : Form {
        
        private Guid _productExposeId;
        
        private Guid _userId;
        
        public CrudeProductExposedSelectionSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposedSelection();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productExposeId, Guid userId) {
            _productExposeId = productExposeId;
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
            var editForm = new CrudeProductExposedSelectionEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposedSelection.CurrentRow.Cells["ProductExposedSelectionId"].Value);
        }
        
        private void dataGridViewCrudeProductExposedSelection_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductExposedSelectionEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposedSelection.CurrentRow.Cells["ProductExposedSelectionId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductExposedSelection = new CrudeProductExposedSelectionService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductExposedSelection.FetchWithFilter(                            
                     Guid.Empty
                    ,Guid.Empty
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductExposedSelection.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposedSelection.DataSource = bindingSource;
                dataGridViewCrudeProductExposedSelection.AutoResizeColumns();
                dataGridViewCrudeProductExposedSelection.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductExposedSelection.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductExposedSelectionEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productExposeId, _userId);
        }
        
        private void InitializeGridCrudeProductExposedSelection() {
            dataGridViewCrudeProductExposedSelection.Columns.Clear();
            dataGridViewCrudeProductExposedSelection.AutoGenerateColumns = false;
            dataGridViewCrudeProductExposedSelection.Columns.Add("ProductExposedSelectionId","Product Exposed Selection Id");
            dataGridViewCrudeProductExposedSelection.Columns.Add("ProductExposeId","Product Expose Id");
            dataGridViewCrudeProductExposedSelection.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductExposedSelection.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductExposedSelection.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductExposedSelection.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductExposedSelection.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductExposedSelection.AutoResizeColumns();
        }
    }
}
