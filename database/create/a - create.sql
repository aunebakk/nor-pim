use norpim
go

set quoted_identifier on
go


DROP TABLE "product_field_set_mapping"
go


DROP TABLE "product_field_set"
go


DROP TABLE "product_identifier"
go


DROP TABLE "product_identifier_ref"
go


DROP TABLE "product_attribute"
go


DROP TABLE "product_attribute_unit_ref"
go


DROP TABLE "product_attribute_ref"
go


DROP TABLE "product_info"
go


DROP TABLE "product_info_ref"
go


DROP TABLE "product_category_mapping"
go


DROP TABLE "product_supplier"
go


DROP TABLE "product_exposed_selection"
go


DROP TABLE "product_expose"
go


DROP TABLE "product_expose_set"
go


DROP TABLE "product_change_set"
go


DROP TABLE "product_image"
go


DROP TABLE "product_image_type_ref"
go


DROP TABLE "product_documentation"
go


DROP TABLE "product_documentation_type_ref"
go


DROP TABLE "product_category_documentation"
go


DROP TABLE "product_category_documentation_type_ref"
go


DROP TABLE "product_category_image"
go


DROP TABLE "product_category_image_type_ref"
go


DROP TABLE "product_category"
go


DROP TABLE "user_activity"
go


DROP TABLE "user_activity_type_ref"
go


DROP TABLE "system_reference_table"
go


DROP TABLE "product_expose_plan"
go


DROP TABLE "product_expose_set_type_ref"
go


DROP TABLE "product"
go


DROP TABLE "user"
go


DROP TABLE "state_ref"
go


DROP TABLE "product_gather_attribute"
go


DROP TABLE "product_gather_key"
go


DROP TABLE "product_gather_attribute_type_ref"
go


DROP TABLE "product_gather_source"
go


DROP TABLE "product_gather_source_type_ref"
go


DROP TABLE "product_gather"
go


DROP TABLE "system_setting"
go


DROP TABLE "system_setting_ref"
go


CREATE TABLE "system_setting_ref"
(
	"system_setting_rcd"  nvarchar(240)  NOT NULL ,
	"system_setting_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKsystem_setting_ref" PRIMARY KEY   CLUSTERED ("system_setting_rcd"  ASC)
)
go


CREATE TABLE "system_setting"
(
	"system_setting_id"  uniqueidentifier  NOT NULL ,
	"system_setting_rcd"  nvarchar(240)  NOT NULL ,
	"system_setting_value"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKsystem_setting" PRIMARY KEY   CLUSTERED ("system_setting_id"  ASC),
	CONSTRAINT  "system_setting_to_system_setting_ref" FOREIGN KEY ("system_setting_rcd") REFERENCES "system_setting_ref"("system_setting_rcd")
)
go


CREATE INDEX "XIF1system_setting" ON "system_setting"
(
	"system_setting_rcd"  ASC
)
go


CREATE TABLE "product_gather"
(
	"product_gather_id"  uniqueidentifier  NOT NULL ,
	"start_date_time"  datetime  NOT NULL ,
	"finish_date_time"  datetime  NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_gather" PRIMARY KEY   CLUSTERED ("product_gather_id"  ASC)
)
go


CREATE TABLE "product_gather_source_type_ref"
(
	"product_gather_source_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_gather_source_type_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_gather_source_type_ref" PRIMARY KEY   CLUSTERED ("product_gather_source_type_rcd"  ASC)
)
go


CREATE TABLE "product_gather_source"
(
	"product_gather_source_id"  uniqueidentifier  NOT NULL ,
	"product_gather_id"  uniqueidentifier  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	"product_gather_source_type_rcd"  nvarchar(240)  NOT NULL ,
	CONSTRAINT  "XPKproduct_gather_source" PRIMARY KEY   CLUSTERED ("product_gather_source_id"  ASC),
	CONSTRAINT  "product_gather_source_to_product_gather" FOREIGN KEY ("product_gather_id") REFERENCES "product_gather"("product_gather_id"),
CONSTRAINT  "product_gather_source_to_product_gather_source_type_ref" FOREIGN KEY ("product_gather_source_type_rcd") REFERENCES "product_gather_source_type_ref"("product_gather_source_type_rcd")
)
go


