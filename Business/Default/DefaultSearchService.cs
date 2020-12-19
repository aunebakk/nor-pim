/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:31:45 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface IDefaultSearchService {
        [OperationContract()]
        List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics ();
        [OperationContract()]
        List<DefaultResourceStatisticsContract> DefaultResourceStatistics ();
        [OperationContract()]
        List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId);
        [OperationContract()]
        List<DefaultUserListForDashboardContract> DefaultUserListForDashboard ();
        [OperationContract()]
        List<DefaultUserListContract> DefaultUserList ();
        [OperationContract()]
        List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress ();
        [OperationContract()]
        List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped ();
        [OperationContract()]
        List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress);
        [OperationContract()]
        List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId);
        [OperationContract()]
        List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands ();
        [OperationContract()]
        List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName);
        [OperationContract()]
        List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 ();
        [OperationContract()]
        List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth ();
        [OperationContract()]
        List<DefaultUserActivityByHourContract> DefaultUserActivityByHour ();
        [OperationContract()]
        List<DefaultStatisticsContract> DefaultStatistics ();
        [OperationContract()]
        List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators ();
        [OperationContract()]
        List<DefaultErrorOverviewContract> DefaultErrorOverview ();
        [OperationContract()]
        List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd);
        [OperationContract()]
        List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName);
        [OperationContract()]
        List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd);
        
        [OperationContract()]
        List<DefaultTestOverviewContract> DefaultTestOverview(string commandName);
    }
    
    public partial class DefaultSearchService : IDefaultSearchService {
        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultResourceDatabaseStatistics();
            return businessLogicLayer.DefaultResourceDatabaseStatisticsFromDal(dataAccessLayer.DefaultResourceDatabaseStatistics());
        }
        public List<DefaultResourceStatisticsContract> DefaultResourceStatistics () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultResourceStatistics();
            return businessLogicLayer.DefaultResourceStatisticsFromDal(dataAccessLayer.DefaultResourceStatistics());
        }
        public List<GetDefaultChangeLogContract> GetDefaultChangeLog (System.String defaultChangeName,System.String defaultChangeLogTypeRcd,System.Guid defaultIssueId,System.Guid defaultChangeLogId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new GetDefaultChangeLog();
            return businessLogicLayer.GetDefaultChangeLogFromDal(dataAccessLayer.GetDefaultChangeLog(defaultChangeName, defaultChangeLogTypeRcd, defaultIssueId, defaultChangeLogId));
        }
        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboard () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserListForDashboard();
            return businessLogicLayer.DefaultUserListForDashboardFromDal(dataAccessLayer.DefaultUserListForDashboard());
        }
        public List<DefaultUserListContract> DefaultUserList () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserList();
            return businessLogicLayer.DefaultUserListFromDal(dataAccessLayer.DefaultUserList());
        }
        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityGroupedByAddress();
            return businessLogicLayer.DefaultUserActivityGroupedByAddressFromDal(dataAccessLayer.DefaultUserActivityGroupedByAddress());
        }
        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityGrouped();
            return businessLogicLayer.DefaultUserActivityGroupedFromDal(dataAccessLayer.DefaultUserActivityGrouped());
        }
        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress (System.String originatingAddress) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityOnAddress();
            return businessLogicLayer.DefaultUserActivityOnAddressFromDal(dataAccessLayer.DefaultUserActivityOnAddress(originatingAddress));
        }
        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecent (System.Guid defaultUserId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityRecent();
            return businessLogicLayer.DefaultUserActivityRecentFromDal(dataAccessLayer.DefaultUserActivityRecent(defaultUserId));
        }
        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceTimeCommands();
            return businessLogicLayer.DefaultPerformanceTimeCommandsFromDal(dataAccessLayer.DefaultPerformanceTimeCommands());
        }
        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimes (System.String commandName) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceTimes();
            return businessLogicLayer.DefaultPerformanceTimesFromDal(dataAccessLayer.DefaultPerformanceTimes(commandName));
        }
        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5 () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatisticsTop5();
            return businessLogicLayer.DefaultStatisticsTop5FromDal(dataAccessLayer.DefaultStatisticsTop5());
        }
        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatisticsByMonth();
            return businessLogicLayer.DefaultStatisticsByMonthFromDal(dataAccessLayer.DefaultStatisticsByMonth());
        }
        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHour () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityByHour();
            return businessLogicLayer.DefaultUserActivityByHourFromDal(dataAccessLayer.DefaultUserActivityByHour());
        }
        public List<DefaultStatisticsContract> DefaultStatistics () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatistics();
            return businessLogicLayer.DefaultStatisticsFromDal(dataAccessLayer.DefaultStatistics());
        }
        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceIndicators();
            return businessLogicLayer.DefaultPerformanceIndicatorsFromDal(dataAccessLayer.DefaultPerformanceIndicators());
        }
        public List<DefaultErrorOverviewContract> DefaultErrorOverview () {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultErrorOverview();
            return businessLogicLayer.DefaultErrorOverviewFromDal(dataAccessLayer.DefaultErrorOverview());
        }
        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilter (System.String defaultIssueTypeRcd,System.String defaultIssueStatusRcd) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultIssueWithFilter();
            return businessLogicLayer.DefaultIssueWithFilterFromDal(dataAccessLayer.DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd));
        }
        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter (System.String commandName) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceIssueFetchWithFilter();
            return businessLogicLayer.DefaultPerformanceIssueFetchWithFilterFromDal(dataAccessLayer.DefaultPerformanceIssueFetchWithFilter(commandName));
        }
        public List<DashboardCountsContract> DashboardCounts (System.String dashboardLayoutRcd) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DashboardCounts();
            return businessLogicLayer.DashboardCountsFromDal(dataAccessLayer.DashboardCounts(dashboardLayoutRcd));
        }
        
        public virtual List<DefaultTestOverviewContract> DefaultTestOverview(string commandName) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultTestOverview();
            return businessLogicLayer.DefaultTestOverviewFromDal(dataAccessLayer.DefaultTestOverview(commandName));
        }
    }
}
