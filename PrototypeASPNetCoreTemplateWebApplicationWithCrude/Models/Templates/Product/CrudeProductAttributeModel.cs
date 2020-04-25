/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:25:17 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductAttributeModel {
        
        [Display(Name="Product Attribute Id")]
        [Required()]
        public System.Guid ProductAttributeId { get; set; } //;
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; } //;
        
        [Display(Name="Product Attribute")]
        [Required()]
        public string ProductAttributeRcd { get; set; } //;
        
        [Display(Name="Product Attribute Unit")]
        [Required()]
        public string ProductAttributeUnitRcd { get; set; } //;
        
        [Display(Name="Value")]
        [Required()]
        public string Value { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