CREATE INDEX "XIF1product_gather_source" ON "product_gather_source"
(
	"product_gather_id"  ASC
)
go


CREATE INDEX "XIF2product_gather_source" ON "product_gather_source"
(
	"product_gather_source_type_rcd"  ASC
)
go


CREATE TABLE "product_gather_attribute_type_ref"
(
	"product_gather_attribute_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_gather_attribute_type_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_gather_attribute_type_ref" PRIMARY KEY   CLUSTERED ("product_gather_attribute_type_rcd"  ASC)
)
go


CREATE TABLE "product_gather_key"
(
	"product_gather_key_id"  uniqueidentifier  NOT NULL ,
	"product_gather_key_value"  nvarchar(240)  NOT NULL ,
	"product_gather_id"  uniqueidentifier  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_gather_key" PRIMARY KEY   CLUSTERED ("product_gather_key_id"  ASC),
	CONSTRAINT  "product_gather_key_to_product_gathering" FOREIGN KEY ("product_gather_id") REFERENCES "product_gather"("product_gather_id")
)
go


CREATE INDEX "XIF1product_gather_key" ON "product_gather_key"
(
	"product_gather_id"  ASC
)
go


CREATE TABLE "product_gather_attribute"
(
	"product_gather_attribute_id"  uniqueidentifier  NOT NULL ,
	"product_gather_attribute_value"  nvarchar(240)  NOT NULL ,
	"product_gather_attribute_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_gather_key_id"  uniqueidentifier  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_gather_attribute" PRIMARY KEY   CLUSTERED ("product_gather_attribute_id"  ASC),
	CONSTRAINT  "product_gather_attribute_to_product_gather_attribute_type_ref" FOREIGN KEY ("product_gather_attribute_type_rcd") REFERENCES "product_gather_attribute_type_ref"("product_gather_attribute_type_rcd"),
CONSTRAINT  "product_gather_attribute_to_product_gather_key" FOREIGN KEY ("product_gather_key_id") REFERENCES "product_gather_key"("product_gather_key_id")
)
go


CREATE INDEX "XIF1product_gather_attribute" ON "product_gather_attribute"
(
	"product_gather_attribute_type_rcd"  ASC
)
go


CREATE INDEX "XIF3product_gather_attribute" ON "product_gather_attribute"
(
	"product_gather_key_id"  ASC
)
go


CREATE TABLE "state_ref"
(
	"state_rcd"  nvarchar(240)  NOT NULL ,
	"state_name"  nvarchar(240)  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKstate_ref" PRIMARY KEY   CLUSTERED ("state_rcd"  ASC)
)
go


CREATE TABLE "user"
(
	"user_id"  uniqueidentifier  NOT NULL ,
	"user_code"  nvarchar(240)  NOT NULL ,
	"user_name"  nvarchar(240)  NOT NULL ,
	"email"  nvarchar(240)  NULL ,
	"password"  nvarchar(240)  NULL ,
	"state_rcd"  nvarchar(240)  NOT NULL ,
	"created_by_user_id"  uniqueidentifier  NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKuser" PRIMARY KEY   CLUSTERED ("user_id"  ASC),
	CONSTRAINT  "user_to_created_by_user" FOREIGN KEY ("created_by_user_id") REFERENCES "user"("user_id"),
CONSTRAINT  "user_to_state" FOREIGN KEY ("state_rcd") REFERENCES "state_ref"("state_rcd")
)
go


CREATE INDEX "XIF1user" ON "user"
(
	"created_by_user_id"  ASC
)
go


CREATE INDEX "XIF2user" ON "user"
(
	"state_rcd"  ASC
)
go


CREATE TABLE "product"
(
	"product_id"  uniqueidentifier  NOT NULL ,
	"product_became_id"  uniqueidentifier  NULL ,
	"product_name"  nvarchar(240)  NOT NULL ,
	"state_rcd"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct" PRIMARY KEY   CLUSTERED ("product_id"  ASC),
	CONSTRAINT  "product_to_state" FOREIGN KEY ("state_rcd") REFERENCES "state_ref"("state_rcd"),
CONSTRAINT  "product_to_user" FOREIGN KEY ("user_id") REFERENCES "user"("user_id"),
CONSTRAINT  "product_to_product_became" FOREIGN KEY ("product_became_id") REFERENCES "product"("product_id")
)
go


