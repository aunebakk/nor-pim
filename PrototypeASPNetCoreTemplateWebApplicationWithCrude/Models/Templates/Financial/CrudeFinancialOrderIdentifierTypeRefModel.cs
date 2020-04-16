/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:20 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialOrderIdentifierTypeRefModel {
        
        [Display(Name="Financial Order Identifier Type")]
        [Required()]
        public string FinancialOrderIdentifierTypeRcd { get; set; } //;
        
        [Display(Name="Financial Order Identifier Type Code")]
        [Required()]
        public string FinancialOrderIdentifierTypeCode { get; set; } //;
        
        [Display(Name="Financial Order Identifier Type Name")]
        [Required()]
        public string FinancialOrderIdentifierTypeName { get; set; } //;
        
        [Display(Name="Sort Sequence Number")]
        [Required()]
        public int SortSequenceNumber { get; set; } //;
        
        [Display(Name="Change Flag")]
        [Required()]
        public bool ChangeFlag { get; set; } //;
        
        [Display(Name="Status Code")]
        [Required()]
        public string StatusCode { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
