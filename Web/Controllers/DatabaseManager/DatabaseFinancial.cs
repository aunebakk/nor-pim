using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    public partial class DatabaseManager {
        void InitFinancial(
            int majorNumber,
            int minorNumber
            ) {

            int sequence = 0;

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "DefaultFinancialColumnTypes",
                Description = "Default Financial Column Types",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
if type_id (N'name') is null
	exec sp_addtype 'name'
	    , 'nvarchar(240)', 'not null'
go
if type_id (N'code') is null
	exec sp_addtype 'code'
	    , 'nvarchar(240)', 'not null'
go
if type_id (N'comment') is null
	exec sp_addtype 'comment'
		, 'nvarchar(255)', 'not null'
go
if type_id (N'currency') is null
	exec sp_addtype 'currency'
	    , 'decimal(15,4)', 'not null'
go
if type_id (N'description') is null
	exec sp_addtype 'description'
	    , 'varchar(255)', 'not null'
go
if type_id (N'flag') is null
	exec sp_addtype 'flag'
	    , 'bit', 'null'
go
if type_id (N'id') is null
	exec sp_addtype 'id'
	    , 'uniqueidentifier', 'not null'
go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "DefaultFinancialDropTables",
                Description = "Default Financial Drop Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
if object_id (N'financial_order') is not null
	drop table financial_order
if object_id (N'financial_currency') is not null
	drop table financial_currency
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "DefaultFinancialCreateTables",
                Description = "Default Financial Create Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
create table financial_currency
(
    financial_currency_id id,
    financial_currency_type_rcd code,
    financial_currency_against_financial_currency_type_rcd code  not null,
    user_id            id,
    date_time          datetime  not null,
    valid_from_date_time datetime  not null,
    valid_until_date_time datetime  null,
    amount             currency,
    equals_amount      currency,
    decimal_count      integer  not null,
    financial_currency_type_code name,
    financial_currency_type_name name,
    constraint xpkfinancial_currency primary key  clustered(financial_currency_id asc)
)
go



create nonclustered index xif1financial_currency on financial_currency
(
    financial_currency_type_rcd  asc
)
go



create nonclustered index xif2financial_currency on financial_currency
(
    financial_currency_against_financial_currency_type_rcd  asc
)
go


create table financial_order
(
    financial_order_id id,
    user_id            id,
    date_time          datetime  not null,
    comment            name  null,
    location_address_id id  null,
    financial_currency_id id,
    financial_order_source_rcd code,
    client_id          id,
    constraint xpkfinancial_order primary key  clustered(financial_order_id asc)
)
go



create nonclustered index xif7financial_order on financial_order
(
    location_address_id  asc
)
go



create nonclustered index xif8financial_order on financial_order
(
    financial_currency_id  asc
)
go



create nonclustered index xif9financial_order on financial_order
(
    financial_order_source_rcd  asc
)
go



create nonclustered index xif10financial_order on financial_order
(
    client_id           asc
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
                Name = "FinancialReferenceData",
                Description = "Financial Reference Data",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
set nocount on
go

-- financial currency
-- SEK
declare @financial_currency_swe_id uniqueidentifier set @financial_currency_swe_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_swe_id, dbo.ref('financial_currency_type_ref.SEK'), dbo.ref('financial_currency_type_ref.SEK'), 'Swedish Krona',  
			1, dbo.ref('financial_currency_type_ref.SEK'), 1, getutcdate(), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- EUR
declare @financial_currency_eur_id uniqueidentifier set @financial_currency_eur_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_eur_id, dbo.ref('financial_currency_type_ref.EUR'), dbo.ref('financial_currency_type_ref.EUR'), 'Euro',  
			1, dbo.ref('financial_currency_type_ref.EUR'), 1, getutcdate(), 4, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- against USD
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (newid(), dbo.ref('financial_currency_type_ref.EUR'), dbo.ref('financial_currency_type_ref.EUR'), 'Euro', 
			1, dbo.ref('financial_currency_type_ref.USD'), 7, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- THB
declare @financial_currency_thb_id uniqueidentifier set @financial_currency_thb_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_thb_id, dbo.ref('financial_currency_type_ref.THB'), dbo.ref('financial_currency_type_ref.THB'), 'Thai Bath',  
			1, dbo.ref('financial_currency_type_ref.THB'), 1, getutcdate(), 4, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- against USD
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (newid(), dbo.ref('financial_currency_type_ref.EUR'), dbo.ref('financial_currency_type_ref.EUR'), 'Euro', 
			1, dbo.ref('financial_currency_type_ref.USD'), 40, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- USD
declare @financial_currency_usd_id uniqueidentifier set @financial_currency_usd_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_usd_id, dbo.ref('financial_currency_type_ref.USD'), dbo.ref('financial_currency_type_ref.USD'), 'United States Dollar',  
			1, dbo.ref('financial_currency_type_ref.USD'), 1, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- against NOK
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (newid(), dbo.ref('financial_currency_type_ref.USD'), dbo.ref('financial_currency_type_ref.USD'), 'United States Dollar', 
			1, dbo.ref('financial_currency_type_ref.NOK'), 7, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- NOK
declare @financial_currency_nok_id uniqueidentifier set @financial_currency_nok_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_nok_id, dbo.ref('financial_currency_type_ref.NOK'), dbo.ref('financial_currency_type_ref.NOK'), 'Norwegian Krone', 
			1, dbo.ref('financial_currency_type_ref.NOK'), 1, getutcdate(), 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- against USD
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (newid(), dbo.ref('financial_currency_type_ref.NOK'), dbo.ref('financial_currency_type_ref.NOK'), 'Norwegian Krone', 
			7, dbo.ref('financial_currency_type_ref.USD'), 1, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }
    }
}
