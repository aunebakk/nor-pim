/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 7:51:50 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultUserListForDashboardData {
        
        public string DefaultUserCode { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public string Email { get; set; }
        
        public string DefaultStateName { get; set; }
        
        public int ActivityCount { get; set; }
        
        public string LastActivityDateTime { get; set; }
        
        public string CreatedDateTime { get; set; }
        
        public string CreatedByDefaultUserCode { get; set; }
        
        public string CreatedByDefaultUserName { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public void Populate(IDataReader reader, DefaultUserListForDashboardDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DefaultUserCode)) DefaultUserCode = reader.GetString(ordinals.DefaultUserCode);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.Email)) Email = reader.GetString(ordinals.Email);
            if (!reader.IsDBNull(ordinals.DefaultStateName)) DefaultStateName = reader.GetString(ordinals.DefaultStateName);
            if (!reader.IsDBNull(ordinals.ActivityCount)) ActivityCount = reader.GetInt32(ordinals.ActivityCount);
            if (!reader.IsDBNull(ordinals.LastActivityDateTime)) LastActivityDateTime = reader.GetString(ordinals.LastActivityDateTime);
            if (!reader.IsDBNull(ordinals.CreatedDateTime)) CreatedDateTime = reader.GetString(ordinals.CreatedDateTime);
            if (!reader.IsDBNull(ordinals.CreatedByDefaultUserCode)) CreatedByDefaultUserCode = reader.GetString(ordinals.CreatedByDefaultUserCode);
            if (!reader.IsDBNull(ordinals.CreatedByDefaultUserName)) CreatedByDefaultUserName = reader.GetString(ordinals.CreatedByDefaultUserName);
            if (!reader.IsDBNull(ordinals.DefaultUserId)) DefaultUserId = reader.GetGuid(ordinals.DefaultUserId);
        }
    }
    
    public partial class DefaultUserListForDashboardDataOrdinals {
        
        public int DefaultUserCode;
        
        public int DefaultUserName;
        
        public int Email;
        
        public int DefaultStateName;
        
        public int ActivityCount;
        
        public int LastActivityDateTime;
        
        public int CreatedDateTime;
        
        public int CreatedByDefaultUserCode;
        
        public int CreatedByDefaultUserName;
        
        public int DefaultUserId;
        
        public DefaultUserListForDashboardDataOrdinals(IDataReader reader) {
            DefaultUserCode = reader.GetOrdinal("default_user_code");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            Email = reader.GetOrdinal("email");
            DefaultStateName = reader.GetOrdinal("default_state_name");
            ActivityCount = reader.GetOrdinal("activity_count");
            LastActivityDateTime = reader.GetOrdinal("last_activity_date_time");
            CreatedDateTime = reader.GetOrdinal("created_date_time");
            CreatedByDefaultUserCode = reader.GetOrdinal("created_by_default_user_code");
            CreatedByDefaultUserName = reader.GetOrdinal("created_by_default_user_name");
            DefaultUserId = reader.GetOrdinal("default_user_id");
        }
    }
}
