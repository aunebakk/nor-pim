/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:46:12 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in DashboardCounts's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class DashboardCountsContract {
        
        [DataMember()]
        public string DashboardItemRcd { get; set; }
        
        [DataMember()]
        public string DashboardItemName { get; set; }
        
        [DataMember()]
        public string ImageSource { get; set; }
        
        [DataMember()]
        public string Value { get; set; }
        
        [DataMember()]
        public int Last24HoursCount { get; set; }
        
        [DataMember()]
        public string LastDateTime { get; set; }
        
        [DataMember()]
        public string LastUserName { get; set; }
        
        [DataMember()]
        public string Url { get; set; }
        
        [DataMember()]
        public int PositionLeft { get; set; }
        
        [DataMember()]
        public int PositionTop { get; set; }
        
        [DataMember()]
        public int PositionOffset { get; set; }
    }
}
