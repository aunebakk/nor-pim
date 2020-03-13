/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:40:26 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeLocationAddressContract {
        
        [DataMember()]
        public System.Guid LocationAddressId { get; set; } //;
        
        [DataMember()]
        public string LocationAddressTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid LocationCountryId { get; set; } //;
        
        [DataMember()]
        public string AddressOne { get; set; } //;
        
        [DataMember()]
        public string AddressTwo { get; set; } //;
        
        [DataMember()]
        public string AddressThree { get; set; } //;
        
        [DataMember()]
        public string City { get; set; } //;
        
        [DataMember()]
        public string Street { get; set; } //;
        
        [DataMember()]
        public string State { get; set; } //;
        
        [DataMember()]
        public string District { get; set; } //;
        
        [DataMember()]
        public string Province { get; set; } //;
        
        [DataMember()]
        public string ZipCode { get; set; } //;
        
        [DataMember()]
        public string PoBox { get; set; } //;
        
        [DataMember()]
        public string Comment { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
