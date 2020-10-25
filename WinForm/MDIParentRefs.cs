using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {
    class MDIParentRefs {
        static public void DisplayRefForm(
            string systemReferenceTableName,
            Form mdiParent
            ) {

            switch (systemReferenceTableName) {
                case "client_address_type_ref": {
                        var mdiChild = new CrudeClientAddressTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_contact_method_ref": {
                        var mdiChild = new CrudeClientContactMethodRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_document_type_ref": {
                        var mdiChild = new CrudeClientDocumentTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_event_type_ref": {
                        var mdiChild = new CrudeClientEventTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_gender_ref": {
                        var mdiChild = new CrudeClientGenderRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_identifier_type_ref": {
                        var mdiChild = new CrudeClientIdentifierTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_link_type_ref": {
                        var mdiChild = new CrudeClientLinkTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_nationality_ref": {
                        var mdiChild = new CrudeClientNationalityRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_title_ref": {
                        var mdiChild = new CrudeClientTitleRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_type_ref": {
                        var mdiChild = new CrudeClientTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_change_log_type_ref": {
                        var mdiChild = new CrudeDefaultChangeLogTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_error_layer_ref": {
                        var mdiChild = new CrudeDefaultErrorLayerRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_error_type_ref": {
                        var mdiChild = new CrudeDefaultErrorTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_issue_status_ref": {
                        var mdiChild = new CrudeDefaultIssueStatusRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_issue_type_ref": {
                        var mdiChild = new CrudeDefaultIssueTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_rule_type_ref": {
                        var mdiChild = new CrudeDefaultRuleTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_state_ref": {
                        var mdiChild = new CrudeDefaultStateRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_system_setting_ref": {
                        var mdiChild = new CrudeDefaultSystemSettingRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_test_run_result_ref": {
                        var mdiChild = new CrudeDefaultTestRunResultRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_user_activity_type_ref": {
                        var mdiChild = new CrudeDefaultUserActivityTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_attribute_ref": {
                        var mdiChild = new CrudeProductAttributeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_attribute_unit_ref": {
                        var mdiChild = new CrudeProductAttributeUnitRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_category_documentation_type_ref": {
                        var mdiChild = new CrudeProductCategoryDocumentationTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_category_image_type_ref": {
                        var mdiChild = new CrudeProductCategoryImageTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_documentation_type_ref": {
                        var mdiChild = new CrudeProductDocumentationTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_entity_type_ref": {
                        var mdiChild = new CrudeProductEntityTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_expose_set_type_ref": {
                        var mdiChild = new CrudeProductExposeSetTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_gather_attribute_type_ref": {
                        var mdiChild = new CrudeProductGatherAttributeTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_gather_source_type_ref": {
                        var mdiChild = new CrudeProductGatherSourceTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_identifier_ref": {
                        var mdiChild = new CrudeProductIdentifierRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_image_type_ref": {
                        var mdiChild = new CrudeProductImageTypeRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "product_info_ref": {
                        var mdiChild = new CrudeProductInfoRefSearch();
                        //Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                default:
                    MessageBox.Show("Missing reference table implementation; " + systemReferenceTableName);
                    break;
            }
        }
    }
}
