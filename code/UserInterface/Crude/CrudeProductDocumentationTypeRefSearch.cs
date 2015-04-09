using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductDocumentationTypeRefSearch : Form {
        
        private Guid _userId;
        
        public CrudeProductDocumentationTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductDocumentationTypeRef();
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
            var editForm = new CrudeProductDocumentationTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductDocumentationTypeRef.CurrentRow.Cells["ProductDocumentationTypeRcd"].Value);
        }
        
        private void dataGridViewCrudeProductDocumentationTypeRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeProductDocumentationTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeProductDocumentationTypeRef.CurrentRow.Cells["ProductDocumentationTypeRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeProductDocumentationTypeRef = new CrudeProductDocumentationTypeRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeProductDocumentationTypeRef.FetchWithFilter(                            
                     productDocumentationTypeRefCombo.Text
                    ,textBoxProductDocumentationTypeName.Text
                    ,userPicker.SelectedValue
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeProductDocumentationTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductDocumentationTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductDocumentationTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductDocumentationTypeRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeProductDocumentationTypeRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeProductDocumentationTypeRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(_userId);
        }
        
        private void InitializeGridCrudeProductDocumentationTypeRef() {
            dataGridViewCrudeProductDocumentationTypeRef.Columns.Clear();
            dataGridViewCrudeProductDocumentationTypeRef.AutoGenerateColumns = false;
            dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
            dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ProductDocumentationTypeName","Product Documentation Type Name");
            dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("UserId","User Id");
            dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeProductDocumentationTypeRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeProductDocumentationTypeRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeProductDocumentationTypeRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeProductDocumentationTypeRef.AutoResizeColumns();
        }
    }
}
