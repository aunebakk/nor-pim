/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:20 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeClientIdentifierTypeRefModel {
        
        [Display(Name="Client Identifier Type")]
        [Required()]
        public string ClientIdentifierTypeRcd { get; set; } //;
        
        [Display(Name="Client Identifier Type Name")]
        [Required()]
        public string ClientIdentifierTypeName { get; set; } //;
        
        [Display(Name="Client Identifier Type Description")]
        [Required()]
        public string ClientIdentifierTypeDescription { get; set; } //;
        
        [Display(Name="Active Flag")]
        [Required()]
        public bool ActiveFlag { get; set; } //;
        
        [Display(Name="Sort Order")]
        [Required()]
        public int SortOrder { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
