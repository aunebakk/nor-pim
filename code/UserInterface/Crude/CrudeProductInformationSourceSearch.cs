using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductInformationSourceSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductInformationSourceSearch() {
            InitializeComponent();
            InitializeGridCrudeProductInformationSource();
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
            var editForm = new CrudeProductInformationSourceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductInformationSource.CurrentRow.Cells["ProductInformationSourceId"].Value);
        }
        
        private void dataGridViewCrudeProductInformationSource_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductInformationSourceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductInformationSource.CurrentRow.Cells["ProductInformationSourceId"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductInformationSource = new CrudeProductInformationSourceService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductInformationSource.FetchWithFilter(                            
                     Guid.Empty
                    ,productInformationSourceTypeRefCombo.Text
                    ,textBoxProductInformationSource.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductInformationSource.AutoGenerateColumns = false;
                dataGridViewCrudeProductInformationSource.DataSource = bindingSource;
                dataGridViewCrudeProductInformationSource.AutoResizeColumns();
                dataGridViewCrudeProductInformationSource.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductInformationSource.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductInformationSourceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductInformationSource() {
            dataGridViewCrudeProductInformationSource.Columns.Clear();
            dataGridViewCrudeProductInformationSource.AutoGenerateColumns = false;
            dataGridViewCrudeProductInformationSource.Columns.Add("ProductInformationSourceId","Product Information Source Id");
            dataGridViewCrudeProductInformationSource.Columns.Add("ProductInformationSourceTypeRcd","Product Information Source Type");
            dataGridViewCrudeProductInformationSource.Columns.Add("ProductInformationSource","Product Information Source");
            dataGridViewCrudeProductInformationSource.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductInformationSource.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductInformationSource.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductInformationSource.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductInformationSource.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductInformationSource.AutoResizeColumns();
        }
    }
}
