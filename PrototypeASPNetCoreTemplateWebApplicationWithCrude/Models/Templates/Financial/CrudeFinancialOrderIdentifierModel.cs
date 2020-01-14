/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:57 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialOrderIdentifierModel {
        
        [Display(Name="Financial Order Identifier Id")]
        [Required()]
        public System.Guid FinancialOrderIdentifierId { get; set; } //;
        
        [Display(Name="Financial Order Id")]
        [Required()]
        public System.Guid FinancialOrderId { get; set; } //;
        
        [Display(Name="Financial Order Identifier Type")]
        [Required()]
        public string FinancialOrderIdentifierTypeRcd { get; set; } //;
        
        [Display(Name="Financial Order Identifier Code")]
        [Required()]
        public string FinancialOrderIdentifierCode { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
