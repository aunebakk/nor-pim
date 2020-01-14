/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:01 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultChangeLogModel {
        
        [Display(Name="Default Change Log Id")]
        [Required()]
        public System.Guid DefaultChangeLogId { get; set; } //;
        
        [Display(Name="Default Change Name")]
        [Required()]
        public string DefaultChangeName { get; set; } //;
        
        [Display(Name="Default Change Description")]
        [Required()]
        public string DefaultChangeDescription { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Default Change Log Type")]
        [Required()]
        public string DefaultChangeLogTypeRcd { get; set; } //;
        
        [Display(Name="Default Issue Id")]
        [Required()]
        public System.Guid DefaultIssueId { get; set; } //;
    }
}
