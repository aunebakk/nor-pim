using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {
    public partial class DefaultSystemReferenceTableSearch : Form {

        private Guid _userId;

        public DefaultSystemReferenceTableSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultSystemReferenceTable();
            AcceptButton = btnSearch;
            CancelButton = btnClose;
        }

        public void Show(Guid userId) {
            _userId = userId;
            btnSearch_Click(new object(), new EventArgs());
            base.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;

            string systemReferenceTableName =
                (string)dataGridViewCrudeDefaultSystemReferenceTable.
                    CurrentRow.
                        Cells["DefaultSystemReferenceTableName"].Value;

            switch (systemReferenceTableName) {
                case "default_state_ref": {
                        CrudeDefaultStateRefSearch mdiChild = new CrudeDefaultStateRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_user_activity_type_ref": {
                        CrudeDefaultUserActivityTypeRefSearch mdiChild = new CrudeDefaultUserActivityTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_system_setting_ref": {
                        CrudeDefaultSystemSettingRefSearch mdiChild = new CrudeDefaultSystemSettingRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_error_layer_ref": {
                        CrudeDefaultErrorLayerRefSearch mdiChild = new CrudeDefaultErrorLayerRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_error_type_ref": {
                        CrudeDefaultErrorTypeRefSearch mdiChild = new CrudeDefaultErrorTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_issue_type_ref": {
                        CrudeDefaultIssueTypeRefSearch mdiChild = new CrudeDefaultIssueTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_issue_status_ref": {
                        CrudeDefaultIssueStatusRefSearch mdiChild = new CrudeDefaultIssueStatusRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_change_log_type_ref": {
                        CrudeDefaultChangeLogTypeRefSearch mdiChild = new CrudeDefaultChangeLogTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_rule_type_ref": {
                        CrudeDefaultRuleTypeRefSearch mdiChild = new CrudeDefaultRuleTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_test_run_result_ref": {
                        CrudeDefaultTestRunResultRefSearch mdiChild = new CrudeDefaultTestRunResultRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show();
                        break;
                    }
                case "product_attribute_ref": {
                        CrudeProductAttributeRefSearch mdiChild = new CrudeProductAttributeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_info_ref": {
                        CrudeProductInfoRefSearch mdiChild = new CrudeProductInfoRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_identifier_ref": {
                        CrudeProductIdentifierRefSearch mdiChild = new CrudeProductIdentifierRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_image_type_ref": {
                        CrudeProductImageTypeRefSearch mdiChild = new CrudeProductImageTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_documentation_type_ref": {
                        CrudeProductDocumentationTypeRefSearch mdiChild = new CrudeProductDocumentationTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_category_documentation_type_ref": {
                        CrudeProductCategoryDocumentationTypeRefSearch mdiChild = new CrudeProductCategoryDocumentationTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_attribute_unit_ref": {
                        CrudeProductAttributeUnitRefSearch mdiChild = new CrudeProductAttributeUnitRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_category_image_type_ref": {
                        CrudeProductImageTypeRefSearch mdiChild = new CrudeProductImageTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_gather_source_type_ref": {
                        CrudeProductGatherSourceTypeRefSearch mdiChild = new CrudeProductGatherSourceTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_gather_attribute_type_ref": {
                        CrudeProductGatherAttributeTypeRefSearch mdiChild = new CrudeProductGatherAttributeTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_event_type_ref": {
                        CrudeClientEventTypeRefSearch mdiChild = new CrudeClientEventTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_nationality_ref": {
                        CrudeClientNationalityRefSearch mdiChild = new CrudeClientNationalityRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_gender_ref": {
                        CrudeClientGenderRefSearch mdiChild = new CrudeClientGenderRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_title_ref": {
                        CrudeClientTitleRefSearch mdiChild = new CrudeClientTitleRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_type_ref": {
                        CrudeClientTypeRefSearch mdiChild = new CrudeClientTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_document_type_ref": {
                        CrudeClientDocumentTypeRefSearch mdiChild = new CrudeClientDocumentTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_address_type_ref": {
                        CrudeClientAddressTypeRefSearch mdiChild = new CrudeClientAddressTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_link_type_ref": {
                        CrudeClientLinkTypeRefSearch mdiChild = new CrudeClientLinkTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_identifier_type_ref": {
                        CrudeClientIdentifierTypeRefSearch mdiChild = new CrudeClientIdentifierTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_contact_method_ref": {
                        CrudeClientContactMethodRefSearch mdiChild = new CrudeClientContactMethodRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_entity_type_ref": {
                        CrudeProductEntityTypeRefSearch mdiChild = new CrudeProductEntityTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_system_reference_table": {
                        CrudeDefaultSystemReferenceTableSearch mdiChild = new CrudeDefaultSystemReferenceTableSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_expose_set_type_ref": {
                        CrudeProductExposeSetTypeRefSearch mdiChild = new CrudeProductExposeSetTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                default:
                    MessageBox.Show("Missing reference table implementation " + systemReferenceTableName);
                    break;
            }

            Cursor.Current = Cursors.Default;
        }

        private void dataGridViewCrudeDefaultSystemReferenceTable_DoubleClick(object sender, EventArgs e) {
            btnEdit_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            CrudeDefaultSystemReferenceTableServiceClient crudeDefaultSystemReferenceTable = new CrudeDefaultSystemReferenceTableServiceClient();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeDefaultSystemReferenceTable.FetchWithFilter(
                     Guid.Empty
                    , textBoxSystemReferenceTableName.Text
                    , textBoxSystemReferenceDisplayName.Text
                    , userPicker.SelectedValue
                    , DateTime.MinValue
                    );

                dataGridViewCrudeDefaultSystemReferenceTable.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemReferenceTable.DataSource = bindingSource;
                dataGridViewCrudeDefaultSystemReferenceTable.AutoResizeColumns();
                dataGridViewCrudeDefaultSystemReferenceTable.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeDefaultSystemReferenceTable.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void InitializeGridCrudeDefaultSystemReferenceTable() {
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Clear();
            dataGridViewCrudeDefaultSystemReferenceTable.AutoGenerateColumns = false;
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceTableId", "System Reference Table Id");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceTableName", "System Reference Table Name");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceDisplayName", "System Reference Display Name");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceDisplayName"].Width = 300;
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DateTime", "Date Time");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns["DateTime"].Visible = false;
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultUserId", "User Id");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("ExtensionData", "");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeDefaultSystemReferenceTable.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id") || column.Name.Equals("DefaultSystemReferenceTableName")) {
                    column.Visible = false;
                }
            }

            dataGridViewCrudeDefaultSystemReferenceTable.AutoResizeColumns();
            dataGridViewCrudeDefaultSystemReferenceTable.Refresh();
        }

        public void ShowByUserId(Guid userId) {
            userPicker.SelectedValue = userId;
            Show();
        }
    }
}
