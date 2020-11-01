/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:25:13 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultUserListData {
        
        public System.DateTime LastActivityDateTime { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public string DefaultUserCode { get; set; }
        
        public System.DateTime CreatedDateTime { get; set; }
        
        public string Email { get; set; }
        
        public string DefaultStateName { get; set; }
        
        public int ActivityCount { get; set; }
        
        public string CreatedByDefaultUserCode { get; set; }
        
        public string CreatedByDefaultUserName { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public void Populate(IDataReader reader, DefaultUserListDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.LastActivityDateTime)) LastActivityDateTime = reader.GetDateTime(ordinals.LastActivityDateTime);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DefaultUserCode)) DefaultUserCode = reader.GetString(ordinals.DefaultUserCode);
            if (!reader.IsDBNull(ordinals.CreatedDateTime)) CreatedDateTime = reader.GetDateTime(ordinals.CreatedDateTime);
            if (!reader.IsDBNull(ordinals.Email)) Email = reader.GetString(ordinals.Email);
            if (!reader.IsDBNull(ordinals.DefaultStateName)) DefaultStateName = reader.GetString(ordinals.DefaultStateName);
            if (!reader.IsDBNull(ordinals.ActivityCount)) ActivityCount = reader.GetInt32(ordinals.ActivityCount);
            if (!reader.IsDBNull(ordinals.CreatedByDefaultUserCode)) CreatedByDefaultUserCode = reader.GetString(ordinals.CreatedByDefaultUserCode);
            if (!reader.IsDBNull(ordinals.CreatedByDefaultUserName)) CreatedByDefaultUserName = reader.GetString(ordinals.CreatedByDefaultUserName);
            if (!reader.IsDBNull(ordinals.DefaultUserId)) DefaultUserId = reader.GetGuid(ordinals.DefaultUserId);
        }
    }
    
    public partial class DefaultUserListDataOrdinals {
        
        public int LastActivityDateTime;
        
        public int DefaultUserName;
        
        public int DefaultUserCode;
        
        public int CreatedDateTime;
        
        public int Email;
        
        public int DefaultStateName;
        
        public int ActivityCount;
        
        public int CreatedByDefaultUserCode;
        
        public int CreatedByDefaultUserName;
        
        public int DefaultUserId;
        
        public DefaultUserListDataOrdinals(IDataReader reader) {
            LastActivityDateTime = reader.GetOrdinal("last_activity_date_time");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DefaultUserCode = reader.GetOrdinal("default_user_code");
            CreatedDateTime = reader.GetOrdinal("created_date_time");
            Email = reader.GetOrdinal("email");
            DefaultStateName = reader.GetOrdinal("default_state_name");
            ActivityCount = reader.GetOrdinal("activity_count");
            CreatedByDefaultUserCode = reader.GetOrdinal("created_by_default_user_code");
            CreatedByDefaultUserName = reader.GetOrdinal("created_by_default_user_name");
            DefaultUserId = reader.GetOrdinal("default_user_id");
        }
    }
}