CREATE INDEX "XIF3product" ON "product"
(
	"state_rcd"  ASC
)
go


CREATE INDEX "XIF4product" ON "product"
(
	"user_id"  ASC
)
go


CREATE INDEX "XIF5product" ON "product"
(
	"product_became_id"  ASC
)
go


CREATE TABLE "product_expose_set_type_ref"
(
	"product_expose_set_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_expose_set_type_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_expose_set_type_ref" PRIMARY KEY   CLUSTERED ("product_expose_set_type_rcd"  ASC)
)
go


CREATE TABLE "product_expose_plan"
(
	"product_expose_plan_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"product_expose_set_type_rcd"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_expose_plan" PRIMARY KEY   CLUSTERED ("product_expose_plan_id"  ASC),
	CONSTRAINT  "product_exposure_plan_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id"),
CONSTRAINT  "product_exporsure_plan_to_product_exposure_set_type_ref" FOREIGN KEY ("product_expose_set_type_rcd") REFERENCES "product_expose_set_type_ref"("product_expose_set_type_rcd")
)
go


CREATE INDEX "XIF1product_expose_plan" ON "product_expose_plan"
(
	"product_id"  ASC
)
go


CREATE INDEX "XIF2product_expose_plan" ON "product_expose_plan"
(
	"product_expose_set_type_rcd"  ASC
)
go


CREATE TABLE "system_reference_table"
(
	"system_reference_table_id"  uniqueidentifier  NOT NULL ,
	"system_reference_table_name"  nvarchar(240)  NOT NULL ,
	"system_reference_display_name"  nvarchar(240)  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	CONSTRAINT  "XPKsystem_reference_table" PRIMARY KEY   CLUSTERED ("system_reference_table_id"  ASC),
	CONSTRAINT  "system_reference_table_to_user" FOREIGN KEY ("user_id") REFERENCES "user"("user_id")
)
go


CREATE INDEX "XIF1system_reference_table" ON "system_reference_table"
(
	"user_id"  ASC
)
go


CREATE TABLE "user_activity_type_ref"
(
	"user_activity_type_rcd"  nvarchar(240)  NOT NULL ,
	"user_activity_type_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKuser_activity_type_ref" PRIMARY KEY   CLUSTERED ("user_activity_type_rcd"  ASC)
)
go


CREATE TABLE "user_activity"
(
	"user_activity_id"  uniqueidentifier  NOT NULL ,
	"user_activity_type_rcd"  nvarchar(240)  NOT NULL ,
	"user_activity_note"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	"originating_address"  nvarchar(240)  NOT NULL ,
	CONSTRAINT  "XPKuser_activity" PRIMARY KEY   CLUSTERED ("user_activity_id"  ASC),
	CONSTRAINT  "user_activity_to_user" FOREIGN KEY ("user_id") REFERENCES "user"("user_id"),
CONSTRAINT  "user_activity_to_user_activity_type_ref" FOREIGN KEY ("user_activity_type_rcd") REFERENCES "user_activity_type_ref"("user_activity_type_rcd")
)
go


CREATE INDEX "XIF1user_activity" ON "user_activity"
(
	"user_id"  ASC
)
go


CREATE INDEX "XIF2user_activity" ON "user_activity"
(
	"user_activity_type_rcd"  ASC
)
go


CREATE TABLE "product_category"
(
	"product_category_id"  uniqueidentifier  NOT NULL ,
	"product_category_became_id"  uniqueidentifier  NULL ,
	"product_category_parent_id"  uniqueidentifier  NOT NULL ,
	"product_category_code"  nvarchar(240)  NOT NULL ,
	"product_category_name"  nvarchar(240)  NOT NULL ,
	"product_category_position"  integer  NOT NULL ,
	"state_rcd"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_category" PRIMARY KEY   CLUSTERED ("product_category_id"  ASC),
	CONSTRAINT  "product_category_to_product_category_parent" FOREIGN KEY ("product_category_parent_id") REFERENCES "product_category"("product_category_id"),
CONSTRAINT  "product_category_to_state" FOREIGN KEY ("state_rcd") REFERENCES "state_ref"("state_rcd"),
CONSTRAINT  "product_category_to_product_category_became" FOREIGN KEY ("product_category_became_id") REFERENCES "product_category"("product_category_id")
)
go


