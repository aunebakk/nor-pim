/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:49:25 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in DefaultUserListForDashboardData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
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
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
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
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in DefaultUserListForDashboardData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
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
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
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
