use norpim
go
set nocount on

-- get system user & system owner ( developer )
declare @user_id uniqueidentifier 
exec get_defaults @user_id out

exec category_basic @user_id
print ('category basic')

declare @product_gather_id_1 uniqueidentifier set @product_gather_id_1 = newid();
exec gather_product_set @product_gather_id_1, @user_id
print ('gather product set 1')

declare @product_gather_id_2 uniqueidentifier set @product_gather_id_2 = newid();
exec gather_product_set @product_gather_id_2, @user_id
print ('gather product set 2')

exec gather_set_move_to_product @product_gather_id_1, @user_id
print ('gather set 1 move to product')

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

print ('updated set 1 to pink')

exec compare_gather_set_to_product @product_gather_id_1, @user_id

print ('compare gather set 1 to product')

exec compare_set_move_to_product @product_gather_id_1, @user_id

print ('move compare set 1 to product')

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

print ('updated set 2 to yellow')

exec compare_gather_set_to_product @product_gather_id_2, @user_id

print ('compare gather set 2 to product')

exec compare_set_move_to_product @product_gather_id_2, @user_id

print ('move compare set 2 to product')

-- find category for products with changes
select pi.identifier, pc.product_category_name
from product_identifier as pi
inner join product as p on p.product_id = pi.product_id
					and p.product_became_id is null
inner join product_category_mapping as pcm on pcm.product_id = pi.product_id
inner join product_category as pc on pc.product_category_id = pcm.product_category_id
where pi.identifier in (666+5, 666+500, 666+999)


