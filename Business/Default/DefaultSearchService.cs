/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:13:46 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // Interface/Protocol (object-oriented programming): https://en.wikipedia.org/wiki/Protocol_(object-oriented_programming)
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/54dd6dfa-2ac2-4032-a68d-47e4f658ece7
    [ServiceContract()]
    public partial interface IDefaultSearchService {
        // returns a list of DefaultResourceDatabaseStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics ();
        // returns a list of DefaultResourceStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultResourceStatisticsContract> DefaultResourceStatistics ();
        // returns a list of GetDefaultChangeLog contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  defaultChangeName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultChangeLogTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultIssueId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultChangeLogId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId);
        // returns a list of DefaultUserListForDashboard contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultUserListForDashboardContract> DefaultUserListForDashboard ();
        // returns a list of DefaultUserList contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultUserListContract> DefaultUserList ();
        // returns a list of DefaultUserActivityGroupedByAddress contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress ();
        // returns a list of DefaultUserActivityGrouped contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped ();
        // returns a list of DefaultUserActivityOnAddress contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  originatingAddress: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress);
        // returns a list of DefaultUserActivityRecent contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  defaultUserId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId);
        // returns a list of DefaultPerformanceTimeCommands contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands ();
        // returns a list of DefaultPerformanceTimes contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName);
        // returns a list of DefaultStatisticsTop5 contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 ();
        // returns a list of DefaultStatisticsByMonth contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth ();
        // returns a list of DefaultUserActivityByHour contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultUserActivityByHourContract> DefaultUserActivityByHour ();
        // returns a list of DefaultStatistics contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultStatisticsContract> DefaultStatistics ();
        // returns a list of DefaultPerformanceIndicators contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators ();
        // returns a list of DefaultErrorOverview contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //
        [OperationContract()]
        List<DefaultErrorOverviewContract> DefaultErrorOverview ();
        // returns a list of DefaultIssueWithFilter contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  defaultIssueTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultIssueStatusRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd);
        // returns a list of DefaultPerformanceIssueFetchWithFilter contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName);
        // returns a list of DashboardCounts contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  dashboardLayoutRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd);
        
        // returns a list of DefaultTestOverview contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<DefaultTestOverviewContract> DefaultTestOverview(string commandName);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class DefaultSearchService : IDefaultSearchService {
        // returns a list of DefaultResourceDatabaseStatistics contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics () {
            // transfer all DefaultResourceDatabaseStatistics serialized objects from DefaultSearch as DefaultResourceDatabaseStatistics contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultResourceDatabaseStatistics();
            return businessLogicLayer.DefaultResourceDatabaseStatisticsFromDal(dataAccessLayer.DefaultResourceDatabaseStatistics());
        }
        // returns a list of DefaultResourceStatistics contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultResourceStatisticsContract> DefaultResourceStatistics () {
            // transfer all DefaultResourceStatistics serialized objects from DefaultSearch as DefaultResourceStatistics contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultResourceStatistics();
            return businessLogicLayer.DefaultResourceStatisticsFromDal(dataAccessLayer.DefaultResourceStatistics());
        }
        // returns a list of GetDefaultChangeLog contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  defaultChangeName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultChangeLogTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultIssueId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultChangeLogId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId) {
            // transfer all GetDefaultChangeLog serialized objects from DefaultSearch as GetDefaultChangeLog contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new GetDefaultChangeLog();
            return businessLogicLayer.GetDefaultChangeLogFromDal(dataAccessLayer.GetDefaultChangeLog(defaultChangeName, defaultChangeLogTypeRcd, defaultIssueId, defaultChangeLogId));
        }
        // returns a list of DefaultUserListForDashboard contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboard () {
            // transfer all DefaultUserListForDashboard serialized objects from DefaultSearch as DefaultUserListForDashboard contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserListForDashboard();
            return businessLogicLayer.DefaultUserListForDashboardFromDal(dataAccessLayer.DefaultUserListForDashboard());
        }
        // returns a list of DefaultUserList contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultUserListContract> DefaultUserList () {
            // transfer all DefaultUserList serialized objects from DefaultSearch as DefaultUserList contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserList();
            return businessLogicLayer.DefaultUserListFromDal(dataAccessLayer.DefaultUserList());
        }
        // returns a list of DefaultUserActivityGroupedByAddress contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress () {
            // transfer all DefaultUserActivityGroupedByAddress serialized objects from DefaultSearch as DefaultUserActivityGroupedByAddress contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityGroupedByAddress();
            return businessLogicLayer.DefaultUserActivityGroupedByAddressFromDal(dataAccessLayer.DefaultUserActivityGroupedByAddress());
        }
        // returns a list of DefaultUserActivityGrouped contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped () {
            // transfer all DefaultUserActivityGrouped serialized objects from DefaultSearch as DefaultUserActivityGrouped contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityGrouped();
            return businessLogicLayer.DefaultUserActivityGroupedFromDal(dataAccessLayer.DefaultUserActivityGrouped());
        }
        // returns a list of DefaultUserActivityOnAddress contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  originatingAddress: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress) {
            // transfer all DefaultUserActivityOnAddress serialized objects from DefaultSearch as DefaultUserActivityOnAddress contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityOnAddress();
            return businessLogicLayer.DefaultUserActivityOnAddressFromDal(dataAccessLayer.DefaultUserActivityOnAddress(originatingAddress));
        }
        // returns a list of DefaultUserActivityRecent contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  defaultUserId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId) {
            // transfer all DefaultUserActivityRecent serialized objects from DefaultSearch as DefaultUserActivityRecent contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityRecent();
            return businessLogicLayer.DefaultUserActivityRecentFromDal(dataAccessLayer.DefaultUserActivityRecent(defaultUserId));
        }
        // returns a list of DefaultPerformanceTimeCommands contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands () {
            // transfer all DefaultPerformanceTimeCommands serialized objects from DefaultSearch as DefaultPerformanceTimeCommands contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceTimeCommands();
            return businessLogicLayer.DefaultPerformanceTimeCommandsFromDal(dataAccessLayer.DefaultPerformanceTimeCommands());
        }
        // returns a list of DefaultPerformanceTimes contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName) {
            // transfer all DefaultPerformanceTimes serialized objects from DefaultSearch as DefaultPerformanceTimes contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceTimes();
            return businessLogicLayer.DefaultPerformanceTimesFromDal(dataAccessLayer.DefaultPerformanceTimes(commandName));
        }
        // returns a list of DefaultStatisticsTop5 contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 () {
            // transfer all DefaultStatisticsTop5 serialized objects from DefaultSearch as DefaultStatisticsTop5 contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatisticsTop5();
            return businessLogicLayer.DefaultStatisticsTop5FromDal(dataAccessLayer.DefaultStatisticsTop5());
        }
        // returns a list of DefaultStatisticsByMonth contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth () {
            // transfer all DefaultStatisticsByMonth serialized objects from DefaultSearch as DefaultStatisticsByMonth contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatisticsByMonth();
            return businessLogicLayer.DefaultStatisticsByMonthFromDal(dataAccessLayer.DefaultStatisticsByMonth());
        }
        // returns a list of DefaultUserActivityByHour contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHour () {
            // transfer all DefaultUserActivityByHour serialized objects from DefaultSearch as DefaultUserActivityByHour contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityByHour();
            return businessLogicLayer.DefaultUserActivityByHourFromDal(dataAccessLayer.DefaultUserActivityByHour());
        }
        // returns a list of DefaultStatistics contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultStatisticsContract> DefaultStatistics () {
            // transfer all DefaultStatistics serialized objects from DefaultSearch as DefaultStatistics contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatistics();
            return businessLogicLayer.DefaultStatisticsFromDal(dataAccessLayer.DefaultStatistics());
        }
        // returns a list of DefaultPerformanceIndicators contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators () {
            // transfer all DefaultPerformanceIndicators serialized objects from DefaultSearch as DefaultPerformanceIndicators contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceIndicators();
            return businessLogicLayer.DefaultPerformanceIndicatorsFromDal(dataAccessLayer.DefaultPerformanceIndicators());
        }
        // returns a list of DefaultErrorOverview contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //
        public List<DefaultErrorOverviewContract> DefaultErrorOverview () {
            // transfer all DefaultErrorOverview serialized objects from DefaultSearch as DefaultErrorOverview contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultErrorOverview();
            return businessLogicLayer.DefaultErrorOverviewFromDal(dataAccessLayer.DefaultErrorOverview());
        }
        // returns a list of DefaultIssueWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  defaultIssueTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  defaultIssueStatusRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd) {
            // transfer all DefaultIssueWithFilter serialized objects from DefaultSearch as DefaultIssueWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultIssueWithFilter();
            return businessLogicLayer.DefaultIssueWithFilterFromDal(dataAccessLayer.DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd));
        }
        // returns a list of DefaultPerformanceIssueFetchWithFilter contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName) {
            // transfer all DefaultPerformanceIssueFetchWithFilter serialized objects from DefaultSearch as DefaultPerformanceIssueFetchWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceIssueFetchWithFilter();
            return businessLogicLayer.DefaultPerformanceIssueFetchWithFilterFromDal(dataAccessLayer.DefaultPerformanceIssueFetchWithFilter(commandName));
        }
        // returns a list of DashboardCounts contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  dashboardLayoutRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd) {
            // transfer all DashboardCounts serialized objects from DefaultSearch as DashboardCounts contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DashboardCounts();
            return businessLogicLayer.DashboardCountsFromDal(dataAccessLayer.DashboardCounts(dashboardLayoutRcd));
        }
        
        // returns a list of DefaultTestOverview contracts from DefaultSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        // parameters:
        //  commandName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public virtual List<DefaultTestOverviewContract> DefaultTestOverview(string commandName) {
            // transfer all DefaultTestOverview serialized objects from DefaultSearch as DefaultTestOverview contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultTestOverview();
            return businessLogicLayer.DefaultTestOverviewFromDal(dataAccessLayer.DefaultTestOverview(commandName));
        }
    }
}
