using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    public partial class SystemReferenceTableSearch : Form {
        
        private Guid _userId;
        
        public SystemReferenceTableSearch() {
            InitializeComponent();
            InitializeGridCrudeSystemReferenceTable();
            this.AcceptButton = btnSearch;
            this.CancelButton = btnClose;
        }
        
        public void Show(Guid userId) {
            _userId = userId;
            btnSearch_Click(new object(), new EventArgs());
            base.Show();
        }
        
        private void btnEdit_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            string systemReferenceTableName = (string) dataGridViewCrudeSystemReferenceTable.CurrentRow.Cells["SystemReferenceTableName"].Value;
            Form mdiChild = null;

            switch (systemReferenceTableName) {
                case "product_attribute_ref":                       mdiChild = new CrudeProductAttributeRefSearch();
                                                                    break;
                case "product_info_ref":                            mdiChild = new CrudeProductInfoRefSearch();
                                                                    break;
                case "product_identifier_ref":                      mdiChild = new CrudeProductIdentifierRefSearch();
                                                                    break;
                case "state_ref":                                   mdiChild = new CrudeStateRefSearch();
                                                                    break;
                case "product_image_type_ref":                      mdiChild = new CrudeProductImageTypeRefSearch();
                                                                    break;
                case "product_documentation_type_ref":              mdiChild = new CrudeProductDocumentationTypeRefSearch();
                                                                    break;
                case "product_information_source_type_ref":         mdiChild = new CrudeProductInformationSourceTypeRefSearch();
                                                                    break;
                case "product_category_documentation_type_ref":     mdiChild = new CrudeProductCategoryDocumentationTypeRefSearch();
                                                                    break;
                case "product_attribute_unit_ref":                  mdiChild = new CrudeProductAttributeUnitRefSearch();
                                                                    break;
                case "product_category_image_type_ref":             mdiChild = new CrudeProductCategoryImageTypeRefSearch();
                                                                    break;
                case "user_activity_type_ref":                      mdiChild = new CrudeUserActivityTypeRefSearch();
                                                                    break;
                case "system_setting_ref":                          mdiChild = new CrudeSystemSettingRefSearch();
                                                                    break;
                default:
                    MessageBox.Show ("Missing reference table implementation " + systemReferenceTableName);
                    break;
            }

            if (mdiChild != null) { 
                Singleton.Instance.CheckForm(mdiChild);
                mdiChild.MdiParent = this.MdiParent;
                mdiChild.Show();
            }

            Cursor.Current = Cursors.Default;
        }
        
        private void dataGridViewCrudeSystemReferenceTable_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeSystemReferenceTableEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewCrudeSystemReferenceTable.CurrentRow.Cells["SystemReferenceTableId"].Value);
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            var crudeSystemReferenceTable = new CrudeSystemReferenceTableService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeSystemReferenceTable.FetchWithFilter(                            
                     Guid.Empty
                    ,textBoxSystemReferenceTableName.Text
                    ,textBoxSystemReferenceDisplayName.Text
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    ,userPicker.SelectedValue
                    );

                dataGridViewCrudeSystemReferenceTable.AutoGenerateColumns = false;
                dataGridViewCrudeSystemReferenceTable.DataSource = bindingSource;
                dataGridViewCrudeSystemReferenceTable.AutoResizeColumns();
                dataGridViewCrudeSystemReferenceTable.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeSystemReferenceTable.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridCrudeSystemReferenceTable() {
            dataGridViewCrudeSystemReferenceTable.Columns.Clear();
            dataGridViewCrudeSystemReferenceTable.AutoGenerateColumns = false;
            dataGridViewCrudeSystemReferenceTable.Columns.Add("SystemReferenceTableId","System Reference Table Id");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("SystemReferenceTableName","System Reference Table Name");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("SystemReferenceDisplayName","System Reference Display Name");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("UserId","User Id");
            dataGridViewCrudeSystemReferenceTable.Columns.Add("ExtensionData", "");
            dataGridViewCrudeSystemReferenceTable.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeSystemReferenceTable.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeSystemReferenceTable.AutoResizeColumns();
        }
        
        public void ShowByUserId(Guid userId) {
            userPicker.SelectedValue = userId;
            Show();
        }
    }
}
