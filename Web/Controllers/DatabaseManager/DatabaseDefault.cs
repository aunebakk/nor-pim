using System;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    public partial class DatabaseManager {
        private void InitSystemReferenceErrorAndIssue(
            int majorNumber,
            int minorNumber
            ) {

            int sequence = 0;

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 01, 23) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultSystemReference",
                Description = "Default System Reference create and Test data",
                #region script ( default_system_reference_table )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            set nocount on
                            go
                            if object_id (N'default_system_reference_table') is not null
                                drop table default_system_reference_table
                            go
                            create table default_system_reference_table
                            (
	                            default_system_reference_table_id  uniqueidentifier  not null ,
	                            default_system_reference_table_name  nvarchar(240)  not null ,
	                            default_system_reference_display_name  nvarchar(240)  not null ,
	                            default_user_id  uniqueidentifier  not null ,
	                            date_time  datetime  not null ,
	                            constraint  xpkdefault_system_reference_table primary key   clustered (default_system_reference_table_id  asc),
	                            constraint  default_system_reference_table_to_default_user foreign key (default_user_id) references default_user(default_user_id)
                            )
                            go
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_state_ref'											,'State'									,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_user_activity_type_ref'								,'User Activity'							,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_system_setting_ref'									,'System Setting'							,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_issue_status_ref'										,'Issue Status'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_issue_type_ref'										,'Issue Type'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_change_log_type_ref'									,'Change Log Type'							,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_error_layer_ref'										,'Error Layer'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_error_type_ref'										,'Error Type'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_rule_type_ref'										,'Rule Type'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'default_test_run_result_ref'									,'Default Test Run Result'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_attribute_ref'									    ,'Product Attribute Type'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_attribute_unit_ref'									,'Product Attribute Unit Type'  			,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_address_type_ref',                    'Client address type'                                        ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_contact_method_ref',                  'Client contact method'                                      ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_document_type_ref',                   'Client document type'                                       ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_event_type_ref',                      'Client event type'                                          ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_gender_ref',                          'Client gender'                                              ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_identifier_type_ref',                 'Client identifier type'                                     ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_link_type_ref',                       'Client link type'                                           ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_nationality_ref',                     'Client nationality'                                         ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_title_ref',                           'Client title'                                               ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'client_type_ref',                            'Client type'                                                ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_attribute_ref',                      'Product attribute'                                          ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_attribute_unit_ref',                 'Product attribute unit'                                     ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_category_documentation_type_ref',    'Product category documentation type'                        ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_category_image_type_ref',            'Product category image type'                                ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_documentation_type_ref',             'Product documentation type'                                 ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_entity_type_ref',                    'Product entity type'                                        ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_expose_set_type_ref',                'Product expose set type'                                    ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_gather_attribute_type_ref',          'Product gather attribute type'                              ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_gather_source_type_ref',             'Product gather source type'                                 ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_identifier_ref',                     'Product identifier'                                         ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_image_type_ref',                     'Product image type'                                         ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	                            values (newid(), 'product_info_ref',                           'Product info'                                               ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

                        ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2016, 01, 01) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultIssueDrop",
                Description = "Default and Issue Drop",
                #region script ( default_issue, default_error, default_error_layer_ref, default_error_type_ref, default_issue_type_ref, default_issue_status_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            if object_id (N'default_issue') is not null
                                drop table default_issue
                            go
                            if object_id (N'default_error') is not null
                                drop table default_error
                            go
                            if object_id (N'default_error_layer_ref') is not null
                                drop table default_error_layer_ref
                            go
                            if object_id (N'default_error_type_ref') is not null
                                drop table default_error_type_ref
                            go
                            if object_id (N'default_issue_type_ref') is not null
                                drop table default_issue_type_ref
                            go
                            if object_id (N'default_issue_status_ref') is not null
                                drop table default_issue_status_ref
                            go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2016, 01, 01) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultIssueCreate",
                Description = "Default and Issue Create",
                #region script ( default_issue, default_error, default_error_layer_ref, default_error_type_ref, default_issue_type_ref, default_issue_status_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            CREATE TABLE 'default_error_layer_ref'
                            (
                                'default_error_layer_rcd'  varchar ( 20 )  NOT NULL ,
                                'default_error_layer_name'  nvarchar ( 240 )  NOT NULL ,
                                'default_user_id'  uniqueidentifier  NULL ,
                                'date_time'  datetime  NOT NULL ,
                                CONSTRAINT  'XPKdefault_error_layer_ref' PRIMARY KEY   CLUSTERED ( 'default_error_layer_rcd'  ASC )
                            )
                            go
                            CREATE TABLE 'default_error_type_ref'
                            (
                                'default_error_type_rcd'  varchar ( 20 )  NOT NULL ,
                                'default_error_type_name'  nvarchar ( 240 )  NOT NULL ,
                                'default_user_id'  uniqueidentifier  NULL ,
                                'date_time'  datetime  NOT NULL ,
                                CONSTRAINT  'XPKdefault_error_type_ref' PRIMARY KEY   CLUSTERED ( 'default_error_type_rcd'  ASC )
                            )
                            go
                            CREATE TABLE 'default_error'
                            (
                                'default_error_id'  uniqueidentifier  NOT NULL ,
                                'default_error_layer_rcd'  varchar ( 20 )  NOT NULL ,
                                'default_error_type_rcd'  varchar ( 20 )  NOT NULL ,
                                'layer_address'  nvarchar ( 240 )  NULL ,
                                'error_message'  text  NOT NULL ,
                                'stack_trace'  text  NULL ,
                                'method_name'  nvarchar ( 240 )  NULL ,
                                'domain_name'  nvarchar ( 240 )  NULL ,
                                'class_name'  nvarchar ( 240 )  NULL ,
                                'default_user_id'  uniqueidentifier  NOT NULL ,
                                'date_time'  datetime  NOT NULL ,
                                CONSTRAINT  'XPKdefault_error' PRIMARY KEY   CLUSTERED ( 'default_error_id'  ASC ) ,
                                CONSTRAINT  'default_error_to_default_user' FOREIGN KEY ( 'default_user_id' ) REFERENCES 'default_user' ( 'default_user_id' ) ,
                                CONSTRAINT  'default_error_to_default_error_layer' FOREIGN KEY ( 'default_error_layer_rcd' ) REFERENCES 'default_error_layer_ref' ( 'default_error_layer_rcd' ) ,
                                CONSTRAINT  'default_error_to_default_error_type' FOREIGN KEY ( 'default_error_type_rcd' ) REFERENCES 'default_error_type_ref' ( 'default_error_type_rcd' )
                            )
                            go
                            CREATE INDEX 'XIF1default_error' ON 'default_error'
                            (
                                'default_user_id'  ASC
                            )
                            go
                            CREATE INDEX 'XIF2default_error' ON 'default_error'
                            (
                                'default_error_layer_rcd'  ASC
                            )
                            go
                            CREATE INDEX 'XIF3default_error' ON 'default_error'
                            (
                                'default_error_type_rcd'  ASC
                            )
                            go
                            CREATE TABLE 'default_issue_type_ref'
                            (
                                'default_issue_type_rcd'  varchar ( 20 )  NOT NULL ,
                                'default_issue_type_name'  nvarchar ( 240 )  NOT NULL ,
                                'default_user_id'  uniqueidentifier  NOT NULL ,
                                'date_time'  datetime  NOT NULL ,
                                CONSTRAINT  'XPKdefault_issue_type_ref' PRIMARY KEY   CLUSTERED ( 'default_issue_type_rcd'  ASC ) ,
                                CONSTRAINT  'default_issue_type_ref_to_default_user' FOREIGN KEY ( 'default_user_id' ) REFERENCES 'default_user' ( 'default_user_id' )
                            )
                            go
                            CREATE INDEX 'XIF1default_issue_type_ref' ON 'default_issue_type_ref'
                            (
                                'default_user_id'  ASC
                            )
                            go
                            CREATE TABLE 'default_issue_status_ref'
                            (
                                'default_issue_status_rcd'  varchar ( 20 )  NOT NULL ,
                                'default_issue_status_name'  nvarchar ( 240 )  NOT NULL ,
                                'default_user_id'  uniqueidentifier  NOT NULL ,
                                'date_time'  datetime  NOT NULL ,
                                CONSTRAINT  'XPKdefault_issue_status_ref' PRIMARY KEY   CLUSTERED ( 'default_issue_status_rcd'  ASC ) ,
                                CONSTRAINT  'default_issue_status_ref_to_default_user' FOREIGN KEY ( 'default_user_id' ) REFERENCES 'default_user' ( 'default_user_id' )
                            )
                            go
                            CREATE INDEX 'XIF1default_issue_status_ref' ON 'default_issue_status_ref'
                            (
                                'default_user_id'  ASC
                            )
                            go
                            CREATE TABLE 'default_issue'
                            (
                                'default_issue_id'  uniqueidentifier  NOT NULL ,
                                'default_issue_type_rcd'  varchar ( 20 )  NOT NULL ,
                                'default_issue_status_rcd'  varchar ( 20 )  NOT NULL ,
                                'default_error_id'  uniqueidentifier  NULL ,
                                'issue_name'  nvarchar ( 240 )  NOT NULL ,
                                'issue_description'  text  NULL ,
                                'steps_to_reproduce'  text  NULL ,
                                'link'  text  NULL ,
                                'default_user_id'  uniqueidentifier  NULL ,
                                'date_time'  datetime  NOT NULL ,
                                'fixed_note'  text  NULL ,
                                CONSTRAINT  'XPKdefault_issue' PRIMARY KEY   CLUSTERED ( 'default_issue_id'  ASC ) ,
                                CONSTRAINT  'default_issue_to_default_error' FOREIGN KEY ( 'default_error_id' ) REFERENCES 'default_error' ( 'default_error_id' ) ,
                                CONSTRAINT  'default_issue_to_default_user' FOREIGN KEY ( 'default_user_id' ) REFERENCES 'default_user' ( 'default_user_id' ) ,
                                CONSTRAINT  'default_issue_to_default_issue_type_ref' FOREIGN KEY ( 'default_issue_type_rcd' ) REFERENCES 'default_issue_type_ref' ( 'default_issue_type_rcd' ) ,
                                CONSTRAINT  'default_issue_to_default_issue_status_ref' FOREIGN KEY ( 'default_issue_status_rcd' ) REFERENCES 'default_issue_status_ref' ( 'default_issue_status_rcd' )
                            )
                            go
                            CREATE INDEX 'XIF1default_issue' ON 'default_issue'
                            (
                                'default_error_id'  ASC
                            )
                            go
                            CREATE INDEX 'XIF2default_issue' ON 'default_issue'
                            (
                                'default_user_id'  ASC
                            )
                            go
                            CREATE INDEX 'XIF3default_issue' ON 'default_issue'
                            (
                                'default_issue_type_rcd'  ASC
                            )
                            go
                            CREATE INDEX 'XIF4default_issue' ON 'default_issue'
                            (
                                'default_issue_status_rcd'  ASC
                            )
                            go
                            ".Replace("'", "\""),
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2016, 01, 01) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultIssueTestData",
                Description = "Default and Issue Test Data",
                #region script ( default_issue_type_ref, default_issue_status_ref, default_error_layer_ref, default_error_type_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            --default_issue_type_ref
                            insert into default_issue_type_ref (default_issue_type_rcd, default_issue_type_name, default_user_id, date_time) 
	                            values ('Bug', 'Bug',						'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_issue_type_ref (default_issue_type_rcd, default_issue_type_name, default_user_id, date_time) 
	                            values ('Incorrect', 'Incorrect Behavior',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_issue_type_ref (default_issue_type_rcd, default_issue_type_name, default_user_id, date_time) 
	                            values ('Change', 'Change Request',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_issue_type_ref (default_issue_type_rcd, default_issue_type_name, default_user_id, date_time) 
	                            values ('Request', 'Feature Request',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            go
                            -- default_issue_status_ref
                            insert into default_issue_status_ref (default_issue_status_rcd, default_issue_status_name, default_user_id, date_time) 
	                            values ('ToBeResolved', 'To Be Resolved',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_issue_status_ref (default_issue_status_rcd, default_issue_status_name, default_user_id, date_time) 
	                            values ('NotReproducible', 'Not Reproducible',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_issue_status_ref (default_issue_status_rcd, default_issue_status_name, default_user_id, date_time) 
	                            values ('Resolved', 'Resolved',					'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_issue_status_ref (default_issue_status_rcd, default_issue_status_name, default_user_id, date_time) 
	                            values ('NotAnIssue', 'Not An Issue',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            go
                            -- default_error_layer_ref
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('DLL', 'Data Access Layer', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('BLL', 'Business Logic Layer', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('WinForms', 'Windows Winforms', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('MVC', 'ASP Model View Controller', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('Proxy', 'Client Proxy', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('BLLEngine', 'Business Layer Engine', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('CEngine', 'Client Engine', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('DB', 'Database', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('Test', 'Automated Testing', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('BLLSoap', 'Business Logic Layer Soap', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('BLLRest', 'Business Logic Layer Rest', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('S2W', 'Sql2Wcf', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('DOC', 'Documentation', getutcdate());
                            insert into default_error_layer_ref (default_error_layer_rcd, default_error_layer_name, date_time) 
	                            values ('TestF', 'Test Front', getutcdate());

                            -- default_error_type_ref
                            insert into default_error_type_ref (default_error_type_rcd, default_error_type_name, date_time) 
	                            values ('User', 'User Initiated', getutcdate());
                            insert into default_error_type_ref (default_error_type_rcd, default_error_type_name, date_time) 
	                            values ('Engine', 'Engine', getutcdate());
                            insert into default_error_type_ref (default_error_type_rcd, default_error_type_name, date_time) 
	                            values ('Test', 'Automated Test', getutcdate());
                            insert into default_error_type_ref (default_error_type_rcd, default_error_type_name, date_time) 
	                            values ('Silent', 'Silent/Caught', getutcdate());
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }

        private void InitDefaultUserActivity(
            int majorNumber,
            int minorNumber,
            out int sequence
            ) {
            sequence = 0;

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 05) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultUserActivity",
                Description = "Default User Activity Drop and Create Tables",
                #region script ( default_user_activity, default_user_activity_type_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            if object_id (N'default_user_activity') is not null
                                drop table default_user_activity
                            go
                            if object_id (N'default_user_activity_type_ref') is not null
                                drop table default_user_activity_type_ref
                            go
                            create table default_user_activity_type_ref (
                                default_user_activity_type_rcd  varchar(20) not null,
                                default_user_activity_type_name  nvarchar(240) not null,
                                default_user_id  uniqueidentifier not null,
                                date_time  datetime not null,
                                constraint  xpkdefault_user_activity_type_ref primary key   clustered(default_user_activity_type_rcd  asc)
                            )
                            go
                            create table default_user_activity (
                                default_user_activity_id  uniqueidentifier not null,
                                default_user_activity_type_rcd  varchar(20) not null,
                                user_activity_note  nvarchar(240) not null,
                                originating_address  varchar(20)  null,
                                referrer  nvarchar(240)  null,
                                default_user_id  uniqueidentifier not null,
                                date_time  datetime not null,
                                constraint  xpkdefault_user_activity primary key   clustered(default_user_activity_id  asc),
                                constraint  default_user_activity_to_user foreign key(default_user_id) references default_user(default_user_id),
                                constraint  default_user_activity_to_default_user_activity_type_ref foreign key(default_user_activity_type_rcd) references default_user_activity_type_ref(default_user_activity_type_rcd)
                            )
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 05) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultUserActivityReference",
                Description = "Default User Activity Reference Data",
                #region script ( default_user_activity_type_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            insert into default_user_activity_type_ref(default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time) 
	                            values ('li', 'Login', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_user_activity_type_ref(default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time) 
	                            values ('lo', 'Logout', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_user_activity_type_ref(default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time) 
	                            values ('fo', 'Form Opened', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_user_activity_type_ref(default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time) 
	                            values ('blmi', 'Business Logic Method Invoked', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_user_activity_type_ref(default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time) 
	                            values ('wpo', 'Web Page Opened', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_user_activity_type_ref(default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time) 
	                            values ('se', 'Scheduled Event', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }

        private void InitDefaultSystemSetting(
            int majorNumber,
            int minorNumber,
            ref int sequence
            ) {
            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 06) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultSystemSetting",
                Description = "DefaultSystemSetting Drop and Create",
                #region script ( default_system_setting, default_system_setting_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            if object_id (N'default_system_setting') is not null
                                drop table default_system_setting
                            go
                            if object_id (N'default_system_setting_ref') is not null
                                drop table default_system_setting_ref
                            go
                            create table default_system_setting_ref (
	                            default_system_setting_rcd varchar(20) not null,
	                            default_system_setting_name nvarchar(240) not null,
	                            default_user_id  uniqueidentifier not null,
	                            date_time datetime not null,
	                            constraint xpkdefault_system_setting_ref primary key clustered (default_system_setting_rcd  asc)
                            )
                            go
                            create table default_system_setting (
	                            default_system_setting_id uniqueidentifier not null,
	                            default_system_setting_rcd varchar(20) not null,
	                            default_system_setting_value nvarchar(240) not null,
	                            default_user_id uniqueidentifier not null,
	                            date_time datetime not null,
	                            constraint xpkdefault_system_setting primary key clustered (default_system_setting_id  asc),
	                            constraint default_system_setting_to_default_system_setting_ref foreign key (default_system_setting_rcd) references default_system_setting_ref(default_system_setting_rcd)
                            )
                            go
                            create index xif1default_system_setting on default_system_setting (
	                            default_system_setting_rcd  asc
                            )                            
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 06) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultSystemSettingReference",
                Description = "Default System Setting Reference",
                #region script ( default_system_setting, default_system_setting_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                        insert into default_system_setting_ref (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time) 
	                        values ('GS1LINK', 'The Global Language of Business', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

                        insert into default_system_setting(default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time )
	                        values (newid(), dbo.ref('default_system_setting_ref.GS1LINK'), 'https://gepir.gs1.org/index.php/search-by-gtin', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

                        insert into default_system_setting_ref (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time) 
	                        values ('EANLINK', 'EAN13 web link', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

                        insert into default_system_setting(default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time )
	                        values (newid(), dbo.ref('default_system_setting_ref.EANLINK'), 'https://www.ean-search.org/?q=', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }

        private void InitDefaultChangeLog(
            int majorNumber,
            int minorNumber,
            ref int sequence
            ) {
            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 06) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultChangeLog",
                Description = "DefaultChangeLog Drop and Create",
                #region script ( default_change_log, default_change_log_type_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            if object_id (N'default_change_log') is not null
                                drop table default_change_log
                            go
                            if object_id (N'default_change_log_type_ref') is not null
                                drop table default_change_log_type_ref
                            go
                            create table default_change_log_type_ref (
                                default_change_log_type_rcd varchar(20) not null,
                                default_change_log_type_name nvarchar(240) not null,
                                default_user_id uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpkdefault_change_log_type_ref primary key clustered(default_change_log_type_rcd asc),
                                constraint default_change_log_type_ref_to_default_user foreign key(default_user_id) references default_user(default_user_id)
                            )
                            go
                            create index xif1default_change_log_type_ref on default_change_log_type_ref (
                                default_user_id asc
                            )
                            go
                            create table default_change_log (
                                default_change_log_id uniqueidentifier not null,
                                default_change_name nvarchar(240) not null,
                                default_change_description text null,
                                default_user_id uniqueidentifier not null,
                                date_time  datetime not null,
                                default_change_log_type_rcd  varchar(20) not null,
                                default_issue_id uniqueidentifier null,
                                constraint xpkdefault_change_log primary key clustered(default_change_log_id asc),
                                constraint default_change_log_to_default_user foreign key(default_user_id) references default_user(default_user_id),
                                constraint default_change_log_to_default_change_log_type_ref foreign key(default_change_log_type_rcd) references default_change_log_type_ref(default_change_log_type_rcd),
                                constraint default_change_log_to_default_issue foreign key(default_issue_id) references default_issue(default_issue_id)
                            )
                            go
                            create index xif1default_change_log on default_change_log (
                                default_user_id asc
                            )
                            go
                            create index xif2default_change_log on default_change_log (
                                default_change_log_type_rcd asc
                            )
                            go
                            create index xif3default_change_log on default_change_log (
                                default_issue_id asc
                            )
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 06) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultChangeLog",
                Description = "DefaultChangeLog Reference ",
                #region script ( default_change_log_type_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            insert into default_change_log_type_ref (default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time) 
	                            values ('New', 'New Feature',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_change_log_type_ref (default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time) 
	                            values ('Change', 'Changed Feature',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_change_log_type_ref (default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time) 
	                            values ('Removed', 'Removed Feature',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into default_change_log_type_ref (default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time) 
	                            values ('Issue', 'Issue',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }

        private void InitDefaultRule(
            int majorNumber,
            int minorNumber,
            ref int sequence
            ) {
            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 06) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultRule",
                Description = "DefaultRule Drop and Create",
                #region script ( default_rule, default_rule_type_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            if object_id (N'default_rule') is not null
                                drop table default_rule
                            go
                            if object_id (N'default_rule_type_ref') is not null
                                drop table default_rule_type_ref
                            go
                            create table default_rule_type_ref (
                                default_rule_type_rcd varchar(20) not null,
                                default_rule_type_name nvarchar(240) not null,
                                default_user_id  uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpkdefault_rule_type_ref primary key clustered(default_rule_type_rcd  asc)
                            )
                            go
                            create table default_rule (
                                default_rule_id uniqueidentifier not null,
                                default_rule_type_rcd varchar(20) not null,
                                address varchar(20) not null,
                                default_user_id uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpkdefault_rule primary key clustered(default_rule_id  asc),
                                constraint default_error_rule_to_default_error_rule_type_ref foreign key(default_rule_type_rcd) references default_rule_type_ref(default_rule_type_rcd)
                            )
                            go
                            create index xif1default_rule on default_rule (
                                default_rule_type_rcd asc
                            )
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 06) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultRule",
                Description = "DefaultRule Reference",
                #region script ( default_rule_type_ref )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            insert into default_rule_type_ref (default_rule_type_rcd, default_rule_type_name, default_user_id, date_time) 
	                            values ('Hide', 'Hide Layer Address', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }

        private void InitDefaultPerformanceIssue(
            int majorNumber,
            int minorNumber,
            ref int sequence
            ) {
            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 06) },
                ScriptNumber = scriptNumber++,
                Name = "DefaultPerformanceIssue",
                Description = "DefaultPerformanceIssue Drop and Create",
                #region script ( default_performance_issue, default_performance_time, default_performance_time_rollup, default_resource_measurement, default_test_run, default_test_run_result_ref, default_test )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            if object_id (N'default_performance_issue') is not null
                                drop table default_performance_issue
                            go
                            if object_id (N'default_performance_time') is not null
                                drop table default_performance_time
                            go
                            if object_id (N'default_performance_time_rollup') is not null
                                drop table default_performance_time_rollup
                            go
                            if object_id (N'default_resource_measurement') is not null
                                drop table default_resource_measurement
                            go
                            if object_id (N'default_test_run') is not null
                                drop table default_test_run
                            go
                            if object_id (N'default_test_run_result_ref') is not null
                                drop table default_test_run_result_ref
                            go
                            if object_id (N'default_test') is not null
                                drop table default_test
                            go
                            create table default_performance_time_rollup (
                                default_performance_time_rollup_id uniqueidentifier not null,
                                command_name nvarchar(240) not null,
                                milliseconds bigint not null,
                                hits bigint not null,
                                default_user_id uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpkdefault_performance_time_rollup primary key clustered(default_performance_time_rollup_id)
                            )
                            go
                            create table default_performance_time (
                                default_performance_time_id uniqueidentifier not null,
                                command_name nvarchar(240) not null,
                                milliseconds integer not null,
                                default_user_id uniqueidentifier null,
                                date_time datetime not null,
                                constraint xpkdefault_performance_time primary key clustered(default_performance_time_id),
                                constraint default_performance_time_to_default_user foreign key(default_user_id) references default_user(default_user_id)
                            )
                            go
                            create index xif1default_performance_time on default_performance_time (
                                default_user_id
                            )
                            go
                            create table default_performance_issue (
                                default_performance_issue_id uniqueidentifier not null,
                                command_name nvarchar(240) not null,
                                command_text text not null,
                                milliseconds integer not null,
                                default_user_id uniqueidentifier null,
                                date_time datetime not null,
                                constraint xpkdefault_performance_issue primary key   clustered(default_performance_issue_id),
                                constraint default_performance_issue_to_default_user foreign key(default_user_id) references default_user(default_user_id)
                            )
                            go
                            create index xif1default_performance_issue on default_performance_issue (
                                default_user_id
                            )
                            go
                            create table default_resource_measurement (
                                default_resource_measurement_id uniqueidentifier not null,
                                client_workingset_bytes integer null,
                                business_workingset_bytes integer null,
                                database_size_bytes integer null,
                                default_user_id uniqueidentifier null,
                                date_time datetime not null,
                                constraint xpkdefault_resource_measurement primary key clustered(default_resource_measurement_id asc)
                            )
                            go
                            create table default_test (
                                default_test_id uniqueidentifier not null,
                                system_name nvarchar(240) not null,
                                test_area nvarchar(240) not null,
                                test_sub_area nvarchar(240) null,
                                test_address nvarchar(240) null,
                                user_id uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpkdefault_test primary key nonclustered(default_test_id asc)
                            )
                            go
                            create table default_test_run_result_ref (
                                default_test_run_result_rcd varchar(20) not null,
                                default_test_run_result_name nvarchar(240) not null,
                                user_id uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpkdefault_test_run_result_ref primary key nonclustered(default_test_run_result_rcd asc)
                            )
                            go
                            create table default_test_run (
                                default_test_run_id uniqueidentifier not null,
                                default_test_id uniqueidentifier not null,
                                default_test_run_result_rcd varchar(20) not null,
                                result nvarchar(240) not null,
                                start_date_time datetime not null,
                                end_date_time datetime not null,
                                elapsed_milliseconds integer not null,
                                user_id uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpkdefault_test_run primary key nonclustered(default_test_run_id asc),
                                constraint default_test_to_default_test_run foreign key(default_test_id) references default_test(default_test_id),
                                constraint default_test_run_to_default_test_run_result_ref foreign key(default_test_run_result_rcd) references default_test_run_result_ref(default_test_run_result_rcd)
                            )
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }
    }
}
