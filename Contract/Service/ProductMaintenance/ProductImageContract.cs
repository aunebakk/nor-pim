/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:26:07 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianGenerator.ContractUsing
*/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductImageContract {
        
        [DataMember()]
        public CrudeProductImageContract ProductImage { get; set; }
    }
}
