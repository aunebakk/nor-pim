if object_id('dbo.random_latin') is not null
	drop function dbo.random_latin
go
create function dbo.random_latin()
returns nvarchar(2400) as begin
	-- not so random latin
	return 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.'
end
go
if object_id('dbo.ipsum') is not null
	drop function dbo.ipsum
go
create function dbo.ipsum(@rand float)
returns nvarchar(2400) as begin
	declare 
		@lorem nvarchar(max)
		,@pos int
		,@pos2 int
	
	select
	--    @lorem = 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.'
		@lorem = 'Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum'

	while 1=1 begin
		set @pos = cast(@rand * Len(@lorem) as int)
		set @pos = charindex(' ', @lorem, @pos)
		set @pos2 = charindex(' ', @lorem, @pos + 20)
		if @pos2 + 20 < len(@lorem) and @pos2 != 0 break
		set @rand = @rand * 0.1
	end

	return lower(substring(@lorem, @pos, @pos2 - @pos))
end
go
if object_id('dbo.product_insert') is not null
	drop procedure dbo.product_insert
go
create procedure product_insert(
	@product_category_parent_id_3 uniqueidentifier, 
	@chapter_text nvarchar(240), 
	@chapter_name_last nvarchar(240)) as begin

	-- products
	declare @product_count int = 0
	while @product_count < 10 begin
		declare @new_product_id uniqueidentifier set @new_product_id = newid();
		insert into product (product_id, product_name, state_rcd, user_id, date_time)
				values (@new_product_id, 
									' ( ' + @chapter_text + ' )'										+ ' ' + @chapter_name_last
									+ ' ' + cast(abs(checksum(newid())) % 14 + 1 as varchar)  + ' mm'	+ ' ' + dbo.random_color()
									+ ' ' + dbo.random_period(),
						'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate() );
		insert into product_category_mapping(	product_category_mapping_id, 	product_category_id, 			product_id, 		user_id, 									date_time				) values (
												newid(), 						@product_category_parent_id_3, 	@new_product_id,	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', 	getutcdate()			)

		-- attributes
		insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) 
			values (newid(), @new_product_id, dbo.ref('product_attribute_ref.Color'), 
			dbo.random_color(),																	-- random color
			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

		insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) 
			values (newid(), @new_product_id, dbo.ref('product_attribute_ref.H'), 
			cast(abs(checksum(newid())) % 14 + 1 as varchar)  + ' mm',							-- random positive number and 'mm'
			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

		insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) 
			values (newid(), @new_product_id, dbo.ref('product_attribute_ref.L'), 
			cast(abs(checksum(newid())) % 14 + 1 as varchar)  + ' mm',							-- random positive number and 'mm'
			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

		insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) 
			values (newid(), @new_product_id, dbo.ref('product_attribute_ref.RKM'), 
			cast(abs(checksum(newid())) % 14 + 1 as varchar),									-- random positive number
			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

		insert into product_identifier (product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time)
			values (newid(), @new_product_id, dbo.ref('product_identifier_ref.GTIN13'), 
			left(replace(CAST(CAST(CRYPT_GEN_RANDOM(8) AS bigint) as varchar), '-', ''), 13),	-- random 13 char long positive number
			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

		insert into product_identifier (product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time)
			values (newid(), @new_product_id, dbo.ref('product_identifier_ref.GTIN14'), 
			left(replace(CAST(CAST(CRYPT_GEN_RANDOM(8) AS bigint) as varchar), '-', ''), 14),	-- random 14 char long positive number
			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

		insert into product_info (product_info_id, product_id, product_info_rcd, product_info_value, user_id, date_time)
			values (newid(), @new_product_id, dbo.ref('product_info_ref.PI'), 
			left(replace(CAST(CAST(CRYPT_GEN_RANDOM(8) AS bigint) as varchar), '-', ''), 14),	-- random 14 char long positive number
			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

		insert into product_documentation (product_documentation_id, product_id, product_documentation_type_rcd, documentation, user_id, date_time)
			values (newid(), @new_product_id, dbo.ref('product_documentation_type_ref.HD'), 
			dbo.random_latin(),																	-- not so random latin
			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

		set @product_count = @product_count + 1
	end
end
go
delete product_category_documentation
go
delete from product_category_mapping
go
delete from product_category_image
go
delete from product_category
go
--delete from product
go
declare @level_1 int = 01
while @level_1 < 15 begin
	declare @chapter_text char(6) = '000000'

	-- level 1
	set @chapter_text = right('00' + cast(@level_1 as varchar(2)), 2) + '0000'
	declare @product_category_parent_id uniqueidentifier = newid()

	insert into product_category (product_category_id, product_category_parent_id, product_category_code, product_category_name,	product_category_position, state_rcd, user_id, date_time ) 
	values ( @product_category_parent_id, @product_category_parent_id,						@chapter_text, @chapter_text + ' - ' + dbo.ipsum(rand())		, 1, 'C', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate()	)

	-- level 2
	declare @level_2 int = 1
	while @level_2 < 3 begin
		set @chapter_text = right('00' + cast(@level_1 as varchar(2)), 2) + right('00' + cast(@level_2 as varchar(2)), 2) + '00'
		declare @product_category_parent_id_2 uniqueidentifier = newid()

		insert into product_category (product_category_id, product_category_parent_id, product_category_code, product_category_name,	product_category_position, state_rcd, user_id, date_time ) 
		values ( @product_category_parent_id_2, @product_category_parent_id,						@chapter_text, @chapter_text + ' - ' + dbo.ipsum(rand())		, 1, 'C', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate()	)

		-- level 3
		declare @level_3 int = 1
		while @level_3 < 6 begin
			set @chapter_text = right('00' + cast(@level_1 as varchar(2)), 2) + right('00' + cast(@level_2 as varchar(2)), 2) + right('00' + cast(@level_3 as varchar(2)), 2)
			declare @product_category_parent_id_3 uniqueidentifier = newid()

			declare @chapter_name_last nvarchar(240) = dbo.ipsum(rand())

			insert into product_category (product_category_id, product_category_parent_id, product_category_code, product_category_name,	product_category_position, state_rcd, user_id, date_time ) 
			values ( @product_category_parent_id_3, @product_category_parent_id_2,						@chapter_text, @chapter_text + ' - ' + @chapter_name_last		, 1, 'C', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate()	)

			exec product_insert @product_category_parent_id_3, @chapter_text, @chapter_name_last

			set @level_3 = @level_3 + 1
		end
		set @level_2 = @level_2 + 1
	end
	set @level_1 = @level_1 + 1
end