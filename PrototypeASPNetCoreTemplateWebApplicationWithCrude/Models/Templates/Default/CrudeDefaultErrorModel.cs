/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:26 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultErrorModel {
        
        [Display(Name="Default Error Id")]
        [Required()]
        public System.Guid DefaultErrorId { get; set; } //;
        
        [Display(Name="Default Error Layer")]
        [Required()]
        public string DefaultErrorLayerRcd { get; set; } //;
        
        [Display(Name="Default Error Type")]
        [Required()]
        public string DefaultErrorTypeRcd { get; set; } //;
        
        [Display(Name="Layer Address")]
        [Required()]
        public string LayerAddress { get; set; } //;
        
        [Display(Name="Error Message")]
        [Required()]
        public string ErrorMessage { get; set; } //;
        
        [Display(Name="Stack Trace")]
        [Required()]
        public string StackTrace { get; set; } //;
        
        [Display(Name="Method Name")]
        [Required()]
        public string MethodName { get; set; } //;
        
        [Display(Name="Domain Name")]
        [Required()]
        public string DomainName { get; set; } //;
        
        [Display(Name="Class Name")]
        [Required()]
        public string ClassName { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
