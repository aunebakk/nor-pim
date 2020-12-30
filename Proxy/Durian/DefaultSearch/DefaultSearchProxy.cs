/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:13:46 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDefaultSearchService")]
    public interface IDefaultSearchService {
        // returns a list of DefaultResourceDatabaseStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultResourceDatabaseStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultResourceDatabaseStatisticsResponse")]
        List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics ();
        // returns a list of DefaultResourceStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultResourceStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultResourceStatisticsResponse")]
        List<DefaultResourceStatisticsContract> DefaultResourceStatistics ();
        // returns a list of GetDefaultChangeLog contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  defaultChangeName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultChangeLogTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultIssueId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultChangeLogId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/GetDefaultChangeLog", ReplyAction="http://tempuri.org/IDefaultSearchService/GetDefaultChangeLogResponse")]
        List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId);
        // returns a list of DefaultUserListForDashboard contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserListForDashboard", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserListForDashboardResponse")]
        List<DefaultUserListForDashboardContract> DefaultUserListForDashboard ();
        // returns a list of DefaultUserList contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserList", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserListResponse")]
        List<DefaultUserListContract> DefaultUserList ();
        // returns a list of DefaultUserActivityGroupedByAddress contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedByAddress", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedByAddressResponse")]
        List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress ();
        // returns a list of DefaultUserActivityGrouped contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGrouped", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityGroupedResponse")]
        List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped ();
        // returns a list of DefaultUserActivityOnAddress contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  originatingAddress: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityOnAddress", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityOnAddressResponse")]
        List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress);
        // returns a list of DefaultUserActivityRecent contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  defaultUserId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityRecent", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityRecentResponse")]
        List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId);
        // returns a list of DefaultPerformanceTimeCommands contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimeCommands", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimeCommandsResponse")]
        List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands ();
        // returns a list of DefaultPerformanceTimes contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimes", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceTimesResponse")]
        List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName);
        // returns a list of DefaultStatisticsTop5 contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatisticsTop5", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsTop5Response")]
        List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 ();
        // returns a list of DefaultStatisticsByMonth contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatisticsByMonth", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsByMonthResponse")]
        List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth ();
        // returns a list of DefaultUserActivityByHour contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultUserActivityByHour", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultUserActivityByHourResponse")]
        List<DefaultUserActivityByHourContract> DefaultUserActivityByHour ();
        // returns a list of DefaultStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultStatistics", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultStatisticsResponse")]
        List<DefaultStatisticsContract> DefaultStatistics ();
        // returns a list of DefaultPerformanceIndicators contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIndicators", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIndicatorsResponse")]
        List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators ();
        // returns a list of DefaultErrorOverview contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultErrorOverview", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultErrorOverviewResponse")]
        List<DefaultErrorOverviewContract> DefaultErrorOverview ();
        // returns a list of DefaultIssueWithFilter contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  defaultIssueTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultIssueStatusRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultIssueWithFilter", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultIssueWithFilterResponse")]
        List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd);
        // returns a list of DefaultPerformanceIssueFetchWithFilter contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIssueFetchWithFilter", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultPerformanceIssueFetchWithFilterResponse")]
        List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName);
        // returns a list of DashboardCounts contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  dashboardLayoutRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DashboardCounts", ReplyAction="http://tempuri.org/IDefaultSearchService/DashboardCountsResponse")]
        List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd);
        // returns a list of DefaultTestOverview contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDefaultSearchService/DefaultTestOverview", ReplyAction="http://tempuri.org/IDefaultSearchService/DefaultTestOverviewResponse")]
        List<DefaultTestOverviewContract> DefaultTestOverview (System.String commandName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDefaultSearchServiceChannel : IDefaultSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class DefaultSearchService : System.ServiceModel.ClientBase<IDefaultSearchService>, IDefaultSearchService {
        // returns a list of DefaultResourceDatabaseStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics () {
            return base.Channel.DefaultResourceDatabaseStatistics();
        }
        // returns a list of DefaultResourceStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultResourceStatisticsContract> DefaultResourceStatistics () {
            return base.Channel.DefaultResourceStatistics();
        }
        // returns a list of GetDefaultChangeLog contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  defaultChangeName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultChangeLogTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultIssueId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultChangeLogId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId) {
            return base.Channel.GetDefaultChangeLog(defaultChangeName, defaultChangeLogTypeRcd, defaultIssueId, defaultChangeLogId);
        }
        // returns a list of DefaultUserListForDashboard contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboard () {
            return base.Channel.DefaultUserListForDashboard();
        }
        // returns a list of DefaultUserList contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultUserListContract> DefaultUserList () {
            return base.Channel.DefaultUserList();
        }
        // returns a list of DefaultUserActivityGroupedByAddress contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress () {
            return base.Channel.DefaultUserActivityGroupedByAddress();
        }
        // returns a list of DefaultUserActivityGrouped contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped () {
            return base.Channel.DefaultUserActivityGrouped();
        }
        // returns a list of DefaultUserActivityOnAddress contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  originatingAddress: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress) {
            return base.Channel.DefaultUserActivityOnAddress(originatingAddress);
        }
        // returns a list of DefaultUserActivityRecent contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  defaultUserId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId) {
            return base.Channel.DefaultUserActivityRecent(defaultUserId);
        }
        // returns a list of DefaultPerformanceTimeCommands contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands () {
            return base.Channel.DefaultPerformanceTimeCommands();
        }
        // returns a list of DefaultPerformanceTimes contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName) {
            return base.Channel.DefaultPerformanceTimes(commandName);
        }
        // returns a list of DefaultStatisticsTop5 contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 () {
            return base.Channel.DefaultStatisticsTop5();
        }
        // returns a list of DefaultStatisticsByMonth contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth () {
            return base.Channel.DefaultStatisticsByMonth();
        }
        // returns a list of DefaultUserActivityByHour contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHour () {
            return base.Channel.DefaultUserActivityByHour();
        }
        // returns a list of DefaultStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultStatisticsContract> DefaultStatistics () {
            return base.Channel.DefaultStatistics();
        }
        // returns a list of DefaultPerformanceIndicators contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators () {
            return base.Channel.DefaultPerformanceIndicators();
        }
        // returns a list of DefaultErrorOverview contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //
        public List<DefaultErrorOverviewContract> DefaultErrorOverview () {
            return base.Channel.DefaultErrorOverview();
        }
        // returns a list of DefaultIssueWithFilter contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  defaultIssueTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultIssueStatusRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd) {
            return base.Channel.DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd);
        }
        // returns a list of DefaultPerformanceIssueFetchWithFilter contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName) {
            return base.Channel.DefaultPerformanceIssueFetchWithFilter(commandName);
        }
        // returns a list of DashboardCounts contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  dashboardLayoutRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd) {
            return base.Channel.DashboardCounts(dashboardLayoutRcd);
        }
        // returns a list of DefaultTestOverview contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultTestOverviewContract> DefaultTestOverview (System.String commandName) {
            return base.Channel.DefaultTestOverview(commandName);
        }
        
        public DefaultSearchService() {
        }
        
        public DefaultSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DefaultSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DefaultSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
