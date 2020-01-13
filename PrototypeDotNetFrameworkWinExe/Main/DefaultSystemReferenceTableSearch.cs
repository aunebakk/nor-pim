using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface
{
    public partial class DefaultSystemReferenceTableSearch : Form
    {

        private Guid _userId;

        public DefaultSystemReferenceTableSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultSystemReferenceTable();
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

            string systemReferenceTableName = 
                ( string ) dataGridViewCrudeDefaultSystemReferenceTable.
                    CurrentRow.
                        Cells["DefaultSystemReferenceTableName"].Value;

            switch ( systemReferenceTableName ) {
                case "default_state_ref": {
                        var mdiChild = new CrudeDefaultStateRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_user_activity_type_ref": {
                        var mdiChild = new CrudeDefaultUserActivityTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_system_setting_ref": {
                        var mdiChild = new CrudeDefaultSystemSettingRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_error_layer_ref": {
                        var mdiChild = new CrudeDefaultErrorLayerRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "default_error_type_ref": {
                        var mdiChild = new CrudeDefaultErrorTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "default_issue_type_ref": {
                        var mdiChild = new CrudeDefaultIssueTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "default_issue_status_ref": {
                        var mdiChild = new CrudeDefaultIssueStatusRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "default_change_log_type_ref": {
                        var mdiChild = new CrudeDefaultChangeLogTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "default_rule_type_ref": {
                        var mdiChild = new CrudeDefaultRuleTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "default_test_run_result_ref": {
                        var mdiChild = new CrudeDefaultTestRunResultRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show (  );
                        break;
                    }
                case "financial_fee_type_ref": {
                        var mdiChild = new CrudeFinancialFeeTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_tax_type_ref": {
                        var mdiChild = new CrudeFinancialTaxTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_payment_type_ref": {
                        var mdiChild = new CrudeFinancialPaymentTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_currency_type_ref": {
                        var mdiChild = new CrudeFinancialCurrencyTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_adjustment_type_ref": {
                        var mdiChild = new CrudeFinancialAdjustmentTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_card_type_ref": {
                        var mdiChild = new CrudeFinancialCardTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_bank_account_number_type_ref": {
                        var mdiChild = new CrudeFinancialBankAccountNumberTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_voucher_type_ref": {
                        var mdiChild = new CrudeFinancialVoucherTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_coupon_type_ref": {
                        var mdiChild = new CrudeFinancialCouponTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_attribute_ref": {
                        var mdiChild = new CrudeProductAttributeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_info_ref": {
                        var mdiChild = new CrudeProductInfoRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_identifier_ref": {
                        var mdiChild = new CrudeProductIdentifierRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_image_type_ref": {
                        var mdiChild = new CrudeProductImageTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_documentation_type_ref": {
                        var mdiChild = new CrudeProductDocumentationTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_category_documentation_type_ref": {
                        var mdiChild = new CrudeProductCategoryDocumentationTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_attribute_unit_ref": {
                        var mdiChild = new CrudeProductAttributeUnitRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_category_image_type_ref": {
                        var mdiChild = new CrudeProductImageTypeRefSearch ();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_gather_source_type_ref": {
                        var mdiChild = new CrudeProductGatherSourceTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "product_gather_attribute_type_ref": {
                        var mdiChild = new CrudeProductGatherAttributeTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "financial_order_event_type_ref": {
                        var mdiChild = new CrudeFinancialOrderEventTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "location_address_type_ref": {
                        var mdiChild = new CrudeLocationAddressTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "financial_order_transaction_type_ref": {
                        var mdiChild = new CrudeFinancialOrderTransactionTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "client_event_type_ref": {
                        var mdiChild = new CrudeClientEventTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "client_nationality_ref": {
                        var mdiChild = new CrudeClientNationalityRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "client_gender_ref": {
                        var mdiChild = new CrudeClientGenderRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "client_title_ref": {
                        var mdiChild = new CrudeClientTitleRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "client_type_ref": {
                        var mdiChild = new CrudeClientTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "client_address_type_ref": {
                        var mdiChild = new CrudeClientAddressTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "client_link_type_ref": {
                        var mdiChild = new CrudeClientLinkTypeRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "client_contact_method_ref": {
                        var mdiChild = new CrudeClientContactMethodRefSearch ();
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "product_entity_type_ref": {
                        var mdiChild = new CrudeProductEntityTypeRefSearch ( );
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_system_reference_table": {
                        var mdiChild = new CrudeDefaultSystemReferenceTableSearch ( );
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "financial_order_identifier_type_ref": {
                        var mdiChild = new CrudeFinancialOrderIdentifierTypeRefSearch ( );
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "financial_order_source_ref": {
                        var mdiChild = new CrudeFinancialOrderSourceRefSearch ( );
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "financial_unit_of_measurement_ref": {
                        var mdiChild = new CrudeFinancialUnitOfMeasurementRefSearch ( );
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
                        break;
                    }
                case "product_expose_set_type_ref": {
                        var mdiChild = new CrudeProductExposeSetTypeRefSearch ( );
                        Singleton.Instance.CheckForm ( mdiChild );
                        mdiChild.MdiParent = this.MdiParent;
                        mdiChild.Show ( Singleton.Instance.UserId );
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
            var crudeDefaultSystemReferenceTable = new CrudeDefaultSystemReferenceTableServiceClient();
            var bindingSource = new BindingSource();

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
            } catch ( Exception ex ) {
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

            foreach ( DataGridViewColumn column in dataGridViewCrudeDefaultSystemReferenceTable.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") || column.Name.Equals("DefaultSystemReferenceTableName") )
                    column.Visible = false;
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
