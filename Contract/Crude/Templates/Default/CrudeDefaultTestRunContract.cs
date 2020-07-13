﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:12:42 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeDefaultTestRunContract {
        
        [DataMember()]
        public System.Guid DefaultTestRunId { get; set; }
        
        [DataMember()]
        public System.Guid DefaultTestId { get; set; }
        
        [DataMember()]
        public string DefaultTestRunResultRcd { get; set; }
        
        [DataMember()]
        public string Result { get; set; }
        
        [DataMember()]
        public System.DateTime StartDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime EndDateTime { get; set; }
        
        [DataMember()]
        public int ElapsedMilliseconds { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}