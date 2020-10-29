/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:26:02 PM
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
    public partial class DefaultTestOverviewData {
        
        public string TestArea { get; set; }
        
        public System.DateTime StartDateTime { get; set; }
        
        public string DefaultTestRunResultRcd { get; set; }
        
        public void Populate(IDataReader reader, DefaultTestOverviewDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.TestArea)) TestArea = reader.GetString(ordinals.TestArea);
            if (!reader.IsDBNull(ordinals.StartDateTime)) StartDateTime = reader.GetDateTime(ordinals.StartDateTime);
            if (!reader.IsDBNull(ordinals.DefaultTestRunResultRcd)) DefaultTestRunResultRcd = reader.GetString(ordinals.DefaultTestRunResultRcd);
        }
    }
    
    public partial class DefaultTestOverviewDataOrdinals {
        
        public int TestArea;
        
        public int StartDateTime;
        
        public int DefaultTestRunResultRcd;
        
        public DefaultTestOverviewDataOrdinals(IDataReader reader) {
            TestArea = reader.GetOrdinal("test_area");
            StartDateTime = reader.GetOrdinal("start_date_time");
            DefaultTestRunResultRcd = reader.GetOrdinal("default_test_run_result_rcd");
        }
    }
}
