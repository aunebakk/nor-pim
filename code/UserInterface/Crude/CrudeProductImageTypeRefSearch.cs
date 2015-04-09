using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductImageTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductImageTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductImageTypeRef();
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
            var editForm = new CrudeProductImageTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductImageTypeRef.CurrentRow.Cells["ProductImageTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductImageTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductImageTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductImageTypeRef.CurrentRow.Cells["ProductImageTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductImageTypeRef = new CrudeProductImageTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductImageTypeRef.FetchWithFilter(                            
                     productImageTypeRefCombo.Text
                    ,textBoxProductImageTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductImageTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductImageTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductImageTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductImageTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductImageTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductImageTypeRef() {
            dataGridViewCrudeProductImageTypeRef.Columns.Clear();
            dataGridViewCrudeProductImageTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductImageTypeRef.Columns.Add("ProductImageTypeRcd","Product Image Type");
            dataGridViewCrudeProductImageTypeRef.Columns.Add("ProductImageTypeName","Product Image Type Name");
            dataGridViewCrudeProductImageTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductImageTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductImageTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductImageTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductImageTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductImageTypeRef.AutoResizeColumns();
        }
    }
}
