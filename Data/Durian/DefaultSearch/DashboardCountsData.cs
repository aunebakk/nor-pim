/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:00:43 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;

namespace SolutionNorSolutionPim.DataAccessLayer {

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

        public void Populate(IDataReader reader, DashboardCountsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DashboardItemRcd)) {
                DashboardItemRcd = reader.GetString(ordinals.DashboardItemRcd);
            }

            if (!reader.IsDBNull(ordinals.DashboardItemName)) {
                DashboardItemName = reader.GetString(ordinals.DashboardItemName);
            }

            if (!reader.IsDBNull(ordinals.ImageSource)) {
                ImageSource = reader.GetString(ordinals.ImageSource);
            }

            if (!reader.IsDBNull(ordinals.Value)) {
                Value = reader.GetString(ordinals.Value);
            }

            if (!reader.IsDBNull(ordinals.Last24HoursCount)) {
                Last24HoursCount = reader.GetInt32(ordinals.Last24HoursCount);
            }

            if (!reader.IsDBNull(ordinals.LastDateTime)) {
                LastDateTime = reader.GetString(ordinals.LastDateTime);
            }

            if (!reader.IsDBNull(ordinals.LastUserName)) {
                LastUserName = reader.GetString(ordinals.LastUserName);
            }

            if (!reader.IsDBNull(ordinals.Url)) {
                Url = reader.GetString(ordinals.Url);
            }

            if (!reader.IsDBNull(ordinals.PositionLeft)) {
                PositionLeft = reader.GetInt32(ordinals.PositionLeft);
            }

            if (!reader.IsDBNull(ordinals.PositionTop)) {
                PositionTop = reader.GetInt32(ordinals.PositionTop);
            }

            if (!reader.IsDBNull(ordinals.PositionOffset)) {
                PositionOffset = reader.GetInt32(ordinals.PositionOffset);
            }
        }
    }

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
