/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:48 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductCategoryModel {
        
        [Display(Name="Product Category Id")]
        [Required()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [Display(Name="Product Category Became Id")]
        [Required()]
        public System.Guid ProductCategoryBecameId { get; set; } //;
        
        [Display(Name="Product Category Parent Id")]
        [Required()]
        public System.Guid ProductCategoryParentId { get; set; } //;
        
        [Display(Name="Product Category Code")]
        [Required()]
        public string ProductCategoryCode { get; set; } //;
        
        [Display(Name="Product Category Name")]
        [Required()]
        public string ProductCategoryName { get; set; } //;
        
        [Display(Name="Product Category Position")]
        [Required()]
        public int ProductCategoryPosition { get; set; } //;
        
        [Display(Name="State")]
        [Required()]
        public string StateRcd { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
