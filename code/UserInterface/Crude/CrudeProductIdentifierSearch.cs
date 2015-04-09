using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductIdentifierSearch : Form {
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductIdentifierSearch() {
            InitializeComponent();
            InitializeGridCrudeProductIdentifier();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(Guid productId, Guid userId) {
            _productId = productId;
            productPicker.SelectedValue = productId;
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
            var editForm = new CrudeProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
        }
        
        private void dataGridViewCrudeProductIdentifier_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductIdentifier = new CrudeProductIdentifierService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductIdentifier.FetchWithFilter(                            
                     Guid.Empty
                    ,productPicker.SelectedValue
                    ,productIdentifierRefCombo.Text
                    ,textBoxIdentifier.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifier.DataSource = bindingSource;
                dataGridViewCrudeProductIdentifier.AutoResizeColumns();
                dataGridViewCrudeProductIdentifier.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductIdentifier.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_productId, _userId);
        }
        
        private void InitializeGridCrudeProductIdentifier() {
            dataGridViewCrudeProductIdentifier.Columns.Clear();
            dataGridViewCrudeProductIdentifier.AutoGenerateColumns = false;
            dataGridViewCrudeProductIdentifier.Columns.Add("ProductIdentifierId","Product Identifier Id");
            dataGridViewCrudeProductIdentifier.Columns.Add("ProductId","Product Id");
            dataGridViewCrudeProductIdentifier.Columns.Add("ProductIdentifierRcd","Product Identifier");
            dataGridViewCrudeProductIdentifier.Columns.Add("Identifier","Identifier");
            dataGridViewCrudeProductIdentifier.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductIdentifier.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductIdentifier.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductIdentifier.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductIdentifier.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductIdentifier.AutoResizeColumns();
        }
    }
}
