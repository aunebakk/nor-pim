/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:21 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeLocationCityModel {
        
        [Display(Name="Location City Id")]
        [Required()]
        public System.Guid LocationCityId { get; set; } //;
        
        [Display(Name="Location Country Id")]
        [Required()]
        public System.Guid LocationCountryId { get; set; } //;
        
        [Display(Name="Location City Code")]
        [Required()]
        public string LocationCityCode { get; set; } //;
        
        [Display(Name="Location City Name")]
        [Required()]
        public string LocationCityName { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
