/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:51 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeLocationAddressModel {
        
        [Display(Name="Location Address Id")]
        [Required()]
        public System.Guid LocationAddressId { get; set; } //;
        
        [Display(Name="Location Address Type")]
        [Required()]
        public string LocationAddressTypeRcd { get; set; } //;
        
        [Display(Name="Location Country Id")]
        [Required()]
        public System.Guid LocationCountryId { get; set; } //;
        
        [Display(Name="Address One")]
        [Required()]
        public string AddressOne { get; set; } //;
        
        [Display(Name="Address Two")]
        [Required()]
        public string AddressTwo { get; set; } //;
        
        [Display(Name="Address Three")]
        [Required()]
        public string AddressThree { get; set; } //;
        
        [Display(Name="City")]
        [Required()]
        public string City { get; set; } //;
        
        [Display(Name="Street")]
        [Required()]
        public string Street { get; set; } //;
        
        [Display(Name="State")]
        [Required()]
        public string State { get; set; } //;
        
        [Display(Name="District")]
        [Required()]
        public string District { get; set; } //;
        
        [Display(Name="Province")]
        [Required()]
        public string Province { get; set; } //;
        
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
