/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:38:05 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeClientAddressContract {
        
        [DataMember()]
        public System.Guid ClientAddressId { get; set; } //;
        
        [DataMember()]
        public System.Guid ClientId { get; set; } //;
        
        [DataMember()]
        public string ClientAddressTypeRcd { get; set; } //;
        
        [DataMember()]
        public string AddressLineOneName { get; set; } //;
        
        [DataMember()]
        public string AddressLineTwoName { get; set; } //;
        
        [DataMember()]
        public string AddressLineThreeName { get; set; } //;
        
        [DataMember()]
        public string CityName { get; set; } //;
        
        [DataMember()]
        public string StreetName { get; set; } //;
        
        [DataMember()]
        public string StateName { get; set; } //;
        
        [DataMember()]
        public string DistrictName { get; set; } //;
        
        [DataMember()]
        public string ProvinceName { get; set; } //;
        
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
