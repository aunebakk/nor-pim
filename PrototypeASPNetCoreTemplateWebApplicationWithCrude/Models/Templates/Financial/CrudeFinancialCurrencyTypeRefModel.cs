/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:53 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialCurrencyTypeRefModel {
        
        [Display(Name="Financial Currency Type")]
        [Required()]
        public string FinancialCurrencyTypeRcd { get; set; } //;
        
        [Display(Name="Financial Currency Type Name")]
        [Required()]
        public string FinancialCurrencyTypeName { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Decimal Count")]
        [Required()]
        public int DecimalCount { get; set; } //;
        
        [Display(Name="Financial Currency Type Code")]
        [Required()]
        public string FinancialCurrencyTypeCode { get; set; } //;
    }
}
