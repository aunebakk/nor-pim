/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:46:35 AM
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
    // this class start with an identical representation of a ansi sql select statement in DefaultIssueWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
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
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
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
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in DefaultIssueWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
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
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
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
