/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:10 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductExposeModel {
        
        [Display(Name="Product Expose Id")]
        [Required()]
        public System.Guid ProductExposeId { get; set; } //;
        
        [Display(Name="Expose Product Id")]
        [Required()]
        public System.Guid ExposeProductId { get; set; } //;
        
        [Display(Name="Expose Based On Product Id")]
        [Required()]
        public System.Guid ExposeBasedOnProductId { get; set; } //;
        
        [Display(Name="Product Expose Set Id")]
        [Required()]
        public System.Guid ProductExposeSetId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
