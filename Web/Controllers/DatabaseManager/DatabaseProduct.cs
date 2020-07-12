using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    public partial class DatabaseManager {
        void InitProduct(
            int majorNumber,
            int minorNumber
            ) {
            int sequence = 0;

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 12) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductColumnTypes",
                Description = "Product Column Types",
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
                Name = "ProductCartDropTables",
                Description = "Product Cart Drop Tables",
                #region script ( cart_product, cart_product_price )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
if object_id(N'cart_product_price') is not null
    drop table cart_product_price
if object_id(N'cart_product') is not null
    drop table cart_product
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductDropTables",
                Description = "Product Drop Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
if object_id (N'product_category_image') is not null
    drop table product_category_image
go
if object_id (N'product_category_image_type_ref') is not null
    drop table product_category_image_type_ref
go
if object_id (N'product_expose_plan') is not null
    drop table product_expose_plan
go
if object_id (N'product_gather_attribute') is not null
    drop table product_gather_attribute
go
if object_id (N'product_gather_attribute_type_ref') is not null
    drop table product_gather_attribute_type_ref
go
if object_id (N'product_gather_source') is not null
    drop table product_gather_source
go
if object_id (N'product_gather_source_type_ref') is not null
    drop table product_gather_source_type_ref
go
if object_id (N'product_field_set_mapping') is not null
    drop table product_field_set_mapping
go
if object_id (N'product_field_set') is not null
    drop table product_field_set
go
if object_id (N'product_category_documentation') is not null
    drop table product_category_documentation
go
if object_id (N'product_category_documentation_type_ref') is not null
    drop table product_category_documentation_type_ref
go
if object_id (N'product_entity_type_ref') is not null
    drop table product_entity_type_ref
go
if object_id (N'product_identifier') is not null
    drop table product_identifier
go
if object_id (N'product_identifier_ref') is not null
    drop table product_identifier_ref
go
if object_id (N'product_attribute') is not null
    drop table product_attribute
go
if object_id (N'product_attribute_unit_ref') is not null
    drop table product_attribute_unit_ref
go
if object_id (N'product_attribute_ref') is not null
    drop table product_attribute_ref
go
if object_id (N'product_exposed_selection') is not null
    drop table product_exposed_selection
go
if object_id (N'product_expose') is not null
    drop table product_expose
go
if object_id (N'product_expose_set') is not null
    drop table product_expose_set
go
if object_id (N'product_expose_set_type_ref') is not null
    drop table product_expose_set_type_ref
go
if object_id (N'product_info') is not null
    drop table product_info
go
if object_id (N'product_info_ref') is not null
    drop table product_info_ref
go
if object_id (N'product_change_set') is not null
    drop table product_change_set
go
if object_id (N'product_gather_key') is not null
    drop table product_gather_key
go
if object_id (N'product_gather') is not null
    drop table product_gather
go
if object_id (N'product_image') is not null
    drop table product_image
go
if object_id (N'product_image_type_ref') is not null
    drop table product_image_type_ref
go
if object_id (N'product_documentation') is not null
    drop table product_documentation
go
if object_id (N'product_documentation_type_ref') is not null
    drop table product_documentation_type_ref
go
if object_id (N'product_category_mapping') is not null
    drop table product_category_mapping
go
if object_id (N'product_category') is not null
    drop table product_category
go
if object_id (N'product_supplier') is not null
    drop table product_supplier
go
if object_id (N'product') is not null
    drop table product
go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript { 
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductCreateTables",
                Description = "Product Create Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
set nocount on
go

CREATE TABLE product
(
    product_id         id  NOT NULL,
    product_became_id  id  NULL,
    product_name       name  NOT NULL,
    state_rcd          code  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct PRIMARY KEY  CLUSTERED(product_id ASC),
    CONSTRAINT product_to_product_became FOREIGN KEY(product_became_id) REFERENCES product(product_id)
)
go



CREATE NONCLUSTERED INDEX XIF5product ON product
(
    product_became_id   ASC
)
go



CREATE TABLE product_supplier
(
    product_supplier_id id  NOT NULL,
    product_id         id  NOT NULL,
    supplier_name      name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_supplier PRIMARY KEY  CLUSTERED(product_supplier_id ASC),
    CONSTRAINT product_supplier_to_product FOREIGN KEY(product_id) REFERENCES product(product_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_supplier ON product_supplier
(
    product_id          ASC
)
go



CREATE TABLE product_category
(
    product_category_id id  NOT NULL,
    product_category_became_id id  NULL,
    product_category_parent_id id  NOT NULL,
    product_category_code code  NOT NULL,
    product_category_name name  NOT NULL,
    product_category_position integer  NOT NULL,
    state_rcd          code  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_category PRIMARY KEY  CLUSTERED(product_category_id ASC),
    CONSTRAINT product_category_to_product_category_parent FOREIGN KEY(product_category_parent_id) REFERENCES product_category(product_category_id),
CONSTRAINT product_category_to_product_category_became FOREIGN KEY(product_category_became_id) REFERENCES product_category(product_category_id)
)
go



CREATE NONCLUSTERED INDEX XIF3product_category ON product_category
(
    product_category_parent_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF5product_category ON product_category
(
    product_category_became_id  ASC
)
go



CREATE TABLE product_category_mapping
(
    product_category_mapping_id id  NOT NULL,
    product_category_id id  NOT NULL,
    product_id         id  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_category_mapping PRIMARY KEY  CLUSTERED(product_category_mapping_id ASC),
    CONSTRAINT product_category_mapping_to_product FOREIGN KEY(product_id) REFERENCES product(product_id),
CONSTRAINT product_category_mapping_to_product_category FOREIGN KEY(product_category_id) REFERENCES product_category(product_category_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_category_mapping ON product_category_mapping
(
    product_id          ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_category_mapping ON product_category_mapping
(
    product_category_id  ASC
)
go



CREATE TABLE product_documentation_type_ref
(
    product_documentation_type_rcd code  NOT NULL,
    product_documentation_type_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_documentation_type_ref PRIMARY KEY  CLUSTERED(product_documentation_type_rcd ASC)
)
go



CREATE TABLE product_documentation
(
    product_documentation_id id  NOT NULL,
    product_id         id  NOT NULL,
    product_documentation_type_rcd code  NOT NULL,
    documentation      text  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_documentation PRIMARY KEY  CLUSTERED(product_documentation_id ASC),
    CONSTRAINT product_documentation_to_product_documentation_type_ref FOREIGN KEY(product_documentation_type_rcd) REFERENCES product_documentation_type_ref(product_documentation_type_rcd),
CONSTRAINT product_documentation_to_product FOREIGN KEY(product_id) REFERENCES product(product_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_documentation ON product_documentation
(
    product_documentation_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_documentation ON product_documentation
(
    product_id          ASC
)
go



CREATE TABLE product_image_type_ref
(
    product_image_type_rcd code  NOT NULL,
    product_image_type_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_image_type_ref PRIMARY KEY  CLUSTERED(product_image_type_rcd ASC)
)
go



CREATE TABLE product_image
(
    product_image_id   id  NOT NULL,
    product_id         id  NOT NULL,
    product_image_type_rcd code  NOT NULL,
    image_file_name    name  NULL,
    image              varbinary(max)  NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_image PRIMARY KEY  CLUSTERED(product_image_id ASC),
    CONSTRAINT product_image_to_product_image_ref FOREIGN KEY(product_image_type_rcd) REFERENCES product_image_type_ref(product_image_type_rcd),
CONSTRAINT product_image_to_product FOREIGN KEY(product_id) REFERENCES product(product_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_image ON product_image
(
    product_image_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_image ON product_image
(
    product_id          ASC
)
go



CREATE TABLE product_gather
(
    product_gather_id  id  NOT NULL,
    start_date_time    datetime  NOT NULL,
    finish_date_time   datetime  NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_gather PRIMARY KEY  CLUSTERED(product_gather_id ASC)
)
go



CREATE TABLE product_gather_key
(
    product_gather_key_id id  NOT NULL,
    product_gather_key_value name  NOT NULL,
    product_gather_id  id  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_gather_key PRIMARY KEY  CLUSTERED(product_gather_key_id ASC),
    CONSTRAINT product_gather_key_to_product_gathering FOREIGN KEY(product_gather_id) REFERENCES product_gather(product_gather_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_gather_key ON product_gather_key
(
    product_gather_id   ASC
)
go



CREATE TABLE product_change_set
(
    product_change_set_id id  NOT NULL,
    product_id         id  NOT NULL,
    product_gather_key_id id  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_change_set PRIMARY KEY  CLUSTERED(product_change_set_id ASC),
    CONSTRAINT product_change_set_to_product FOREIGN KEY(product_id) REFERENCES product(product_id),
CONSTRAINT product_change_set_to_product_gather_key FOREIGN KEY(product_gather_key_id) REFERENCES product_gather_key(product_gather_key_id)
)
go



CREATE NONCLUSTERED INDEX XIF2product_change_set ON product_change_set
(
    product_id          ASC
)
go



CREATE NONCLUSTERED INDEX XIF3product_change_set ON product_change_set
(
    product_gather_key_id  ASC
)
go



CREATE TABLE product_info_ref
(
    product_info_rcd   code  NOT NULL,
    product_info_name  name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_info_ref PRIMARY KEY  CLUSTERED(product_info_rcd ASC)
)
go



CREATE TABLE product_info
(
    product_info_id    id  NOT NULL,
    product_id         id  NOT NULL,
    product_info_rcd   code  NOT NULL,
    product_info_value name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_info PRIMARY KEY  CLUSTERED(product_info_id ASC),
    CONSTRAINT product_info_to_product FOREIGN KEY(product_id) REFERENCES product(product_id),
CONSTRAINT product_info_to_product_info_ref FOREIGN KEY(product_info_rcd) REFERENCES product_info_ref(product_info_rcd)
)
go



CREATE NONCLUSTERED INDEX XIF2product_info ON product_info
(
    product_id          ASC
)
go



CREATE NONCLUSTERED INDEX XIF3product_info ON product_info
(
    product_info_rcd    ASC
)
go



CREATE TABLE product_expose_set_type_ref
(
    product_expose_set_type_rcd code  NOT NULL,
    product_expose_set_type_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_expose_set_type_ref PRIMARY KEY  CLUSTERED(product_expose_set_type_rcd ASC)
)
go



CREATE TABLE product_expose_set
(
    product_expose_set_id id  NOT NULL,
    product_expose_set_type_rcd code  NOT NULL,
    product_expose_set_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_expose_set PRIMARY KEY  CLUSTERED(product_expose_set_id ASC),
    CONSTRAINT product_expose_set_to_product_expose_set_type_ref FOREIGN KEY(product_expose_set_type_rcd) REFERENCES product_expose_set_type_ref(product_expose_set_type_rcd)
)
go



CREATE NONCLUSTERED INDEX XIF1product_expose_set ON product_expose_set
(
    product_expose_set_type_rcd  ASC
)
go



CREATE TABLE product_expose
(
    product_expose_id  id  NOT NULL,
    expose_product_id  id  NOT NULL,
    expose_based_on_product_id id  NOT NULL,
    product_expose_set_id id  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_expose PRIMARY KEY  CLUSTERED(product_expose_id ASC),
    CONSTRAINT product_expose_to_product FOREIGN KEY(expose_product_id) REFERENCES product(product_id),
CONSTRAINT product_exposed_to_product_expose_set FOREIGN KEY(product_expose_set_id) REFERENCES product_expose_set(product_expose_set_id),
CONSTRAINT product_expose_to_based_on_product FOREIGN KEY(expose_based_on_product_id) REFERENCES product(product_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_expose ON product_expose
(
    expose_product_id   ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_expose ON product_expose
(
    product_expose_set_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3product_expose ON product_expose
(
    expose_based_on_product_id  ASC
)
go



CREATE TABLE product_exposed_selection
(
    product_exposed_selection_id id  NOT NULL,
    product_expose_id  id  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_exposed_selection PRIMARY KEY  CLUSTERED(product_exposed_selection_id ASC),
    CONSTRAINT product_exposed_selection_to_product_exposed FOREIGN KEY(product_expose_id) REFERENCES product_expose(product_expose_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_exposed_selection ON product_exposed_selection
(
    product_expose_id   ASC
)
go



CREATE TABLE product_attribute_ref
(
    product_attribute_rcd code  NOT NULL,
    product_attribute_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_attribute_ref PRIMARY KEY  CLUSTERED(product_attribute_rcd ASC)
)
go



CREATE TABLE product_attribute_unit_ref
(
    product_attribute_unit_rcd code  NOT NULL,
    product_attribute_unit_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_attribute_unit_ref PRIMARY KEY  CLUSTERED(product_attribute_unit_rcd ASC)
)
go



CREATE TABLE product_attribute
(
    product_attribute_id id  NOT NULL,
    product_id         id  NOT NULL,
    product_attribute_rcd code  NOT NULL,
    product_attribute_unit_rcd code  NULL,
    value              name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_attribute PRIMARY KEY  CLUSTERED(product_attribute_id ASC),
    CONSTRAINT product_attribute_to_product FOREIGN KEY(product_id) REFERENCES product(product_id),
CONSTRAINT product_attribute_to_product_attribute_ref FOREIGN KEY(product_attribute_rcd) REFERENCES product_attribute_ref(product_attribute_rcd),
CONSTRAINT product_attribute_to_product_attribute_unit_ref FOREIGN KEY(product_attribute_unit_rcd) REFERENCES product_attribute_unit_ref(product_attribute_unit_rcd)
)
go



CREATE NONCLUSTERED INDEX XIF1product_attribute ON product_attribute
(
    product_id          ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_attribute ON product_attribute
(
    product_attribute_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3product_attribute ON product_attribute
(
    product_attribute_unit_rcd  ASC
)
go



CREATE TABLE product_identifier_ref
(
    product_identifier_rcd code  NOT NULL,
    product_identifier_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_identifier_ref PRIMARY KEY  CLUSTERED(product_identifier_rcd ASC)
)
go



CREATE TABLE product_identifier
(
    product_identifier_id id  NOT NULL,
    product_id         id  NOT NULL,
    product_identifier_rcd code  NOT NULL,
    identifier         name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_identifier PRIMARY KEY  CLUSTERED(product_identifier_id ASC),
    CONSTRAINT product_identifier_to_product_identifier_ref FOREIGN KEY(product_identifier_rcd) REFERENCES product_identifier_ref(product_identifier_rcd),
CONSTRAINT product_identifier_to_product FOREIGN KEY(product_id) REFERENCES product(product_id)
)
go



CREATE NONCLUSTERED INDEX XIF2product_identifier ON product_identifier
(
    product_identifier_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3product_identifier ON product_identifier
(
    product_id          ASC
)
go



CREATE TABLE product_entity_type_ref
(
    product_entity_type_rcd code  NOT NULL,
    product_entity_type_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_entity_type_ref PRIMARY KEY  NONCLUSTERED(product_entity_type_rcd ASC)
)
go



CREATE TABLE product_category_documentation_type_ref
(
    product_category_documentation_type_rcd code  NOT NULL,
    product_category_documentation_type_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_category_documentation_type_ref PRIMARY KEY  CLUSTERED(product_category_documentation_type_rcd ASC)
)
go



CREATE TABLE product_category_documentation
(
    product_category_documentation_id id  NOT NULL,
    product_category_documentation_type_rcd code  NOT NULL,
    product_category_id id  NOT NULL,
    documentation      text  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_category_documentation PRIMARY KEY  CLUSTERED(product_category_documentation_id ASC),
    CONSTRAINT product_category_documentation_to_product_category_documentation_type_ref FOREIGN KEY(product_category_documentation_type_rcd) REFERENCES product_category_documentation_type_ref(product_category_documentation_type_rcd),
CONSTRAINT product_category_documentation_to_product_category FOREIGN KEY(product_category_id) REFERENCES product_category(product_category_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_category_documentation ON product_category_documentation
(
    product_category_documentation_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_category_documentation ON product_category_documentation
(
    product_category_id  ASC
)
go



CREATE TABLE product_field_set
(
    product_field_set_id id  NOT NULL,
    product_field_set_name char(18)  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_field_set PRIMARY KEY  CLUSTERED(product_field_set_id ASC)
)
go



CREATE TABLE product_field_set_mapping
(
    product_field_set_mapping_id id  NOT NULL,
    product_field_set_id id  NOT NULL,
    product_identifier_rcd code  NOT NULL,
    product_attribute_rcd code  NOT NULL,
    product_info_rcd   code  NOT NULL,
    product_image_type_rcd code  NOT NULL,
    product_documentation_type_rcd code  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_field_set_mapping PRIMARY KEY  CLUSTERED(product_field_set_mapping_id ASC),
    CONSTRAINT product_field_set_mapping_to_product_field_set FOREIGN KEY(product_field_set_id) REFERENCES product_field_set(product_field_set_id),
CONSTRAINT product_field_set_mapping_to_product_identifier_ref FOREIGN KEY(product_identifier_rcd) REFERENCES product_identifier_ref(product_identifier_rcd),
CONSTRAINT product_field_set_mapping_to_product_attribute_ref FOREIGN KEY(product_attribute_rcd) REFERENCES product_attribute_ref(product_attribute_rcd),
CONSTRAINT product_field_set_mapping_to_product_info_ref FOREIGN KEY(product_info_rcd) REFERENCES product_info_ref(product_info_rcd),
CONSTRAINT product_field_set_mapping_to_product_image_type_ref FOREIGN KEY(product_image_type_rcd) REFERENCES product_image_type_ref(product_image_type_rcd),
CONSTRAINT product_field_set_mapping_to_product_documentation_type_ref FOREIGN KEY(product_documentation_type_rcd) REFERENCES product_documentation_type_ref(product_documentation_type_rcd)
)
go



CREATE NONCLUSTERED INDEX XIF1product_field_set_mapping ON product_field_set_mapping
(
    product_field_set_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_field_set_mapping ON product_field_set_mapping
(
    product_identifier_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3product_field_set_mapping ON product_field_set_mapping
(
    product_attribute_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4product_field_set_mapping ON product_field_set_mapping
(
    product_info_rcd    ASC
)
go



CREATE NONCLUSTERED INDEX XIF5product_field_set_mapping ON product_field_set_mapping
(
    product_image_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF6product_field_set_mapping ON product_field_set_mapping
(
    product_documentation_type_rcd  ASC
)
go



CREATE TABLE product_gather_source_type_ref
(
    product_gather_source_type_rcd code  NOT NULL,
    product_gather_source_type_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_gather_source_type_ref PRIMARY KEY  CLUSTERED(product_gather_source_type_rcd ASC)
)
go



CREATE TABLE product_gather_source
(
    product_gather_source_id id  NOT NULL,
    product_gather_id  id  NOT NULL,
    product_gather_source_type_rcd code  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_gather_source PRIMARY KEY  CLUSTERED(product_gather_source_id ASC),
    CONSTRAINT product_gather_source_to_product_gather FOREIGN KEY(product_gather_id) REFERENCES product_gather(product_gather_id),
CONSTRAINT product_gather_source_to_product_gather_source_type_ref FOREIGN KEY(product_gather_source_type_rcd) REFERENCES product_gather_source_type_ref(product_gather_source_type_rcd)
)
go



CREATE NONCLUSTERED INDEX XIF1product_gather_source ON product_gather_source
(
    product_gather_id   ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_gather_source ON product_gather_source
(
    product_gather_source_type_rcd  ASC
)
go



CREATE TABLE product_gather_attribute_type_ref
(
    product_gather_attribute_type_rcd code  NOT NULL,
    product_gather_attribute_type_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_gather_attribute_type_ref PRIMARY KEY  CLUSTERED(product_gather_attribute_type_rcd ASC)
)
go



CREATE TABLE product_gather_attribute
(
    product_gather_attribute_id id  NOT NULL,
    product_gather_attribute_value name  NOT NULL,
    product_gather_attribute_type_rcd code  NOT NULL,
    product_gather_key_id id  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_gather_attribute PRIMARY KEY  CLUSTERED(product_gather_attribute_id ASC),
    CONSTRAINT product_gather_attribute_to_product_gather_attribute_type_ref FOREIGN KEY(product_gather_attribute_type_rcd) REFERENCES product_gather_attribute_type_ref(product_gather_attribute_type_rcd),
CONSTRAINT product_gather_attribute_to_product_gather_key FOREIGN KEY(product_gather_key_id) REFERENCES product_gather_key(product_gather_key_id)
)
go



CREATE NONCLUSTERED INDEX XIF1product_gather_attribute ON product_gather_attribute
(
    product_gather_attribute_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3product_gather_attribute ON product_gather_attribute
(
    product_gather_key_id  ASC
)
go



CREATE TABLE product_expose_plan
(
    product_expose_plan_id id  NOT NULL,
    product_id         id  NOT NULL,
    product_expose_set_type_rcd code  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_expose_plan PRIMARY KEY  CLUSTERED(product_expose_plan_id ASC),
    CONSTRAINT product_exposure_plan_to_product FOREIGN KEY(product_id) REFERENCES product(product_id),
CONSTRAINT product_exporsure_plan_to_product_exposure_set_type_ref FOREIGN KEY(product_expose_set_type_rcd) REFERENCES product_expose_set_type_ref(product_expose_set_type_rcd)
)
go



CREATE NONCLUSTERED INDEX XIF1product_expose_plan ON product_expose_plan
(
    product_id          ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_expose_plan ON product_expose_plan
(
    product_expose_set_type_rcd  ASC
)
go



CREATE TABLE product_category_image_type_ref
(
    product_category_image_type_rcd code  NOT NULL,
    product_category_image_type_name name  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_category_image_type_ref PRIMARY KEY  CLUSTERED(product_category_image_type_rcd ASC)
)
go



CREATE TABLE product_category_image
(
    product_category_image_id id  NOT NULL,
    product_category_id id  NOT NULL,
    product_category_image_type_rcd code  NOT NULL,
    image              varbinary(max)  NOT NULL,
    user_id            id  NOT NULL,
    date_time          datetime  NOT NULL,
    CONSTRAINT XPKproduct_category_image PRIMARY KEY  CLUSTERED(product_category_image_id ASC),
    CONSTRAINT product_category_image_to_product_category FOREIGN KEY(product_category_id) REFERENCES product_category(product_category_id),
CONSTRAINT product_category_image_type_to_product_category_image_type_ref FOREIGN KEY(product_category_image_type_rcd) REFERENCES product_category_image_type_ref(product_category_image_type_rcd)
)
go



CREATE NONCLUSTERED INDEX XIF1product_category_image ON product_category_image
(
    product_category_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2product_category_image ON product_category_image
(
    product_category_image_type_rcd  ASC
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
                Name = "ProductReferenceDataDefaults",
                Description = "Product Reference Data",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
set nocount on
go
-- attribute
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('Color', 'Color', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('MTOW', 'Max Take Off Weight', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('SEAT', 'Average Seats', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('RKM', 'Range in Kilometer', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('SUP', 'Supplier Number', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('MOD', 'Model', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('SUPID', 'Supplied Id', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('PU', 'Price Unit', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('H', 'Height', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('W', 'Width', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('L', 'Length', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) 
	values ('WE', 'Weight', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- attribute unit of measurement
insert into product_attribute_unit_ref (product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time) 
	values ('METER', 'Meters', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_unit_ref (product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time) 
	values ('MM', 'Milli Meters', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_attribute_unit_ref (product_attribute_unit_rcd, product_attribute_unit_name, user_id, date_time) 
	values ('G', 'Grams', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- identifier
insert into product_identifier_ref (product_identifier_rcd, product_identifier_name, user_id, date_time) 
	values ('GTIN13', 'Global Trade Item Number(13)', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_identifier_ref (product_identifier_rcd, product_identifier_name, user_id, date_time) 
	values ('GTIN14', 'Global Trade Item Number(14)', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_identifier_ref (product_identifier_rcd, product_identifier_name, user_id, date_time) 
	values ('HN', 'HN', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_identifier_ref (product_identifier_rcd, product_identifier_name, user_id, date_time) 
	values ('BS1', 'Block Structure 1', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_identifier_ref (product_identifier_rcd, product_identifier_name, user_id, date_time) 
	values ('BS2', 'Block Structure 2', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_identifier_ref (product_identifier_rcd, product_identifier_name, user_id, date_time) 
	values ('BS3', 'Block Structure 3', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- image type
insert into product_image_type_ref (product_image_type_rcd, product_image_type_name, user_id, date_time) 
	values ('PI', 'Product image variable size', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_image_type_ref (product_image_type_rcd, product_image_type_name, user_id, date_time) 
	values ('ISP', 'Internal Stock Photo', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- documentation type
insert into product_documentation_type_ref (product_documentation_type_rcd, product_documentation_type_name, user_id, date_time) 
	values ('SD', 'Short description', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_documentation_type_ref (product_documentation_type_rcd, product_documentation_type_name, user_id, date_time) 
	values ('LD', 'Long description', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_documentation_type_ref (product_documentation_type_rcd, product_documentation_type_name, user_id, date_time) 
	values ('HD', 'Headline', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- info
insert into product_info_ref (product_info_rcd, product_info_name, user_id, date_time) 
	values ('HTML', 'HTML Info', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())
insert into product_info_ref (product_info_rcd, product_info_name, user_id, date_time) 
	values ('EAN', 'EAN Info', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())
insert into product_info_ref (product_info_rcd, product_info_name, user_id, date_time) 
	values ('HMS', 'HMS Info', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())
insert into product_info_ref (product_info_rcd, product_info_name, user_id, date_time) 
	values ('PI', 'Product Info', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())
insert into product_info_ref (product_info_rcd, product_info_name, user_id, date_time) 
	values ('UM', 'User Manual', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())

-- category documentation type
insert into product_category_documentation_type_ref (product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time) 
	values ('TT', 'Top text', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_category_documentation_type_ref (product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time) 
	values ('BT', 'Bottom text', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into product_category_image_type_ref (product_category_image_type_rcd, product_category_image_type_name, user_id, date_time) 
	values ('SS', 'Small size', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_category_image_type_ref (product_category_image_type_rcd, product_category_image_type_name, user_id, date_time) 
	values ('LS', 'Large size', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into product_expose_set_type_ref (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time) 
	values ('Web', 'Web', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_expose_set_type_ref (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time) 
	values ('Print', 'Print', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_expose_set_type_ref (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time) 
	values ('Export', 'Export', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_expose_set_type_ref (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time) 
	values ('Customer', 'Customer', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into product_gather_source_type_ref (product_gather_source_type_rcd, product_gather_source_type_name, user_id, date_time) 
	values ('tsql', 'TSQL script', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into product_gather_attribute_type_ref (product_gather_attribute_type_rcd, product_gather_attribute_type_name, user_id, date_time) 
	values ('name', 'Name', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())
insert into product_gather_attribute_type_ref (product_gather_attribute_type_rcd, product_gather_attribute_type_name, user_id, date_time) 
	values ('color', 'Color', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())

-- product entity type ref
insert into product_entity_type_ref ( product_entity_type_rcd, product_entity_type_name, user_id, date_time) 
	values ('P', 'Product', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_entity_type_ref ( product_entity_type_rcd, product_entity_type_name, user_id, date_time) 
	values ('PA', 'Product Attribute', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_entity_type_ref ( product_entity_type_rcd, product_entity_type_name, user_id, date_time) 
	values ('PC', 'Product Category', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_entity_type_ref ( product_entity_type_rcd, product_entity_type_name, user_id, date_time) 
	values ('PD', 'Product Description', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_entity_type_ref ( product_entity_type_rcd, product_entity_type_name, user_id, date_time) 
	values ('PID', 'Product Identifier', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_entity_type_ref ( product_entity_type_rcd, product_entity_type_name, user_id, date_time) 
	values ('PI', 'Product Info', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into product_entity_type_ref ( product_entity_type_rcd, product_entity_type_name, user_id, date_time) 
	values ('PS', 'Product Supplier', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductRawLoadProcedures",
                Description = "Product Raw Load Procedures",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
 
go
set nocount on
go
if object_id(N'category_basic') is not null
	drop procedure category_basic
go
create procedure category_basic(@user_id uniqueidentifier
								) as begin

	declare @parent_loop int set @parent_loop = 1
	while @parent_loop <= 25 begin
		declare @product_category_parent_id uniqueidentifier set @product_category_parent_id = newid()
		insert into product_category (product_category_id,		   product_category_parent_id, product_category_code,					product_category_name,											   product_category_position, state_rcd, user_id, date_time) 
							 values (@product_category_parent_id, 
									 @product_category_parent_id, 
									 convert(varchar(2), @parent_loop), 
									 'Main cat ' + convert(varchar(2), @parent_loop), 
									 @parent_loop,			 
									 'C',
									 @user_id, 
									 getutcdate())

		insert into product_category_image (product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time)
							values (newid(),
									@product_category_parent_id, 
									iif(@parent_loop % 2 = 0,
										'SS',
										'LS'
										),
									iif(@parent_loop % 2 = 0,
										0xFFD8FFE000104A46494600010101000000000000FFDB00430009060614121014141214141414141414141414141414141414141414151414141414171C261E1719241914141F2F202327292C2C2C151E3135302A35262B2C29FFDB004301090A0A0505050D05050D291812182929292929292929292929292929292929292929292929292929292929292929292929292929292929292929292929292929FFC000110800A8012C03012200021101031101FFC4001B00000203010101000000000000000000000203000104060507FFC4003A10000201020501060404050305010000000001020311040512213141132251617191063281A11442B1C1155262D1F02372E133437382F107FFC40014010100000000000000000000000000000000FFC40014110100000000000000000000000000000000FFDA000C03010002110311003F00ECDC40D23B494E0027494E239C4151013A419447B882E2021C4AD23B494E00669530254CD32882E20657001C4D6E22DD30333882E2687005C40CF240B88F7029C00458A711AE2538809D253437495A005D8AD233494E202EC4D232C55805345586588E202AC558658AB00BB1561B62AC029A2AC31A2AC02DA258368AB001629A0EC4B00BB12C1D8AB01DDD8A71196269012E24D236C0B4029A05C473814E0023482E268710748087101D31EE0538019FB305C4D0E20380089440D03DC0171010E980E268B02E2067D20B89A1C4070010E25388E7105C404B883A47B883A404E92AC35A07480BD25583D24B00BB14D0C6816805B894D0CB14D001A4A68658AB00A681D235A05A01762583B036006C5582B12C077C5341A8956002C56919625805D8AB06CAB00BB14C658A71012D03A47692804B882E239ADCA68043800E2687017288099400940D0E0069010E20E9343800E0021A01C0D0E20B8808D00389A5C4C78CCC69D3F9E693F0E5FB200DC0070250C6D3A9F24D37E17B3F67B8D68043814E03F4934819B482E2687005C404E90748ED2538809B1561BA4171017605C46D81B000E203436C55805D8AB0C689603BB68A61345A002C5D8BB15A401D04D0122801B15609B29800D01A46A258056905A1AC171016D032436C534025A05C47693263333A54977E714FC2FBFB2DC02D054A07818DF8CE2B6A5072FEA96CBD96EFEC63C37C6734FF00D48464BFA6F16BDEF703AA7001C4565F9BD3AEBB92DFAC5ED25F4FEC6A9C2FB71E2FCBC00C399E57DAD34956EC65CA4E4B4C974D4977974DF7E7838ACDB23AB4256AB071BEE9F3192F14D6CFE87D2A8350DE375E7FDFC7EA66C6676DEA854A1652768C9C3FD2A8D7E5941ECE5E71EF7007CA6ED33D6CBFE24A90D9BD71F0973F491E9E272CC3D6D5A64B0F5A3CD39B72A4F9F967CC787CDD799CBE261A527B352BA52BA69D9C974DF98B5BDBA7881DEE07308568DE0F75CC5FCCBD51A5C0F9CE5B99CA9D64D746ADD15AFD7D57A9F49A3514E2A51E24AE805E80349A5C4171033E92691AE20E9012E20B80E68A71010E20B43DC0171013A41687B882E2026C4B0C7129C40EEC161B45200648A896C8901454904E253400589A43B02D80B7125832D2017602C3DC7C0171015A419EC86D8555925CF0AEC0E77E2785774F5D37254E2F4D48C7671BEF193B6FA5EEBC2E8E3250F1DFC7C4FA960B31BA524927BA716D3BC6ED77A3E0D6FB9E4E6FF0852AC9CF0CE34A7CBA527683FF0064BF2FA3DBD00E00166AC6E0274DB538B5F75EE8C6A4DBB24E527C4629C9BF4480B8557169C5B4D70D6CD1D6647F146A71856D295ED2A976B6B73B27BF1D0E6FF84576ECE1D9DBF9DABFB27FB9AA8E4B08B8CA4DCDA69DA5F2F5DACB67D3DC0EC72ECFA8C6A4F555A7534A7A14D68D4EFB6E9E8B785FC56E62CEBFFD0A55976704A92EB795F7E7469E257B6CFD99F35CF6ACE15A50BA5BEA8DBF95DFBBF4FD8CEF337285E4DB946DA5EDC7552FB34FC501E8E3B3AEDA6E4FBB3DF8DAFE2BEBCFAFA83846EAD1A90DEF4A7DA2E2CA35D5A5E7F3D34FFF0073C8755D493E925177BBE74ABBE7AECDA357C3988D35ECD6D529D4A3A9DFBBA92943D5F6B1A4BEA03A51574FAB57F7B7FCFB1DF7C298DD749C5F31FD1FFC9C3548FD9B5F495E5FADCE93E0EC7B5354F6B4B9F549DBEFFA81D88360F495A405B894E037494E2025C0070346905C40CEE255873802E2029C4194473882E2025A06C39C4AD0076CE2534195701762341176014CA18E203800099560F490016CA68BB15602AE468245D80070326224D4252E8AE9CAD74BA2B8FC44DBEEC62E6EEBBA9A8B96FBA4DECB6B88CDF21EC633C553AB528D4504DC67A5C57571969BA978755FA81CA4B192C4C2ACE15E4AB45AD119AD319DB96A7C49ECECB635CE338766ABC942A5D6A6AFBC5A4FBD17C7D39399CE3E2555A92D54E14EA47E694169D4BF99AE1AF2E5717B1CDE619F4AAA8B5296AA6AC9DFA5FF00CBA03B7CEF1719768D4EF15C35D6CFEC7BF0AB87A78682C3C146F18F7F99392EF3BBF53E5D83CC1D54E29FFD48B8B5E1349E9F7FDCF63E16CEDCE9B83567196DD15BCFCC0F73155B7E4CB3958AA93EBFE7A99A789E8060CF3094E6A33A927150776E31527BAE2D75B376FB9E3769195354E9D15A6EEF37F35484ACD26B88B4974EB73DFC5A528B5EA7255B3492514BBB6D775D2FAA5FB01BAA64696A95495B6A6DDB9DD2DC0A197B941D5A4FBB49CAEFC251D328C92F5B7B1E7623113A977BBDA2BABE11B72BC63A546AD37FF72D7FAECC0D8F11DA699EDDF5BA5BDA5F35AFE4F52376472D35E9FF00E483FA6A478F87494649B496B7285B7767676DBCF572751F0A607B49F6B256845ED7E6725C7A25E4077C0D808D64C2B81195608A001941B4558007105C063453016E20CA23AC55804690748FB02E20762C1B0C68A016E250CB5CAD00012E1692B4F5006481630170017A48E231A2B480AB16A231449A00F2F10FBEF7E0F3F3FC554952BB93928A6B7DED17CDFC783D5C6D1EFA7E2BEE84CE926ACFADD01F0EC6D454EB5D36E0DBBF5EEF1256F2FEC61C55174EAE96ECAFF37469EF7F66BDCEAB3BF862A51A95254F884954A7B5EC9CB7D9F36EE8AC5E47DA52A6E5BBA77A73D3EF4FDAE0737844E9D5714FADE2FC6DBA6BD51EA53AAE9E2FFA6A5A6BC16B577ECEFEC156A1150A1512E5E897AC5DD3BFFB64CF4B30C91CA8C6AC5DDD271D565CD29253BAF4BBFB80F788BADD80AB5FA19DD6D32BD93B70A4AE9FAAF02E9B7D3C37B81AAE68C8FE03A752F5EA4D548B73D34E37493D4D5E6F9E9B2F3EA78B53338A6A31BD49B76518BB2BBDADABFB1D7E22BD3A387A70725AE3177943A4A4DCA5157E63776DFC00E773ACB21874F84BA70BFF00A724EA5FEBB9EB6758D5395F4272E92BB6BD6CDBB7A1E4D3C3B6EEC0F472FC26ADDED1FD4F7F0F8B942CA2EC970BA1E261AAB491BA9D6B81EFE1F3E92E773D5C367917D6CFCCE4E121B16077147189F51F1AC711471528F0CF470F9D35F301D4A9208F270D99465D4DD0AE06845692A3502D400344B0C05A001449D98CD256903AC230A288C00258BB11802C16192C003440D81A401D2112C440558BD05A2E310118BA1AA3E6B74616B6B9ECC20554CB75F0EC071999504E6EF6DE2D7F9EC72F85C14BB3AD7FCF3A4A17F1B257F4BFE87D1EBFC213949DEA46CF6BD9DD2F4EAC5623218539C7B4778C3E45C2BDAC9B6BAA57B01F26C6E4F24B0D84A6BB4AAE53AB3B7482FCDE5BA8ADFC4ECB01973A349295AEE314D2E9A63A5AF7B9EFAC250A7373A718A9CBE6973297364DF8791F3BF8E7E30EFBA541AF09CD78F827E3E6079DF12E368D2AAD535AA5D77BC62FD7F6398C4E6139F2F6F05B25F4333937C0EA142CEEC0D9808E87ABF374F2BF5F5344F12DF2D8888D8C40A71B96A88C8C0742980A8D31D4E03634C646981203A3224290D587605464322C158761AA0C0284AC6FC3663246385263A34C0F730D99A66FA756E7374A9B3761EB3407BB190662A389D8D70603122AC122C0EA0B2CA02994CB2240522244B9600C8A081680912BA92C5D80BB16994401B198FA750C572F501B2A635238FF008AB3B7A5C6DB7E87BF391E3E7394F691BAE40F956658CAEEFA6ACB4BE8DFEFC9CCD4CBDDFBCEE7D0331C96516EE8F1311977901CF430B61AA81E8CB0BE407E1C0C90A63E1487C70E32344054690D8D31B1A43152016A212435522B40129B36D1919234C6D3D80F568D14CD11CBEFC1930958F6709550193F86F913F02FC0F6A9D98E54901E0AA032340F6BF068A78303CDA746C6AA51B1A561C254801884E21A805A40E98924122AC0558AB6C1B65340058A08A02AC530D200097214912C0594441D8002DD30A311D18019674C54E9EC7A12A667A94C0F3311828CF692473F98FC309FCA759287DC5B5F503E6B8BC85AE861A99635D0FA856C2465CA3CBC464ABC00F9FF00E07C8A5843B1A993F90A795F901CAAC306B0E746F2AF201E57E40783D883F863A0FE1BE40BCBC0F01511B0C39EB3C016B0A061A740D745B43E3871CB0C0370F54F46948C14E81B68A034261216906803D20E90AE5014D056F42302CC0E9D9491080591B210007B148B2014C164201562692100BD21420590028447C510805C999AA144013342EC590053446BC4840175295C4CF06AC42002F0C892C222C802E797DC4CF0242019AA60043C090805C70A1C30E4200E8D20E34C8400D44B512100B48A9725900A27D4B201FFD9,
										0x89504E470D0A1A0A0000000D49484452000000730000007A08060000008C4C6C2E000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000020B749444154785EEDDD57906C5515066029A0E0852A52497AE11179E1812AE0C1B2A040C94982E4244941720E12948C92334894A044151125E79CA392A3E41C058EF56DEE7FD9F7D0736786DBD3777AAA57D5A9EE3E619FBDD7BFFEB5D65E27F4F79A2EC8175F7CD17CFAE9A7CD679F7D56BE8F54FEF7BFFF4DFA36906EC83483F9E5975F4E01A0EF1F7DF451F3C9279F4C5E0FE448B65B3700B3BBD215303FFFFCF36F0193DFB65B88FD6A60DF7FFFFD49DF06D20D99663001540BE03EFEF8E3E6830F3E28AE1713DB00BEFBEEBBE538FB0DA47B32CD607EF8E187C5A5869D3EDF7EFBEDE6E1871F6EFEF18F7F34975D765973C71D77342FBEF862F3C61B6F4CC146C70DA47BD295040880EFBCF34EF3E8A38F36575D755573CB2DB7346FBDF556D9F6D5575F15063EF1C41365DBD5575FDD3CF9E49383783906D215306FB8E186C2C2175E78610AB7FBDFFFFEB7800658AE9500F6AF7FFD6BF397BFFC650AF73B9069976906F381071E68CE3BEFBCE6CE3BEF2CBF311170622560E34A7D868D587CF6D967377BEDB557F93D90EEC888C0C4A02432C94C0977291E3EF5D4530540090FA9B35702C4243BD9E7B6DB6E6BB6DF7EFBE6BAEBAE2BDBEB694CBE0F6474322230291BE380538329463EF3CC33CD73CF3D57000D50806D67AA35D0CF3EFB6C73EEB9E736279C704273F1C51717F0B44F9CAB3EC740462E2302338AA6748A8EB2EFBBEFBEE6A5975E2A19ED430F3DD43CFDF4D3A5204080625B8A0759EFBBE32EBCF0C2E6DA6BAF6D8E3AEAA86F0199DF03199D8C2A6652326547E95CEC89279ED8BCF7DE7B05D0BBEFBEBBB9F2CA2B9B7BEEB9A779F5D5570B3B016AAAE253267BCE39E734F7DE7B6FC96EFFF4A73F35BBEEBAEBA4D6BF612F71AE01A8A39351274014CCDD02D414E4E0830F6EEEBFFFFE2980E07231951BFEF7BFFF5D9888B5DC2F23C052D9ECAAABAEDA6CB9E596938E9A124C120F309091C9A8C1248004E8CD37DF5C980818C58164B4B6D79F0C807B750C861E72C821CDF2CB2FDFACB8E28A53809984298C1C80393A19119880A8C56F40015302F3C8238F14E671AF803DEBACB30AC837DD7453898B3E4D5F4C458E3DF6D8E6F7BFFF7DB3EDB6DB363FF9C94F9AEDB6DBAEB4A9BD3688EDF30E64EA322C98141BC644ACA3686EF6924B2E296E943B153B95ED64AB8F3DF65873FBEDB7377FFBDBDF9A2BAEB8A2B9F5D65B9B4B2FBDB439FAE8A39BDD77DFBDC4CAB5D65AABD96DB7DD0A88B58B0D8803304727236266ED2E2300C53859A93AAC3869C934E53FFFF94F89A55CAF0A91AA8F7D4F3DF5D4E637BFF94DB3C5165B949869AE49B4DD6E3F0C1DC8C86400E604920198134806604E20198039816400E604920198134806604E20198039816400E604920198134806604E20198039816400E604920198134806604E201980D90752DFF99F8BF83E834B6400669F092C72DB6A5B06608E73C9035879CCA3D649FB599D01987D20B9072B80C2A3D383CA0330C7B9B8911C03BFF7BDAFA172B3F9503200B30FC45373F3CD375FF90E0B000F98D98782959E0498638E39A6D089DB50DBB7A20EC01CE70230317396596699B4E61B3CDA3200733A4BD8558FBDFD9D9B9D6BAEB926ADF9FA18F3CCF6B3390330A7B304106F67A9051BB95762DB9C73CEF92DB7DA7ED26000E67496B6CBAC0B02C0C34AA02EB8E08293D67E7B7E191980390EC4FC116811996A0D2AF66266F433945E06604E67A9C7D9C98D7AF8CAB3AEB3CD36DBA4B5DF489BD50330A7B36060DCA6EF58E83D119E965B669965CAB3AC77DD7557F3831FFCA0EC63DFE8691033C7A100C5E259D7A5965AAA547B16586081F23CABC724C9420B2D54989B921E198039CE24BA95E4FCFCE73F6F669A69A6E6FBDFFF7E73DC71C795F50463E799679EC93AA217C7751DCC3C39ED615B2F9D08905C85771A00F3FAEBAF2F6FF0BAE8A28B4A277FFBDBDF36DB6CB34D7914FE17BFF8C5E4767D266EB4E3C7584AEA9DB5D57BA9462D149AFDC296E8A516FBA51DE331AD88D2ED1F03AD8FBDFCF2CB9B4D37DDB4BC1F62955556696EBCF1C6C953156D4888E69D77DEF29B58179DD532CD607A721A6800F492276002D6A7C03D1C98790C9E683FE7EA152BDBD64D5E79E59549DFBE063820A64FE2D69B6FBE59BEDB967E03A036C2DA3822D601DCFEF4B6FEFAEB37FBEFBF7F79730BA9414EDBC0C4CC8875351691AE80E991F780E8DD0640B5783C7E383077D96597492D7EDD7E94DB2B3023406817AF2523DEFFE7DD0D42C3CB2FBF3C45BF329D684FF8EB7D8C29BF5304C06CEF75106AE82E4C075EFA41E716C7F70C4C6E56878018F70AC8C71F7FBCBC17686A602EB7DC72E59D06116D26B3EBD4D9B1100A044A0D00091B4F39E594D26FEF6FC0A2D75E7BADB0AB13A3815F3333E0D5FB7A51C74A2BAD54DE1D58BB6EFBB4FB407A0A663B01F2728AC4CF9180B9D34E3B4D6AF1EBF633F04E9D1D2BC9B9308C82CF3CF3CC02B0BE6CBCF1C6255C102FA5F2869408F0EA6A4C5E31475F355BFDFEFBDFFFDEACBDF6DACD41071DF42D0F40620471CDB5CE7B06A6376EE56D23D8F9FCF3CF974FBFBD896B3837BBD5565B4D6191F9DEC94AC742282FCA7DF0C107CB1B50BCDE26EB0E38E080F2B69430C7EF6BAEB9A66C0B785E8A1CB15FF4258992D1EFBDF7DE2553F56A1D12830D2B3138E3A5E36C273D05F3B4D34E2B8071AB40F4EA18D313DFBDBE743830D75B6FBD32A89C23C2523B7578ACC4F9175B6CB112322857C8B08E517AF99477E91263111A12E70883B02F1002B004C97B01D758638D32F64818581BABEFD6D72012BF7B0AE649279D545E379AB8E90D5CD8C9DD8E249BFDE94F7F5A2CB87657C439EBF833D6E25CC71F7F7C7921D5AF7EF5AB02C23AEBAC53DC2EEF23E304B2317B1B27450331EE945B8E7E8C73CD35D76C4E3EF9E4F25BDB5C72B6D39DF16174DC6A24FB300A8BDF5D03334092DA9A745E6A7DCC31C714A0FEF5AF7F15008189996226F7ABB6A868E08D5DE79F7F7E0173CF3DF76C36DA68A39208A874109D4BC2509FB31742D1166161E185179E3C3551E038E38C33CAF7D34F3FBDF459DFDB4C0A908EFFE52F7F598C9541D7FAFAAE1230BB32CF4C871C5C33856B94B91A2C204D7C3150D6C7BD62A9375B622CE67A3B17164B00B829C50213E525975CB2C4955861CED72B66D61E81EBCCABC8897EC960F52DFBF9DE9E8A30C27DF6D9A7D964934DCA9BC8BA2901B36B6E96506CCD18BFDDD3C90599F0B24A01DEBBF2CC3DC552693D262A1AFFEE77BF2B732BC9057786D17E7369E670AC5C9B01B06D3C632940CCFDA9BC8BB92F50941A55B722F281482A44C6C9C37819722D74C5454FAB8C09983A578349289B2BF26A6E2CE59E58B685AB3527C34C0A9129021C73D569311A9898BAE1861B96B96984123A7576AC2560898B8C50DF019DF818C14CE3586185154AFCA46CCCB5BE8EA3DD90AE83E9404076620A26021378E2844FEE55B5C4A0AC33FF145F03A838EA18732FCA30D794F9D52286F5428C0D58DCE7D4242CD37F951B5734CCAF6BA941A4836E48D7C114C76A56D6815D5CF1466753130062256B969A8BAB06E83BABCFFCD3BE80CD2B4D01BAE38E3B96585B4BAF00ADDD61FD3D711CD8324FD716CD43014AE824001A7332D6E10C6334D27530DBACE4529210883562A31803284C34C00011652471902C001CB0DC2F0065BADCDA91471E3945913B93EAB19480A77F19638AE894C8708D6FE595572E891EA18FA18CBB5EDF0DE93A98C0A83B6CE0949075DED32E09E25A32770244A61A6D719CE3251126E7401547BD8756F24428A53EE75889B105C4FA3B6599239B2F8AED61202365C8B5B112E3A90D9E8EBAC1D0AE83399C0084ABC43231135B2986E4C4432DF6750CB76BB2ED9A1E37064806110F4018876348BB9DA949DA6A4B9DD4A4BF8CC8781435CC2B0194453B594672DE6E887300B36BD733871359AB6A878BAA8A06891FF5A0875AECC3EA2D92242E57B545913ED206C2249D244665194EEC1F465150C4B9F583FB57145876D9654BF54A9B9DC01CCD39A7559CA3A7CCA46C6EF28F7FFC63611965B370D69E130FB55012C13AAE8A421905976B8A4079D9078B1D534BBBBDB630ACC4314086E9DAAD45196FF1C5172FC654B73335203B9DAFDBE21C3D05536C00A2D80980A4E51497130FB524012162A8749FBB6518FE594171A13D07D56E6258272577923A31093BB959B15E8D5809AE8E7131A0B43F92738C8538574FC14CBC51B203286029860273E2A116C0502AE5B9A26FA2EE38192596AAFBEEBBEFBEA5AE1BF76AFF2457C329BB9EEFE57CC4946AF3CD376FD65D77DD729E00EC535BFA3014237B29CED7533023AA40871F7E7829B00394D273E2A1164269DCB4E94A986A00DCB7364D790E3DF4D066F6D9679F7C4D9082896387527ADA6704014BB62D3B55135633268ECBF61C43ACEBD45E2FC5397B0666941A4B561152A764F92C3E271E6AD151D3913AB3CCF7B852AE17886E0A5606542D527870EE803914A0B5FCF9CF7F2E37139B37469CAB667CBC4C183C545BBD12E7ED3998F5E0F7D8638F7217B65897130FB528E96180E3D30691B890ACE37E4DDCB95FAE578C93417702B3069488E3F3CF3F7F61A4B85CC7CFEC232C38578E25B567995EE2DC3D75B375C32C5B596FBFFDF62BD73153A38DC593ECFFFAEBAF972980A98DED9449813110129672DB2E1813F1527CD53E505DB948D586680B38CE6DD2EF223326D72086F5C349DD975AB4551B9FFD1854C6E6777DBEEF2ADA03664FE69935481183F0DF60AE5F62544A74B9CC14254898EA02036977340A01E66AABAD3639B6014B2C553DF25FD692A4C453C7B8E4E6367FC692640980694F1FD2D6D4A406D3F77891086303E25849C0EC69021440E2EEC4A10B2EB8A064B7AA3BAE9C4428830BC6AE4E527736CCD486CC93649D0409BBD583DDA3A37AA46AB3C8228B9479632D293C4439A3110032841A7CED68B3069B3016BAE8A4ECEF22E96F4FDD2C05FB0454E29D6981E2B9D8A644865D5108C6C8540905D4D69E1818C15E80FDF0873F2CE091B04D92E58A8B8A911BB24C37B052A2C47D67EEC80DB7DB1D09336B712CA0EA367C07A825DB2DC6D406FABB484FC164B1614AA42E0450A62BF76E2BC9754F22B30C5B0CBC56ACDF5158DA724F91CB4FC476E774596DEEB9E76E669D75D65282934103598DD81FCAB9E6E8BE5E6DB4811BE9F5464A733E00D5E0C470F5C3521B63A406FDBB4A4FC1AC5D4A7D82582BC10AF78DBA762986CA744D473A298050425B1112989FFDEC67939906383171C619676C669E79E672975F8CC027372E8672F5EE66902C11C7EBF348A593D28612E31DCDFE2311EDF53C6692809713010B2BFCE60EC534778B7389EE0BB2CE24BE664D804C1BBEB37C06E15E1B02A0196698A1FCE64EB13662EA91639D9B276008E696325FC5FCD1486D542E22B84BC252972C6B714E616628431DAD184B4FC10446ACDD4992F6630811E76C375073503775A91471BB5C22C56803685C6F8E8B50280572B3B95446B1840145E199FC137D704E0BA39180999F8AA7CEEF9C2361A86CD95D87EEA6E0B265E9BE6B831B57B9622CB518A7B174437A0EE64824007173EE41F558C261871D56940128C91005636AACBAB66EA53E60C650485C7996A106699BF3322AA546F1DA8D68961851F6D3BEF332807FFEF39F2551731C43D107C6E4AACE1FFEF087727BA522BD6286AB3CD6270FA8257D8B30A23601DAFB44AC0366CFAE674E4D6A37952C97B8CDC45F15FB875B457477BB8983E6A42C9BF2732CE5526AA626847150062564E934C8BA1DFB500CC3519765486ABEBC4398AC5D57520019F7EFFCC074E701667BA674EBADB72E0F15990A49F0DC032C9B062CE61AABF311E74FBFACD3A7BA9FD63947F6AFC57EE38A99069601E8583A8D8558EADE5917852545AC5B8244E1D81120DCCFEAB1F9B60BD656964E836CEF1F015E40E5323D6AA7062C4973AEF411C040F4C01000B95606E8BB3E3306532337761F71C411E553666D312EE349B1C458EAFEE883DF3917A9C742A2B37103661D3F74AC661C9194A8E0788848115D2C9524C9486DC356ECF1883831104AF699C147019D061909932349AC9C4722C5ED87A1847B7593F70E3BEC50C202F000E9F3C0030F2C8C747B89DF9EF4C258374E0770193C50DDE9AE78C2584C9D1877A7984A2FD65B323ECBB80193CB8CB4598299B5984A5002F74B89A61358623AE3313A7556029028633830DB6CB0DDB171A184B224366AB9445B148EB1EE91151B012679931103D17AEBD4A0B131ECF4FBD7BFFE75F98E9940F62806F7EB79D4DC41A17DFDB230EA80D716EBC60D9814E7C47567015C2B93649BFD65AB9483AD9E8D54F613C3D466B95EC707A0E1C02400CD7ADFE3DE226E15494529C6C7A0300C30BE639C9BB50104302E95E1B95FC9EFB01188BE0311F859CF20B425CE7A3D8CBBF8DD04C7334417FAA61FDC72D6E9F7B872B3119D8D00571C6D0B50ECA788EE51710A343F9578B89EC9DD72BBC97C470266C436203A77FA22A6D5F35442F98C890B0524A3020A4602C46FDF81E5378606789F8EB51DC88CC0F61C27F632006D2B74FCE8473F2A63F454769E5F21FA87B1FA3CAEC0D4A9284F27EACC8DBB8960653BD3331D906498962CBAE8A2251931BD105359F57060E63C6DA1206D633D1600D8F93DD4C42D0244E508205C23802D0111403BEFBC7349840066BDDFF6B1DD317E032DC7F8041CF662AAB6012B13165B8D11E32580F110C6332E99F95D246088695EA0EB8931F1D4E533F35309525C1543F0C970022E8962B0926200C7D5BA2342F121891860B93F8A06904F4C030CD000EC3780AC031040023EA07C7A8CC13ADB01677F9F8003B6842A6C0D8BB965E02B598AAFF637466CE576BDE8C9988CAF26402DE31ECC884ACCD24B2F5DEEDAA30883155BCD4D254E12A5648AB517C8F73643B9578660BE6B0E8BF114CB5836DB6CB3C9EE123000E0228100208F29302415258F55004BDF1880FD010D58806A2FCC0658DCADEF40748CEF0CC7EF30DBD51F2FC3D00E83CB0BF7790F1203ADA52FC0648D5C4FAE9AB85AE27AA5C15394D7D7982FBA13DE36968C81040B49EDEA4D117233978A8DF88B158C04306274148B91DC2DD6CAA819052330853295F2BE03192E6FE1780FE7CA7431169089998C437B61B44FEB9D471C750EBFED0F40FB6BC377356897003316FA006A9DC491710F2677484C1B32CF2440303F34DF03806984380A509FACD9B12C189029B361AEC2402C9C28EF6DB0C10605508FB16B9332FDD6AEBA2EF0B5A99C875D4A81DCA0C2837EB875459206282CC56AA06A2BEC761FB0369328010F2301264BF609648BED40B6AF396EF440E266639C91BE60264064B19284B600C5BC8D920C5A311CA016592A0000190558EF427904388E030265529E0C968B7431C0BE5CB2788CD100E39A81EBDCB2506C92C4000F43DDC62291D19EFB9600CB950A0D00049675FA0C60EBB13071D3362E5D3FB85B53323A30069E0123FBD2CDEABC8E6300F6104AA4DC3A0E72ABCA81144A895C2F90151CB85E8A6010E22361D5DA50F5A13C718CAB4BCCC250719A319826393FB72993B61097F31C6F0A0560EE0F4B81A3FAC348C45FED03D17A0BD7AA8FCEE54E0CE7039CF58C09A8C04CCC751E313A12F7DA97CC24142A3EB58502EBD8A1A860F0ACDF9426A072BD0A1089A50AE712188CA2584B4A76CA728AF0C0F64994E380C8B512004AC680C850806E1D97CFB53AAF4B676E25C552B117CB002BAB4D66EB7C5CAA632CDCADC282F558CE10812614C81B48B26F63AF65DC8329E8038BC57359066630195044E65AAF939D8A4780E17A31A076AF120A2CA650EE348947A625EE1FC264C6A12D06C14513BF5D02F3A91D8B7B7215EBB95F17C415365C10571870AB27462676321AE7084BC546E0A9E102DC5D8D922C1EC85C9841A813EBBF78CF4BD0495B077DC14C40897F14C3B502342E06D81814A9ADD5FCD33442D6898571CBF6C10CAE4D8CE2E62C18621DE5616E26EFCA6E9220801285054086290C45B951FCC45040708FDCB6B92CA3E0EEB1CBB10CCC5800CAADBA8C0648FB8BCF62BC844F6DDA79526A24FAC5CBE84BEE78341EFAE87B306BEBB49F85C49DCA028193F58EA724D746018A194014A3B01298CE2531C2389F0CC17C163B7C37AF15C34CE8DD38C6FDFA048070806914EE3C8C0DC862AB0BD9BC0BC672F9CEEBE5884035EDC142E2110FDB810A287D6654315463B12F6362ACC974FB1ECC80D4966CE7F662C1066D0E0A482E555CC548EE0E9880E506298E7229536102AB80E358D75FB9516DBA57D72387DC1FC6004E3BB25E17DB312A0F0FFB640000C72AB79F4ABA00AAEA84CDDAE5469360650C0490F5742A19BA70C0C08CB3EFC12494687D84D20905992690A4F2E68DDC1A254A367C4A4A802A7BE4F6801030B0483B00C3026E4F01816B774781D8981BAE01A412653BC3C148EED63D420002A47D81986C569BDC2FA3D007A04780672C615E8437AA430B61401302CCB81F62A0595CE4C6980880B835098FA90720251E948A9D40C54E8AB1001040DC19172B76620F16A40A659BBE681B28B6311C2EDAB1F6E782890BE08E715B8AC57EDC29372B49328DE1E67903AE367D97ECC4DDD6123D84B17D0F663D2D61AD290E9816982712EBB9238990840780C0F3C9D5A65020D6C970DD93242E9A76985670B158657A022CE7304591DD3A0F0112D71B77EC3819B8784DB867C98DFD6D67280A0558AA7CC8BD3A9FED92240666BE990B03C4D89D3BBF89ED74E1B3EFC18CFB242926708F94629B631DE33E5DF10C1B01C9A571750005662E3A63ACFDB0890BB45ECC94080153BC6340DA4B294FB66A3E9A39A9CC963BC656022846C0ED320AB1168880E69281CBF0D4785D3151E9D2071E44D9D09CD5B988731B9F7102D5F88C9B3EFA1ECCB898DA5AC5C9DABD02C0DC2ED96A1849A1962442DC9DDFAE56609AC442F6290ECA4C31887BC52A2E1793F4C7FC11A0D64B4C000D6499AD223EA6899B8C82280E6030B0F55FFFC4561E41210270DCB4228473BA5D46BF1904776BAC197F2DE31ECCB851A93830330800FB2E365268C41482E258AE63B925D708B10F605C17779A04044B818CB1A99F4A84281C33C558C641E12A3380959572A35CB1E44452E5BB6448ACF31DB3F511B0E69E8ED15FF34EEE56AC0524236018122471549F3191BB07A22B458A1EE271EECAC7625EC7B8B976E033F6BE05330C0D23E36EB0C9BA305635459D1480804AACF4297EFAAC5DAF6D188AAD1218A0522417AAE00D2C00986EC8723150F9902B25F6D757A0A7C48751142E19123B191BD7EA7805076D60BE2207B0150F780649987172DB5CAE980F649F793D9DFD5DB1B14FDF8309344012D6CFAD651FD66EE0356040CA54C477EC04A02CD61276AAD260AF38E953C2A3362CCEC940C5526E140BB946E796F1AA07639D3E310200621AE11D94071D4330923B155F09E03D2DE76240EE71D26F05070C05B063B977E544FD763EEEDA3113869914CB1512DB64AF4051F896D800075014001C406257B25BBFB39E0201EEF2942B350CC23C105301806912156CE01A5D16031AF789B9922FEE1D73B0589C93E848803050E5C8F48317611C42854FEDD91FAB254918AA3DC7192B0673B3A631AA492E126CBEF9E685A55C70DF834928C33D42E264B25B4A375089055065875C2D90808791C0042090253E98998CD76F403B5EDC941449746C03963B0AB04322A3AEEAD3BC96F2B947AE94FB031EE1EE31D67ED8294B95108975C6E8C9360CB59866603BA3C178499736F5C938DDE5E038F901F72F66CBC2FB1E4C0BB793BFAA205C9138C9955A0C1460C073298A5280898500042EF6FACD7D3A060302B0DF4006E88F7FFCE3D28EC406D09211EE97523193A2B9772088A5D8243E322E0995B80824FB622B1147819E7931C0188624CAB1E22D230428B0B970AE95C7D0278FFD33B4BE0793B2F2A7312918C84E65A4611720006691DC0016232D80026C325ADB311960C095B52AFF895962A54407AB1CC360C452C68285DCA104053BB950F11683808BCDC01416285EF2033C2C742C968993D8AA7D6E5B1C1453314FA66CAE4B243D8CCC2537F1981EB4D5F760529A7DCCEFFC168B281450120E0CC33A8CB32E0C4C820344566F9DEFD60113F0E2EDEAABAF3EB99A63B26ED2CF78B0474C752EF18AD188796219F6E80766AA12611D00B85921014BB95B21012B01613F091460C57BCC253C0080C566B1D77995056D6728448224A48C7B302306E42EB564AEC480586E003669A75C136CACC4BAC44CCA062EC6590F3CBF2DC00424C69A5A609D38A91D00618FAC995BC4B0D4821526B83BF1137365AF8C477CA47453190CC41E490AA67195EE20E06AB950E061A1F5C688FDDA64ACBE63B3B081D1CE2FA305625CB2FE2A36B865A62FC0A44C8CC80D5D060A38964E5284C63AEE27490EB709389F49826C0760E2212602CFA76A0B601419B049E221F3A4782E3497D2086FE09C4406CAE52DB1C41225EB65300A0D2EB501D8776D0393ABC44619ABF63116EB180BD0B59524C9B1C6691DC08D8FBB6560447CE605780AFB8D7B30B9255609386C49390B2BEB929DCB51E2A48C150B318F6B4D8C8C7B4D420340CCB3CE31E2A2E73F6591AA3A5C1ED72AB1495D94507A3DB7258C8D003E8912F7C89D8A7F62A8BFCDF08941BC00160229AE58BCC73AACD41EE311427802A21DFD4958B1AF6D0C8D51007BDC8369BAC18D9A477A248E18B001009A60AD640468166001310CA56031123BC35260DA661F718EF2B92F8CC020D715FD16D7C463F192C2E3D289F5B5CBAD8B17DCADBE488EB4A57F805314706EE141F2643F63912461692A49DC2F90812E31C2524992FE6135B7CDC83093F161FEB80733AE4C7C118328944546C9AC34712E573C583EF028CA27E6899D186BC1529F988E99A6369424F130253081A720ED4778037D713EDBB03362BA41D257DBAD53D1F1F81E8391A4B8E94BDCF3B83C5789653C82699531C97E01A60C087871D479C45F60EB1B034EE13E5770142DC4D5BE8899AC9F15A6360AC8B092525442000898B8580062288B9595029942AD7325848B15A3B8276E4D9C926C60412D2942749280C8D0022E06C708F451FB1222179ECD71314F5F242DE2B2792B4FC09DAB188989428A8C15B00C431C063000C546D933C63A17C0C54C71B72FC0A460AEC5E418A86180EF980748F1D214224910B6266626630522A57267DCB6B868CAC30D6226E012FF7CB78E381FF76A011A05C7DDD66007DC48FA695F2C549E339D917CE99FF3BA32C240B951EE1F4BE503580C28E0AA34019E513302C6A33DC295EB735FCC3323B2404904119B14A16573DC14E560238BC74471D1F54B0A3341370793A152267785392C5DEC65D15CA885CBA2F81A2080389F6D80B45F84721327133BD3866488F89E6DF100FACBB0304E78900903D6D40B93557E781106276E72B358CA585C3DE152010A74AED62532FD9CEE60D6596144C728854479E6660089425933D69952009255E73B76622B703D6CE4BBAC0F4840E496C42E3192B2C772313EC613C613EC938DF226E21DAF217B5514911499CA180F6FC4F5CB80330FC552C012EEDB74492C65DCE31A4CDB28042B4D3DF2BA35A2B88D7916600110F37C179B30562C751C6B175F6499921B4A8AB495DFED85E161A6C56F627C00C63473524F8DE9B70C15CB548F549E780D8503899C90C21563A5710051C294A9CBD5575FDDFC1F0659020F1068A8ED0000000049454E44AE426082
										),
									@user_id, 
									getutcdate())

		declare @category_loop int set @category_loop = 1
		while @category_loop <= 10 begin
			declare @product_category_id uniqueidentifier set @product_category_id = newid()
			insert into product_category (product_category_id, product_category_parent_id, product_category_code, product_category_name, product_category_position, state_rcd, user_id, date_time) 
								 values (@product_category_id, 
										 @product_category_parent_id, 
										 convert(varchar(2), @parent_loop) + convert(varchar(2), @category_loop), 
										 ' Main cat ' + convert(varchar(2), @parent_loop) +
											' Sub Cat ' + convert(varchar(2), @category_loop), 
										 @category_loop, 
										 'C',
										 @user_id, 
										 getutcdate())

			insert into product_category_image (product_category_image_id, product_category_id, product_category_image_type_rcd, image, user_id, date_time)
								values (newid(),
										@product_category_id, 
										iif(@category_loop % 2 = 0,
											'SS',
											'LS'
											),
										iif(@category_loop % 2 = 0,
											0xFFD8FFE000104A46494600010101000000000000FFDB004300090606141211141413141615151518171417171518181C18171C171C1817171818171C1B261F171D231C17171F2F202327292C2C2C181E3135302A35262B2C29FFDB004301090A0A0E0C0E1A0F0F1A2C241C242C2C292C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2CFFC000110800C4010103012200021101031101FFC4001C0001000203010101000000000000000000000103040506070208FFC4004A10000102030307090504070704030000000100020304110521F0123141516191A106131452717281B1D1072232339223B2C2E115244282C1C3F143536273A2B3E283A3D2D3162563FFC40017010101010100000000000000000000000000010203FFC4001F1101000202020203000000000000000000000111213141811222025161FFDA000C03010002110311003F00F4C9B9C7888F01CEB9C749D6A913D13AEEFA8A99DF98FEF1F32A84C8BBA6C4EBBBEA2A7A6C4EBBBEA3EAA829541789E89D776F2A3A6C4EBBBEA2A944C8BBA6C4EBBB794E9D13AEEFA8FAAA4202962FE9D13AEEDE53A6C4EBBBEA2A8441774D89D777D47D54F4D89D776F3EAA84C62A82FE9B13AEEFA8A74D89D777D47D550882FE9D13AEEFA8A74E89D776F2A8441774E89D776F3EAA7A6C4EBBB795425505FD3A275DDBCA8E9D13AEEFA8AAAAA2A82FE9B13AEEDE7D5474E89D776F3EAA9C631B91205DD3A275DDF5153D36275DDBCAA2A882EE9B13AEEDE53A6C4EBBBEA2A9C62F4C631EA82FE9D13AEEFA8A8E9D13AEEDE7D5528962FE9D13AEEDE53A6C4EBBB7954850105FD36275DDBCA19C89D777D47D5508422369D25FD63BCA2AB19CFAA27B2B1A7BE63FBCEF32A957CF7CC7F78F9AA102A881022083180888A2214C62E5010A5500C0FC950A2225502AA5463144A202204AA80318C6944A22A012AA6AA102A8510A825425115410A90A288A2510A2022257172055110A83615DBE68BE68304FAA2BD0C79D1F68FEF3BCCEC54ABE747DA3FBCEF32A8080BE62C50D05CE21AD1797388006D24E6ED5F4BCF3DB5CDD24E0C3AD0448C2BD8C6B8F8DEE05077D62CF3261BCE3328C3A90D79040894A82595BCB7FC5400E8256E04B30E81C560C9C36C36358C00358D6B1A0660D6800529B02CE87114449B2DA731238AF93629D0E6F88A2C986F56BE2D1AE234028340428AA5318C76A2AA2226318DE807154014D146317202044AA055022205100D489440281022026318F44440A2263172202221404AA20C6288821444567DFAF1BD1465766EFF92297F14CB1E77E63FBCEF354ABE77E63FBCEF32A80555178E7B749CAC796855F821B9E7665BB27F96BD8D7E7DF69D1CC7B5A3359579061C168152490D68C9035E5123B507A3FB21E58C49B8265E231CE7CBB1BF6A2F0E6FC2D0F2733F46D009D06BE8E011A085A4E40724DB67C9B610BE23BDF8CE17E53C81500F55BF08EC274AEAA195063B222AED49AC884E34AE61DB53E955B40D07385A2E55DAB2D00436468B0E139F57379C706D436E34A9A6770446B1B6AB34870F0F4F457B2758733878DDC0AC682C85145613D9106B639AE1BC1BF3A44B3367054678DE955AA3675335476234446E671F1BC71515B545AC13B106700F85FC17DB6D4D6C3E0506C128B11B69B0E9A768F4573665A7339A4EAA8545A888100A1444044250E2A80888501156E986E5B61D465BEF6B2B5711A4D33E48ADE730D6B30D9EFD02BD94418E8BEDF05C33823C0F9AF8A2814C6022918C050A80504A9A63F242E419D8CFF009A85650E2BEA8A96C59DF98FEF3B3F6AA2AAE9DF98FEF3BCCAA68A0631A978EFB35B304EDB13136E156427BE30ADFEFC473B9AF10329DDAC0BD4EDF9DE66563C5D30E14478ED0D2471A2E6FD8C5942159C227ED477B9E7B1A4C368ECF75C7F78A0F4484564C32B16115910D4465C35836CF25E56700E93021C5C905A39C6D4B41CF47671E0566B551126A8E2355C8AE2673D8359AF24B046827FFCA29BBEB0E2B09DEC766A10FD5AD699653336202E6F65CF03FD257A2B66D58D9ADA83CD5F615BD047BB1A4E6A9A1ED2C71DCD68D3D6557E9FB521FCFB21EE0339978AD7EE68CA277AF541349963520F2867B43802BD225A6E5699CC580EC91E2DBFFD2B6525CA9908FF002E6A0926940E7063AFD4D7D0F05E8C437590B0E6AC1978A087C284F073E5C363ABB2F0511CC9B38115178CF5178F02A989666C5B28BECCE4AA5D0E0082EEB4BBDF048DA39B73457C28AB89C929A877C29D7387566A13228FAE1F34F1E24A0C09785CD9739CE221C3851A3380BEB9005F4D9944DD9CD16AECEE5AB5D67C49F8AD2C8622C56B1A3E22D60606376B9CE2ED82BA85566DB8C88C833AE8D90D74392C8221B8B984CC4478A82E6B48BA0B2E22EAE72B8DB4A572793128D19E2C4AF8C48AE2380083B936DB5AD93E728224DF30190DA6A43A3069767A7BAC0EA93D9A4ACCE98D11799AFBF9062168CE181CD6171D4329C00D77EA2B9BB5E447E9FB3216883089EC10E19A7160581C9F2E13D6E4704D61C36B1A73D3F6B4FF009554576CC8E1C5C01AE49C9750E67501C93A8D08BB685F6D3A470FC97984BDA51A57939CF35C4458F3114979BDD4796B1CE04E93906F5BEB567E2C299B22419EEB22365B9D23E270606653360B893AF366AD6A3B10169F95F6B74691988C2E73219C93A9CFA3187C1CE07C15167F281D167A721DC20CA4261AE973DEF692E3AA8D0E000DA74DDC2729F951FA4990980164BBE7A04100DCF78A1CB2EBEEF8DB468CD722BD13D9B580E9694112312F9998A458CF79ABAF1EE432E37D1ADD1D62E5D9437AC186FDD8D0B21AFC7E6A2339AE554ECB07B1D70AD2A2ED5A17CC37ABC390736460A2BE75803C81B0EF0377E7A5518C5CAAA68A0A210833AA3670F445F54C5E8AE518D3C3ED1FDE7799542BA77E63FBCEF354A8AE43DABCF9856645A1A18A590BEA3570FA5AE1E2B79C8B801967C981FDC433F53438F125709EDD2769025A157E388F791DC6868FF70AEFF91EFAC84A117FD841FB8D0837D08AC9605890964B71FD544E194C372E7FA65493AEF5B69F8F910623B534EF370F35C7366951BE6CDAB04DAD0B66F6AB5B35B541BE6CDAB5B36B42D9956B66FB506F9B37B5582696804DEDF356B66951BE137B55A26F6AD0B66F6AB1B36A0E5B97539FAA5AAFEB4483006DE6E1437BA9D8E7BF715836DCAD24AC296EB3E57286BBE113F78AD6F2C2D0E76CB6919E62666220DB53158CFF00486AE86DA7836AD9B07F660073E9DC63C0FF006820B61811794EED50655D7F7B9B1F8CAD0D8F17F52B6A3FF7B301837347F30AD972766C1B52D59826E870DACECA39F5B8FF0093C169B2F9BB00F5A3CC3DFDB925C3F94507C72924696059704678A611A7F98ECA3C6205D15B125CE728E4DA3FB18515F4D54690DF362A39492C39CB165B430C007B186057EE1D0B32CC99CAB766A29BC4180F00EAF903F0B906A393ECBADB8DA0B9AC07BAD88ED3B5CD5E613B3465E52CD753FB78D354EB643E1C36FF00B4E0BD36C97645893AF39E34768AEBA080DFE0E5E5DCB763AB67CBB412E649C0F740A92F8E5D1C8A69279D6DCA8FD132B36D88D6BD86AC7B439A75870A8E0565C388B9BE42D8516524A1418CFCA7B41CD999944B8301FDAA573F6E801746D82758506435CAF6C4B96331AED5BBD124E2E5BB678A0E46D6E56360C09C9A8BF0429A892D09ADCEFE6D8C14AE82620897E6006FDAC939E60C17BC00E890A1C4206605ED0E2076124782E0F9797D890699E3CE4689DBCE468EE19B61685E9D3F2B939234436358DD9414C7620C2AA14AA1C62AAAB3AA31FD514D7B515ED18D3DF31FDE779AA95B3BF31FDE779954A83C4BDB74F654EC2860FCB842BB0BDCE3F74357A57B339DE76CB96273B58619FF00A6E730700178B7B419931ED499C9ABBED39A6819CE4010E8076B57A17B35B462484B3A14C34905F96D0D20965451C08240CE2B406EBD34AF5686564B572F2FCB89539E21677DAEF3150B77216DC08C2B0E3437F75C2BBAB51E2A228E574DE44B534BDCD68F0F78FDD5C5366F6ADC7B479EC9E619DF7FDD68FE2B8E6CE20DF09CDAAC136B42D9B5689C0837AD9B56B66F6AD0B26F6AB04D22B7EC9AC056366D685B36AC6CE2237CD9B545AD6A7372F19F5F861BC8ED0D34E345AD6CDF62D2F2E2D12D918B4B8BF259F5387F0AA0A66A28FF00EA209F86909C46BCB743ADDF56F2B7F0E683EDA2E39D92E4F8BA80F08A77AE5A7620FD27270B442637B3DC6BDE3886ACAB3677F5F9F8BA61C20D1C0E8FF2820CBB1E6692769C606F8AF7301DFF00FBD63DB6E3FA2ECF860DEF25E3B6265385DA69CE85A6979B30EC58AEFEF229ED2039ADAFFDA3B9675B6D39764C0EAF321DFBA61E57086E4A1D5DA3355B6E55A333213881ABDD8C7C7470587645A7F696CC61A1A5ADDF1FCE8DDCB12427B2EDA8A49BA1C1A761AC207CDFBD69ECAB4726CDB4629FED2316E7D4218A7177141B2989A736C380C19E3C6790358CB8991E50D5DC98B0DB336D4ECD38653255ED810B56531A2103FBAD65DB5C0E8544FC4C98564423FB3CDBDD5D4C6C37B8F0795D4FB369230ECF84E77C71CBA61E7497453940FD390AABAB84164B337E6B198B29A33288BA1AC588E109B19F9831AF7EE6972CB879D69F96B14B6466A99DF0C421FF0054B616BCFEFA0E2394F2A398B06548CEF962E1E10B2B792F5E956C3C640A6727CBF3A2E16DB60896DC8C31F0C0062534010DB18B7EEB17593B172B27B0E3820C6095442AAB3ABDBB9132BB37FE4A15F192D4CEFCC7F79DE6551B73E37ABE747DA3FBCEF3545541E2DC88B3B2DD313511B488E8AF68045EC3F13EE39892E035DC75ADFCCB17596C590D6E54486DA659CA894D268065D341A015ECAE924F3332C50692658B5534CBEF0B7932C5AA996A2332CCB2661D05AF64288F67BD925B570B8E49A019AF0740CCAB7462D3477BA7483507C41BD7AA727A579B9580CA6686D27B5C329DC495B07B038508046A22BE78FE21E3A26F19D5AD9AC7F55E9731C99957FC50218DA1B9277B6856B66BD9FCB387B862433FE17650DCEAF9AA38A134AD6CD2DEC7F670E1F2E383B1EC238826BB96BA372226DB99AC7F71E3F1512A450D9B56326F1F92C098B366219F7E0C51FBAE23EA029C56209BD6A0DF09BC631FC79EE59CDE519685D78CD2476507E2590D9A5A3B59CE74F4AD410DA65B6A2E3473AA46B15653C151B3978E1F6C3DD5F970CEFA35A7EF15F323354856946EBBDEC1FBA08FE6705816046FD726A26A25BFEAFF0082C56CD52CC89AE23C9DEF6FF06A2B3ED1894B2A5616988F1E394E7BBF105BC9C99CBB5E0373F3509E7C725F4BBF782D1CE3BDEB3A1F54B5C4775ACA7915916747CAB4E3BFAB0DAD1E391F9A236360CDFEB36945D556D760E71C7C9BB96AA3BF26C586D19E34524EDCA73C0E002C5B1E73264676256F88E78DE001F7CABA7BE4D9B04E62F86E23E93F8CA0DBF2E264362B40AE4C2958D4D9960CBB78BC715EC12704321B1A05CD6B5A06A000006E0BC0796F68FDAC51ADB019E1EF453C4357E82826E08ABE1AC96E30163C35920288BE185A0E5B3C16CB4326E8B350B286B6C20E8EEFF6C705BF8772E2396F3B59D936037B21C78E7F7C084CFC5B9069AC8992FB626621FECE0E4F617084CFC4F5D9D6A0760E3FD579C72466F2A667A275A23580F63A2103735ABD180D19F47F0555295444467D3B778F544F01BBFE28953F4B4C69DF98FEF3BCCAA55D3BF31FDE779AA688042D44CD821C5B40CCC72AE2D24D0D082DCC2B4A8A78ADC28088E4A6792795998E6D2FF75E1DB6E05A0EBCE468CF55AE89C8088FF85E06B111A5A6F1A295AF0BD77C88A014BB462837222941154A2044044085001D4AA8F28C7FC6C6BFBCD07CD5A9541ACFFE332B5AF47875ECBB766E0A2D1E4DC08EF80F7B0565C92CA5C28E142D22EAB731A7F8769AED11073CCE43C01371A61C32846A39D088F772A9473CEBCACF4A67A9BEE5CCCDFB2BFD422420ECB8A09741A1A0A079201248AB9CC245E280D3B57A3D3180883CAED8F67D1DB3127119EF921F0DE00F761BA8E734D7AB4A8AEB6ED0B5F29C929864FCE42600F790D735D7B5B92F0E734D4E615A37B415EC8A00C71FE3C4A0FCF50E5220B2E251A681C0BCF56B10345755E02CD9C24CD49B48A0634B81BE872450D35FC0BDB266C784F8312096379B899596D14152F3573AA3F6AB7D741A6A58B68725E0467402E6D040CA0C68B816B80AB5DB2AD69D776D283F3D72966F2E6225F7659E01ACFC2BF417B3EB584CD9D2EFAD5CD6084FEF43F70D769003BF79783DB92BCEDA13647C223C63E196EA00B26522BE0FCA7BE1E9F71CE6F8DC507E9786B202FCF129ED0ED0846A265EFA688818FAF6E5349E2174129EDC269A47392F0220D3925F0CEF25C38288F668F1E946E939FB1795F296D1CAB6264D6E830A1C1E01EED1ACB9771C93B61B3B0D91DA6E899C696117161DA3D35AF199DB54BA2DA11CE77C48B4D1A5F41B8B47820DB7B358B960FF008E3D4D74DCD27CCAF575E5FEC9E1FCBD8D8910F89C81C0AF50C62F5410A008833A9D98F04445AED544EFCC7F79DE6550AF9D3F68FEF3BCCAA0AC89A28A6E41B93B5012AA542055102631A9012A81104A28C5E8825414A20440A144C68451114D50404088500290541441E0D3D6544833132C8CDC9798CE7EC735E729AE073106BE62E22EC589057B472A793026D828432232B90E22EA1CED769A69A8CC75E9E0A6F90336C2690C3C6B639A6BE0483C1291C73E1FF558EF84B7B3B6246875CB85119ACB98E0379145850245F11E190DA5EE71A06B4549C67D883D1BD89C57081360FC2D7B08ED73483C1AD5D0C3E484BF3930F2DCAE919594D378196D0D7E48A5C4D2B5DB7517D7246C2E852A21541738E5C4233171A5C3600001D84ADC20D0F247926D9185939796FA6497661406A001B89DAB7C98CE88A510A251066D4629FF00922FAC938FE889D0C69DF98FEF3BCCAA68AF9DF98FEF3BCD515404A62E4418C7E4808502209505110111318DC88222228898C5EA1412888A8221C631D894402898C5E881442112A818D08881001C602F8101A0D435A0E6AD054E9A139D7DA55012B8C144444A84AE2E44510E3144C631E885067D76A28C9EDDFF00922BE3FA8C79EF98FEF3BCCAA68AF9DF98FEF3BCCAA1654288A551144AA6342828268885318D29812542852A025318F4445504A22252898C5110A026318FCC9440AA2631722004AA29C63FAA08A2144501318AA950ACA0898D38C6840102A8888A225549C67419B7E0A29DFBBF244F54CBEE6E4817B8D4FC4756BEC550910749E1E8A114E161F4D906EB3C3D1419214CE786CD888AC11B1B2409CE71E0A0C90D671E088A35584F4115CE7869A6C46C903A4F0F4508AF0CF2FA320DD6787A27406EB3C3D11149106445339C1EC52641B5CE787A284527423A10AE73C366CDABE8C88D6786DD88893A210E910349E1E882446B3C3D11123402486B3C36EC52241B5CE746AF4508AC01921ACF0F4502486B3C34F86D4456120122DD67429324299CF0F4508A2F2FA122359E1E8A0C88D6786AEC444890322359E1E8A4C88D6787A22249087488D6787A274115CE787A28449234964882739CE357A27421ACF0F45089224C88D6787A21916EB39ABA3D142212D87401ACF0F444452DC7CA5FFFD9,
											0xFFD8FFE000104A46494600010101000000000000FFDB00430009060714131015141314151415141515181418141515141516141515181715141518181C2820181C251C151521312125292B2E302E171F3338332C37282D2E2BFFDB0043010A0A0A0E0D0E17100F172C1C1C1C2C2C2C2C2C2C2C2C2C2C2C2C2C2C2C372C2C2C2C372C2C2C2C2C2C37372C2C2C2C2C372B2C2C372C2C2B372C2B2B2B2B2B37FFC000110800BD010A03012200021101031101FFC4001B00000105010100000000000000000000000002030405060107FFC4004610000201020403050407060305090000000102030011041221310522410613516171328191A123425262B1C1F0147282A2D1E13392C2244353B2F107164454748384A3D2FFC40017010101010100000000000000000000000000010203FFC4001C1101010101000301010000000000000000000111021221315141FFDA000C03010002110311003F00F71A28AE136A0ED15CBD7680A28A280A28A280A28A280A28A280A28A280A28A280A28A280A28A280A2ABF8AF1A830E077D22A16D1177773E088399CFA0A8582ED18935EE6641B8EF046A48B8B9CA1C95B037B358F955C357B4555E1BB438679044B32778C2EAB7176FDDE8DE82AD2A028A28A028A28A028A28A028A2F5C0C283B45145014514503792DB7C3A7F6AEAC9D363E1FD3C6974965BEF40AA29BD4798F9FF007A5AB5F6A0ED145140514514051451405145140514525E4001248000B927400789A05572F58BE3FF00F6938580948B36265BE5CB17B0AC45C6673A5BF7737A565E5E258FC7006594E1A060088F0F605D0B84CDDE825C58937BD8100E95A9CD4B5BAE3FDB6C2610959250F20FF7517D2497B5C060344BFDE22A89B8BF10C612100C0C37209233E2480D94EAD654D9CDD736C2C75A8FC1BB3B061C8012F290F65D048EBDEE7BE6395643648EE0787A55849C54586520296C81B29EED64240EE710961240C6FA36A35B9E8A6E44D310F074C38678C5E56B096799B339D0D8C8E473017B73557623823B93DFE21F400B2440DD2DA0900B969232342576D7DCF49C5F5520B2B10F92C55A54743631E7D527898026CFCDB1DED95A6C5BDB40B046AD136B7BC4B39B1D3DA8D09B6DCBF95889584E118780E65458DAF9831224704E81D18FF8919EA2C08F2D32E9F80F685276318B965172C0129A1B5B378E848F43E06B0A60E8C4B3AE6521C8212789FBC0B228E531C896B3917171EE6311DA6481EF135DE32FDDC69AB6521641048C410B662029B580622FBD2CD257AF576A3E03122589245D9D1587A30BDBE7522B9B628A28A0292EC06F492F7DBE3D3FBD7563B6BB9F1FD6D409D4F90F9FF6A71540DABB45014514501451450145145014DB2751A1FD6FE349971017CFD2A0E2318E472F2F9EE7E7A7E34160B278E9F81FD7853959C8E6950EAC5C750DADC787EADEFDAACF098E0DA0D0FD96FF0049EBE87E557058514847BD2EA028A29B9A65504B102C2E7C878D039496703736AA57E3C1CDA119FEF6D18FE3B1BFF086F7545C4C4EFACB2E553D072023CB763F123CAAE26A276A3B5F3422D86C23CC736567621512FB1C82EEE6FF005485BDB7AF399531DC48838B9B2464852A6F1E1B36F96C0E5CE34B06BB5C8F0D3D19F884116A8B999458336817F77C079683CAB37C578FC4CCC59ACCD60C6251B0E8C3459079137F02A75ADF319AA88B0F061B58632D2074BC9281782441B272F3291F96FD1CC3F1C0A49CCE588369145CA3E62724B19D1D0B1F2F68DAD5364E1CB23076CAF1BA812056E64FB1361DAD765245F2BEC6E0DFA3D0B4505AD95A545CB9ADFE3462E4ABAF436BF9DB43B035A43117ED13294EE9638D90B3466E503A7B3361D090D11BEB653D09B5F53224C18BE69243248F14654DECD2F7172CA1C00D9B53A1FCEAAF1DDA3E4263255117BD8D8733457720ABDC8216CACD7F207C6A3F3990F2D82CE8C416170A63B99217E9CC4DC0D7908BE8282E1B892202F10555E59636600095588496096FF5B5B03D74AA7E25C7523BAA5E4C8B8A8466BF2A72E5C3E23EB15CCDCAFA0B0BEB50C6199D392D2FFB3AB33BF2A4D07ED1666C854AB4886F7248D98D8E94E6370B1C0CE1D8CA54CF1B392499219240C119492340A069E74355BC43884D25D646318CCC9917EA9CA9108E636C8E8DCD66DC69A8350609D98A88D72A92B6DEE54C8EAF11624B69945B5B5AC3A53B85C03CC6EDAF2D89D94859CBA1161B8B81EEAD6707E11CEA918BBB9B5EDAEA6F76B6961BDFCA83D23B050B270DC2A3DEEB12AEBBD868B7B795AAFE99C344238D546C8A00F402D5DCC4EDA0F1FE82B8BA14CE07AF875A4E4277DBC3A7BFC6968807EB5A550700AED145014514501451450145145055768B8CAE162CE54B92CAAAA080589D4DBD1431F7545E11C7E39D2E185B4B9D80BEC1C5F90FC41E84ED48ED7C292AAC5228753CC41F11EC90775235B11622BCFB17C325C2B77B13BB28B9CE05E441D44CAA3E917A67504DBDA53BD6E4D8CDBEDEB0CB48EE8563FB3DDAF0D9525B2B102DA8C8E0EC637BD85FD72F815DAB6114C18687D41D083E041DAB3658BA4BC00D4697060EE2A7D14D1016778FDA06451D47F88A3FD63E7EB4FBF18895331752A7406F6D7EC9BEC7CB7A78AD41C5F0C562587237DA00106DF681D1879EFE045045C471A95CDA18F283F5E4B8FF002A0E76F4E5F7D40C54B1AF34EE1C8D79ECC011D4202101FBDED7AD43C5091D99639630AA42BE4E61737B58F5D8EFB1D35DEA0CBC194733B173F78FE55B919B4EE2FB56368949B6C7737F106D607CC0AA1C771799AE49B7BEE7E2695C431889A2815483BC9DF2A0249F0AD488462B14CDB92DF3A9DC2B81B4A4170403B01BB790AD1F67BB27F598063E27D81E9F6CFCAB5D1C3161D4B3103C5DAD73E43FA0A97A2450627B3CE30A72850D1D9913C40D594F85F7F223CC838D381048691F322B3DD58A5C093285E6BF29B05D37E6D81AF4B6C44928E50628FED301DE30FBAA7D91E6DF0AC3F1BC4261A667176EEF1505C03B438827269B581565F1A4AB622C70E41C8A19960621DC10648A3D08CC18826E18F36BCA7D9BD0791B36666EEA4E1F3C44B366EEE5395D59AFCC2E47C35BDEA360F10E248D180022C663B0E6C00061EE58A9B799D6FE67C699C1A318A32FA1386C1A91F7A291A4607E2A3E356224CB2854EED3655C7C22DB0479864A8EBC3C33166B9BEBA9F316FC3E752A28EE6CA2E6E4FC49249F79356D81E1FADDB53E1F57FBD2F5212693C2785B4B60B644FB4469AEF947D6D7D079D6FB81F0D8A01F46B99CFB4CDED1F227651E42AAB010EDF9568B062C2B95EAD6E4C4C58FA9D7F01E94E5254D2AA28A28A280A28A280A28A280A28A280AE576B84D065B8E4D799BEE80BF0D4FCC9AAECD4A9A5CCC5BED127E26F4DD74614FC4F80ABDDA20AAC49250F2C6E4EA59481F44E7ED0163F581DE99E15C7E4C39C92E7289606FCB3420FB218136284EC2E50FD520D5FD318DC124A066B8650423ADB3A5F7CB704107AAB02A7A8AA2FF0007C69590302190E81976BFD9607546FBA7DC4D4F4C7A9EB5E79C3B874B0E2172B04576084A80D14970C44791989427265CAD99417166FAA35D2C6A14E50003A8F43A8DFDE3DD59B174EF10E3C89ECF39F82FC7AFBAB2BC538CCB2DC331CBF65745F78FADEFBD44E298FCB2150B7B6FA91AF80B555623885B78EDEF3F9D6A44B56DD9DC55B1063BD84AA54793AF3467E447F1543E37C59CB321D0A9208F31556262195D370432DFA329EBEF15E810F0C8E49FBF000EF115C13A91A5ACA0E80ED73BD2A325C27B3324CC0C9750750BF5C8F1B1F64799F856E7877048A15B655006A474D3AB93ABFBF4F2A24E24884C70A99641BAA1161F7A590E8BEF37A858D2A006C648A6FECC2B711FF93DA948F13A7975A9BAB89EDC55A4E5C32871B778DA422DA5948D6423C07854595E284992693BD9105CB390163FDD1ECC7EBBF9D6578E76EADC910B74CAA406B7DE61A20F25D76D6B118F69312C3BE3994105224056353E3941BB1F3356726B4FDA2FFB4532129845CFB83235C442DE1F6FF0F5AAE58E59633DE9BBB4581CE6D6B98B192C8C6C2DA8423C29180E176B17B003A69F3E83D05592927D9D05F7F21F8D5F511D9180627EB34923F8F331B7E161F1A72080B6FA0F9FF6A730B84F79F1AB5830D58BD7E3539FD35868028E800D4F87993565C3245740E01CA4E84D96F6B5ED988246A35F3AAEC545DE38801B2DB3E2187D58FA2FEF31B0B787AD5834F7B002CA05940E8A361E7EBE24D2725B8BBC3E2D17F43F2353138CA0FF00AB7FF9ACB4F3148CC854950402401B9DBAD438F8CA960397717506EE2FE4351A7955F186B727B40BD16FEF3FD28FFBC23EC9F91FE955667C20DCB8F331E200FF00364B5459F13856B08664672CA0A0950B58EE727B553D1EDA04E3809D87BF4F9DCFEBC2AD609C30B83EEEA3D6BCE715C5A38E56424D87D6B5C7BC0D6AD387713B00C8C197C8DC79D8F43FA2297935B714557F0FE28B20F03D7F5F9EDF8558561A14514501451450149717163D695450623198731BB21E874F31D0D335A1ED3616EA241F5746F4274F9FE359DBD74959A55149BD741AA82583BC5284E5CD6CAC3747073238F356008F4A831714966516B292482A00B29CC438DBA383AF81BD58C6751EB54DC1580C49561CB2A39FE2550B281EB1D9BD50D4AA8D8D9B2B9083331D598E9BF563D2FE02AA7138A6D6F623AE524E9E6ADA1152388128F2AB7B4B2B06F3FB27D08B91E46AAC312C2DE35A8CD3D1A36852D96FB58102FA822E363AE9D2B6F8452F83E724776798A1C84C77BB8B8DB4CC74F01EB59EECFE16F1313B5CE5F4CE2DF9D6C781C60C6EBD09B7C4566AC8CD717E3BDD7D161C645452CCC05BA5C9006A74EA4DCF5AC6C98F791B334B2589170798B0BEC4963F017F2AB6C7609C625E2D000A501F45B580FE1AEC7848E2D4F33789D4FBAB512AA30BC2BC4AC634DF56F8006DEFD6AD70F8655D23B313B906FAFDE276A79A72CC5401CA3524AAED616F64F8814E70D8AD2482C17C86D7CD59BD2CE498F0E08CCCCA474D796FE16DCFC2A5C710CA5858800916D45C0DA95C170E0AEA01BB5B500E961A7CEA570782EAE0ED703DC4106B16EB786B87E11DD43191C5C9D05FA1B788AB295841097918BE53A5F424B582A6FB93F8D721E14C345908BF4B1F9D8D47E0C4CF234B21CD0E16E101D7BD99B975BE84022C0F993D6922554A638A864257BD77CF211A666B1B28F10A2C055A767DD6493E9582AA8CC413AB780B0D6DA127C8552411121D8FB45F536F1076AB5ECB6242CD2A18C48E5C940DF72F7B6876507D3D2BA5F8CB9DB8E31C864122C787164700D8C9AF2AB5B53702D9074DEE0691E0EDB62A385061F00AAB61CD348B864D3C23B0034D7DAF70AAFED862D5F119932AA364C8EAA647E628D9624EAC6F62D6D341D2A8A3C072994E0C3B923E978863238081627D82F1E84F4BD4FE2B438AEDA7107437182234CA166889DFFF0051F9542ED1F1D966589717844548D05A4BE656CC176CC08B82A750D554D048D1B66C3E0180CA00C3E32EC6ED7FFCDB7E150F19077522078E4C2865046A5D1B4B025ACA4ECA0FB5A55889A847FB896E48CDDDBB1716F427328D37536F5A9581E30C8DA7D1C96D56F99580DC8E8EBEEB8BF4ACBE245C9925086C7FC6846AAC3FE228F0F4535618398BD926652C79A191367B0DD6E3471F317DF5ABA8F4CE0DC5C4CB71C8EBB807E6A7A8FD7AEA78771C2B60FA8F1FD6DF87A564FB31874FD9D4AC64CAEBCE72976D0EBDD8D1628C95B86624F4D6A666ACD9ABAF42867561706FF97AD3B590ECF3317203580527D2E47E7ADBCAB4D82C4E717EBA7C0EA3E558B1A89345145451451450373C4194A9D98107D0D61B110947643BA9B7F43EF163EFADED66FB5386B65947EEB7FA4FE23E15AE6A551D76F4CE7A0BD6D93EAFAD579E1A74647FA48D8491F2FD75BF2EFF00594B21F27352435391B58D054F6B30AAF1A62622402AA09B6E8C018F303BF2F2F88EE8D67309872ED62743B855B5FC893D2B70B08612E1CFB2EA648FC32CAC73AFF04DF059C555700E1FB13489577C3B85DE3500E502D716F875E956F80C277608BDEE6FB5BA52706B6A912C96159AD319DB2C17FB403B778B9811D0A595C7CD0FBCD53438621813248C41BEA77B74DCD6B7B4A99E02F6BB424482DA9CA34900F5427E1550985A9562BD30B76CC19949F6AD637F8D4FC16082B1619B9BA1D6DADF7EB5320C1D58C185ACAA270EC00416049D6FA8B7879F9549C2600206D49CDE56B6876D7CEAC238694EB4193ED3F790E1C98E490926DA6E16C4B30E6DEDF8DFA555F63FB49DC290AA6484DCCB19B665B01CF1DCE800DD6FE77B735687B40DA27A9FCAB2B370DCAFDEC3CAE35200D0FBBAFA7C3CFA733D316FB6CD383C6EBDF61E42F13DF4B0D3EEB5F5045FD6A978870A756EF62BACAA6E34166FB4B7D0A66171707AD35C271CF0B77B85EA2F361F52AC0685A31E5E03517F0D2B77C371306322EF22B7DE1A5D1B7CADFD763D29F0FAF055E28F9950ACCAC0943200AB3BD9CE58403C91D8EEDF31D6F1384C6096298685DB5659F14D3C97F308F6F975ADF7693B14931EF179241D7756F2917AE9A5F71E7B56565C13C1CB2A777D011FE11FDD71A7B8D8F9537F0C409706857295C1BDED6C93BC4E4DF601E4416D3CEAAF1F0E562969210028CAC56550CAA05C1EA0FBFD6B46D1D429F04BE16F4D3FEB527717C593C5B59C5898A43619C806197A05617D2E34A9DC03066499638ED19691465600AC5313F472AE86E84F4B11FCC2BBC4F00CA095E653ED21D88FC8F9EDE94BE09C462C3FD24A04C155822393DE366B85423C5580D4DB4075BEFA65E8FDA0E207BC5591E34BADFBB4399545CFB41C15636F04D34D688CF856493883B349272E4982BA2F76D0BC24EF1E4072E800FB5E37F05C1C41D363570D7A5767C5A390F562147E04FBB38AD0F0D4E427ED13F01A0FC2B31C05EF1661A8B69F0FCF3FF27956BE04CAA078002B9F4D4394514565A145145015171D0091191B6616F4F03EE352A9A9283CE250558AB6854907D46F406AD1F1FE1424BBA68FD7A06B78F81F3FFA8CA33104837046E0EE2BA4BAC5F4941A9C56A8424A7124AD0958A6CAA25B5FB9BB38EA70EC32E217C7D9B3D86E625A91824CB34919D75CEA7A156DC8F1E6D7F8C533879EC6FE1E3B5A9100C806E3F656C849F69B0B20BC6DAEB655D2E776C3D41A2C3B0A83C5F18A9AB1B0F99F41D6AB38AF689101486CEDD5B741E9F6FF000F5AA6C142D3B9790961D49FAC4741E42A67E8B98B18F20D3910EC3EB379B1E83C87CEA54187AEC10D59E1E1AC5AD4370E16A4AC352A28A9C31D4544C951310D56522556E2968333C7E4D53F8BF2AAF8DAADB8C61338D3DA5BDBC0DF707E159F492C6C74237F2AE9CFC63AFA7E6C2DCE65255C1BDC1B6BD083D0F9F5D8DE9585C4CA93878BE8B12752B6B458A035202EC24F15EBA9537DD71BD49C8AEB9245CCA7DC54F4643F55878D691ACE01DA58B14B94F24A3DA8DBA91BE53D7D37F2A978CC3820E9EB5E758881CC8AAEC17117FA19C72262ADB2B9BDA3C40F33AE9E20D6AB8171C9E48ACF877664628E418E3E65B5C10E45985F51B7A6D59CFC6B5131BC0E3E8B97F7095FE51A7CAAA311C17EFBFF00F59FF456AA5C65F78957F7F1302DBD40BD33788FB4F02FFF002958FF002C74462A7E0FE2CE7FCA3FE55150D785226AAA01F13AB7C4EB5E88B86C29DDEFFBBDE3FCC2D28E07067FDDCCDE91CE7FD3574C79B491D30E2BD2DB85614FFE1B107FF6C8FF009AD51A6E0386208FD9A6B1046B2226FF00C74F24F159F65B079218108D42A66F503BC6FE6661EEAD68AA8E102ED9BC17C8D99CE66D891B8F9D5BD73BF5B828A28A8A28A28A029B929CA6DC5040C4AD50716E1824D468E363E3E46B4B2A5419D28307221562AC2C46E2856FD74AD3F10E1A251AE847B27A8F5F2F2ACD622068DB2B0B787811E23CABA4BAC59877BCB0F3E9E5E9553C4319BA8FE23F97CE9F94BB9C91825BCBA0F127A54DC07030BABF3B7F28F41D7D4FC2ADB27D49ED5580E16D26ADCABF33E83A7AD6AF098500000580D853D0616AD70F85AE76EB72619C3E1EAC618A9C8E1A9291D452112BA569E0B415A089247503130D5BB2D332437A0CB62A0AA2E25C3F36A3461F3F23FD6B6F89C2554E2709497062E07B1B1D08DC7855846D52788F0DCDCCBA30FE6F23E7E755B1BDB43B8DFF00BD75975CECC4F78D24431C833236E2E46A3665235561D08AB9C0C28B122C844ACAA0192448CBB01ECE6E5DC0B0F755046D53CB528B73347D028F4441F82D7471103AFBC661F1B1D2A9B35283D315707888F16FF337F5A41C78F0F8807F1AAA07C3FB7F6A507A60B1FDB47D91F0147EDDE02ABC353F858F3BAA0FAC40F4F13EE1AFBAA60D67061F4418EEFCDEED87C80F8D58D368B6000D00D07A0A72B9B628A28A028A28A02B84525A4B7AF80DEB992FBFC3A7BFC681B6D7D9F8F4FEF4C9C3FBCF89A9B6AE15A0AE782A362B872B8B3A861E7F91DC55C14A498E82863E18A82C8A14797E27A9F7D38980F2AB9EEA94B150408B0752A382D5202D76D40D88E96169545072D45ABB45024AD732D2E8A06248AA06270D56A4534E9419BC4616A8F89F0BCDCCBED0FE6F2F5F3ADACB87A87260E8301873CDE9BF95BC6A667AD0E3780876CC0E46D8902F71E62E35F3A68766C7576F7003FAD74F28C78A8B3D19EB40BD9C4F173EF5FC969C5ECFC5E0C7D59BF234F28B959B1252B3D6A1781443EA7C4B1FC4D3A9C1E2FF00869EF507F1153CA18CA093F5D7FBD68BB2987CCE64E8A2CBE64EF6F41A7F155B61B028BB228F4551F80A9CB178687CBF31D6A5E970EAD2A9B592DA1D3F0FED4E5654514514057185768A04A25BF5F8D2A8A280A28A280A28A280A28A280A28A280A28A280A28A280A28A280A28A2812529063A768A067B9A4F735228A063B9A3B9A7E8A067BAAE88E9DA2810129405768A0E115C55B52A8A028A28A028A28A028A28A028A28A028A28A0ADE2FC50C251550C8F25F2ADF28362A0F358DBDA1F3F0A6A4E34446A4467BD69044232C07D2119B56B68B939AF6BDBA5F4A91C4F86A4D6CD7057D9652030B917B5C11F546E3A03B8A69B83C7DC8886650AC19595887575370E1BC74B5B6B696B694097E36235071086262587286992CA5467CE8BA2F30D582F5F0BD3D82E2F1CA5950B12A0920A3A5C0664254B001B9908D3CBC4541C4765E1900CED231E7CCC58166EF32E63A8E53C8A3972E82DB6953F0FC323422D73CAC9A9BF2BB976F9D05460BB5A194178B2DDE15CAAF9DE3333E50274CA1A265EA08237009A9C3B4B87B68CE4D830510CC5CA10CC1D5326664211B980B6845EF4DAF6722D333CAF97BB085DF31558DC3AA824730B8172D726DA9AE2766E25B307943AA2A2387E758943011036D56CEDA9BB5EC6F7008097C3B8C24B2491AFB71B30602E6C01B29636B296DC29D6DAD52C5DB30731EED081DE5C45377AE9DDCA23FA5411DD2F7B81ADCE957782E111C52348970CF9B3EB7CF72082DF688B1009D4063E35D4E16821EE75C97BEFADCBF79BFEF50323B4701B7336A6C6F14A329CE63024BAFD192EA400D6BF4BD37C27B4D0CEB111994CAA8406470159E3EF046CF6CA1F2EB96F7B11E22BADC0222E5F9C6760F200DCAE5643226616D95C93A5B7B1B8D291C3BB370C3DDE532658CA9552D75CE91F748E74B921005DEDA02413AD059E231C888CECC32A5F3DB988B74B2DCDFCB7A8B1F1D859D5017CCDB298A5047315BB82BC82E0EAD61A53F88C046E8E854287F68AF292770D71AE607507CAA14BC023768D9DE5731B87059EE4BABE753B726BD1328234208D281AC476993B93244338550EDDE16C38589831592F22DC825328B037246DBD358DED1C88CDF40ACAB0F7B7129CC0390B0AC89DDF2976CE342D6EEDB7D2E70CECEAAC31FD2CD9C468B9D5F29C8AAC0265B152BF48E6CC09B906FCAB69F0F058D10A479D01589014720A2C2A1630A77B0B6C6E0DCDEF73411071E90F7396389C4AE50E49D895C858C86C611A2AA6B7B7310BB9178F076B81C3198C633595962572D20564CE4C819172596E49D469A126C0D9E1783C71B0605CB0128259B5266657918DBEB128BB5AC3416A892F65B0EEAC2553333A7779E622491635BD95588B8DC9BEE49B924D04EC37132D8A960EED97BB48DC392B6712348BCA01BD87767536DFDF5635161C122CA6402CCD1A47E592367650074D646F954AA028A28A028A28A028A28A028A28A0FFD9
											),
										@user_id, 
										getutcdate())

			set @category_loop = @category_loop + 1
			continue
		end

		set @parent_loop = @parent_loop + 1
		continue
	end
end
go
if object_id(N'gather_product_set') is not null
	drop procedure gather_product_set
go
create procedure gather_product_set(@product_gather_id uniqueidentifier,
									@user_id uniqueidentifier
									) as begin

	-- gather job
	insert into product_gather (product_gather_id,  start_date_time,	 user_id, date_time)
						values (@product_gather_id, getutcdate(),		@user_id, getutcdate())

	-- one source, sql script
	insert into product_gather_source (product_gather_source_id, product_gather_source_type_rcd,				 product_gather_id,  user_id, date_time)
							   values (newid(),					 dbo.ref('product_gather_source_type_ref.tsql'),@product_gather_id, @user_id, getutcdate())

	declare @gather_loop int set @gather_loop = 1
	while @gather_loop <= 10 begin
		-- key
		declare @product_gather_key_id uniqueidentifier set @product_gather_key_id = newid()
		insert into product_gather_key (product_gather_key_id, product_gather_id, product_gather_key_value, user_id, date_time)
								values (@product_gather_key_id, @product_gather_id, '666' + @gather_loop, @user_id, getutcdate())

		-- value name
		insert into product_gather_attribute (product_gather_attribute_id, product_gather_key_id, product_gather_attribute_type_rcd, product_gather_attribute_value, user_id, date_time)
									values (newid(), @product_gather_key_id, 'name', ' product ' + convert(varchar(10), @gather_loop) + ' green', @user_id, getutcdate())

		-- value color
		insert into product_gather_attribute (product_gather_attribute_id, product_gather_key_id, product_gather_attribute_type_rcd, product_gather_attribute_value, user_id, date_time)
									values (newid(), @product_gather_key_id, 'color', 'Green', @user_id, getutcdate())

		set @gather_loop = @gather_loop + 1

		continue
	end

	-- finished gathering
	update product_gather set finish_date_time = getutcdate() where product_gather_id = @product_gather_id
end
go
if object_id(N'gather_set_move_to_product') is not null
	drop procedure gather_set_move_to_product
go
create procedure gather_set_move_to_product(@product_gather_id uniqueidentifier,	
											@user_id uniqueidentifier
											) as
begin
	declare	@gtin  nvarchar(240)
	declare	@name  nvarchar(240)  
	declare	@color nvarchar(240) 

	-- loop through raw data
	declare raw_cursor cursor fast_forward for  
		select	 pgk.product_gather_key_value as gtin
				,(	select pga.product_gather_attribute_value
					from product_gather_attribute as pga
					where pga.product_gather_key_id = pgk.product_gather_key_id
					  and pga.product_gather_attribute_type_rcd = 'name'
				 ) as name
				,(	select pga.product_gather_attribute_value
					from product_gather_attribute as pga
					where pga.product_gather_key_id = pgk.product_gather_key_id
					  and pga.product_gather_attribute_type_rcd = 'color'
				 ) as color
		from product_gather_key as pgk
		where product_gather_id = @product_gather_id

	open raw_cursor
	fetch next from raw_cursor into @gtin, @name, @color

	while @@fetch_status = 0 begin
		-- insert product 
		declare @product_id uniqueidentifier set @product_id = newid()
		insert into product (product_id, product_name, state_rcd, user_id, date_time) 
			values (@product_id, @name, 'C', @user_id, getutcdate());

		insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) 
			values (newid(), @product_id, 'Color', @color, @user_id, getutcdate());

		insert into product_identifier (product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time) 
			values (newid(), @product_id, 'GTIN13', @gtin, @user_id, getutcdate());

		-- category mapping
		declare @product_category_id_random uniqueidentifier
		set @product_category_id_random = ( select top 1 product_category_id
											from product_category as pc
											order by row_number() over (order by abs(checksum(newid())) % (	select count(*) 
																											from product_category
																											)
																		) 
											)

		insert into product_category_mapping(product_category_mapping_id, product_category_id, product_id, user_id, date_time) 
									 values (newid(), @product_category_id_random, @product_id, @user_id, getutcdate())

		fetch next from raw_cursor into @gtin, @name, @color
	end   

	close raw_cursor   
	deallocate raw_cursor 
end
go
if object_id(N'compare_gather_set_to_product') is not null
	drop procedure compare_gather_set_to_product
go
create procedure compare_gather_set_to_product(	@product_gather_id uniqueidentifier,	
												@user_id uniqueidentifier
												) as 
begin
	declare @product_gather_key_id	uniqueidentifier
	declare	@gtin					nvarchar(240)
	declare	@name					nvarchar(240)  
	declare	@color					nvarchar(240) 

	-- loop through raw data
	declare raw_cursor cursor fast_forward for  
		select	  pgk.product_gather_key_id
				 ,pgk.product_gather_key_value as gtin
				,(	select pga.product_gather_attribute_value
					from product_gather_attribute as pga
					where pga.product_gather_key_id = pgk.product_gather_key_id
					  and pga.product_gather_attribute_type_rcd = 'name'
				 ) as name
				,(	select pga.product_gather_attribute_value
					from product_gather_attribute as pga
					where pga.product_gather_key_id = pgk.product_gather_key_id
					  and pga.product_gather_attribute_type_rcd = 'color'
				 ) as color
		from product_gather_key as pgk
		inner join product_gather as pg on pg.product_gather_id = pgk.product_gather_id

	open raw_cursor   
	fetch next from raw_cursor into @product_gather_key_id, @gtin, @name, @color

	while @@fetch_status = 0 begin   

		declare @old_product_id uniqueidentifier 
		set @old_product_id = (
				select p.product_id
				from product as p
				inner join product_attribute as pa on pa.product_id = p.product_id
				inner join product_identifier as pi on pi.product_id = p.product_id
				where p.product_became_id is null
				  and pi.identifier = @gtin
				  and pa.value <> @color
			)

		if not @old_product_id is null begin
			-- add to change set
			insert into product_change_set (product_change_set_id, product_gather_key_id, product_id, user_id, date_time) 
				values (newid(), @product_gather_key_id, @old_product_id, @user_id, getutcdate())
		end

		fetch next from raw_cursor into @product_gather_key_id, @gtin, @name, @color
	end   

	close raw_cursor   
	deallocate raw_cursor 
end
go
if object_id(N'compare_set_move_to_product') is not null
	drop procedure compare_set_move_to_product
go
create procedure compare_set_move_to_product(	@product_gather_id uniqueidentifier,	
												@user_id uniqueidentifier
												) as 
begin
	declare raw_cursor cursor fast_forward for  
		select 
				 pcs.product_id
				,(	select pgk.product_gather_key_value
					from product_gather_key as pgk
					where pgk.product_gather_key_id = pcs.product_gather_key_id
					) as gtin
				,(	select pga.product_gather_attribute_value
					from product_gather_attribute as pga
					where pga.product_gather_key_id = pcs.product_gather_key_id
						and pga.product_gather_attribute_type_rcd = 'name'
					) as name
				,(	select pga.product_gather_attribute_value
					from product_gather_attribute as pga
					where pga.product_gather_key_id = pcs.product_gather_key_id
						and pga.product_gather_attribute_type_rcd = 'color'
					) as color
				,(	select pcm.product_category_id
					from product_category_mapping as pcm
					where pcm.product_id = pcs.product_id
					) as product_category_id
		from product_change_set			as pcs
		inner join product_gather_key	as pgk on pgk.product_gather_key_id = pcs.product_gather_key_id
		inner join product_gather		as pg on pg.product_gather_id = pgk.product_gather_id
		where pgk.product_gather_id = @product_gather_id

	declare @old_product_id			uniqueidentifier
	declare	@gtin					nvarchar(240)
	declare	@name					nvarchar(240)  
	declare	@color					nvarchar(240) 
	declare	@product_category_id	uniqueidentifier

	open raw_cursor   
	fetch next from raw_cursor into @old_product_id, @gtin, @name, @color, @product_category_id

	while @@fetch_status = 0 begin   
		-- does not exist, add it
		-- does exist, equal, ignore
		-- does exist, differs, update
		-- print ('update gtin ' + @gtin + ' to color ' + @color)

		declare @new_product_id uniqueidentifier set @new_product_id = newid()
		insert into product (product_id, product_name, state_rcd, user_id, date_time) 
			values (@new_product_id, @name, 'C', @user_id, getutcdate());

		insert into product_category_mapping (product_category_mapping_id, product_id, product_category_id, user_id, date_time) 
			values (newid(), @new_product_id, @product_category_id, @user_id, getutcdate());

		insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) 
			values (newid(), @new_product_id, 'Color', @color, @user_id, getutcdate());

		insert into product_identifier (product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time) 
			values (newid(), @new_product_id, 'GTIN13', @gtin, @user_id, getutcdate());

		update product set product_became_id = @new_product_id where product_id = @old_product_id

		fetch next from raw_cursor into @old_product_id, @gtin, @name, @color, @product_category_id
	end
	close raw_cursor   
	deallocate raw_cursor 
end
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductRawLoad",
                Description = "Product Raw Load",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
go
set nocount on
go
begin transaction

-- get system user & system owner ( developer )
declare @user_id uniqueidentifier 
exec get_defaults @user_id out

exec category_basic @user_id
-- print ('category basic')

declare @product_gather_id_1 uniqueidentifier set @product_gather_id_1 = newid();
exec gather_product_set @product_gather_id_1, @user_id
-- print ('gather product set 1')

declare @product_gather_id_2 uniqueidentifier set @product_gather_id_2 = newid();
exec gather_product_set @product_gather_id_2, @user_id
-- print ('gather product set 2')

exec gather_set_move_to_product @product_gather_id_1, @user_id
-- print ('gather set 1 move to product')

-- change a few products color to pink
update product_gather_attribute 
set product_gather_attribute_value = 'Pink'
where product_gather_attribute_type_rcd = 'color'
  and product_gather_key_id in (
	select product_gather_key_id
	from product_gather_key as pgk
	where pgk.product_gather_key_value in (666+5, 666+500, 666+999)
	  and pgk.product_gather_id = @product_gather_id_1
	)

-- print ('updated set 1 to pink')

exec compare_gather_set_to_product @product_gather_id_1, @user_id

-- print ('compare gather set 1 to product')

exec compare_set_move_to_product @product_gather_id_1, @user_id

-- print ('move compare set 1 to product')

-- change a few products color to yellow
update product_gather_attribute 
set product_gather_attribute_value = 'Yellow'
where product_gather_attribute_type_rcd = 'color'
  and product_gather_key_id in (
	select product_gather_key_id
	from product_gather_key as pgk
	where pgk.product_gather_key_value in (666+5, 666+500, 666+999)
	  and pgk.product_gather_id = @product_gather_id_2
	)

-- print ('updated set 2 to yellow')

exec compare_gather_set_to_product @product_gather_id_2, @user_id

-- print ('compare gather set 2 to product')

exec compare_set_move_to_product @product_gather_id_2, @user_id

-- print ('move compare set 2 to product')

-- find category for products with changes
/*
select pi.identifier, pc.product_category_name
from product_identifier as pi
inner join product as p on p.product_id = pi.product_id
					and p.product_became_id is null
inner join product_category_mapping as pcm on pcm.product_id = pi.product_id
inner join product_category as pc on pc.product_category_id = pcm.product_category_id
where pi.identifier = '213'
*/
--where pi.identifier in (666+5, 666+500, 666+999)

commit transaction
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductDuplicateTest",
                Description = "Product Duplicate Test",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
 
go
set nocount on
go
if object_id('duplicate_products') is not null
	drop procedure duplicate_products
go
create procedure duplicate_products(@product_expose_set_id uniqueidentifier, 
									@user_id uniqueidentifier) as begin

	declare @product_to_duplicate_id uniqueidentifier
	declare @product_category_id uniqueidentifier

	declare raw_cursor cursor fast_forward for  
		select   p.product_id
				,pcm.product_category_id
		from product						as p
		inner join product_category_mapping as pcm on pcm.product_id = p.product_id
		inner join product_expose_plan		as pep on pep.product_id = p.product_id	

	open raw_cursor
	fetch next from raw_cursor into @product_to_duplicate_id, @product_category_id

	declare @new_product_id uniqueidentifier 

	while @@fetch_status = 0 begin

		set @new_product_id = newid()
		insert into product (product_id, product_name, state_rcd, user_id, date_time) 
			select  @new_product_id,
					p.product_name,
					dbo.ref('state_ref.C'), 
					@user_id,
					getutcdate()
				from product as p
				where p.product_id = @product_to_duplicate_id 

		insert into product_category_mapping (product_category_mapping_id, product_id, product_category_id, user_id, date_time) 
			values (newid(), @new_product_id, @product_category_id, @user_id, getutcdate());

		insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) 
			select newid(), @new_product_id, pa.product_attribute_rcd, pa.value, @user_id, getutcdate()
			from product_attribute as pa
			where pa.product_id = @product_to_duplicate_id 

		insert into product_identifier(product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time) 
			select newid(), @new_product_id, pa.product_identifier_rcd, pa.identifier, @user_id, getutcdate()
			from product_identifier as pa
			where pa.product_id = @product_to_duplicate_id 

		insert into product_expose (product_expose_id, product_expose_set_id, expose_product_id, expose_based_on_product_id, user_id, date_time)
			select	newid(),
					@product_expose_set_id,
					@new_product_id,
					@product_to_duplicate_id,
					@user_id, 
					getutcdate()
			from product as p
		where p.product_id = @product_to_duplicate_id 

		fetch next from raw_cursor into @product_to_duplicate_id, @product_category_id
	end   

	close raw_cursor   
	deallocate raw_cursor 
end
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductExposeLoad",
                Description = "Product Expose Load",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
go
set nocount on
go
-- get system user ( developer )
declare @user_id uniqueidentifier 
exec get_defaults @user_id out

delete product_expose_plan
delete product_expose

insert into product_expose_plan (product_expose_plan_id, product_expose_set_type_rcd, product_id, user_id, date_time)
	select newid(), 
			dbo.ref('product_expose_set_type_ref.Web'), 
			p.product_id,
			@user_id, 
			getutcdate()
	from product					as p
	inner join product_identifier	as pi on pi.product_id = p.product_id
	where pi.identifier in (666+5, 666+500, 666+999)
		and p.product_became_id is null

declare @product_expose_set_id uniqueidentifier set @product_expose_set_id = newid()

insert into product_expose_set (product_expose_set_id, product_expose_set_type_rcd, product_expose_set_name, user_id, date_time)
	values (@product_expose_set_id, dbo.ref('product_expose_set_type_ref.Web'), 'web expose from load test',@user_id, getutcdate())

exec duplicate_products @product_expose_set_id, @user_id

go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductCartCreateTables",
                Description = "Product Cart Create Tables",
                #region script ( cart_product, cart_product_price )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
create table cart_product_price
(
	cart_product_price_id  uniqueidentifier  not null ,
	financial_currency_id  uniqueidentifier  not null ,
	amount  decimal(15,4)  not null ,
	state_rcd  nvarchar(240)  not null ,
	user_id  uniqueidentifier  not null ,
	date_time  datetime  not null ,
	product_id  uniqueidentifier  not null ,
	constraint  xpkcart_product_price primary key   nonclustered (cart_product_price_id  asc),
	constraint  cart_product_price_to_financial_currency foreign key (financial_currency_id) references financial_currency(financial_currency_id),
    constraint  cart_product_price_to_product foreign key (product_id) references product(product_id)
)
go
create index xif2cart_product_price on cart_product_price
(
	financial_currency_id  asc
)
go
create index xif3cart_product_price on cart_product_price
(
	product_id  asc
)
go
create table cart_product
(
	cart_product_id  uniqueidentifier  not null ,
	client_id  uniqueidentifier  not null ,
	product_id  uniqueidentifier  not null ,
	financial_currency_id  uniqueidentifier  not null ,
	amount  decimal(15,4)  not null ,
	session_id  uniqueidentifier  null ,
	asp_id  uniqueidentifier  null ,
	state_rcd  nvarchar(240)  not null ,
	user_id  uniqueidentifier  not null ,
	date_time  datetime  not null ,
	constraint  xpkcart_product primary key   nonclustered (cart_product_id  asc),
	constraint  cart_product_to_product foreign key (product_id) references product(product_id),
    constraint  cart_product_to_financial_currency foreign key (financial_currency_id) references financial_currency(financial_currency_id),
    constraint  cart_product_to_client foreign key (client_id) references client(client_id)
)
go
create index xif1cart_product on cart_product
(
	product_id  asc
)
go
create index xif2cart_product on cart_product
(
	financial_currency_id  asc
)
go
create index xif3cart_product on cart_product
(
	client_id  asc
)
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 12) },
                ScriptNumber = this.scriptNumber++,
                Name = "ProductLastScript",
                Description = "Product Last Script",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
set nocount on
go

                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });
        }
    }
}
