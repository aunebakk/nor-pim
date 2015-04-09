-- distribution of products
select count(*) from product as p

select count (*) from product_gather as pg

select product_gather_id, count (*) from product_gather_key as pgk group by product_gather_id

select count (*) from product_gather_attribute as pgk
