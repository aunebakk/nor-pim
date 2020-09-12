/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 9/12/2020 3:54:36 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateWithDurianGenerator.ContractUsing
*/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductAttributeContract {
        
        [DataMember()]
        public CrudeProductAttributeContract ProductAttribute { get; set; }
    }
}
