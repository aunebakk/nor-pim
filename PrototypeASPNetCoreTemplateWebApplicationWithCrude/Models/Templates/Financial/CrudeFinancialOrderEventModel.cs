/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:07 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialOrderEventModel {
        
        [Display(Name="Fiancial Order Event Id")]
        [Required()]
        public System.Guid FiancialOrderEventId { get; set; } //;
        
        [Display(Name="Financial Order Id")]
        [Required()]
        public System.Guid FinancialOrderId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Comment")]
        [Required()]
        public string Comment { get; set; } //;
        
        [Display(Name="Financial Order Event Type")]
        [Required()]
        public string FinancialOrderEventTypeRcd { get; set; } //;
    }
}
