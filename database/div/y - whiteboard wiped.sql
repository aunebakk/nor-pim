                    select 
	                     convert(nvarchar(30), date_time, 2) as activity_date
	                    ,count(*) as day_count
                    from user_activity as ua
                    group by convert(nvarchar(30), date_time, 2)
                    order by convert(nvarchar(30), date_time, 2) desc
