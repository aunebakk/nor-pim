/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:31 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeClientLinkModel {
        
        [Display(Name="Client Link Id")]
        [Required()]
        public System.Guid ClientLinkId { get; set; } //;
        
        [Display(Name="Client Id")]
        [Required()]
        public System.Guid ClientId { get; set; } //;
        
        [Display(Name="Client Link Type")]
        [Required()]
        public string ClientLinkTypeRcd { get; set; } //;
        
        [Display(Name="Link Name")]
        [Required()]
        public string LinkName { get; set; } //;
        
        [Display(Name="Link")]
        [Required()]
        public string Link { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
