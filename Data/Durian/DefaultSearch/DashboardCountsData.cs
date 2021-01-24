/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:46:10 AM
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
    // this class start with an identical representation of a ansi sql select statement in DashboardCountsData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
    [Serializable()]
    public partial class DashboardCountsData {
        
        public string DashboardItemRcd { get; set; }
        
        public string DashboardItemName { get; set; }
        
        public string ImageSource { get; set; }
        
        public string Value { get; set; }
        
        public int Last24HoursCount { get; set; }
        
        public string LastDateTime { get; set; }
        
        public string LastUserName { get; set; }
        
        public string Url { get; set; }
        
        public int PositionLeft { get; set; }
        
        public int PositionTop { get; set; }
        
        public int PositionOffset { get; set; }
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
        public void Populate(IDataReader reader, DashboardCountsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DashboardItemRcd)) DashboardItemRcd = reader.GetString(ordinals.DashboardItemRcd);
            if (!reader.IsDBNull(ordinals.DashboardItemName)) DashboardItemName = reader.GetString(ordinals.DashboardItemName);
            if (!reader.IsDBNull(ordinals.ImageSource)) ImageSource = reader.GetString(ordinals.ImageSource);
            if (!reader.IsDBNull(ordinals.Value)) Value = reader.GetString(ordinals.Value);
            if (!reader.IsDBNull(ordinals.Last24HoursCount)) Last24HoursCount = reader.GetInt32(ordinals.Last24HoursCount);
            if (!reader.IsDBNull(ordinals.LastDateTime)) LastDateTime = reader.GetString(ordinals.LastDateTime);
            if (!reader.IsDBNull(ordinals.LastUserName)) LastUserName = reader.GetString(ordinals.LastUserName);
            if (!reader.IsDBNull(ordinals.Url)) Url = reader.GetString(ordinals.Url);
            if (!reader.IsDBNull(ordinals.PositionLeft)) PositionLeft = reader.GetInt32(ordinals.PositionLeft);
            if (!reader.IsDBNull(ordinals.PositionTop)) PositionTop = reader.GetInt32(ordinals.PositionTop);
            if (!reader.IsDBNull(ordinals.PositionOffset)) PositionOffset = reader.GetInt32(ordinals.PositionOffset);
        }
    }
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in DashboardCountsData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
    public partial class DashboardCountsDataOrdinals {
        
        public int DashboardItemRcd;
        
        public int DashboardItemName;
        
        public int ImageSource;
        
        public int Value;
        
        public int Last24HoursCount;
        
        public int LastDateTime;
        
        public int LastUserName;
        
        public int Url;
        
        public int PositionLeft;
        
        public int PositionTop;
        
        public int PositionOffset;
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
        public DashboardCountsDataOrdinals(IDataReader reader) {
            DashboardItemRcd = reader.GetOrdinal("dashboard_item_rcd");
            DashboardItemName = reader.GetOrdinal("dashboard_item_name");
            ImageSource = reader.GetOrdinal("image_source");
            Value = reader.GetOrdinal("value");
            Last24HoursCount = reader.GetOrdinal("last_24_hours_count");
            LastDateTime = reader.GetOrdinal("last_date_time");
            LastUserName = reader.GetOrdinal("last_user_name");
            Url = reader.GetOrdinal("url");
            PositionLeft = reader.GetOrdinal("position_left");
            PositionTop = reader.GetOrdinal("position_top");
            PositionOffset = reader.GetOrdinal("position_offset");
        }
    }
}
