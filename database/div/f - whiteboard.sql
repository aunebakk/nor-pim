declare @system_owner_id uniqueidentifier set @system_owner_id = (select top 1 system_owner_id from system_owner)

select
	 u.user_code
	,u.user_name
	,u.date_time
	,u.email
	,u.state_rcd
	,sr.state_name

	,uu.user_code	as created_by_user_code
	,uu.user_name	as created_by_user_name
from [user] as u
inner join [user]		as	uu	on uu.user_id = u.created_by_user_id
inner join state_ref	as	sr	on sr.state_rcd = u.state_rcd
where u.system_owner_id = @system_owner_id

select *
from [user]