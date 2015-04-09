using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposeSetSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductExposeSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposeSet();
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
            var editForm = new CrudeProductExposeSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposeSet.CurrentRow.Cells["ProductExposeSetId"].Value);
        }
        
        private void dataGridViewCrudeProductExposeSet_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductExposeSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposeSet.CurrentRow.Cells["ProductExposeSetId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductExposeSet = new CrudeProductExposeSetService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductExposeSet.FetchWithFilter(                            
                     Guid.Empty
                    ,productExposeSetTypeRefCombo.Text
                    ,textBoxProductExposeSetName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductExposeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSet.DataSource = bindingSource;
                dataGridViewCrudeProductExposeSet.AutoResizeColumns();
                dataGridViewCrudeProductExposeSet.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductExposeSet.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductExposeSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductExposeSet() {
            dataGridViewCrudeProductExposeSet.Columns.Clear();
            dataGridViewCrudeProductExposeSet.AutoGenerateColumns = false;
            dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetId","Product Expose Set Id");
            dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
            dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetName","Product Expose Set Name");
            dataGridViewCrudeProductExposeSet.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductExposeSet.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductExposeSet.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductExposeSet.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductExposeSet.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductExposeSet.AutoResizeColumns();
        }
    }
}
