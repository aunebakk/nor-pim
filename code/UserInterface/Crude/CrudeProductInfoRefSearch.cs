using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductInfoRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductInfoRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductInfoRef();
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
            var editForm = new CrudeProductInfoRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductInfoRef.CurrentRow.Cells["ProductInfoRcd"].Value);
        }
        
        private void dataGridViewCrudeProductInfoRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductInfoRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductInfoRef.CurrentRow.Cells["ProductInfoRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductInfoRef = new CrudeProductInfoRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductInfoRef.FetchWithFilter(                            
                     productInfoRefCombo.Text
                    ,textBoxProductInfoName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductInfoRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductInfoRef.DataSource = bindingSource;
                dataGridViewCrudeProductInfoRef.AutoResizeColumns();
                dataGridViewCrudeProductInfoRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductInfoRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductInfoRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductInfoRef() {
            dataGridViewCrudeProductInfoRef.Columns.Clear();
            dataGridViewCrudeProductInfoRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductInfoRef.Columns.Add("ProductInfoRcd","Product Info");
            dataGridViewCrudeProductInfoRef.Columns.Add("ProductInfoName","Product Info Name");
            dataGridViewCrudeProductInfoRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductInfoRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductInfoRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductInfoRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductInfoRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductInfoRef.AutoResizeColumns();
        }
    }
}
