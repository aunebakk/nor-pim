/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:02:23 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeClientDocumentModel {
        
        [Display(Name="Client Document Id")]
        [Required()]
        public System.Guid ClientDocumentId { get; set; } //;
        
        [Display(Name="Client Id")]
        [Required()]
        public System.Guid ClientId { get; set; } //;
        
        [Display(Name="Client Document Type")]
        [Required()]
        public string ClientDocumentTypeRcd { get; set; } //;
        
        [Display(Name="Document Name")]
        [Required()]
        public string DocumentName { get; set; } //;
        
        [Display(Name="Document Date Time")]
        [Required()]
        public System.DateTime DocumentDateTime { get; set; } //;
        
        [Display(Name="Expiry Date Time")]
        [Required()]
        public System.DateTime ExpiryDateTime { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
