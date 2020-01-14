/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:01 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeClientTitleRefModel {
        
        [Display(Name="Client Title")]
        [Required()]
        public string ClientTitleRcd { get; set; } //;
        
        [Display(Name="Client Title Name")]
        [Required()]
        public string ClientTitleName { get; set; } //;
        
        [Display(Name="Client Title Description")]
        [Required()]
        public string ClientTitleDescription { get; set; } //;
        
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
