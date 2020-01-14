/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:23:00 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductGatherSourceModel {
        
        [Display(Name="Product Gather Source Id")]
        [Required()]
        public System.Guid ProductGatherSourceId { get; set; } //;
        
        [Display(Name="Product Gather Id")]
        [Required()]
        public System.Guid ProductGatherId { get; set; } //;
        
        [Display(Name="Product Gather Source Type")]
        [Required()]
        public string ProductGatherSourceTypeRcd { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
