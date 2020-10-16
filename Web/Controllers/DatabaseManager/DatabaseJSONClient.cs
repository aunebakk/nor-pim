using System;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    public partial class DatabaseManager {
        public void InitJSONClient(
            int majorNumber,
            int minorNumber
            ) {

            int sequence = 0;

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2015, 11, 22) },
                ScriptNumber = scriptNumber++,
                Name = "ClientSchema",
                Description = "Client Schema",
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            /*
                              SQL2X Generated code based on a SQL Server Schema
                              SQL2X Version: 0.d
                              http://sql2core.azurewebsites.net/
                              Generated Date: 21.01.2018 18:54:14
                              Template: sql2x.GenerateSchema.Generate
                            */
                            if object_id (N'client_link') is not null
                                drop table client_link 
                            go
                            if object_id (N'client_identifier') is not null
                                drop table client_identifier 
                            go
                            if object_id (N'client_event') is not null
                                drop table client_event 
                            go
                            if object_id (N'client_document') is not null
                                drop table client_document 
                            go
                            if object_id (N'client_contact_method') is not null
                                drop table client_contact_method 
                            go
                            if object_id (N'client_link_type_ref') is not null
                                drop table client_link_type_ref 
                            go
                            if object_id (N'client_identifier_type_ref') is not null
                                drop table client_identifier_type_ref 
                            go
                            if object_id (N'client_event_type_ref') is not null
                                drop table client_event_type_ref 
                            go
                            if object_id (N'client_document_type_ref') is not null
                                drop table client_document_type_ref 
                            go
                            if object_id (N'client_contact_method_ref') is not null
                                drop table client_contact_method_ref 
                            go
                            if object_id (N'client') is not null
                                drop table client 
                            go
                            if object_id (N'client_address') is not null
                                drop table client_address 
                            go
                            if object_id (N'client_type_ref') is not null
                                drop table client_type_ref 
                            go
                            if object_id (N'client_nationality_ref') is not null
                                drop table client_nationality_ref 
                            go
                            if object_id (N'client_gender_ref') is not null
                                drop table client_gender_ref 
                            go
                            if object_id (N'client_title_ref') is not null
                                drop table client_title_ref 
                            go
                            if object_id (N'client_address_type_ref') is not null
                                drop table client_address_type_ref 
                            go
                            set nocount on
                            go
                            create table client_type_ref (
                                client_type_rcd varchar(20) not null,
                                client_type_name nvarchar(240) not null,
                                client_type_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_type_ref
                                    primary key clustered (client_type_rcd asc)
                            )
                            go
                            insert into client_type_ref(client_type_rcd, client_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('PRA', 'Private', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_type_ref(client_type_rcd, client_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('BUA', 'Business', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_nationality_ref (
                                client_nationality_rcd varchar(20) not null,
                                client_nationality_name nvarchar(240) not null,
                                client_nationality_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_nationality_ref
                                    primary key clustered (client_nationality_rcd asc)
                            )
                            go
                            insert into client_nationality_ref(client_nationality_rcd, client_nationality_name, sort_order, active_flag, [user_id], date_time)
                             values ('AFA', 'Africa', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_nationality_ref(client_nationality_rcd, client_nationality_name, sort_order, active_flag, [user_id], date_time)
                             values ('AMA', 'Americas', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_nationality_ref(client_nationality_rcd, client_nationality_name, sort_order, active_flag, [user_id], date_time)
                             values ('ASA', 'Asia', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_nationality_ref(client_nationality_rcd, client_nationality_name, sort_order, active_flag, [user_id], date_time)
                             values ('EUA', 'Europe', 4, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_nationality_ref(client_nationality_rcd, client_nationality_name, sort_order, active_flag, [user_id], date_time)
                             values ('OCA', 'Oceania', 5, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_gender_ref (
                                client_gender_rcd varchar(20) not null,
                                client_gender_name nvarchar(240) not null,
                                client_gender_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_gender_ref
                                    primary key clustered (client_gender_rcd asc)
                            )
                            go
                            insert into client_gender_ref(client_gender_rcd, client_gender_name, sort_order, active_flag, [user_id], date_time)
                             values ('MAA', 'Male', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_gender_ref(client_gender_rcd, client_gender_name, sort_order, active_flag, [user_id], date_time)
                             values ('FEA', 'Female', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_gender_ref(client_gender_rcd, client_gender_name, sort_order, active_flag, [user_id], date_time)
                             values ('UNA', 'Unknown', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_title_ref (
                                client_title_rcd varchar(20) not null,
                                client_title_name nvarchar(240) not null,
                                client_title_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_title_ref
                                    primary key clustered (client_title_rcd asc)
                            )
                            go
                            insert into client_title_ref(client_title_rcd, client_title_name, sort_order, active_flag, [user_id], date_time)
                             values ('MR', 'Mr', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_title_ref(client_title_rcd, client_title_name, sort_order, active_flag, [user_id], date_time)
                             values ('MRS', 'Mrs', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_title_ref(client_title_rcd, client_title_name, sort_order, active_flag, [user_id], date_time)
                             values ('CHA', 'Child', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_title_ref(client_title_rcd, client_title_name, sort_order, active_flag, [user_id], date_time)
                             values ('INA', 'Infant', 4, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_link_type_ref (
                                client_link_type_rcd varchar(20) not null,
                                client_link_type_name nvarchar(240) not null,
                                client_link_type_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_link_type_ref
                                    primary key clustered (client_link_type_rcd asc)
                            )
                            go
                            insert into client_link_type_ref(client_link_type_rcd, client_link_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('WPE', 'Web Page', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_identifier_type_ref (
                                client_identifier_type_rcd varchar(20) not null,
                                client_identifier_type_name nvarchar(240) not null,
                                client_identifier_type_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_identifier_type_ref
                                    primary key clustered (client_identifier_type_rcd asc)
                            )
                            go
                            insert into client_identifier_type_ref(client_identifier_type_rcd, client_identifier_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('PNR', 'Passport Number', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_identifier_type_ref(client_identifier_type_rcd, client_identifier_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('ENR', 'Employee Number', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_address_type_ref (
                                client_address_type_rcd varchar(20) not null,
                                client_address_type_name nvarchar(240) not null,
                                client_address_type_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_address_type_ref
                                    primary key clustered (client_address_type_rcd asc)
                            )
                            go
                            insert into client_address_type_ref(client_address_type_rcd, client_address_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('PRA', 'Private', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_address_type_ref(client_address_type_rcd, client_address_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('OFA', 'Office', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_address_type_ref(client_address_type_rcd, client_address_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('TEA', 'Temporary', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_event_type_ref (
                                client_event_type_rcd varchar(20) not null,
                                client_event_type_name nvarchar(240) not null,
                                client_event_type_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_event_type_ref
                                    primary key clustered (client_event_type_rcd asc)
                            )
                            go
                            insert into client_event_type_ref(client_event_type_rcd, client_event_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('CRA', 'Created', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_event_type_ref(client_event_type_rcd, client_event_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('INA', 'Inactivated', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_event_type_ref(client_event_type_rcd, client_event_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('SIM', 'Sent Introduction Mail', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_event_type_ref(client_event_type_rcd, client_event_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('IMC', 'Introduction Mail Confirmed', 4, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_event_type_ref(client_event_type_rcd, client_event_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('PMS', 'Package Mail Sent', 5, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_event_type_ref(client_event_type_rcd, client_event_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('PSV', 'Package Site Viewed', 6, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_event_type_ref(client_event_type_rcd, client_event_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('POD', 'Package Ordered', 7, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_document_type_ref (
                                client_document_type_rcd varchar(20) not null,
                                client_document_type_name nvarchar(240) not null,
                                client_document_type_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_document_type_ref
                                    primary key clustered (client_document_type_rcd asc)
                            )
                            go
                            insert into client_document_type_ref(client_document_type_rcd, client_document_type_name, sort_order, active_flag, [user_id], date_time)
                             values ('PFP', 'Passport First Page', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_contact_method_ref (
                                client_contact_method_rcd varchar(20) not null,
                                client_contact_method_name nvarchar(240) not null,
                                client_contact_method_description nvarchar(240) null,
                                active_flag bit not null,
                                sort_order integer not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_contact_method_ref
                                    primary key clustered (client_contact_method_rcd asc)
                            )
                            go
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('EMA', 'EMail', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('TEA', 'Telephone', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('LPE', 'Local Phone', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('IPE', 'International Phone', 4, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('HPE', 'Home Phone', 5, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('BPE', 'Business Phone', 6, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('FAX', 'Fax', 7, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('MOA', 'Mobile', 8, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('SME', 'SMS Mobile', 9, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            insert into client_contact_method_ref(client_contact_method_rcd, client_contact_method_name, sort_order, active_flag, [user_id], date_time)
                             values ('MME', 'MMS Mobile', 10, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}',getutcdate())
                            go
                            create table client_address (
                                client_address_id uniqueidentifier not null,
                                client_id uniqueidentifier null,
                                client_address_type_rcd varchar(20) not null,
                                address_line_one_name nvarchar(240) not null,
                                address_line_two_name nvarchar(240) not null,
                                address_line_three_name nvarchar(240) not null,
                                city_name nvarchar(240) not null,
                                street_name nvarchar(240) not null,
                                state_name nvarchar(240) not null,
                                district_name nvarchar(240) not null,
                                province_name nvarchar(240) not null,
                                zip_code nvarchar(240) not null,
                                po_box nvarchar(240) not null,
                                [comment] nvarchar(240) not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_address
                                    primary key clustered (client_address_id asc),
                                constraint client_address_to_client_address_type_ref 
                                    foreign key (client_address_type_rcd)
                                    references client_address_type_ref(client_address_type_rcd)
                            )
                            go
                            create table client (
                                client_id uniqueidentifier not null,
                                client_type_rcd varchar(20) not null,
                                client_nationality_rcd varchar(20) null,
                                client_gender_rcd varchar(20) null,
                                client_title_rcd varchar(20) null,
                                client_address_id uniqueidentifier null,
                                first_name nvarchar(240) not null,
                                middle_name nvarchar(240) null,
                                last_name nvarchar(240) not null,
                                [image] varbinary(max) null,
                                image_blob_filename nvarchar(240) null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client
                                    primary key clustered (client_id asc),
                                constraint client_to_client_type_ref 
                                    foreign key (client_type_rcd)
                                    references client_type_ref(client_type_rcd),
                                constraint client_to_client_nationality_ref 
                                    foreign key (client_nationality_rcd)
                                    references client_nationality_ref(client_nationality_rcd),
                                constraint client_to_client_gender_ref 
                                    foreign key (client_gender_rcd)
                                    references client_gender_ref(client_gender_rcd),
                                constraint client_to_client_title_ref 
                                    foreign key (client_title_rcd)
                                    references client_title_ref(client_title_rcd),
                                constraint client_to_client_address 
                                    foreign key (client_address_id)
                                    references client_address(client_address_id)
                            )
                            go
                            create table client_link (
                                client_link_id uniqueidentifier not null,
                                client_id uniqueidentifier not null,
                                client_link_type_rcd varchar(20) not null,
                                link_name nvarchar(240) null,
                                link nvarchar(240) not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_link
                                    primary key clustered (client_link_id asc),
                                constraint client_link_to_client 
                                    foreign key (client_id)
                                    references client(client_id),
                                constraint client_link_to_client_link_type_ref 
                                    foreign key (client_link_type_rcd)
                                    references client_link_type_ref(client_link_type_rcd)
                            )
                            go
                            create table client_identifier (
                                client_identifier_id uniqueidentifier not null,
                                client_id uniqueidentifier not null,
                                client_identifier_type_rcd varchar(20) not null,
                                client_identifier_code varchar(20) not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_identifier
                                    primary key clustered (client_identifier_id asc),
                                constraint client_identifier_to_client 
                                    foreign key (client_id)
                                    references client(client_id),
                                constraint client_identifier_to_client_identifier_type_ref 
                                    foreign key (client_identifier_type_rcd)
                                    references client_identifier_type_ref(client_identifier_type_rcd)
                            )
                            go
                            create table client_event (
                                client_event_id uniqueidentifier not null,
                                client_id uniqueidentifier not null,
                                client_event_type_rcd varchar(20) not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_event
                                    primary key clustered (client_event_id asc),
                                constraint client_event_to_client 
                                    foreign key (client_id)
                                    references client(client_id),
                                constraint client_event_to_client_event_type_ref 
                                    foreign key (client_event_type_rcd)
                                    references client_event_type_ref(client_event_type_rcd)
                            )
                            go
                            create table client_document (
                                client_document_id uniqueidentifier not null,
                                client_id uniqueidentifier not null,
                                client_document_type_rcd varchar(20) not null,
                                document_name nvarchar(240) not null,
                                document_date_time datetime not null,
                                expiry_date_time datetime not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_document
                                    primary key clustered (client_document_id asc),
                                constraint client_document_to_client 
                                    foreign key (client_id)
                                    references client(client_id),
                                constraint client_document_to_client_document_type_ref 
                                    foreign key (client_document_type_rcd)
                                    references client_document_type_ref(client_document_type_rcd)
                            )
                            go
                            create table client_contact_method (
                                client_contact_method_id uniqueidentifier not null,
                                client_id uniqueidentifier not null,
                                client_contact_method_rcd varchar(20) not null,
                                contact_method_way nvarchar(240) not null,
                                [comment] text not null,
                                [user_id] uniqueidentifier not null,
                                date_time datetime not null,
                                constraint xpk_client_contact_method
                                    primary key clustered (client_contact_method_id asc),
                                constraint client_contact_method_to_client 
                                    foreign key (client_id)
                                    references client(client_id),
                                constraint client_contact_method_to_client_contact_method_ref 
                                    foreign key (client_contact_method_rcd)
                                    references client_contact_method_ref(client_contact_method_rcd)
                            )
                            ",
                    BreakUpToBatches = false
                }
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2015, 11, 22) },
                ScriptNumber = scriptNumber++,
                Name = "ClientTestData",
                Description = "Client Test Data",
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
                            -- default client uses default user 
                            declare @client_id uniqueidentifier = N'ffffffff-5555-5555-5555-ffffffffffff'
                            insert into client ( client_id, first_name, middle_name, last_name, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_type_rcd, user_id, date_time)
			                            values (@client_id,	'Test', '', 'Data', dbo.ref('client_nationality_ref.OCA'), dbo.ref('client_gender_ref.MAA'), dbo.ref('client_title_ref.MR'), dbo.ref('client_type_ref.BUA'), '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into client_contact_method ( client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time)
			                            values ( newid(), @client_id, dbo.ref('client_contact_method_ref.EMA'), 'email@outlook.com', '', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into client_contact_method ( client_contact_method_id, client_id, client_contact_method_rcd, contact_method_way, comment, user_id, date_time)
			                            values ( newid(), @client_id, dbo.ref('client_contact_method_ref.MOA'), '+1 987 654321', '', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into client_link ( client_link_id, client_id, client_link_type_rcd, link, user_id, date_time)
			                            values ( newid(), @client_id, dbo.ref('client_link_type_ref.WPE'), 'www.google.com', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            insert into client_event ( client_event_id, client_id, client_event_type_rcd, user_id, date_time)
			                            values ( newid(), @client_id, dbo.ref('client_event_type_ref.CRA'), '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            go
                            declare @client_address_id uniqueidentifier = newid()
                            insert into client_address ( client_address_id, client_id, client_address_type_rcd,     address_line_one_name ,    address_line_two_name ,    address_line_three_name ,    city_name ,    street_name ,    state_name ,    district_name ,    province_name ,    zip_code ,    po_box ,    [comment] , user_id, date_time)
                               values (@client_address_id, @client_id, dbo.ref('client_address_type_ref.PRA'), 'Oslo', 'Oslo', 'Oslo', 'Oslo', 'Oslo', 'Oslo', 'Oslo', 'Oslo', 'Oslo', 'Oslo', 'Oslo', N'ffffffff-5555-5555-5555-ffffffffffff', getdate())
                            ",
                    BreakUpToBatches = false
                }
            });
        }
    }
}
