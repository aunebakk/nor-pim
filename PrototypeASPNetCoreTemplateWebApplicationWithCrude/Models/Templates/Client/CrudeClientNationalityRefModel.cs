/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:57 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeClientNationalityRefModel {
        
        [Display(Name="Client Nationality")]
        [Required()]
        public string ClientNationalityRcd { get; set; } //;
        
        [Display(Name="Client Nationality Name")]
        [Required()]
        public string ClientNationalityName { get; set; } //;
        
        [Display(Name="Client Nationality Description")]
        [Required()]
        public string ClientNationalityDescription { get; set; } //;
        
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
