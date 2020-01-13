using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    public partial class DatabaseManager {
        void InitLocation(
            int majorNumber,
            int minorNumber
            ) {

            int sequence = 0;

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "LocationDropTables",
                Description = "Location Drop Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
if object_id (N'location_address_type_ref') is not null
	drop table location_address_type_ref
if object_id (N'location_country') is not null
	drop table location_country
if object_id (N'location_address') is not null
	drop table location_address
if object_id (N'location_city') is not null
	drop table location_city
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "LocationCreateTables",
                Description = "Location Create Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
create table location_address_type_ref
(
    location_address_type_rcd  nvarchar(240)  not null,
    location_address_type_name  nvarchar(240)  not null,
    user_id  uniqueidentifier  not null,
    date_time  datetime  not null,
    constraint  xpklocation_address_type_ref primary key   clustered(location_address_type_rcd  asc)
)
go


create table location_country
(
    location_country_id  uniqueidentifier  not null,
    location_country_code  nvarchar(240)  not null,
    location_country_name  nvarchar(240)  not null,
    user_id  uniqueidentifier  not null,
    date_time  datetime  not null,
    constraint  xpklocation_country primary key   clustered(location_country_id  asc)
)
go


create table location_address
(
    location_address_id  uniqueidentifier  not null,
    location_address_type_rcd  nvarchar(240)  null,
    location_country_id  uniqueidentifier  not null,
    address_one  nvarchar(240)  null,
    address_two  nvarchar(240)  null,
    address_three  nvarchar(240)  null,
    city  nvarchar(240)  null,
    street  nvarchar(240)  null,
    state  nvarchar(240)  null,
    district  nvarchar(240)  null,
    province  nvarchar(240)  null,
    zip_code  nvarchar(240)  null,
    po_box  nvarchar(240)  null,
    comment  nvarchar(240)  null,
    user_id  uniqueidentifier  not null,
    date_time  datetime  not null,
    constraint  xpklocation_address primary key   clustered(location_address_id  asc),
    constraint  address_to_address_type_ref foreign key(location_address_type_rcd) references location_address_type_ref(location_address_type_rcd),
constraint  location_address_to_location_country foreign key(location_country_id) references location_country(location_country_id)
)
go
create table location_city
(
    location_city_id  uniqueidentifier  not null,
    location_country_id  uniqueidentifier  not null,
    location_city_code  nvarchar(240)  not null,
    location_city_name  nvarchar(240)  not null,
    user_id  uniqueidentifier  not null,
    date_time  datetime  not null,
    constraint  xpklocation_city primary key   clustered(location_city_id  asc),
    constraint  city_to_country foreign key(location_country_id) references location_country(location_country_id)
)
go


create index xif1location_city on location_city
(
    location_country_id  asc
)
go

                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "LocationReferenceAndTestData",
                Description = "Location Reference And Test Data",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'location_address_type_ref'			                        ,'Location Address Type'			        ,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- country
insert into location_country (location_country_id, location_country_code, location_country_name, user_id, date_time ) 
	values (newid(), 'NO', 'Norway', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getdate());
insert into location_country (location_country_id, location_country_code, location_country_name, user_id, date_time ) 
	values (newid(), 'SE', 'Sweden', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getdate());

-- address type
insert into location_address_type_ref (location_address_type_rcd, location_address_type_name, user_id, date_time )
	values ('Primary', 'Primary', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into location_address_type_ref (location_address_type_rcd, location_address_type_name, user_id, date_time )
	values ('Office', 'Office', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into location_address_type_ref (location_address_type_rcd, location_address_type_name, user_id, date_time )
	values ('Private', 'Private', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }
    }
}
