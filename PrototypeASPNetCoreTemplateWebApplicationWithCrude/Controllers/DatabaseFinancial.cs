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
if object_id (N'financial_order_event') is not null
	drop table financial_order_event
if object_id (N'financial_order_event_type_ref') is not null
	drop table financial_order_event_type_ref
if object_id (N'financial_order_transaction') is not null
	drop table financial_order_transaction
if object_id (N'financial_order_transaction_type_ref') is not null
	drop table financial_order_transaction_type_ref
if object_id (N'financial_adjustment') is not null
	drop table financial_adjustment
if object_id (N'financial_adjustment_type_ref') is not null
	drop table financial_adjustment_type_ref
if object_id (N'financial_costcentre') is not null
	drop table financial_costcentre
if object_id (N'financial_company') is not null
	drop table financial_company
if object_id (N'financial_payment') is not null
	drop table financial_payment
if object_id (N'financial_payment_coupon') is not null
	drop table financial_payment_coupon
if object_id (N'financial_coupon') is not null
	drop table financial_coupon
if object_id (N'financial_coupon_type_ref') is not null
	drop table financial_coupon_type_ref
if object_id (N'financial_payment_cash') is not null
	drop table financial_payment_cash
if object_id (N'financial_payment_card') is not null
	drop table financial_payment_card
if object_id (N'financial_card_type_ref') is not null
	drop table financial_card_type_ref
if object_id (N'financial_payment_voucher') is not null
	drop table financial_payment_voucher
if object_id (N'financial_voucher') is not null
	drop table financial_voucher
if object_id (N'financial_voucher_type_ref') is not null
	drop table financial_voucher_type_ref
if object_id (N'financial_payment_bank') is not null
	drop table financial_payment_bank
if object_id (N'financial_bank_account_number_type_ref') is not null
	drop table financial_bank_account_number_type_ref
if object_id (N'financial_payment_accounting') is not null
	drop table financial_payment_accounting
if object_id (N'financial_payment_type_ref') is not null
	drop table financial_payment_type_ref
if object_id (N'financial_tax') is not null
	drop table financial_tax
if object_id (N'financial_tax_type_ref') is not null
	drop table financial_tax_type_ref
if object_id (N'financial_fee') is not null
	drop table financial_fee
if object_id (N'financial_fee_type_ref') is not null
	drop table financial_fee_type_ref
if object_id (N'financial_order_line') is not null
	drop table financial_order_line
if object_id (N'financial_unit_of_measurement_ref') is not null
	drop table financial_unit_of_measurement_ref
if object_id (N'financial_order_identifier') is not null
	drop table financial_order_identifier
if object_id (N'financial_order_identifier_type_ref') is not null
	drop table financial_order_identifier_type_ref
if object_id (N'financial_order') is not null
	drop table financial_order
if object_id (N'financial_order_source_ref') is not null
	drop table financial_order_source_ref
if object_id (N'financial_currency') is not null
	drop table financial_currency
if object_id (N'financial_currency_type_ref') is not null
	drop table financial_currency_type_ref
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
create table financial_adjustment
(
    financial_adjustment_id id,
    amount             currency,
    financial_currency_id id,
    user_id            id,
    date_time          datetime  not null,
    financial_adjustment_type_rcd code,
    constraint xpkfinancial_adjustment primary key  clustered(financial_adjustment_id asc)
)
go



create nonclustered index xif1financial_adjustment on financial_adjustment
(
    financial_currency_id  asc
)
go



create nonclustered index xif2financial_adjustment on financial_adjustment
(
    financial_adjustment_type_rcd  asc
)
go



create table financial_adjustment_type_ref
(
    financial_adjustment_type_rcd code,
    financial_adjustment_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_adjustment_type_ref primary key  clustered(financial_adjustment_type_rcd asc)
)
go



create table financial_bank_account_number_type_ref
(
    financial_bank_account_number_type_rcd code,
    financial_bank_account_number_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_bank_account_number_type_ref primary key  clustered(financial_bank_account_number_type_rcd asc)
)
go



