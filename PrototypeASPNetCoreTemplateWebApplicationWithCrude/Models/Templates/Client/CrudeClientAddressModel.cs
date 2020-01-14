/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:24 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeClientAddressModel {
        
        [Display(Name="Client Address Id")]
        [Required()]
        public System.Guid ClientAddressId { get; set; } //;
        
        [Display(Name="Client Id")]
        [Required()]
        public System.Guid ClientId { get; set; } //;
        
        [Display(Name="Client Address Type")]
        [Required()]
        public string ClientAddressTypeRcd { get; set; } //;
        
        [Display(Name="Address Line One Name")]
        [Required()]
        public string AddressLineOneName { get; set; } //;
        
        [Display(Name="Address Line Two Name")]
        [Required()]
        public string AddressLineTwoName { get; set; } //;
        
        [Display(Name="Address Line Three Name")]
        [Required()]
        public string AddressLineThreeName { get; set; } //;
        
        [Display(Name="City Name")]
        [Required()]
        public string CityName { get; set; } //;
        
        [Display(Name="Street Name")]
        [Required()]
        public string StreetName { get; set; } //;
        
        [Display(Name="State Name")]
        [Required()]
        public string StateName { get; set; } //;
        
        [Display(Name="District Name")]
        [Required()]
        public string DistrictName { get; set; } //;
        
        [Display(Name="Province Name")]
        [Required()]
        public string ProvinceName { get; set; } //;
        
        [Display(Name="Zip Code")]
        [Required()]
        public string ZipCode { get; set; } //;
        
        [Display(Name="Po Box")]
        [Required()]
        public string PoBox { get; set; } //;
        
        [Display(Name="Comment")]
        [Required()]
        public string Comment { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
