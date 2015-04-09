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
