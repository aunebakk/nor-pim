/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:23:00 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductCategoryImageModel {
        
        [Display(Name="Product Category Image Id")]
        [Required()]
        public System.Guid ProductCategoryImageId { get; set; } //;
        
        [Display(Name="Product Category Id")]
        [Required()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [Display(Name="Product Category Image Type")]
        [Required()]
        public string ProductCategoryImageTypeRcd { get; set; } //;
        
        [Display(Name="Image")]
        [Required()]
        public byte[] Image { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
