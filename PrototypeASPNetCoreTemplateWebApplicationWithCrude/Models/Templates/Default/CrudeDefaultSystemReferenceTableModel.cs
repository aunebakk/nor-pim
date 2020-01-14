/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:56 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultSystemReferenceTableModel {
        
        [Display(Name="Default System Reference Table Id")]
        [Required()]
        public System.Guid DefaultSystemReferenceTableId { get; set; } //;
        
        [Display(Name="Default System Reference Table Name")]
        [Required()]
        public string DefaultSystemReferenceTableName { get; set; } //;
        
        [Display(Name="Default System Reference Display Name")]
        [Required()]
        public string DefaultSystemReferenceDisplayName { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
