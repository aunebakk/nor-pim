/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:11 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductCategoryDocumentationModel {
        
        [Display(Name="Product Category Documentation Id")]
        [Required()]
        public System.Guid ProductCategoryDocumentationId { get; set; } //;
        
        [Display(Name="Product Category Documentation Type")]
        [Required()]
        public string ProductCategoryDocumentationTypeRcd { get; set; } //;
        
        [Display(Name="Product Category Id")]
        [Required()]
        public System.Guid ProductCategoryId { get; set; } //;
        
        [Display(Name="Documentation")]
        [Required()]
        public string Documentation { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
