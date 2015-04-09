using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceSearch : Form {
        
        private Guid _productGatherId;
        
        private Guid _userId;
        
        public CrudeProductGatherSourceSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherSource();
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
            var editForm = new CrudeProductGatherSourceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherSource.CurrentRow.Cells["ProductGatherSourceId"].Value);
        }
        
        private void dataGridViewCrudeProductGatherSource_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherSourceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherSource.CurrentRow.Cells["ProductGatherSourceId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductGatherSource = new CrudeProductGatherSourceService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductGatherSource.FetchWithFilter(                            
                     Guid.Empty
                    ,Guid.Empty
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    ,productGatherSourceTypeRefCombo.Text
                    );

                dataGridViewCrudeProductGatherSource.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSource.DataSource = bindingSource;
                dataGridViewCrudeProductGatherSource.AutoResizeColumns();
                dataGridViewCrudeProductGatherSource.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductGatherSource.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductGatherSourceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productGatherId, _userId);
        }
        
        private void InitializeGridCrudeProductGatherSource() {
            dataGridViewCrudeProductGatherSource.Columns.Clear();
            dataGridViewCrudeProductGatherSource.AutoGenerateColumns = false;
            dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherSourceId","Product Gather Source Id");
            dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherId","Product Gather Id");
            dataGridViewCrudeProductGatherSource.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductGatherSource.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductGatherSource.Columns.Add("ProductGatherSourceTypeRcd","Product Gather Source Type");
            dataGridViewCrudeProductGatherSource.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductGatherSource.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductGatherSource.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductGatherSource.AutoResizeColumns();
        }
    }
}
