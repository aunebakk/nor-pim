using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace norpim.DataAccessLayer {
    /// <summary> 
    /// Provides product search with different parameter and result sets
    /// </summary>
    /// <domain>User</domain>
    public class UserSearch {
        /// <summary>Search users by system owner</summary>
        /// <cardinality>Many</cardinality>
        public List<UserSearchBySystemOwner> UserSearchBySystemOwner(Guid systemOwnerId) {

            var ret = new List<UserSearchBySystemOwner>();

            string sql = @" 
                    select
                         u.user_id
	                    ,u.user_code
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
                ";
            
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@system_owner_id", SqlDbType.UniqueIdentifier).Value = systemOwnerId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new UserSearchBySystemOwnerOrdinals(reader);

                    while (reader.Read()) {
                        var data = new UserSearchBySystemOwner();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }
    }
}
