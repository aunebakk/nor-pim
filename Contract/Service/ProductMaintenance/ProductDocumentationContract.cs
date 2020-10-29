/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:15:50 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianGenerator.ContractUsing
*/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductDocumentationContract {
        
        [DataMember()]
        public CrudeProductDocumentationContract ProductDocumentation { get; set; }
    }
}
