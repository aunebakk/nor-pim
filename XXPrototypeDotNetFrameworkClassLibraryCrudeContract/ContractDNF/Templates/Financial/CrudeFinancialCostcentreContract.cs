/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:18:52 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialCostcentreContract {
        
        [DataMember()]
        public System.Guid FinancialCostcentreId { get; set; } //;
        
        [DataMember()]
        public string FinancialCostcentreName { get; set; } //;
        
        [DataMember()]
        public string FinancialCostcentreCode { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialCompanyId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