create table financial_card_type_ref
(
    financial_card_type_rcd code,
    financial_card_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_card_type_ref primary key  clustered(financial_card_type_rcd asc)
)
go



create table financial_company
(
    financial_company_id id,
    financial_company_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_company primary key  clustered(financial_company_id asc)
)
go



create table financial_costcentre
(
    financial_costcentre_id id,
    financial_costcentre_name name,
    financial_costcentre_code code,
    financial_company_id id,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_costcentre primary key  clustered(financial_costcentre_id asc)
)
go



create nonclustered index xif1financial_costcentre on financial_costcentre
(
    financial_company_id  asc
)
go



create table financial_coupon
(
    financial_coupon_id id,
    coupon_number      integer  not null,
    value_amount       currency,
    valid_from_date_time datetime  not null,
    valid_until_date_time datetime  not null,
    coupon_description description  null,
    financial_currency_id id,
    user_id            id,
    date_time          datetime  not null,
    financial_coupon_type_rcd code,
    constraint xpkfinancial_coupon primary key  clustered(financial_coupon_id asc)
)
go



create nonclustered index xif1financial_coupon on financial_coupon
(
    financial_currency_id  asc
)
go



create nonclustered index xif2financial_coupon on financial_coupon
(
    financial_coupon_type_rcd  asc
)
go



create table financial_coupon_type_ref
(
    financial_coupon_type_rcd code,
    financial_coupon_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_coupon_type_ref primary key  clustered(financial_coupon_type_rcd asc)
)
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



create table financial_currency_type_ref
(
    financial_currency_type_rcd code,
    financial_currency_type_name name,
    user_id            id,
    date_time          datetime  not null,
    decimal_count      integer  not null,
    financial_currency_type_code name,
    constraint xpkfinancial_currency_type_ref primary key  clustered(financial_currency_type_rcd asc)
)
go



create table financial_fee
(
    financial_fee_id   id,
    user_id            id,
    date_time          datetime  not null,
    financial_fee_type_rcd name,
    financial_currency_id id,
    amount             currency,
    constraint xpkfinancial_fee primary key  clustered(financial_fee_id asc)
)
go



create nonclustered index xif1financial_fee on financial_fee
(
    financial_fee_type_rcd  asc
)
go



create nonclustered index xif2financial_fee on financial_fee
(
    financial_currency_id  asc
)
go



