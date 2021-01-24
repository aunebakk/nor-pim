/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:46:46 AM
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
    // this class start with an identical representation of a ansi sql select statement in DefaultErrorOverviewData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
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
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
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
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in DefaultErrorOverviewData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class DefaultErrorOverviewDataOrdinals {
        
        public int DefaultErrorId;
        
        public int DateTime;
        
        public int DefaultErrorLayerName;
        
        public int DefaultErrorTypeName;
        
        public int DomainName;
        
        public int ClassName;
        
        public int MethodName;
        
        public int ErrorMessage;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
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
