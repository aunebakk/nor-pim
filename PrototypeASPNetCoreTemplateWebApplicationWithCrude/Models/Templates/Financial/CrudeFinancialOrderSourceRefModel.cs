/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:49 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialOrderSourceRefModel {
        
        [Display(Name="Financial Order Source")]
        [Required()]
        public string FinancialOrderSourceRcd { get; set; } //;
        
        [Display(Name="Financial Order Source Name")]
        [Required()]
        public string FinancialOrderSourceName { get; set; } //;
        
        [Display(Name="Financial Order Source Code")]
        [Required()]
        public string FinancialOrderSourceCode { get; set; } //;
        
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
