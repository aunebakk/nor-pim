/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:13:36 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

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
