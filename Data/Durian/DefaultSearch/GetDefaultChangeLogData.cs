/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:10:28 AM
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
    public partial class GetDefaultChangeLogData {
        
        public string DefaultChangeName { get; set; }
        
        public string DefaultChangeDescription { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string DefaultChangeLogTypeRcd { get; set; }
        
        public string DefaultChangeLogTypeName { get; set; }
        
        public System.Guid DefaultIssueId { get; set; }
        
        public string IssueName { get; set; }
        
        public System.Guid DefaultChangeLogId { get; set; }
        
        public void Populate(IDataReader reader, GetDefaultChangeLogDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DefaultChangeName)) DefaultChangeName = reader.GetString(ordinals.DefaultChangeName);
            if (!reader.IsDBNull(ordinals.DefaultChangeDescription)) DefaultChangeDescription = reader.GetString(ordinals.DefaultChangeDescription);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.DefaultChangeLogTypeRcd)) DefaultChangeLogTypeRcd = reader.GetString(ordinals.DefaultChangeLogTypeRcd);
            if (!reader.IsDBNull(ordinals.DefaultChangeLogTypeName)) DefaultChangeLogTypeName = reader.GetString(ordinals.DefaultChangeLogTypeName);
            if (!reader.IsDBNull(ordinals.DefaultIssueId)) DefaultIssueId = reader.GetGuid(ordinals.DefaultIssueId);
            if (!reader.IsDBNull(ordinals.IssueName)) IssueName = reader.GetString(ordinals.IssueName);
            if (!reader.IsDBNull(ordinals.DefaultChangeLogId)) DefaultChangeLogId = reader.GetGuid(ordinals.DefaultChangeLogId);
        }
    }
    
    public partial class GetDefaultChangeLogDataOrdinals {
        
        public int DefaultChangeName;
        
        public int DefaultChangeDescription;
        
        public int DateTime;
        
        public int DefaultChangeLogTypeRcd;
        
        public int DefaultChangeLogTypeName;
        
        public int DefaultIssueId;
        
        public int IssueName;
        
        public int DefaultChangeLogId;
        
        public GetDefaultChangeLogDataOrdinals(IDataReader reader) {
            DefaultChangeName = reader.GetOrdinal("default_change_name");
            DefaultChangeDescription = reader.GetOrdinal("default_change_description");
            DateTime = reader.GetOrdinal("date_time");
            DefaultChangeLogTypeRcd = reader.GetOrdinal("default_change_log_type_rcd");
            DefaultChangeLogTypeName = reader.GetOrdinal("default_change_log_type_name");
            DefaultIssueId = reader.GetOrdinal("default_issue_id");
            IssueName = reader.GetOrdinal("issue_name");
            DefaultChangeLogId = reader.GetOrdinal("default_change_log_id");
        }
    }
}