CREATE INDEX "XIF3product_category" ON "product_category"
(
	"product_category_parent_id"  ASC
)
go


CREATE INDEX "XIF4product_category" ON "product_category"
(
	"state_rcd"  ASC
)
go


CREATE INDEX "XIF5product_category" ON "product_category"
(
	"product_category_became_id"  ASC
)
go


CREATE TABLE "product_category_image_type_ref"
(
	"product_category_image_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_category_image_type_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_category_image_type_ref" PRIMARY KEY   CLUSTERED ("product_category_image_type_rcd"  ASC)
)
go


CREATE TABLE "product_category_image"
(
	"product_category_image_id"  uniqueidentifier  NOT NULL ,
	"product_category_id"  uniqueidentifier  NOT NULL ,
	"product_category_image_type_rcd"  nvarchar(240)  NOT NULL ,
	"image"  varbinary(max)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_category_image" PRIMARY KEY   CLUSTERED ("product_category_image_id"  ASC),
	CONSTRAINT  "product_category_image_to_product_category" FOREIGN KEY ("product_category_id") REFERENCES "product_category"("product_category_id"),
CONSTRAINT  "product_category_image_type_to_product_category_image_type_ref" FOREIGN KEY ("product_category_image_type_rcd") REFERENCES "product_category_image_type_ref"("product_category_image_type_rcd")
)
go


CREATE INDEX "XIF1product_category_image" ON "product_category_image"
(
	"product_category_id"  ASC
)
go


CREATE INDEX "XIF2product_category_image" ON "product_category_image"
(
	"product_category_image_type_rcd"  ASC
)
go


CREATE TABLE "product_category_documentation_type_ref"
(
	"product_category_documentation_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_category_documentation_type_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_category_documentation_type_ref" PRIMARY KEY   CLUSTERED ("product_category_documentation_type_rcd"  ASC)
)
go


CREATE TABLE "product_category_documentation"
(
	"product_category_documentation_id"  uniqueidentifier  NOT NULL ,
	"product_category_documentation_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_category_id"  uniqueidentifier  NOT NULL ,
	"documentation"  text  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_category_documentation" PRIMARY KEY   CLUSTERED ("product_category_documentation_id"  ASC),
	CONSTRAINT  "product_category_documentation_to_product_category_documentation_type_ref" FOREIGN KEY ("product_category_documentation_type_rcd") REFERENCES "product_category_documentation_type_ref"("product_category_documentation_type_rcd"),
CONSTRAINT  "product_category_documentation_to_product_category" FOREIGN KEY ("product_category_id") REFERENCES "product_category"("product_category_id")
)
go


CREATE INDEX "XIF1product_category_documentation" ON "product_category_documentation"
(
	"product_category_documentation_type_rcd"  ASC
)
go


CREATE INDEX "XIF2product_category_documentation" ON "product_category_documentation"
(
	"product_category_id"  ASC
)
go


CREATE TABLE "product_documentation_type_ref"
(
	"product_documentation_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_documentation_type_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_documentation_type_ref" PRIMARY KEY   CLUSTERED ("product_documentation_type_rcd"  ASC)
)
go


CREATE TABLE "product_documentation"
(
	"product_documentation_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"product_documentation_type_rcd"  nvarchar(240)  NOT NULL ,
	"documentation"  text  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_documentation" PRIMARY KEY   CLUSTERED ("product_documentation_id"  ASC),
	CONSTRAINT  "product_documentation_to_product_documentation_type_ref" FOREIGN KEY ("product_documentation_type_rcd") REFERENCES "product_documentation_type_ref"("product_documentation_type_rcd"),
CONSTRAINT  "product_documentation_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id")
)
go


CREATE INDEX "XIF1product_documentation" ON "product_documentation"
(
	"product_documentation_type_rcd"  ASC
)
go


CREATE INDEX "XIF2product_documentation" ON "product_documentation"
(
	"product_id"  ASC
)
go


