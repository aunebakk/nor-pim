/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 6:22:37 PM
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
