using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductChangeSetSearch : Form {
        
        private Guid _productId;
        
        private Guid _productGatherKeyId;
        
        private Guid _userId;
        
        public CrudeProductChangeSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductChangeSet();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productId, Guid productGatherKeyId, Guid userId) {
            _productId = productId;
            productPicker.SelectedValue = productId;
            _productGatherKeyId = productGatherKeyId;
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
            var editForm = new CrudeProductChangeSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductChangeSet.CurrentRow.Cells["ProductChangeSetId"].Value);
        }
        
        private void dataGridViewCrudeProductChangeSet_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductChangeSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductChangeSet.CurrentRow.Cells["ProductChangeSetId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductChangeSet = new CrudeProductChangeSetService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductChangeSet.FetchWithFilter(                            
                     Guid.Empty
                    ,productPicker.SelectedValue
                    ,Guid.Empty
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductChangeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductChangeSet.DataSource = bindingSource;
                dataGridViewCrudeProductChangeSet.AutoResizeColumns();
                dataGridViewCrudeProductChangeSet.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductChangeSet.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductChangeSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productId, _productGatherKeyId, _userId);
        }
        
        private void InitializeGridCrudeProductChangeSet() {
            dataGridViewCrudeProductChangeSet.Columns.Clear();
            dataGridViewCrudeProductChangeSet.AutoGenerateColumns = false;
            dataGridViewCrudeProductChangeSet.Columns.Add("ProductChangeSetId","Product Change Set Id");
            dataGridViewCrudeProductChangeSet.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductChangeSet.Columns.Add("ProductGatherKeyId","Product Gather Key Id");
            dataGridViewCrudeProductChangeSet.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductChangeSet.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductChangeSet.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductChangeSet.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductChangeSet.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductChangeSet.AutoResizeColumns();
        }
    }
}
