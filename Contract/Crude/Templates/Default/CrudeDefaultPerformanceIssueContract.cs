﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:08:54 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeDefaultPerformanceIssueContract {
        
        [DataMember()]
        public System.Guid DefaultPerformanceIssueId { get; set; }
        
        [DataMember()]
        public string CommandName { get; set; }
        
        [DataMember()]
        public string CommandText { get; set; }
        
        [DataMember()]
        public int Milliseconds { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
