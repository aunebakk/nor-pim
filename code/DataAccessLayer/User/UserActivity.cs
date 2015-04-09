using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace norpim.DataAccessLayer {

    public class UserActivity {
        public void DeleteAllActivities() {
            string sql = " delete user_activity";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                var command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
        }
    }
}
