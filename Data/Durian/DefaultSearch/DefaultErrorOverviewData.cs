/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:33:39 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultErrorOverviewData {
        
        public System.Guid DefaultErrorId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string DefaultErrorLayerName { get; set; }
        
        public string DefaultErrorTypeName { get; set; }
        
        public string DomainName { get; set; }
        
        public string ClassName { get; set; }
        
        public string MethodName { get; set; }
        
        public string ErrorMessage { get; set; }
        
        public void Populate(IDataReader reader, DefaultErrorOverviewDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DefaultErrorId)) DefaultErrorId = reader.GetGuid(ordinals.DefaultErrorId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.DefaultErrorLayerName)) DefaultErrorLayerName = reader.GetString(ordinals.DefaultErrorLayerName);
            if (!reader.IsDBNull(ordinals.DefaultErrorTypeName)) DefaultErrorTypeName = reader.GetString(ordinals.DefaultErrorTypeName);
            if (!reader.IsDBNull(ordinals.DomainName)) DomainName = reader.GetString(ordinals.DomainName);
            if (!reader.IsDBNull(ordinals.ClassName)) ClassName = reader.GetString(ordinals.ClassName);
            if (!reader.IsDBNull(ordinals.MethodName)) MethodName = reader.GetString(ordinals.MethodName);
            if (!reader.IsDBNull(ordinals.ErrorMessage)) ErrorMessage = reader.GetString(ordinals.ErrorMessage);
        }
    }
    
    public partial class DefaultErrorOverviewDataOrdinals {
        
        public int DefaultErrorId;
        
        public int DateTime;
        
        public int DefaultErrorLayerName;
        
        public int DefaultErrorTypeName;
        
        public int DomainName;
        
        public int ClassName;
        
        public int MethodName;
        
        public int ErrorMessage;
        
        public DefaultErrorOverviewDataOrdinals(IDataReader reader) {
            DefaultErrorId = reader.GetOrdinal("default_error_id");
            DateTime = reader.GetOrdinal("date_time");
            DefaultErrorLayerName = reader.GetOrdinal("default_error_layer_name");
            DefaultErrorTypeName = reader.GetOrdinal("default_error_type_name");
            DomainName = reader.GetOrdinal("domain_name");
            ClassName = reader.GetOrdinal("class_name");
            MethodName = reader.GetOrdinal("method_name");
            ErrorMessage = reader.GetOrdinal("error_message");
        }
    }
}
