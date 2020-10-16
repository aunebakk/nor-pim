/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:04 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class GetDefaultChangeLog {

        public List<GetDefaultChangeLogContract> GetDefaultChangeLogFromDal(List<GetDefaultChangeLogData> dataList) {
            List<GetDefaultChangeLogContract> list = new List<GetDefaultChangeLogContract>();

            foreach (GetDefaultChangeLogData data in dataList) {
                GetDefaultChangeLogContract contract = new GetDefaultChangeLogContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(GetDefaultChangeLogData dalGetDefaultChangeLog, GetDefaultChangeLogContract dataContract) {
            dataContract.DefaultChangeName = dalGetDefaultChangeLog.DefaultChangeName;
            dataContract.DefaultChangeDescription = dalGetDefaultChangeLog.DefaultChangeDescription;
            dataContract.DateTime = dalGetDefaultChangeLog.DateTime;
            dataContract.DefaultChangeLogTypeRcd = dalGetDefaultChangeLog.DefaultChangeLogTypeRcd;
            dataContract.DefaultChangeLogTypeName = dalGetDefaultChangeLog.DefaultChangeLogTypeName;
            dataContract.DefaultIssueId = dalGetDefaultChangeLog.DefaultIssueId;
            dataContract.IssueName = dalGetDefaultChangeLog.IssueName;
            dataContract.DefaultChangeLogId = dalGetDefaultChangeLog.DefaultChangeLogId;
        }
    }
}
