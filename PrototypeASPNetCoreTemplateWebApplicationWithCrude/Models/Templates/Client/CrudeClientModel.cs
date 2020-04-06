/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:41:17 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeClientModel {
        
        [Display(Name="Client Id")]
        [Required()]
        public System.Guid ClientId { get; set; } //;
        
        [Display(Name="Client Type")]
        [Required()]
        public string ClientTypeRcd { get; set; } //;
        
        [Display(Name="Client Nationality")]
        [Required()]
        public string ClientNationalityRcd { get; set; } //;
        
        [Display(Name="Client Gender")]
        [Required()]
        public string ClientGenderRcd { get; set; } //;
        
        [Display(Name="Client Title")]
        [Required()]
        public string ClientTitleRcd { get; set; } //;
        
        [Display(Name="Client Address Id")]
        [Required()]
        public System.Guid ClientAddressId { get; set; } //;
        
        [Display(Name="First Name")]
        [Required()]
        public string FirstName { get; set; } //;
        
        [Display(Name="Middle Name")]
        [Required()]
        public string MiddleName { get; set; } //;
        
        [Display(Name="Last Name")]
        [Required()]
        public string LastName { get; set; } //;
        
        [Display(Name="Image")]
        [Required()]
        public byte[] Image { get; set; } //;
        
        [Display(Name="Image Blob Filename")]
        [Required()]
        public string ImageBlobFilename { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
