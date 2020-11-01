/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:36:25 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultUserListForDashboardContract {
        
        [DataMember()]
        public string DefaultUserCode { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public string Email { get; set; }
        
        [DataMember()]
        public string DefaultStateName { get; set; }
        
        [DataMember()]
        public int ActivityCount { get; set; }
        
        [DataMember()]
        public string LastActivityDateTime { get; set; }
        
        [DataMember()]
        public string CreatedDateTime { get; set; }
        
        [DataMember()]
        public string CreatedByDefaultUserCode { get; set; }
        
        [DataMember()]
        public string CreatedByDefaultUserName { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
    }
}
