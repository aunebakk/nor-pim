/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:29 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeClientDocumentTypeRefModel {
        
        [Display(Name="Client Document Type")]
        [Required()]
        public string ClientDocumentTypeRcd { get; set; } //;
        
        [Display(Name="Client Document Type Name")]
        [Required()]
        public string ClientDocumentTypeName { get; set; } //;
        
        [Display(Name="Client Document Type Description")]
        [Required()]
        public string ClientDocumentTypeDescription { get; set; } //;
        
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
