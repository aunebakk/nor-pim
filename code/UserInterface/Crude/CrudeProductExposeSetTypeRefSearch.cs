using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposeSetTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductExposeSetTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposeSetTypeRef();
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
            var editForm = new CrudeProductExposeSetTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductExposeSetTypeRef.CurrentRow.Cells["ProductExposeSetTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductExposeSetTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductExposeSetTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductExposeSetTypeRef.CurrentRow.Cells["ProductExposeSetTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductExposeSetTypeRef = new CrudeProductExposeSetTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductExposeSetTypeRef.FetchWithFilter(                            
                     productExposeSetTypeRefCombo.Text
                    ,textBoxProductExposeSetTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductExposeSetTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSetTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductExposeSetTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductExposeSetTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductExposeSetTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductExposeSetTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductExposeSetTypeRef() {
            dataGridViewCrudeProductExposeSetTypeRef.Columns.Clear();
            dataGridViewCrudeProductExposeSetTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
            dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ProductExposeSetTypeName","Product Expose Set Type Name");
            dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductExposeSetTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductExposeSetTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductExposeSetTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductExposeSetTypeRef.AutoResizeColumns();
        }
    }
}