CREATE TABLE "product_image_type_ref"
(
	"product_image_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_image_type_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_image_type_ref" PRIMARY KEY   CLUSTERED ("product_image_type_rcd"  ASC)
)
go


CREATE TABLE "product_image"
(
	"product_image_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"product_image_type_rcd"  nvarchar(240)  NOT NULL ,
	"image"  varbinary(max)  NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	"image_file_name"  nvarchar(240)  NULL ,
	CONSTRAINT  "XPKproduct_image" PRIMARY KEY   CLUSTERED ("product_image_id"  ASC),
	CONSTRAINT  "product_image_to_product_image_ref" FOREIGN KEY ("product_image_type_rcd") REFERENCES "product_image_type_ref"("product_image_type_rcd"),
CONSTRAINT  "product_image_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id")
)
go


CREATE INDEX "XIF1product_image" ON "product_image"
(
	"product_image_type_rcd"  ASC
)
go


CREATE INDEX "XIF2product_image" ON "product_image"
(
	"product_id"  ASC
)
go


CREATE TABLE "product_change_set"
(
	"product_change_set_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"product_gather_key_id"  uniqueidentifier  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_change_set" PRIMARY KEY   CLUSTERED ("product_change_set_id"  ASC),
	CONSTRAINT  "product_change_set_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id"),
CONSTRAINT  "product_change_set_to_product_gather_key" FOREIGN KEY ("product_gather_key_id") REFERENCES "product_gather_key"("product_gather_key_id")
)
go


CREATE INDEX "XIF2product_change_set" ON "product_change_set"
(
	"product_id"  ASC
)
go


CREATE INDEX "XIF3product_change_set" ON "product_change_set"
(
	"product_gather_key_id"  ASC
)
go


CREATE TABLE "product_expose_set"
(
	"product_expose_set_id"  uniqueidentifier  NOT NULL ,
	"product_expose_set_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_expose_set_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_expose_set" PRIMARY KEY   CLUSTERED ("product_expose_set_id"  ASC),
	CONSTRAINT  "product_expose_set_to_product_expose_set_type_ref" FOREIGN KEY ("product_expose_set_type_rcd") REFERENCES "product_expose_set_type_ref"("product_expose_set_type_rcd")
)
go


CREATE INDEX "XIF1product_expose_set" ON "product_expose_set"
(
	"product_expose_set_type_rcd"  ASC
)
go


CREATE TABLE "product_expose"
(
	"product_expose_id"  uniqueidentifier  NOT NULL ,
	"expose_product_id"  uniqueidentifier  NOT NULL ,
	"expose_based_on_product_id"  uniqueidentifier  NOT NULL ,
	"product_expose_set_id"  uniqueidentifier  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_expose" PRIMARY KEY   CLUSTERED ("product_expose_id"  ASC),
	CONSTRAINT  "product_expose_to_product" FOREIGN KEY ("expose_product_id") REFERENCES "product"("product_id"),
CONSTRAINT  "product_exposed_to_product_expose_set" FOREIGN KEY ("product_expose_set_id") REFERENCES "product_expose_set"("product_expose_set_id"),
CONSTRAINT  "product_expose_to_based_on_product" FOREIGN KEY ("expose_based_on_product_id") REFERENCES "product"("product_id")
)
go


CREATE INDEX "XIF1product_expose" ON "product_expose"
(
	"expose_product_id"  ASC
)
go


CREATE INDEX "XIF2product_expose" ON "product_expose"
(
	"product_expose_set_id"  ASC
)
go


CREATE INDEX "XIF3product_expose" ON "product_expose"
(
	"expose_based_on_product_id"  ASC
)
go


CREATE TABLE "product_exposed_selection"
(
	"product_exposed_selection_id"  uniqueidentifier  NOT NULL ,
	"product_expose_id"  uniqueidentifier  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_exposed_selection" PRIMARY KEY   CLUSTERED ("product_exposed_selection_id"  ASC),
	CONSTRAINT  "product_exposed_selection_to_product_exposed" FOREIGN KEY ("product_expose_id") REFERENCES "product_expose"("product_expose_id")
)
go


