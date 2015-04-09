-- products that became something
select pi.identifier, p.product_name, pa.value
from product as p
inner join product_attribute	as pa on pa.product_id = p.product_id
inner join product_identifier	as pi on pi.product_id = p.product_id
where p.product_became_id is not null

-- products that was something
select pi.identifier, p.product_name, pa.value
from product as p
inner join product_attribute	as pa on pa.product_id = p.product_id
inner join product_identifier	as pi on pi.product_id = p.product_id
where p.product_id in (select p.product_became_id from product as p where p.product_became_id is not null)

select  
        p.product_id,
        p.product_name, 

        pi.identifier, 
        pa.value,
		pin.product_info_value,

		pim.product_image_type_rcd,
		pit.product_image_type_name,
		pim.image
		,pcm.product_category_id

from product as p
inner join product_category_mapping		as pcm on pcm.product_id = p.product_id
inner join product_attribute			as pa  on pa.product_id = p.product_id
inner join product_identifier			as pi  on pi.product_id = p.product_id
 left join product_info					as pin on pin.product_id = p.product_id
 left join product_image				as pim on pim.product_id = p.product_id
 left join product_image_type_ref		as pit on pim.product_id = p.product_id
where pcm.product_category_id = '3BFDD550-9534-48EF-B79C-4A3F329485DC'

delete system_setting

select *
from product as p
where p.product_became_id is not null

select *
from product as p
where p.product_name like '%891%'

insert into product_category_mapping (product_category_mapping_id, product_id, product_category_id)
select 
	newid(),
	cpm.product_id,
	cpm.product_category_id   
from product_category_mapping as cpm
where cpm.product_id = '{dc5e8ecb-2620-4da8-84cc-902b586e94b5}'

select *
from product_category_mapping as cpm
where cpm.product_id = '{238353bc-19c5-4bb8-8ff1-2a9ee73b616b}'