/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 8:13:08 PM
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
    public partial class DefaultPerformanceTimeCommandsData {
        
        public string CommandName { get; set; }
        
        public string CommandDisplayName { get; set; }
        
        public void Populate(IDataReader reader, DefaultPerformanceTimeCommandsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.CommandName)) CommandName = reader.GetString(ordinals.CommandName);
            if (!reader.IsDBNull(ordinals.CommandDisplayName)) CommandDisplayName = reader.GetString(ordinals.CommandDisplayName);
        }
    }
    
    public partial class DefaultPerformanceTimeCommandsDataOrdinals {
        
        public int CommandName;
        
        public int CommandDisplayName;
        
        public DefaultPerformanceTimeCommandsDataOrdinals(IDataReader reader) {
            CommandName = reader.GetOrdinal("command_name");
            CommandDisplayName = reader.GetOrdinal("command_display_name");
        }
    }
}
