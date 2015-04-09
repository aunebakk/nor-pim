using System;
using System.Configuration;
using System.ServiceModel;
using System.Windows.Forms;

namespace norpim.BusinessLogicLayer {
    [ServiceContract()]
    public interface IDiagnosticsService {
        [OperationContract()]
        DateTime PingTest();
        
        [OperationContract()]
        string Database();

        [OperationContract()]
        string ComputerName();
    }

    /// <domain>Diagnostics</domain>
    /// <namespace>norpim.BusinessLogicLayer.Other</namespace>
    public class DiagnosticsService : IDiagnosticsService {
        public DateTime PingTest() {
            return DateTime.UtcNow;
        }

        public string Database() {
            string connection = ConfigurationManager.AppSettings["Conn"];
            
            // exclude password if present
            if (connection.IndexOf("Password") > 0)
                return connection.Substring(0, 
                       connection.IndexOf("Password"));

            return connection;
        }

        public string ComputerName() {
            return SystemInformation.ComputerName;
        }
    }
}
