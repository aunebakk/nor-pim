/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:41 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialOrderTransactionTypeRefModel {
        
        [Display(Name="Financial Order Transaction Type")]
        [Required()]
        public string FinancialOrderTransactionTypeRcd { get; set; } //;
        
        [Display(Name="Financial Order Transaction Type Name")]
        [Required()]
        public string FinancialOrderTransactionTypeName { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
