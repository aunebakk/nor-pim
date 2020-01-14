/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:31 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductGatherAttributeModel {
        
        [Display(Name="Product Gather Attribute Id")]
        [Required()]
        public System.Guid ProductGatherAttributeId { get; set; } //;
        
        [Display(Name="Product Gather Attribute Value")]
        [Required()]
        public string ProductGatherAttributeValue { get; set; } //;
        
        [Display(Name="Product Gather Attribute Type")]
        [Required()]
        public string ProductGatherAttributeTypeRcd { get; set; } //;
        
        [Display(Name="Product Gather Key Id")]
        [Required()]
        public System.Guid ProductGatherKeyId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
