select
	 ist.table_name

	,(  select
			max(index_col(object_name(id),indid,1)) as column_name
		from sysindexes
		where (object_name(id) = ist.table_name
			and (status & 64 = 0
			and status & 2<>0
			and (soundex(object_name(id)) = soundex(index_col(object_name(id),indid,1))
			) or (status & 16)<>0))
		)                       as primary_key


from information_schema.tables as ist
order by ist.table_name