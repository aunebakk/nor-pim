/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:09:35 AM
  From Machine: DESKTOP-9A2DH39
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
        List<DefaultTestOverviewContract> DefaultTestOverview(string commandName);
        [OperationContract()]
        List<DashboardCountsContract> DashboardCounts(string dashboardLayoutRcd);
        [OperationContract()]
        List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter(string commandName);
        [OperationContract()]
        List<DefaultIssueWithFilterContract> DefaultIssueWithFilter(string defaultIssueTypeRcd, string defaultIssueStatusRcd);
        [OperationContract()]
        List<DefaultErrorOverviewContract> DefaultErrorOverview();
        [OperationContract()]
        List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators();
        [OperationContract()]
        List<DefaultStatisticsContract> DefaultStatistics();
        [OperationContract()]
        List<DefaultUserActivityByHourContract> DefaultUserActivityByHour();
        [OperationContract()]
        List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth();
        [OperationContract()]
        List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5();
        [OperationContract()]
        List<DefaultPerformanceTimesContract> DefaultPerformanceTimes(string commandName);
        [OperationContract()]
        List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands();
        [OperationContract()]
        List<DefaultUserActivityRecentContract> DefaultUserActivityRecent(Guid defaultUserId);
        [OperationContract()]
        List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress(string originatingAddress);
        [OperationContract()]
        List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped();
        [OperationContract()]
        List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress();
        [OperationContract()]
        List<DefaultUserListContract> DefaultUserList();
        [OperationContract()]
        List<DefaultUserListForDashboardContract> DefaultUserListForDashboard();
        [OperationContract()]
        List<GetDefaultChangeLogContract> GetDefaultChangeLog(string defaultChangeName, string defaultChangeLogTypeRcd, Guid defaultIssueId, Guid defaultChangeLogId);
        [OperationContract()]
        List<DefaultResourceStatisticsContract> DefaultResourceStatistics();
        [OperationContract()]
        List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics();
    }

    public partial class DefaultSearchService : IDefaultSearchService {
        
        public virtual List<DefaultTestOverviewContract> DefaultTestOverview(string commandName) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultTestOverview();
            return businessLogicLayer.DefaultTestOverviewFromDal(dataAccessLayer.DefaultTestOverview(commandName));
        }

        public List<DashboardCountsContract> DashboardCounts(string dashboardLayoutRcd) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DashboardCounts();
            return businessLogicLayer.DashboardCountsFromDal(dataAccessLayer.DashboardCounts(dashboardLayoutRcd));
        }

        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter(string commandName) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceIssueFetchWithFilter();
            return businessLogicLayer.DefaultPerformanceIssueFetchWithFilterFromDal(dataAccessLayer.DefaultPerformanceIssueFetchWithFilter(commandName));
        }

        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilter(string defaultIssueTypeRcd, string defaultIssueStatusRcd) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultIssueWithFilter();
            return businessLogicLayer.DefaultIssueWithFilterFromDal(dataAccessLayer.DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd));
        }

        public List<DefaultErrorOverviewContract> DefaultErrorOverview() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultErrorOverview();
            return businessLogicLayer.DefaultErrorOverviewFromDal(dataAccessLayer.DefaultErrorOverview());
        }

        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceIndicators();
            return businessLogicLayer.DefaultPerformanceIndicatorsFromDal(dataAccessLayer.DefaultPerformanceIndicators());
        }

        public List<DefaultStatisticsContract> DefaultStatistics() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatistics();
            return businessLogicLayer.DefaultStatisticsFromDal(dataAccessLayer.DefaultStatistics());
        }

        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHour() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityByHour();
            return businessLogicLayer.DefaultUserActivityByHourFromDal(dataAccessLayer.DefaultUserActivityByHour());
        }

        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatisticsByMonth();
            return businessLogicLayer.DefaultStatisticsByMonthFromDal(dataAccessLayer.DefaultStatisticsByMonth());
        }

        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultStatisticsTop5();
            return businessLogicLayer.DefaultStatisticsTop5FromDal(dataAccessLayer.DefaultStatisticsTop5());
        }

        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimes(string commandName) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceTimes();
            return businessLogicLayer.DefaultPerformanceTimesFromDal(dataAccessLayer.DefaultPerformanceTimes(commandName));
        }

        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultPerformanceTimeCommands();
            return businessLogicLayer.DefaultPerformanceTimeCommandsFromDal(dataAccessLayer.DefaultPerformanceTimeCommands());
        }

        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecent(Guid defaultUserId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityRecent();
            return businessLogicLayer.DefaultUserActivityRecentFromDal(dataAccessLayer.DefaultUserActivityRecent(defaultUserId));
        }

        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress(string originatingAddress) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityOnAddress();
            return businessLogicLayer.DefaultUserActivityOnAddressFromDal(dataAccessLayer.DefaultUserActivityOnAddress(originatingAddress));
        }

        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityGrouped();
            return businessLogicLayer.DefaultUserActivityGroupedFromDal(dataAccessLayer.DefaultUserActivityGrouped());
        }

        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserActivityGroupedByAddress();
            return businessLogicLayer.DefaultUserActivityGroupedByAddressFromDal(dataAccessLayer.DefaultUserActivityGroupedByAddress());
        }

        public List<DefaultUserListContract> DefaultUserList() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserList();
            return businessLogicLayer.DefaultUserListFromDal(dataAccessLayer.DefaultUserList());
        }

        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboard() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultUserListForDashboard();
            return businessLogicLayer.DefaultUserListForDashboardFromDal(dataAccessLayer.DefaultUserListForDashboard());
        }

        public List<GetDefaultChangeLogContract> GetDefaultChangeLog(string defaultChangeName, string defaultChangeLogTypeRcd, Guid defaultIssueId, Guid defaultChangeLogId) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new GetDefaultChangeLog();
            return businessLogicLayer.GetDefaultChangeLogFromDal(dataAccessLayer.GetDefaultChangeLog(defaultChangeName, defaultChangeLogTypeRcd, defaultIssueId, defaultChangeLogId));
        }

        public List<DefaultResourceStatisticsContract> DefaultResourceStatistics() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultResourceStatistics();
            return businessLogicLayer.DefaultResourceStatisticsFromDal(dataAccessLayer.DefaultResourceStatistics());
        }

        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics() {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            var businessLogicLayer = new DefaultResourceDatabaseStatistics();
            return businessLogicLayer.DefaultResourceDatabaseStatisticsFromDal(dataAccessLayer.DefaultResourceDatabaseStatistics());
        }
    }
}