CREATE INDEX "XIF1product_exposed_selection" ON "product_exposed_selection"
(
	"product_expose_id"  ASC
)
go


CREATE TABLE "product_supplier"
(
	"product_supplier_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"supplier_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_supplier" PRIMARY KEY   CLUSTERED ("product_supplier_id"  ASC),
	CONSTRAINT  "product_supplier_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id")
)
go


CREATE INDEX "XIF1product_supplier" ON "product_supplier"
(
	"product_id"  ASC
)
go


CREATE TABLE "product_category_mapping"
(
	"product_category_mapping_id"  uniqueidentifier  NOT NULL ,
	"product_category_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_category_mapping" PRIMARY KEY   CLUSTERED ("product_category_mapping_id"  ASC),
	CONSTRAINT  "product_category_mapping_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id"),
CONSTRAINT  "product_category_mapping_to_product_category" FOREIGN KEY ("product_category_id") REFERENCES "product_category"("product_category_id")
)
go


CREATE INDEX "XIF1product_category_mapping" ON "product_category_mapping"
(
	"product_id"  ASC
)
go


CREATE INDEX "XIF2product_category_mapping" ON "product_category_mapping"
(
	"product_category_id"  ASC
)
go


CREATE TABLE "product_info_ref"
(
	"product_info_rcd"  nvarchar(240)  NOT NULL ,
	"product_info_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_info_ref" PRIMARY KEY   CLUSTERED ("product_info_rcd"  ASC)
)
go


CREATE TABLE "product_info"
(
	"product_info_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"product_info_rcd"  nvarchar(240)  NOT NULL ,
	"product_info_value"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_info" PRIMARY KEY   CLUSTERED ("product_info_id"  ASC),
	CONSTRAINT  "product_info_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id"),
CONSTRAINT  "product_info_to_product_info_ref" FOREIGN KEY ("product_info_rcd") REFERENCES "product_info_ref"("product_info_rcd")
)
go


CREATE INDEX "XIF2product_info" ON "product_info"
(
	"product_id"  ASC
)
go


CREATE INDEX "XIF3product_info" ON "product_info"
(
	"product_info_rcd"  ASC
)
go


CREATE TABLE "product_attribute_ref"
(
	"product_attribute_rcd"  nvarchar(240)  NOT NULL ,
	"product_attribute_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_attribute_ref" PRIMARY KEY   CLUSTERED ("product_attribute_rcd"  ASC)
)
go


CREATE TABLE "product_attribute_unit_ref"
(
	"product_attribute_unit_rcd"  nvarchar(240)  NOT NULL ,
	"product_attribute_unit_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_attribute_unit_ref" PRIMARY KEY   CLUSTERED ("product_attribute_unit_rcd"  ASC)
)
go


CREATE TABLE "product_attribute"
(
	"product_attribute_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"product_attribute_rcd"  nvarchar(240)  NOT NULL ,
	"product_attribute_unit_rcd"  nvarchar(240)  NULL ,
	"value"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_attribute" PRIMARY KEY   CLUSTERED ("product_attribute_id"  ASC),
	CONSTRAINT  "product_attribute_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id"),
CONSTRAINT  "product_attribute_to_product_attribute_ref" FOREIGN KEY ("product_attribute_rcd") REFERENCES "product_attribute_ref"("product_attribute_rcd"),
CONSTRAINT  "product_attribute_to_product_attribute_unit_ref" FOREIGN KEY ("product_attribute_unit_rcd") REFERENCES "product_attribute_unit_ref"("product_attribute_unit_rcd")
)
go


CREATE INDEX "XIF1product_attribute" ON "product_attribute"
(
	"product_id"  ASC
)
go


CREATE INDEX "XIF2product_attribute" ON "product_attribute"
(
	"product_attribute_rcd"  ASC
)
go


CREATE INDEX "XIF3product_attribute" ON "product_attribute"
(
	"product_attribute_unit_rcd"  ASC
)
go


CREATE TABLE "product_identifier_ref"
(
	"product_identifier_rcd"  nvarchar(240)  NOT NULL ,
	"product_identifier_name"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_identifier_ref" PRIMARY KEY   CLUSTERED ("product_identifier_rcd"  ASC)
)
go


