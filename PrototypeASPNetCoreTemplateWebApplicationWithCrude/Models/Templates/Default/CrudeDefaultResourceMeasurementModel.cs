/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:47 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultResourceMeasurementModel {
        
        [Display(Name="Default Resource Measurement Id")]
        [Required()]
        public System.Guid DefaultResourceMeasurementId { get; set; } //;
        
        [Display(Name="Client Workingset Bytes")]
        [Required()]
        public int ClientWorkingsetBytes { get; set; } //;
        
        [Display(Name="Business Workingset Bytes")]
        [Required()]
        public int BusinessWorkingsetBytes { get; set; } //;
        
        [Display(Name="Database Size Bytes")]
        [Required()]
        public int DatabaseSizeBytes { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
