/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:50:08 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateWithDurianGenerator.ContractUsing
*/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductIdentifierContract {
        
        [DataMember()]
        public CrudeProductIdentifierContract ProductIdentifier { get; set; }
    }
}
