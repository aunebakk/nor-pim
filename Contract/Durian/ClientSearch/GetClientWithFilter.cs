/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:45:41 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in GetClientWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
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
