/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:09 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultResourceStatisticsData {

        public string HourNumber { get; set; }

        public int ClientWorkingsetBytes { get; set; }

        public int BusinessWorkingsetBytes { get; set; }

        public int DatabaseSizeBytes { get; set; }

        public void Populate(IDataReader reader, DefaultResourceStatisticsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.HourNumber)) {
                HourNumber = reader.GetString(ordinals.HourNumber);
            }

            if (!reader.IsDBNull(ordinals.ClientWorkingsetBytes)) {
                ClientWorkingsetBytes = reader.GetInt32(ordinals.ClientWorkingsetBytes);
            }

            if (!reader.IsDBNull(ordinals.BusinessWorkingsetBytes)) {
                BusinessWorkingsetBytes = reader.GetInt32(ordinals.BusinessWorkingsetBytes);
            }

            if (!reader.IsDBNull(ordinals.DatabaseSizeBytes)) {
                DatabaseSizeBytes = reader.GetInt32(ordinals.DatabaseSizeBytes);
            }
        }
    }

    public partial class DefaultResourceStatisticsDataOrdinals {

        public int HourNumber;

        public int ClientWorkingsetBytes;

        public int BusinessWorkingsetBytes;

        public int DatabaseSizeBytes;

        public DefaultResourceStatisticsDataOrdinals(IDataReader reader) {
            HourNumber = reader.GetOrdinal("hour_number");
            ClientWorkingsetBytes = reader.GetOrdinal("client_workingset_bytes");
            BusinessWorkingsetBytes = reader.GetOrdinal("business_workingset_bytes");
            DatabaseSizeBytes = reader.GetOrdinal("database_size_bytes");
        }
    }
}
