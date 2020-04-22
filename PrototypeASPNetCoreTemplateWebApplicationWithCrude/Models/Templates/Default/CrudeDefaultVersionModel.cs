/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:22 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultVersionModel {
        
        [Display(Name="Default Version Id")]
        [Required()]
        public System.Guid DefaultVersionId { get; set; } //;
        
        [Display(Name="Fun Version")]
        [Required()]
        public string FunVersion { get; set; } //;
        
        [Display(Name="Number")]
        [Required()]
        public string Number { get; set; } //;
        
        [Display(Name="Major Number")]
        [Required()]
        public int MajorNumber { get; set; } //;
        
        [Display(Name="Minor Number")]
        [Required()]
        public int MinorNumber { get; set; } //;
        
        [Display(Name="Sequence Number")]
        [Required()]
        public int SequenceNumber { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
