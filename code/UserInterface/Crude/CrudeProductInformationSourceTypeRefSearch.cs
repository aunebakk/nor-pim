using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductInformationSourceTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductInformationSourceTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductInformationSourceTypeRef();
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
            var editForm = new CrudeProductInformationSourceTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductInformationSourceTypeRef.CurrentRow.Cells["ProductInformationSourceTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductInformationSourceTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductInformationSourceTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductInformationSourceTypeRef.CurrentRow.Cells["ProductInformationSourceTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductInformationSourceTypeRef = new CrudeProductInformationSourceTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductInformationSourceTypeRef.FetchWithFilter(                            
                     productInformationSourceTypeRefCombo.Text
                    ,textBoxProductInformationSourceTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductInformationSourceTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductInformationSourceTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductInformationSourceTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductInformationSourceTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductInformationSourceTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductInformationSourceTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductInformationSourceTypeRef() {
            dataGridViewCrudeProductInformationSourceTypeRef.Columns.Clear();
            dataGridViewCrudeProductInformationSourceTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductInformationSourceTypeRef.Columns.Add("ProductInformationSourceTypeRcd","Product Information Source Type");
            dataGridViewCrudeProductInformationSourceTypeRef.Columns.Add("ProductInformationSourceTypeName","Product Information Source Type Name");
            dataGridViewCrudeProductInformationSourceTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductInformationSourceTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductInformationSourceTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductInformationSourceTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductInformationSourceTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductInformationSourceTypeRef.AutoResizeColumns();
        }
    }
}
