/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:50:18 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductExposeSetModel {
        
        [Display(Name="Product Expose Set Id")]
        [Required()]
        public System.Guid ProductExposeSetId { get; set; } //;
        
        [Display(Name="Product Expose Set Type")]
        [Required()]
        public string ProductExposeSetTypeRcd { get; set; } //;
        
        [Display(Name="Product Expose Set Name")]
        [Required()]
        public string ProductExposeSetName { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
