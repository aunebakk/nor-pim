/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:45:42 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultTestModel {
        
        [Display(Name="Default Test Id")]
        [Required()]
        public System.Guid DefaultTestId { get; set; } //;
        
        [Display(Name="System Name")]
        [Required()]
        public string SystemName { get; set; } //;
        
        [Display(Name="Test Area")]
        [Required()]
        public string TestArea { get; set; } //;
        
        [Display(Name="Test Sub Area")]
        [Required()]
        public string TestSubArea { get; set; } //;
        
        [Display(Name="Test Address")]
        [Required()]
        public string TestAddress { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
