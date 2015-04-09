-- get system user ( developer )
declare @user_id uniqueidentifier 
exec get_defaults @user_id out

-- insert product one with a color green and gtin 23423423
declare @product_one_green_id uniqueidentifier set @product_one_green_id = newid()
insert into product (product_id, product_name, state_rcd, user_id, date_time) values (@product_one_green_id, 'product one green', 'C', @user_id, getutcdate());
insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) values (newid(), @product_one_green_id, 'Color', 'Green', @user_id, getutcdate());
insert into product_identifier (product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time) values (newid(), @product_one_green_id, 'GTIN', '23423423', @user_id, getutcdate());

-- change product one's color from green to pink ( i.e. a new product ), gtin unchanged
declare @product_one_pink_id uniqueidentifier set @product_one_pink_id = newid()

insert into product (product_id, product_name, state_rcd, user_id, date_time) values (@product_one_pink_id, 'product one changed to pink', 'C', @user_id, getutcdate());
insert into product_attribute (product_attribute_id, product_id, product_attribute_rcd, value, user_id, date_time) values (newid(), @product_one_pink_id, 'Color', 'Pink', @user_id, getutcdate());
insert into product_identifier (product_identifier_id, product_id, product_identifier_rcd, identifier, user_id, date_time) values (newid(), @product_one_pink_id, 'GTIN', '23423423', @user_id, getutcdate());

update product set product_became_id = @product_one_pink_id where product_id = @product_one_green_id

-- get changed product
select * 
from product as p
inner join product_attribute as pa on pa.product_id = p.product_id
inner join product_identifier as pi on pi.product_id = p.product_id
where p.product_became_id is null
