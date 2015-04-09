using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeUserSearch : Form {
        
        public CrudeUserSearch() {
            InitializeComponent();
            InitializeGridCrudeUser();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            buttonSearch_Click(new object(), new EventArgs());
            base.Show();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeUserEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeUser.CurrentRow.Cells["UserId"].Value);
        }
        
        private void dataGridViewCrudeUser_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeUserEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeUser.CurrentRow.Cells["UserId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeUser = new CrudeUserService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeUser.FetchWithFilter(                            
                     Guid.Empty
                    ,textBoxUserCode.Text
                    ,textBoxUserName.Text
                    ,textBoxEmail.Text
                    ,textBoxPassword.Text
                    ,stateRefCombo.Text
                    ,Guid.Empty
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeUser.AutoGenerateColumns = false;
                dataGridViewCrudeUser.DataSource = bindingSource;
                dataGridViewCrudeUser.AutoResizeColumns();
                dataGridViewCrudeUser.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeUser.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeUserEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd();
        }
        
        private void InitializeGridCrudeUser() {
            dataGridViewCrudeUser.Columns.Clear();
            dataGridViewCrudeUser.AutoGenerateColumns = false;
            dataGridViewCrudeUser.Columns.Add("UserId","User Id");
            dataGridViewCrudeUser.Columns.Add("UserCode","User Code");
            dataGridViewCrudeUser.Columns.Add("UserName","User Name");
            dataGridViewCrudeUser.Columns.Add("Email","Email");
            dataGridViewCrudeUser.Columns.Add("Password","Password");
            dataGridViewCrudeUser.Columns.Add("StateRcd","State");
            dataGridViewCrudeUser.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeUser.Columns.Add("ExtensionData", "");
            dataGridViewCrudeUser.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeUser.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeUser.AutoResizeColumns();
        }
    }
}
