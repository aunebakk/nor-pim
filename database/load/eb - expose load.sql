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
