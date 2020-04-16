/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:20 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialCurrencyModel {
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        [Display(Name="Financial Currency Type")]
        [Required()]
        public string FinancialCurrencyTypeRcd { get; set; } //;
        
        [Display(Name="Financial Currency Against Financial Currency Type")]
        [Required()]
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Valid From Date Time")]
        [Required()]
        public System.DateTime ValidFromDateTime { get; set; } //;
        
        [Display(Name="Valid Until Date Time")]
        [Required()]
        public System.DateTime ValidUntilDateTime { get; set; } //;
        
        [Display(Name="Amount")]
        [Required()]
        public decimal Amount { get; set; } //;
        
        [Display(Name="Equals Amount")]
        [Required()]
        public decimal EqualsAmount { get; set; } //;
        
        [Display(Name="Decimal Count")]
        [Required()]
        public int DecimalCount { get; set; } //;
        
        [Display(Name="Financial Currency Type Code")]
        [Required()]
        public string FinancialCurrencyTypeCode { get; set; } //;
        
        [Display(Name="Financial Currency Type Name")]
        [Required()]
        public string FinancialCurrencyTypeName { get; set; } //;
    }
}
