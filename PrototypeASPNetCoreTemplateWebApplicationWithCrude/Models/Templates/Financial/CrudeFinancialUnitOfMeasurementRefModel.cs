/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:59 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialUnitOfMeasurementRefModel {
        
        [Display(Name="Financial Unit Of Measurement")]
        [Required()]
        public string FinancialUnitOfMeasurementRcd { get; set; } //;
        
        [Display(Name="Sort Sequence Number")]
        [Required()]
        public int SortSequenceNumber { get; set; } //;
        
        [Display(Name="Change Flag")]
        [Required()]
        public bool ChangeFlag { get; set; } //;
        
        [Display(Name="Status Code")]
        [Required()]
        public string StatusCode { get; set; } //;
        
        [Display(Name="Financial Unit Of Measurement Name")]
        [Required()]
        public string FinancialUnitOfMeasurementName { get; set; } //;
        
        [Display(Name="Financial Unit Of Measurement Code")]
        [Required()]
        public string FinancialUnitOfMeasurementCode { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
