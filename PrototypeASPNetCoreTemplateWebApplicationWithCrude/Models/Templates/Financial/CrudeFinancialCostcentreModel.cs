/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:25 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialCostcentreModel {
        
        [Display(Name="Financial Costcentre Id")]
        [Required()]
        public System.Guid FinancialCostcentreId { get; set; } //;
        
        [Display(Name="Financial Costcentre Name")]
        [Required()]
        public string FinancialCostcentreName { get; set; } //;
        
        [Display(Name="Financial Costcentre Code")]
        [Required()]
        public string FinancialCostcentreCode { get; set; } //;
        
        [Display(Name="Financial Company Id")]
        [Required()]
        public System.Guid FinancialCompanyId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
