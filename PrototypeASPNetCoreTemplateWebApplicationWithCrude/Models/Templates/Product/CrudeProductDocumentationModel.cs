/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:24 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductDocumentationModel {
        
        [Display(Name="Product Documentation Id")]
        [Required()]
        public System.Guid ProductDocumentationId { get; set; } //;
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; } //;
        
        [Display(Name="Product Documentation Type")]
        [Required()]
        public string ProductDocumentationTypeRcd { get; set; } //;
        
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
