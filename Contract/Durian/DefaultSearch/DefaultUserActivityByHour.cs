﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:39:36 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultUserActivityByHourContract {
        
        [DataMember()]
        public string HourNumber { get; set; }
        
        [DataMember()]
        public int HourCount { get; set; }
    }
}
