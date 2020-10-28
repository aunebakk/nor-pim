/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 7:21:53 PM
  From Machine: DESKTOP-517I8BU
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
