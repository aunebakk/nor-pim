﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 7:02:26 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeClientIdentifierTypeRefContract {
        
        [DataMember()]
        public string ClientIdentifierTypeRcd { get; set; }
        
        [DataMember()]
        public string ClientIdentifierTypeName { get; set; }
        
        [DataMember()]
        public string ClientIdentifierTypeDescription { get; set; }
        
        [DataMember()]
        public bool ActiveFlag { get; set; }
        
        [DataMember()]
        public int SortOrder { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
