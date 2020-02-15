/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:27 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductFieldSetMappingModel {
        
        [Display(Name="Product Field Set Mapping Id")]
        [Required()]
        public System.Guid ProductFieldSetMappingId { get; set; } //;
        
        [Display(Name="Product Field Set Id")]
        [Required()]
        public System.Guid ProductFieldSetId { get; set; } //;
        
        [Display(Name="Product Identifier")]
        [Required()]
        public string ProductIdentifierRcd { get; set; } //;
        
        [Display(Name="Product Attribute")]
        [Required()]
        public string ProductAttributeRcd { get; set; } //;
        
        [Display(Name="Product Info")]
        [Required()]
        public string ProductInfoRcd { get; set; } //;
        
        [Display(Name="Product Image Type")]
        [Required()]
        public string ProductImageTypeRcd { get; set; } //;
        
        [Display(Name="Product Documentation Type")]
        [Required()]
        public string ProductDocumentationTypeRcd { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