CREATE TABLE "product_identifier"
(
	"product_identifier_id"  uniqueidentifier  NOT NULL ,
	"product_id"  uniqueidentifier  NOT NULL ,
	"product_identifier_rcd"  nvarchar(240)  NOT NULL ,
	"identifier"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_identifier" PRIMARY KEY   CLUSTERED ("product_identifier_id"  ASC),
	CONSTRAINT  "product_identifier_to_product_identifier_ref" FOREIGN KEY ("product_identifier_rcd") REFERENCES "product_identifier_ref"("product_identifier_rcd"),
CONSTRAINT  "product_identifier_to_product" FOREIGN KEY ("product_id") REFERENCES "product"("product_id")
)
go


CREATE INDEX "XIF2product_identifier" ON "product_identifier"
(
	"product_identifier_rcd"  ASC
)
go


CREATE INDEX "XIF3product_identifier" ON "product_identifier"
(
	"product_id"  ASC
)
go


CREATE TABLE "product_field_set"
(
	"product_field_set_id"  uniqueidentifier  NOT NULL ,
	"product_field_set_name"  char(18)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_field_set" PRIMARY KEY   NONCLUSTERED ("product_field_set_id"  ASC)
)
go


CREATE TABLE "product_field_set_mapping"
(
	"product_field_set_mapping_id"  uniqueidentifier  NOT NULL ,
	"product_field_set_id"  uniqueidentifier  NOT NULL ,
	"product_identifier_rcd"  nvarchar(240)  NOT NULL ,
	"product_attribute_rcd"  nvarchar(240)  NOT NULL ,
	"product_info_rcd"  nvarchar(240)  NOT NULL ,
	"product_image_type_rcd"  nvarchar(240)  NOT NULL ,
	"product_documentation_type_rcd"  nvarchar(240)  NOT NULL ,
	"user_id"  uniqueidentifier  NOT NULL ,
	"date_time"  datetime  NOT NULL ,
	CONSTRAINT  "XPKproduct_field_set_mapping" PRIMARY KEY   NONCLUSTERED ("product_field_set_mapping_id"  ASC),
	CONSTRAINT  "product_field_set_mapping_to_product_field_set" FOREIGN KEY ("product_field_set_id") REFERENCES "product_field_set"("product_field_set_id"),
CONSTRAINT  "product_field_set_mapping_to_product_identifier_ref" FOREIGN KEY ("product_identifier_rcd") REFERENCES "product_identifier_ref"("product_identifier_rcd"),
CONSTRAINT  "product_field_set_mapping_to_product_attribute_ref" FOREIGN KEY ("product_attribute_rcd") REFERENCES "product_attribute_ref"("product_attribute_rcd"),
CONSTRAINT  "product_field_set_mapping_to_product_info_ref" FOREIGN KEY ("product_info_rcd") REFERENCES "product_info_ref"("product_info_rcd"),
CONSTRAINT  "product_field_set_mapping_to_product_image_type_ref" FOREIGN KEY ("product_image_type_rcd") REFERENCES "product_image_type_ref"("product_image_type_rcd"),
CONSTRAINT  "product_field_set_mapping_to_product_documentation_type_ref" FOREIGN KEY ("product_documentation_type_rcd") REFERENCES "product_documentation_type_ref"("product_documentation_type_rcd")
)
go


CREATE INDEX "XIF1product_field_set_mapping" ON "product_field_set_mapping"
(
	"product_field_set_id"  ASC
)
go


CREATE INDEX "XIF2product_field_set_mapping" ON "product_field_set_mapping"
(
	"product_identifier_rcd"  ASC
)
go


CREATE INDEX "XIF3product_field_set_mapping" ON "product_field_set_mapping"
(
	"product_attribute_rcd"  ASC
)
go


CREATE INDEX "XIF4product_field_set_mapping" ON "product_field_set_mapping"
(
	"product_info_rcd"  ASC
)
go


CREATE INDEX "XIF5product_field_set_mapping" ON "product_field_set_mapping"
(
	"product_image_type_rcd"  ASC
)
go


CREATE INDEX "XIF6product_field_set_mapping" ON "product_field_set_mapping"
(
	"product_documentation_type_rcd"  ASC
)
go


