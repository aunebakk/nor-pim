using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductIdentifierRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductIdentifierRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductIdentifierRef();
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
            var editForm = new CrudeProductIdentifierRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductIdentifierRef.CurrentRow.Cells["ProductIdentifierRcd"].Value);
        }
        
        private void dataGridViewCrudeProductIdentifierRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductIdentifierRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductIdentifierRef.CurrentRow.Cells["ProductIdentifierRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductIdentifierRef = new CrudeProductIdentifierRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductIdentifierRef.FetchWithFilter(                            
                     productIdentifierRefCombo.Text
                    ,textBoxProductIdentifierName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductIdentifierRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifierRef.DataSource = bindingSource;
                dataGridViewCrudeProductIdentifierRef.AutoResizeColumns();
                dataGridViewCrudeProductIdentifierRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductIdentifierRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductIdentifierRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductIdentifierRef() {
            dataGridViewCrudeProductIdentifierRef.Columns.Clear();
            dataGridViewCrudeProductIdentifierRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductIdentifierRef.Columns.Add("ProductIdentifierRcd","Product Identifier");
            dataGridViewCrudeProductIdentifierRef.Columns.Add("ProductIdentifierName","Product Identifier Name");
            dataGridViewCrudeProductIdentifierRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductIdentifierRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductIdentifierRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductIdentifierRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductIdentifierRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductIdentifierRef.AutoResizeColumns();
        }
    }
}