create table financial_fee_type_ref
(
    financial_fee_type_rcd name,
    financial_fee_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_fee_type_ref primary key  clustered(financial_fee_type_rcd asc)
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



create table financial_order_event
(
    fiancial_order_event_id id,
    financial_order_id id,
    user_id            id,
    date_time          datetime  not null,
    comment            name  null,
    financial_order_event_type_rcd code,
    constraint xpkfinancial_order_event primary key  clustered(fiancial_order_event_id asc)
)
go



create nonclustered index xif2financial_order_event on financial_order_event
(
    financial_order_id  asc
)
go



create nonclustered index xif3financial_order_event on financial_order_event
(
    financial_order_event_type_rcd  asc
)
go



create table financial_order_event_type_ref
(
    financial_order_event_type_rcd code,
    financial_order_event_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_order_event_type_ref primary key  clustered(financial_order_event_type_rcd asc)
)
go



create table financial_order_identifier
(
    financial_order_identifier_id id,
    financial_order_id id,
    financial_order_identifier_type_rcd code,
    financial_order_identifier_code code,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_order_identifier primary key  nonclustered(financial_order_identifier_id asc)
)
go



create nonclustered index xif1financial_order_identifier on financial_order_identifier
(
    financial_order_id  asc
)
go



create nonclustered index xif2financial_order_identifier on financial_order_identifier
(
    financial_order_identifier_type_rcd  asc
)
go



create table financial_order_identifier_type_ref
(
    financial_order_identifier_type_rcd code,
    financial_order_identifier_type_code code,
    financial_order_identifier_type_name name,
    sort_sequence_number integer  not null,
    change_flag        flag  not null,
    status_code        code,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_order_identifier_type_ref primary key  nonclustered(financial_order_identifier_type_rcd asc)
)
go



create table financial_order_line
(
    financial_order_line_id id,
    financial_order_id id,
    product_id         id,
    user_id            id,
    date_time          datetime  not null,
    comment            name  null,
    line_number        integer  not null,
    financial_unit_of_measurement_rcd code,
    quantity_number    integer  not null,
    financial_currency_id id,
    amount             currency,
    constraint xpkfinancial_order_line primary key  nonclustered(financial_order_line_id asc)
)
go



create nonclustered index xif1financial_order_line on financial_order_line
(
    financial_order_id  asc
)
go



create nonclustered index xif2financial_order_line on financial_order_line
(
    product_id          asc
)
go



create nonclustered index xif3financial_order_line on financial_order_line
(
    financial_unit_of_measurement_rcd  asc
)
go



create nonclustered index xif5financial_order_line on financial_order_line
(
    financial_currency_id  asc
)
go



create table financial_order_source_ref
(
    financial_order_source_rcd code,
    financial_order_source_name name,
    financial_order_source_code code,
    sort_sequence_number integer  not null,
    change_flag        flag  not null,
    status_code        code,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_order_source_ref primary key  nonclustered(financial_order_source_rcd asc)
)
go



create table financial_order_transaction
(
    financial_booking_transaction_id id,
    user_id            id,
    date_time          datetime  not null,
    amount             currency,
    financial_fee_id   id  null,
    financial_tax_id   id  null,
    financial_payment_id id  null,
    financial_currency_id id,
    transaction_number integer  not null,
    financial_costcentre_id id,
    financial_adjustment_id id  null,
    financial_order_transaction_type_rcd code,
    financial_order_id id,
    constraint xpkfinancial_order_transaction primary key  clustered(financial_booking_transaction_id asc)
)
go



create nonclustered index xif2financial_order_transaction on financial_order_transaction
(
    financial_fee_id    asc
)
go



create nonclustered index xif3financial_order_transaction on financial_order_transaction
(
    financial_tax_id    asc
)
go



create nonclustered index xif5financial_order_transaction on financial_order_transaction
(
    financial_payment_id  asc
)
go



create nonclustered index xif6financial_order_transaction on financial_order_transaction
(
    financial_currency_id  asc
)
go



create nonclustered index xif7financial_order_transaction on financial_order_transaction
(
    financial_costcentre_id  asc
)
go



create nonclustered index xif8financial_order_transaction on financial_order_transaction
(
    financial_adjustment_id  asc
)
go



create nonclustered index xif10financial_order_transaction on financial_order_transaction
(
    financial_order_transaction_type_rcd  asc
)
go



create nonclustered index xif11financial_order_transaction on financial_order_transaction
(
    financial_order_id  asc
)
go



create table financial_order_transaction_type_ref
(
    financial_order_transaction_type_rcd code,
    financial_order_transaction_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_order_transaction_type_ref primary key  clustered(financial_order_transaction_type_rcd asc)
)
go



create table financial_payment
(
    financial_payment_id id,
    financial_payment_type_rcd code,
    user_id            id,
    date_time          datetime  not null,
    financial_payment_accounting_id id  null,
    financial_payment_bank_id id  null,
    financial_payment_voucher_id id  null,
    financial_payment_card_id id  null,
    financial_payment_cash_id id  null,
    financial_payment_coupon_id id  null,
    constraint xpkfinancial_payment primary key  clustered(financial_payment_id asc)
)
go



create nonclustered index xif1financial_payment on financial_payment
(
    financial_payment_type_rcd  asc
)
go



create nonclustered index xif3financial_payment on financial_payment
(
    financial_payment_accounting_id  asc
)
go



create nonclustered index xif4financial_payment on financial_payment
(
    financial_payment_bank_id  asc
)
go



create nonclustered index xif5financial_payment on financial_payment
(
    financial_payment_voucher_id  asc
)
go



create nonclustered index xif6financial_payment on financial_payment
(
    financial_payment_card_id  asc
)
go



create nonclustered index xif7financial_payment on financial_payment
(
    financial_payment_cash_id  asc
)
go



create nonclustered index xif8financial_payment on financial_payment
(
    financial_payment_coupon_id  asc
)
go



create table financial_payment_accounting
(
    financial_payment_accounting_id id,
    user_id            id,
    date_time          datetime  not null,
    amount             currency,
    financial_currency_id id,
    constraint xpkfinancial_payment_accounting primary key  clustered(financial_payment_accounting_id asc)
)
go



create nonclustered index xif1financial_payment_accounting on financial_payment_accounting
(
    financial_currency_id  asc
)
go



create table financial_payment_bank
(
    financial_payment_bank_id id,
    user_id            id,
    date_time          datetime  not null,
    bank_name          name,
    bank_account       code,
    bank_number        code,
    financial_bank_account_number_type_rcd code,
    amount             currency,
    financial_currency_id id,
    constraint xpkfinancial_payment_bank primary key  clustered(financial_payment_bank_id asc)
)
go



create nonclustered index xif1financial_payment_bank on financial_payment_bank
(
    financial_bank_account_number_type_rcd  asc
)
go



create nonclustered index xif2financial_payment_bank on financial_payment_bank
(
    financial_currency_id  asc
)
go



create table financial_payment_card
(
    financial_payment_card_id id,
    user_id            id,
    date_time          datetime  not null,
    card_number        code,
    name_on_card       code,
    expiry_year        integer  not null,
    expiry_month       integer  not null,
    financial_card_type_rcd code,
    card_verification_value integer  null,
    issued_month       integer  null,
    issued_year        integer  null,
    address_verification_code code  null,
    amount             currency,
    financial_currency_id id,
    constraint xpkfinancial_payment_card primary key  clustered(financial_payment_card_id asc)
)
go



create nonclustered index xif1financial_payment_card on financial_payment_card
(
    financial_card_type_rcd  asc
)
go



create nonclustered index xif2financial_payment_card on financial_payment_card
(
    financial_currency_id  asc
)
go



create table financial_payment_cash
(
    financial_payment_cash_id id,
    user_id            id,
    date_time          datetime  not null,
    amount             currency,
    financial_currency_id id,
    constraint xpkfinancial_payment_cash primary key  clustered(financial_payment_cash_id asc)
)
go



create nonclustered index xif1financial_payment_cash on financial_payment_cash
(
    financial_currency_id  asc
)
go



create table financial_payment_coupon
(
    financial_payment_coupon_id id,
    financial_coupon_id id,
    user_id            id,
    date_time          datetime  not null,
    amount             currency,
    financial_currency_id id,
    constraint xpkfinancial_payment_coupon primary key  clustered(financial_payment_coupon_id asc)
)
go



create nonclustered index xif1financial_payment_coupon on financial_payment_coupon
(
    financial_coupon_id  asc
)
go



create nonclustered index xif2financial_payment_coupon on financial_payment_coupon
(
    financial_currency_id  asc
)
go



create table financial_payment_type_ref
(
    financial_payment_type_rcd code,
    financial_payment_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_payment_type_ref primary key  clustered(financial_payment_type_rcd asc)
)
go



create table financial_payment_voucher
(
    financial_payment_voucher_id id,
    user_id            id,
    date_time          datetime  not null,
    financial_voucher_id id,
    amount             currency,
    financial_currency_id id,
    constraint xpkfinancial_payment_voucher primary key  clustered(financial_payment_voucher_id asc)
)
go



create nonclustered index xif1financial_payment_voucher on financial_payment_voucher
(
    financial_voucher_id  asc
)
go



create nonclustered index xif2financial_payment_voucher on financial_payment_voucher
(
    financial_currency_id  asc
)
go



create table financial_tax
(
    financial_tax_id   id,
    financial_tax_type_rcd code,
    user_id            id,
    date_time          datetime  not null,
    financial_currency_id id,
    amount             currency,
    constraint xpkfinancial_tax primary key  clustered(financial_tax_id asc)
)
go



create nonclustered index xif1financial_tax on financial_tax
(
    financial_tax_type_rcd  asc
)
go



create nonclustered index xif2financial_tax on financial_tax
(
    financial_currency_id  asc
)
go



create table financial_tax_type_ref
(
    financial_tax_type_name name,
    financial_tax_type_rcd code,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_tax_type_ref primary key  clustered(financial_tax_type_rcd asc)
)
go



create table financial_unit_of_measurement_ref
(
    financial_unit_of_measurement_rcd code,
    sort_sequence_number integer  not null,
    change_flag        flag  not null,
    status_code        code,
    financial_unit_of_measurement_name name,
    financial_unit_of_measurement_code code,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_unit_of_measurement_ref primary key  nonclustered(financial_unit_of_measurement_rcd asc)
)
go



create table financial_voucher
(
    financial_voucher_id id,
    user_id            id,
    date_time          datetime  not null,
    value_amount       currency,
    valid_from_date_time datetime  not null,
    valid_until_date_time datetime  not null,
    financial_currency_id id,
    voucher_number     integer  not null,
    voucher_description description  null,
    financial_voucher_type_rcd code,
    constraint xpkfinancial_voucher primary key  clustered(financial_voucher_id asc)
)
go



create nonclustered index xif1financial_voucher on financial_voucher
(
    financial_currency_id  asc
)
go



create nonclustered index xif2financial_voucher on financial_voucher
(
    financial_voucher_type_rcd  asc
)
go



create table financial_voucher_type_ref
(
    financial_voucher_type_rcd code,
    financial_voucher_type_name name,
    user_id            id,
    date_time          datetime  not null,
    constraint xpkfinancial_voucher_type_ref primary key  clustered(financial_voucher_type_rcd asc)
)
go




alter table financial_adjustment

    add constraint financial_adjustment_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_adjustment

    add constraint financial_adjustment_to_financial_adjustment_type_ref foreign key(financial_adjustment_type_rcd) references financial_adjustment_type_ref(financial_adjustment_type_rcd)
go




alter table financial_costcentre

    add constraint financial_costcentre_to_financial_company foreign key(financial_company_id) references financial_company(financial_company_id)
go




alter table financial_coupon

    add constraint financial_coupon_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_coupon

    add constraint financial_coupon_to_financial_coupon_type foreign key(financial_coupon_type_rcd) references financial_coupon_type_ref(financial_coupon_type_rcd)
go




alter table financial_currency

    add constraint financial_currency_to_financial_currency_type_ref foreign key(financial_currency_type_rcd) references financial_currency_type_ref(financial_currency_type_rcd)
go




alter table financial_currency

    add constraint financial_currency_against_financial_currency_ref foreign key(financial_currency_against_financial_currency_type_rcd) references financial_currency_type_ref(financial_currency_type_rcd)
go




alter table financial_fee

    add constraint financial_fee_to_financial_fee_type_ref foreign key(financial_fee_type_rcd) references financial_fee_type_ref(financial_fee_type_rcd)
go




alter table financial_fee

    add constraint financial_fee_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go








alter table financial_order

    add constraint financial_order_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_order

    add constraint financial_order_to_financial_order_source_ref foreign key(financial_order_source_rcd) references financial_order_source_ref(financial_order_source_rcd)
go




alter table financial_order

    add constraint client_to_financial_order foreign key(client_id) references client(client_id)
go




alter table financial_order_event

    add constraint financial_order_event_to_booking foreign key(financial_order_id) references financial_order(financial_order_id)
go




alter table financial_order_event

    add constraint financial_order_event_to_financial_order_event_type_ref foreign key(financial_order_event_type_rcd) references financial_order_event_type_ref(financial_order_event_type_rcd)
go




alter table financial_order_identifier

    add constraint financial_order_identifier_to_financial_order foreign key(financial_order_id) references financial_order(financial_order_id)
go




alter table financial_order_identifier

    add constraint financial_order_identifier_to_financial_order_identifier_type_ref foreign key(financial_order_identifier_type_rcd) references financial_order_identifier_type_ref(financial_order_identifier_type_rcd)
go




alter table financial_order_line

    add constraint financial_order_line_to_financial_order foreign key(financial_order_id) references financial_order(financial_order_id)
go









alter table financial_order_line

    add constraint financial_order_line_to_financial_unit_of_measurement_ref foreign key(financial_unit_of_measurement_rcd) references financial_unit_of_measurement_ref(financial_unit_of_measurement_rcd)
go




alter table financial_order_line

    add constraint financial_order_line_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_order_transaction

    add constraint financial_booking_transaction_to_financial_fee foreign key(financial_fee_id) references financial_fee(financial_fee_id)
go




alter table financial_order_transaction

    add constraint financial_booking_transaction_to_financial_tax foreign key(financial_tax_id) references financial_tax(financial_tax_id)
go




alter table financial_order_transaction

    add constraint financial_booking_transaction_to_financial_payment foreign key(financial_payment_id) references financial_payment(financial_payment_id)
go




alter table financial_order_transaction

    add constraint financial_booking_transaction_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_order_transaction

    add constraint financial_booking_transaction_to_financial_costcentre foreign key(financial_costcentre_id) references financial_costcentre(financial_costcentre_id)
go




alter table financial_order_transaction

    add constraint financial_booking_transaction_to_financial_adjustment foreign key(financial_adjustment_id) references financial_adjustment(financial_adjustment_id)
go




alter table financial_order_transaction

    add constraint financial_booking_transaction_to_financial_booking_transaction_type_ref foreign key(financial_order_transaction_type_rcd) references financial_order_transaction_type_ref(financial_order_transaction_type_rcd)
go




alter table financial_order_transaction

    add constraint financial_order_to_financial_order_transaction foreign key(financial_order_id) references financial_order(financial_order_id)
go




alter table financial_payment

    add constraint financial_payment_to_financial_payment_type_ref foreign key(financial_payment_type_rcd) references financial_payment_type_ref(financial_payment_type_rcd)
go




alter table financial_payment

    add constraint financial_payment_to_financial_payment_accounting foreign key(financial_payment_accounting_id) references financial_payment_accounting(financial_payment_accounting_id)
go




alter table financial_payment

    add constraint financial_payment_to_financial_payment_bank foreign key(financial_payment_bank_id) references financial_payment_bank(financial_payment_bank_id)
go




alter table financial_payment

    add constraint financial_payment_to_financial_payment_voucher foreign key(financial_payment_voucher_id) references financial_payment_voucher(financial_payment_voucher_id)
go




alter table financial_payment

    add constraint financial_payment_to_financial_payment_card foreign key(financial_payment_card_id) references financial_payment_card(financial_payment_card_id)
go




alter table financial_payment

    add constraint financial_payment_to_financial_payment_cash foreign key(financial_payment_cash_id) references financial_payment_cash(financial_payment_cash_id)
go




alter table financial_payment

    add constraint financial_payment_to_financial_payment_coupon foreign key(financial_payment_coupon_id) references financial_payment_coupon(financial_payment_coupon_id)
go




alter table financial_payment_accounting

    add constraint financial_payment_accounting_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_payment_bank

    add constraint financial_payment_bank_to_financial_bank_account_number_type_ref foreign key(financial_bank_account_number_type_rcd) references financial_bank_account_number_type_ref(financial_bank_account_number_type_rcd)
go




alter table financial_payment_bank

    add constraint financial_payment_bank_to_financialcurrency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_payment_card

    add constraint financial_payment_card_to_financial_card_type_ref foreign key(financial_card_type_rcd) references financial_card_type_ref(financial_card_type_rcd)
go




alter table financial_payment_card

    add constraint financial_payment_card_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_payment_cash

    add constraint financial_payment_cash_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_payment_coupon

    add constraint financial_payment_coupon_to_financial_coupon foreign key(financial_coupon_id) references financial_coupon(financial_coupon_id)
go




alter table financial_payment_coupon

    add constraint financial_payment_coupon_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_payment_voucher

    add constraint financial_payment_voucher_to_financial_voucher foreign key(financial_voucher_id) references financial_voucher(financial_voucher_id)
go




alter table financial_payment_voucher

    add constraint financial_payment_voucher_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_tax

    add constraint financial_tax_to_financial_tax_type_ref foreign key(financial_tax_type_rcd) references financial_tax_type_ref(financial_tax_type_rcd)
go




alter table financial_tax

    add constraint financial_tax_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_voucher

    add constraint financial_voucher_to_financial_currency foreign key(financial_currency_id) references financial_currency(financial_currency_id)
go




alter table financial_voucher

    add constraint financial_voucher_to_financial_voucher_type_ref foreign key(financial_voucher_type_rcd) references financial_voucher_type_ref(financial_voucher_type_rcd)
go


                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "FinancialReferenceDataDefaults",
                Description = "Financial Reference Data ( Defaults )",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
set nocount on
go

-- financial
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_adjustment_type_ref'					,'Financial Adjustment Type'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_currency_type_ref'						,'Financial Currency Type Ref'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_fee_type_ref'							,'Financial Fee Type Ref'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_tax_type_ref'							,'Financial Tax Type Ref'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_payment_type_ref'						,'Financial Payment Type Ref'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_card_type_ref'							,'Financial Card Type'							,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_bank_account_number_type_ref'			,'Financial Bank Account Number Type'			,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_coupon_type_ref'						,'Financial Coupon Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_order_event_type_ref'					,'Financial Order Event Type'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_order_identifier_type_ref'				,'Financial Order Identifier Type'				,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_order_source_ref'						,'Financial Order Source Ref'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_order_transaction_type_ref'				,'Financial Order Transaction Type'				,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_unit_of_measurement_ref'				,'Financial Unit Of Measurement'				,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_voucher_type_ref'						,'Financial Voucher Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into default_system_setting_ref (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time) 
	values ('BCC', 'Booking costcentre', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_setting_ref (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time) 
	values ('BCU', 'Booking currency', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
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
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('USD', 'USD', 'United States Dollar', 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('NOK', 'NOK', 'Norwegian Krone', 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('SEK', 'SEK', 'Swedish Krona', 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('EUR', 'EUR', 'Euro', 4, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('THB', 'THB', 'Thai Bath', 4, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
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

-- Order identifier
insert into financial_order_identifier_type_ref (financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time) 
	values ('ION', 'ION', 'Internal Order Number', 1, 0, 'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_order_identifier_type_ref (financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time) 
	values ('EON', 'EON', 'External Order Number', 1, 0, 'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Order source
insert into financial_order_source_ref (financial_order_source_rcd, financial_order_source_code, financial_order_source_name, sort_sequence_number, change_flag, status_code, user_id, date_time) 
	values ('IS', 'INS', 'Internal System', 1, 0, 'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_order_source_ref (financial_order_source_rcd, financial_order_source_code, financial_order_source_name, sort_sequence_number, change_flag, status_code, user_id, date_time) 
	values ('WEB', 'WEB', 'WEB Front', 2, 0, 'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_order_source_ref (financial_order_source_rcd, financial_order_source_code, financial_order_source_name, sort_sequence_number, change_flag, status_code, user_id, date_time) 
	values ('T', 'TE', 'Test Data', 3, 0, 'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
go

-- financial fee
insert into financial_fee_type_ref (financial_fee_type_rcd, financial_fee_type_name, user_id, date_time )
	values ('Payment', 'Payment Fee', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_fee_type_ref (financial_fee_type_rcd, financial_fee_type_name, user_id, date_time )
	values ('Ex', 'Express Handling Fee', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
go

-- financial tax
insert into financial_tax_type_ref (financial_tax_type_rcd, financial_tax_type_name, user_id, date_time )
	values ('Order', 'Order Tax', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_tax_type_ref (financial_tax_type_rcd, financial_tax_type_name, user_id, date_time )
	values ('Payment', 'Payment Tax', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
go

-- financial payment
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('STD', 'Standard payment', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('CASH', 'Cash', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('CARD', 'Card', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('COUPON', 'Coupon', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('BANK', 'Bank', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('ACC', 'Accounting', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('VOU', 'Voucher', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial adjustment type
insert into financial_adjustment_type_ref (financial_adjustment_type_rcd, financial_adjustment_type_name, user_id, date_time) 
	values ('RR', 'Rounding rule', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial card type
insert into financial_card_type_ref (financial_card_type_rcd, financial_card_type_name, user_id, date_time) 
	values ('Visa', 'Visa', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_card_type_ref (financial_card_type_rcd, financial_card_type_name, user_id, date_time) 
	values ('Master', 'Master Card', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_card_type_ref (financial_card_type_rcd, financial_card_type_name, user_id, date_time) 
	values ('AmEx', 'American Express', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial bank account number type 
insert into financial_bank_account_number_type_ref(financial_bank_account_number_type_rcd, financial_bank_account_number_type_name, user_id, date_time) 
	values ('SWIFT', 'Society Worldwide Interbank Financial Telecommunication', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_bank_account_number_type_ref(financial_bank_account_number_type_rcd, financial_bank_account_number_type_name, user_id, date_time) 
	values ('IBAN', 'International Bank Account', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial voucher type
insert into financial_voucher_type_ref(financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time) 
	values ('FV', 'Flight Voucher', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_voucher_type_ref(financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time) 
	values ('DV', 'Disruption Voucher', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial coupon type
insert into financial_coupon_type_ref(financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time) 
	values ('MC', 'Meal Coupon', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_coupon_type_ref(financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time) 
	values ('LC', 'Lounge Coupon', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial unit of measurement ref
insert into financial_unit_of_measurement_ref(financial_unit_of_measurement_rcd, financial_unit_of_measurement_code, financial_unit_of_measurement_name, change_flag, sort_sequence_number, status_code, user_id, date_time) 
	values ('P', 'PI', 'Pieces', 0, 1, N'a', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_unit_of_measurement_ref(financial_unit_of_measurement_rcd, financial_unit_of_measurement_code, financial_unit_of_measurement_name, change_flag, sort_sequence_number, status_code, user_id, date_time) 
	values ('M', 'ME', 'Meter', 0, 1, N'a', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_unit_of_measurement_ref(financial_unit_of_measurement_rcd, financial_unit_of_measurement_code, financial_unit_of_measurement_name, change_flag, sort_sequence_number, status_code, user_id, date_time) 
	values ('C', 'Ce', 'Centimeter', 0, 1, N'a', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "DefaultFinancialTestData",
                Description = "Default Financial Test Data",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
set nocount on
go
declare @client_id uniqueidentifier set @client_id = (select top 1 client_id from client)
declare @location_country_id uniqueidentifier set @location_country_id = (select top 1 location_country_id from location_country)
declare @location_address_id uniqueidentifier set @location_address_id = newid()
declare @financial_currency_id uniqueidentifier set @financial_currency_id = (select top 1 financial_currency_id from financial_currency)

insert into location_address ( location_address_id, location_address_type_rcd, city, location_country_id, user_id, date_time)
	values (@location_address_id, dbo.ref('location_address_type_ref.Office'),  'Oslo', @location_country_id, N'ffffffff-5555-5555-5555-ffffffffffff', getdate())

declare @loop int = 0
while @loop < 5 begin
	declare @financial_order_id uniqueidentifier set @financial_order_id = newid()
	insert into financial_order (financial_order_id, client_id, location_address_id, financial_currency_id, financial_order_source_rcd, comment, user_id, date_time)
		values (@financial_order_id, @client_id, @location_address_id, @financial_currency_id, dbo.ref('financial_order_source_ref.T'), 'no comment',  N'ffffffff-5555-5555-5555-ffffffffffff', getdate())

	--insert into financial_order_line (financial_order_line_id, financial_order_id, product_id, quantity_number, amount, financial_currency_id, financial_unit_of_measurement_rcd, line_number, comment, user_id, date_time)
	--	select top 5 newid(), @financial_order_id, p.product_id, 1, CAST(66.0000 AS Decimal(15, 4)), @financial_currency_id, dbo.ref('financial_unit_of_measurement_ref.P'), 1, 'no comment', N'ffffffff-5555-5555-5555-ffffffffffff', getdate()
	--	from product as p

    select @loop = @loop + 1
end
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }
    }
}
