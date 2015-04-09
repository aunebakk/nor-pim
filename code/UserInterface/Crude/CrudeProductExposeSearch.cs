using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposeSearch : Form {
        
        private Guid _productExposeSetId;
        
        private Guid _userId;
        
        public CrudeProductExposeSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExpose();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productExposeSetId, Guid userId) {
            _productExposeSetId = productExposeSetId;
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
            var editForm = new CrudeProductExposeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExpose.CurrentRow.Cells["ProductExposeId"].Value);
        }
        
        private void dataGridViewCrudeProductExpose_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductExposeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExpose.CurrentRow.Cells["ProductExposeId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductExpose = new CrudeProductExposeService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductExpose.FetchWithFilter(                            
                     Guid.Empty
                    ,Guid.Empty
                    ,Guid.Empty
                    ,Guid.Empty
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductExpose.AutoGenerateColumns = false;
                dataGridViewCrudeProductExpose.DataSource = bindingSource;
                dataGridViewCrudeProductExpose.AutoResizeColumns();
                dataGridViewCrudeProductExpose.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductExpose.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductExposeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productExposeSetId, _userId);
        }
        
        private void InitializeGridCrudeProductExpose() {
            dataGridViewCrudeProductExpose.Columns.Clear();
            dataGridViewCrudeProductExpose.AutoGenerateColumns = false;
            dataGridViewCrudeProductExpose.Columns.Add("ProductExposeId","Product Expose Id");
            dataGridViewCrudeProductExpose.Columns.Add("ProductExposeSetId","Product Expose Set Id");
            dataGridViewCrudeProductExpose.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductExpose.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductExpose.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductExpose.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductExpose.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductExpose.AutoResizeColumns();
        }
    }
}
