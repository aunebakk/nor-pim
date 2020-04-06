/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:25 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductImageModel {
        
        [Display(Name="Product Image Id")]
        [Required()]
        public System.Guid ProductImageId { get; set; } //;
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; } //;
        
        [Display(Name="Product Image Type")]
        [Required()]
        public string ProductImageTypeRcd { get; set; } //;
        
        [Display(Name="Image File Name")]
        [Required()]
        public string ImageFileName { get; set; } //;
        
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
