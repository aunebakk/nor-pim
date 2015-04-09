use norpim
go
-- base
declare @user_id uniqueidentifier set @user_id = '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}'

insert into state_ref (state_rcd, state_name, date_time) values ('C', 'Created', getutcdate());
insert into state_ref (state_rcd, state_name, date_time) values ('U', 'Updated', getutcdate());
insert into state_ref (state_rcd, state_name, date_time) values ('I', 'Invalidated', getutcdate());

insert into [user] (user_id, user_code, user_name, state_rcd, created_by_user_id, date_time) 
	values (@user_id, 'SUX', 'System user X', 'C', @user_id, getutcdate());

-- product
insert into product_attribute_ref (product_attribute_rcd, product_attribute_name, user_id, date_time) values ('Color', 'Color', @user_id, getutcdate());

insert into product_identifier_ref (product_identifier_rcd, product_identifier_name, user_id, date_time) values ('GTIN', 'GTIN', @user_id, getutcdate());
insert into product_identifier_ref (product_identifier_rcd, product_identifier_name, user_id, date_time) values ('HN', 'HN', @user_id, getutcdate());

insert into product_expose_set_type_ref (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time) values ('Web', 'Web', @user_id, getutcdate());
insert into product_expose_set_type_ref (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time) values ('Print', 'Print', @user_id, getutcdate());
insert into product_expose_set_type_ref (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time) values ('Export', 'Export', @user_id, getutcdate());
insert into product_expose_set_type_ref (product_expose_set_type_rcd, product_expose_set_type_name, user_id, date_time) values ('Customer', 'Customer', @user_id, getutcdate());

insert into product_image_type_ref (product_image_type_rcd, product_image_type_name, user_id, date_time) values ('PI', 'Product image variable size', @user_id, getutcdate());
insert into product_image_type_ref (product_image_type_rcd, product_image_type_name, user_id, date_time) values ('ISP', 'Internal Stock Photo', @user_id, getutcdate());

insert into product_documentation_type_ref (product_documentation_type_rcd, product_documentation_type_name, user_id, date_time) values ('SD', 'Short description', @user_id, getutcdate());
insert into product_documentation_type_ref (product_documentation_type_rcd, product_documentation_type_name, user_id, date_time) values ('LD', 'Long description', @user_id, getutcdate());
insert into product_documentation_type_ref (product_documentation_type_rcd, product_documentation_type_name, user_id, date_time) values ('HD', 'Headline', @user_id, getutcdate());

insert into product_category_documentation_type_ref (product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time) values ('TT', 'Top text', @user_id, getutcdate());
insert into product_category_documentation_type_ref (product_category_documentation_type_rcd, product_category_documentation_type_name, user_id, date_time) values ('BT', 'Bottom text', @user_id, getutcdate());

insert into product_category_image_type_ref (product_category_image_type_rcd, product_category_image_type_name, user_id, date_time) values ('SS', 'Small size', @user_id, getutcdate());
insert into product_category_image_type_ref (product_category_image_type_rcd, product_category_image_type_name, user_id, date_time) values ('LS', 'Large size', @user_id, getutcdate());

insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_attribute_ref'						,'Product Attribute'						,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_info_ref'							,'Product Info'								,@user_id, getutcdate());	
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_identifier_ref'						,'Product Identifier'						,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'state_ref'									,'State'									,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_image_type_ref'						,'Product Image Type'						,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_documentation_type_ref'				,'Product Documentation Type'				,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_gather_source_type_ref'				,'Product Information Source Type'			,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_gather_attribute_type_ref'			,'Product Gather Attribute Type'			,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_category_documentation_type_ref'	,'Product Category Documentation Type'		,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_attribute_unit_ref'					,'Product Attribute Unit'					,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'product_category_image_type_ref'			,'Product Category Image Type'				,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'user_activity_type_ref'						,'User Activity Type'						,@user_id, getutcdate());
insert into system_reference_table(system_reference_table_id, system_reference_table_name, system_reference_display_name, user_id, date_time) values (newid(), 'system_setting_ref'							,'System Setting'							,@user_id, getutcdate());

insert into user_activity_type_ref(user_activity_type_rcd, user_activity_type_name, user_id, date_time) 
	values ('li', 'Login', @user_id, getutcdate());
insert into user_activity_type_ref(user_activity_type_rcd, user_activity_type_name, user_id, date_time) 
	values ('lo', 'Logout', @user_id, getutcdate());
insert into user_activity_type_ref(user_activity_type_rcd, user_activity_type_name, user_id, date_time) 
	values ('fo', 'Form Opened', @user_id, getutcdate());
insert into user_activity_type_ref(user_activity_type_rcd, user_activity_type_name, user_id, date_time) 
	values ('blmi', 'Business Logic Method Invoked', @user_id, getutcdate());
insert into user_activity_type_ref(user_activity_type_rcd, user_activity_type_name, user_id, date_time) 
	values ('wpo', 'Web Page Opened', @user_id, getutcdate());
insert into user_activity_type_ref(user_activity_type_rcd, user_activity_type_name, user_id, date_time) 
	values ('se', 'Scheduled Event', @user_id, getutcdate());

insert into system_setting_ref (system_setting_rcd, system_setting_name, user_id, date_time) values ('dcs', 'Dark color scheme', @user_id, getutcdate());
insert into system_setting_ref (system_setting_rcd, system_setting_name, user_id, date_time) values ('pl', 'Product grid layout', @user_id, getutcdate());

insert into product_gather_source_type_ref (product_gather_source_type_rcd, product_gather_source_type_name, user_id, date_time) values ('tsql', 'TSQL script', @user_id, getutcdate());

insert into product_gather_attribute_type_ref (product_gather_attribute_type_rcd, product_gather_attribute_type_name, user_id, date_time) values ('name', 'Name', @user_id, getutcdate())
insert into product_gather_attribute_type_ref (product_gather_attribute_type_rcd, product_gather_attribute_type_name, user_id, date_time) values ('color', 'Color', @user_id, getutcdate())



