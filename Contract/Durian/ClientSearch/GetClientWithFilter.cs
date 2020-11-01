/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:09:31 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class GetClientWithFilterContract {
        
        [DataMember()]
        public string FirstName { get; set; }
        
        [DataMember()]
        public string MiddleName { get; set; }
        
        [DataMember()]
        public string LastName { get; set; }
        
        [DataMember()]
        public string ClientTypeRcd { get; set; }
        
        [DataMember()]
        public string ClientTypeName { get; set; }
        
        [DataMember()]
        public string ClientNationalityRcd { get; set; }
        
        [DataMember()]
        public string ClientNationalityName { get; set; }
        
        [DataMember()]
        public string ClientGenderRcd { get; set; }
        
        [DataMember()]
        public string ClientGenderName { get; set; }
        
        [DataMember()]
        public string ClientTitleRcd { get; set; }
        
        [DataMember()]
        public string ClientTitleName { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
        
        [DataMember()]
        public System.Guid ClientUserId { get; set; }
    }
}
