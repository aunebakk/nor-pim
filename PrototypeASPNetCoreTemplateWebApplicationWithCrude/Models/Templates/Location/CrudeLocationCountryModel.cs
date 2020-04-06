/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:47 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeLocationCountryModel {
        
        [Display(Name="Location Country Id")]
        [Required()]
        public System.Guid LocationCountryId { get; set; } //;
        
        [Display(Name="Location Country Code")]
        [Required()]
        public string LocationCountryCode { get; set; } //;
        
        [Display(Name="Location Country Name")]
        [Required()]
        public string LocationCountryName { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
