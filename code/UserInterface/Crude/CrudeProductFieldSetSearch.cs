using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductFieldSetSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductFieldSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductFieldSet();
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
            var editForm = new CrudeProductFieldSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSet.CurrentRow.Cells["ProductFieldSetId"].Value);
        }
        
        private void dataGridViewCrudeProductFieldSet_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductFieldSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSet.CurrentRow.Cells["ProductFieldSetId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductFieldSet = new CrudeProductFieldSetService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductFieldSet.FetchWithFilter(                            
                     Guid.Empty
                    ,textBoxProductFieldSetName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductFieldSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductFieldSet.DataSource = bindingSource;
                dataGridViewCrudeProductFieldSet.AutoResizeColumns();
                dataGridViewCrudeProductFieldSet.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductFieldSet.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductFieldSetEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductFieldSet() {
            dataGridViewCrudeProductFieldSet.Columns.Clear();
            dataGridViewCrudeProductFieldSet.AutoGenerateColumns = false;
            dataGridViewCrudeProductFieldSet.Columns.Add("ProductFieldSetId","Product Field Set Id");
            dataGridViewCrudeProductFieldSet.Columns.Add("ProductFieldSetName","Product Field Set Name");
            dataGridViewCrudeProductFieldSet.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductFieldSet.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductFieldSet.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductFieldSet.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductFieldSet.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductFieldSet.AutoResizeColumns();
        }
    }
}
