using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeSystemReferenceTableSearch : Form {
        
        private Guid _userId;
        
        public CrudeSystemReferenceTableSearch() {
            InitializeComponent();
            InitializeGridCrudeSystemReferenceTable();
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
            var editForm = new CrudeSystemReferenceTableEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeSystemReferenceTable.CurrentRow.Cells["SystemReferenceTableId"].Value);
        }
        
        private void dataGridViewCrudeSystemReferenceTable_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeSystemReferenceTableEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeSystemReferenceTable.CurrentRow.Cells["SystemReferenceTableId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeSystemReferenceTable = new CrudeSystemReferenceTableService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeSystemReferenceTable.FetchWithFilter(                            
                     Guid.Empty
                    ,textBoxSystemReferenceTableName.Text
                    ,textBoxSystemReferenceDisplayName.Text
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    ,userPicker.SelectedValue
                    );

                dataGridViewCrudeSystemReferenceTable.AutoGenerateColumns = false;
                dataGridViewCrudeSystemReferenceTable.DataSource = bindingSource;
                dataGridViewCrudeSystemReferenceTable.AutoResizeColumns();
                dataGridViewCrudeSystemReferenceTable.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeSystemReferenceTable.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeSystemReferenceTableEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeSystemReferenceTable() {
            dataGridViewCrudeSystemReferenceTable.Columns.Clear();
            dataGridViewCrudeSystemReferenceTable.AutoGenerateColumns = false;
            dataGridViewCrudeSystemReferenceTable.Columns.Add("SystemReferenceTableId","System Reference Table Id");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("SystemReferenceTableName","System Reference Table Name");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("SystemReferenceDisplayName","System Reference Display Name");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("UserId","User Id");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("ExtensionData", "");
            dataGridViewCrudeSystemReferenceTable.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeSystemReferenceTable.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeSystemReferenceTable.AutoResizeColumns();
        }
    }
}
