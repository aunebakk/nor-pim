/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:13:41 PM
  From Machine: DESKTOP-LSRVP12
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
//  data access layer: https://en.wikipedia.org/wiki/Data_access_layer
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in GetClientWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class GetClientWithFilterData {
        
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        public string LastName { get; set; }
        
        public string ClientTypeRcd { get; set; }
        
        public string ClientTypeName { get; set; }
        
        public string ClientNationalityRcd { get; set; }
        
        public string ClientNationalityName { get; set; }
        
        public string ClientGenderRcd { get; set; }
        
        public string ClientGenderName { get; set; }
        
        public string ClientTitleRcd { get; set; }
        
        public string ClientTitleName { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public System.Guid ClientUserId { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, GetClientWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FirstName)) FirstName = reader.GetString(ordinals.FirstName);
            if (!reader.IsDBNull(ordinals.MiddleName)) MiddleName = reader.GetString(ordinals.MiddleName);
            if (!reader.IsDBNull(ordinals.LastName)) LastName = reader.GetString(ordinals.LastName);
            if (!reader.IsDBNull(ordinals.ClientTypeRcd)) ClientTypeRcd = reader.GetString(ordinals.ClientTypeRcd);
            if (!reader.IsDBNull(ordinals.ClientTypeName)) ClientTypeName = reader.GetString(ordinals.ClientTypeName);
            if (!reader.IsDBNull(ordinals.ClientNationalityRcd)) ClientNationalityRcd = reader.GetString(ordinals.ClientNationalityRcd);
            if (!reader.IsDBNull(ordinals.ClientNationalityName)) ClientNationalityName = reader.GetString(ordinals.ClientNationalityName);
            if (!reader.IsDBNull(ordinals.ClientGenderRcd)) ClientGenderRcd = reader.GetString(ordinals.ClientGenderRcd);
            if (!reader.IsDBNull(ordinals.ClientGenderName)) ClientGenderName = reader.GetString(ordinals.ClientGenderName);
            if (!reader.IsDBNull(ordinals.ClientTitleRcd)) ClientTitleRcd = reader.GetString(ordinals.ClientTitleRcd);
            if (!reader.IsDBNull(ordinals.ClientTitleName)) ClientTitleName = reader.GetString(ordinals.ClientTitleName);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ClientId)) ClientId = reader.GetGuid(ordinals.ClientId);
            if (!reader.IsDBNull(ordinals.ClientUserId)) ClientUserId = reader.GetGuid(ordinals.ClientUserId);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    //  this class start with an identical representation of the method in GetClientWithFilterData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class GetClientWithFilterDataOrdinals {
        
        public int FirstName;
        
        public int MiddleName;
        
        public int LastName;
        
        public int ClientTypeRcd;
        
        public int ClientTypeName;
        
        public int ClientNationalityRcd;
        
        public int ClientNationalityName;
        
        public int ClientGenderRcd;
        
        public int ClientGenderName;
        
        public int ClientTitleRcd;
        
        public int ClientTitleName;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int ClientId;
        
        public int ClientUserId;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public GetClientWithFilterDataOrdinals(IDataReader reader) {
            FirstName = reader.GetOrdinal("first_name");
            MiddleName = reader.GetOrdinal("middle_name");
            LastName = reader.GetOrdinal("last_name");
            ClientTypeRcd = reader.GetOrdinal("client_type_rcd");
            ClientTypeName = reader.GetOrdinal("client_type_name");
            ClientNationalityRcd = reader.GetOrdinal("client_nationality_rcd");
            ClientNationalityName = reader.GetOrdinal("client_nationality_name");
            ClientGenderRcd = reader.GetOrdinal("client_gender_rcd");
            ClientGenderName = reader.GetOrdinal("client_gender_name");
            ClientTitleRcd = reader.GetOrdinal("client_title_rcd");
            ClientTitleName = reader.GetOrdinal("client_title_name");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            ClientId = reader.GetOrdinal("client_id");
            ClientUserId = reader.GetOrdinal("client_user_id");
        }
    }
}
