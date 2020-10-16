/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:00:37 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;

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
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultTestOverview businessLogicLayer = new DefaultTestOverview();
            return businessLogicLayer.DefaultTestOverviewFromDal(dataAccessLayer.DefaultTestOverview(commandName));
        }

        public List<DashboardCountsContract> DashboardCounts(string dashboardLayoutRcd) {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DashboardCounts businessLogicLayer = new DashboardCounts();
            return businessLogicLayer.DashboardCountsFromDal(dataAccessLayer.DashboardCounts(dashboardLayoutRcd));
        }

        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilter(string commandName) {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultPerformanceIssueFetchWithFilter businessLogicLayer = new DefaultPerformanceIssueFetchWithFilter();
            return businessLogicLayer.DefaultPerformanceIssueFetchWithFilterFromDal(dataAccessLayer.DefaultPerformanceIssueFetchWithFilter(commandName));
        }

        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilter(string defaultIssueTypeRcd, string defaultIssueStatusRcd) {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultIssueWithFilter businessLogicLayer = new DefaultIssueWithFilter();
            return businessLogicLayer.DefaultIssueWithFilterFromDal(dataAccessLayer.DefaultIssueWithFilter(defaultIssueTypeRcd, defaultIssueStatusRcd));
        }

        public List<DefaultErrorOverviewContract> DefaultErrorOverview() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultErrorOverview businessLogicLayer = new DefaultErrorOverview();
            return businessLogicLayer.DefaultErrorOverviewFromDal(dataAccessLayer.DefaultErrorOverview());
        }

        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicators() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultPerformanceIndicators businessLogicLayer = new DefaultPerformanceIndicators();
            return businessLogicLayer.DefaultPerformanceIndicatorsFromDal(dataAccessLayer.DefaultPerformanceIndicators());
        }

        public List<DefaultStatisticsContract> DefaultStatistics() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultStatistics businessLogicLayer = new DefaultStatistics();
            return businessLogicLayer.DefaultStatisticsFromDal(dataAccessLayer.DefaultStatistics());
        }

        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHour() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultUserActivityByHour businessLogicLayer = new DefaultUserActivityByHour();
            return businessLogicLayer.DefaultUserActivityByHourFromDal(dataAccessLayer.DefaultUserActivityByHour());
        }

        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonth() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultStatisticsByMonth businessLogicLayer = new DefaultStatisticsByMonth();
            return businessLogicLayer.DefaultStatisticsByMonthFromDal(dataAccessLayer.DefaultStatisticsByMonth());
        }

        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultStatisticsTop5 businessLogicLayer = new DefaultStatisticsTop5();
            return businessLogicLayer.DefaultStatisticsTop5FromDal(dataAccessLayer.DefaultStatisticsTop5());
        }

        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimes(string commandName) {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultPerformanceTimes businessLogicLayer = new DefaultPerformanceTimes();
            return businessLogicLayer.DefaultPerformanceTimesFromDal(dataAccessLayer.DefaultPerformanceTimes(commandName));
        }

        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommands() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultPerformanceTimeCommands businessLogicLayer = new DefaultPerformanceTimeCommands();
            return businessLogicLayer.DefaultPerformanceTimeCommandsFromDal(dataAccessLayer.DefaultPerformanceTimeCommands());
        }

        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecent(Guid defaultUserId) {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultUserActivityRecent businessLogicLayer = new DefaultUserActivityRecent();
            return businessLogicLayer.DefaultUserActivityRecentFromDal(dataAccessLayer.DefaultUserActivityRecent(defaultUserId));
        }

        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddress(string originatingAddress) {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultUserActivityOnAddress businessLogicLayer = new DefaultUserActivityOnAddress();
            return businessLogicLayer.DefaultUserActivityOnAddressFromDal(dataAccessLayer.DefaultUserActivityOnAddress(originatingAddress));
        }

        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGrouped() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultUserActivityGrouped businessLogicLayer = new DefaultUserActivityGrouped();
            return businessLogicLayer.DefaultUserActivityGroupedFromDal(dataAccessLayer.DefaultUserActivityGrouped());
        }

        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddress() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultUserActivityGroupedByAddress businessLogicLayer = new DefaultUserActivityGroupedByAddress();
            return businessLogicLayer.DefaultUserActivityGroupedByAddressFromDal(dataAccessLayer.DefaultUserActivityGroupedByAddress());
        }

        public List<DefaultUserListContract> DefaultUserList() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultUserList businessLogicLayer = new DefaultUserList();
            return businessLogicLayer.DefaultUserListFromDal(dataAccessLayer.DefaultUserList());
        }

        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboard() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultUserListForDashboard businessLogicLayer = new DefaultUserListForDashboard();
            return businessLogicLayer.DefaultUserListForDashboardFromDal(dataAccessLayer.DefaultUserListForDashboard());
        }

        public List<GetDefaultChangeLogContract> GetDefaultChangeLog(string defaultChangeName, string defaultChangeLogTypeRcd, Guid defaultIssueId, Guid defaultChangeLogId) {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            GetDefaultChangeLog businessLogicLayer = new GetDefaultChangeLog();
            return businessLogicLayer.GetDefaultChangeLogFromDal(dataAccessLayer.GetDefaultChangeLog(defaultChangeName, defaultChangeLogTypeRcd, defaultIssueId, defaultChangeLogId));
        }

        public List<DefaultResourceStatisticsContract> DefaultResourceStatistics() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultResourceStatistics businessLogicLayer = new DefaultResourceStatistics();
            return businessLogicLayer.DefaultResourceStatisticsFromDal(dataAccessLayer.DefaultResourceStatistics());
        }

        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatistics() {
            DataAccessLayer.DefaultSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.DefaultSearch();
            DefaultResourceDatabaseStatistics businessLogicLayer = new DefaultResourceDatabaseStatistics();
            return businessLogicLayer.DefaultResourceDatabaseStatisticsFromDal(dataAccessLayer.DefaultResourceDatabaseStatistics());
        }
    }
}
