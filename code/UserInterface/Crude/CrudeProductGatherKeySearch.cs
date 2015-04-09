using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherKeySearch : Form {
        
        private Guid _productGatherId;
        
        private Guid _userId;
        
        public CrudeProductGatherKeySearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherKey();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productGatherId, Guid userId) {
            _productGatherId = productGatherId;
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
            var editForm = new CrudeProductGatherKeyEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherKey.CurrentRow.Cells["ProductGatherKeyId"].Value);
        }
        
        private void dataGridViewCrudeProductGatherKey_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherKeyEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherKey.CurrentRow.Cells["ProductGatherKeyId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductGatherKey = new CrudeProductGatherKeyService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductGatherKey.FetchWithFilter(                            
                     Guid.Empty
                    ,textBoxProductGatherKeyValue.Text
                    ,Guid.Empty
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductGatherKey.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherKey.DataSource = bindingSource;
                dataGridViewCrudeProductGatherKey.AutoResizeColumns();
                dataGridViewCrudeProductGatherKey.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductGatherKey.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherKeyEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productGatherId, _userId);
        }
        
        private void InitializeGridCrudeProductGatherKey() {
            dataGridViewCrudeProductGatherKey.Columns.Clear();
            dataGridViewCrudeProductGatherKey.AutoGenerateColumns = false;
            dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherKeyId","Product Gather Key Id");
            dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherKeyValue","Product Gather Key Value");
            dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherId","Product Gather Id");
            dataGridViewCrudeProductGatherKey.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductGatherKey.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductGatherKey.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductGatherKey.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductGatherKey.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductGatherKey.AutoResizeColumns();
        }
    }
}
