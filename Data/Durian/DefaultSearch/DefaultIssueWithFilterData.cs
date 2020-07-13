/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:02:55 AM
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
    public partial class DefaultIssueWithFilterData {
        
        public string DefaultIssueTypeRcd { get; set; }
        
        public string DefaultIssueTypeName { get; set; }
        
        public string DefaultIssueStatusRcd { get; set; }
        
        public string DefaultIssueStatusName { get; set; }
        
        public System.Guid DefaultErrorId { get; set; }
        
        public string MethodName { get; set; }
        
        public string IssueName { get; set; }
        
        public string IssueDescription { get; set; }
        
        public string StepsToReproduce { get; set; }
        
        public string Link { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid DefaultIssueId { get; set; }
        
        public void Populate(IDataReader reader, DefaultIssueWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DefaultIssueTypeRcd)) DefaultIssueTypeRcd = reader.GetString(ordinals.DefaultIssueTypeRcd);
            if (!reader.IsDBNull(ordinals.DefaultIssueTypeName)) DefaultIssueTypeName = reader.GetString(ordinals.DefaultIssueTypeName);
            if (!reader.IsDBNull(ordinals.DefaultIssueStatusRcd)) DefaultIssueStatusRcd = reader.GetString(ordinals.DefaultIssueStatusRcd);
            if (!reader.IsDBNull(ordinals.DefaultIssueStatusName)) DefaultIssueStatusName = reader.GetString(ordinals.DefaultIssueStatusName);
            if (!reader.IsDBNull(ordinals.DefaultErrorId)) DefaultErrorId = reader.GetGuid(ordinals.DefaultErrorId);
            if (!reader.IsDBNull(ordinals.MethodName)) MethodName = reader.GetString(ordinals.MethodName);
            if (!reader.IsDBNull(ordinals.IssueName)) IssueName = reader.GetString(ordinals.IssueName);
            if (!reader.IsDBNull(ordinals.IssueDescription)) IssueDescription = reader.GetString(ordinals.IssueDescription);
            if (!reader.IsDBNull(ordinals.StepsToReproduce)) StepsToReproduce = reader.GetString(ordinals.StepsToReproduce);
            if (!reader.IsDBNull(ordinals.Link)) Link = reader.GetString(ordinals.Link);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.DefaultIssueId)) DefaultIssueId = reader.GetGuid(ordinals.DefaultIssueId);
        }
    }
    
    public partial class DefaultIssueWithFilterDataOrdinals {
        
        public int DefaultIssueTypeRcd;
        
        public int DefaultIssueTypeName;
        
        public int DefaultIssueStatusRcd;
        
        public int DefaultIssueStatusName;
        
        public int DefaultErrorId;
        
        public int MethodName;
        
        public int IssueName;
        
        public int IssueDescription;
        
        public int StepsToReproduce;
        
        public int Link;
        
        public int DateTime;
        
        public int DefaultIssueId;
        
        public DefaultIssueWithFilterDataOrdinals(IDataReader reader) {
            DefaultIssueTypeRcd = reader.GetOrdinal("default_issue_type_rcd");
            DefaultIssueTypeName = reader.GetOrdinal("default_issue_type_name");
            DefaultIssueStatusRcd = reader.GetOrdinal("default_issue_status_rcd");
            DefaultIssueStatusName = reader.GetOrdinal("default_issue_status_name");
            DefaultErrorId = reader.GetOrdinal("default_error_id");
            MethodName = reader.GetOrdinal("method_name");
            IssueName = reader.GetOrdinal("issue_name");
            IssueDescription = reader.GetOrdinal("issue_description");
            StepsToReproduce = reader.GetOrdinal("steps_to_reproduce");
            Link = reader.GetOrdinal("link");
            DateTime = reader.GetOrdinal("date_time");
            DefaultIssueId = reader.GetOrdinal("default_issue_id");
        }
    }
}
