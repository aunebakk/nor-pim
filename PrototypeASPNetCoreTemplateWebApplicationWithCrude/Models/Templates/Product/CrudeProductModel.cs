/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductModel {
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; } //;
        
        [Display(Name="Product Became Id")]
        [Required()]
        public System.Guid ProductBecameId { get; set; } //;
        
        [Display(Name="Product Name")]
        [Required()]
        public string ProductName { get; set; } //;
        
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
