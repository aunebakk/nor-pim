/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 1:20:06 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultPerformanceIssueFetchWithFilterData {
        
        public System.DateTime DateTime { get; set; }
        
        public string CommandName { get; set; }
        
        public int Milliseconds { get; set; }
        
        public System.Guid DefaultPerformanceIssueId { get; set; }
        
        public void Populate(IDataReader reader, DefaultPerformanceIssueFetchWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.CommandName)) CommandName = reader.GetString(ordinals.CommandName);
            if (!reader.IsDBNull(ordinals.Milliseconds)) Milliseconds = reader.GetInt32(ordinals.Milliseconds);
            if (!reader.IsDBNull(ordinals.DefaultPerformanceIssueId)) DefaultPerformanceIssueId = reader.GetGuid(ordinals.DefaultPerformanceIssueId);
        }
    }
    
    public partial class DefaultPerformanceIssueFetchWithFilterDataOrdinals {
        
        public int DateTime;
        
        public int CommandName;
        
        public int Milliseconds;
        
        public int DefaultPerformanceIssueId;
        
        public DefaultPerformanceIssueFetchWithFilterDataOrdinals(IDataReader reader) {
            DateTime = reader.GetOrdinal("date_time");
            CommandName = reader.GetOrdinal("command_name");
            Milliseconds = reader.GetOrdinal("milliseconds");
            DefaultPerformanceIssueId = reader.GetOrdinal("default_performance_issue_id");
        }
    }
}
