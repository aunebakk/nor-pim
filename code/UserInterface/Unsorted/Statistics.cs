using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class Statistics : Form {
        
        public Statistics() {
           InitializeComponent();
           InitializeGridProductStatisticsTop5();
           InitializeGridProductStatistics();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            StatisticsSearchService productStatisticsTop5 = new StatisticsSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                Log("diagnostics, start test: " + DateTime.UtcNow);
                bindingSource.DataSource = productStatisticsTop5.ProductStatisticsTop5();
                Log("diagnostics, end test: " + DateTime.UtcNow);

                gridProductStatisticsTop5.AutoGenerateColumns = true;
                gridProductStatisticsTop5.DataSource = bindingSource;
                gridProductStatisticsTop5.AutoResizeColumns();
                gridProductStatisticsTop5.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productStatisticsTop5.Close();
            }

            // second
            StatisticsSearchService productStatistics = new StatisticsSearchService();
            BindingSource bindingSource2 = new BindingSource();

            try {
                bindingSource2.DataSource = productStatistics.ProductStatistics();
                gridProductStatistics.AutoGenerateColumns = true;
                gridProductStatistics.DataSource = bindingSource2;
                gridProductStatistics.AutoResizeColumns();
                gridProductStatistics.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productStatistics.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductStatistics() {
            gridProductStatistics.Columns.Clear();
            gridProductStatistics.AutoGenerateColumns = false;
            gridProductStatistics.Columns.Add("ActivityDate","Activity Date");
            gridProductStatistics.Columns.Add("DayCount","Day Count");
            gridProductStatistics.Columns.Add("ExtensionData", "");
            gridProductStatistics.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductStatistics.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductStatistics.AutoResizeColumns();
        }

        private void InitializeGridProductStatisticsTop5() {
            gridProductStatisticsTop5.Columns.Clear();
            gridProductStatisticsTop5.AutoGenerateColumns = false;
            gridProductStatisticsTop5.Columns.Add("Measurement","Measurement");
            gridProductStatisticsTop5.Columns.Add("Value","Value");
            gridProductStatisticsTop5.Columns.Add("ExtensionData", "");
            gridProductStatisticsTop5.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductStatisticsTop5.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductStatisticsTop5.AutoResizeColumns();
        }

        private void Log(string message) {
            Singleton.Instance.Log(message);
        }

        private void buttonPingTest_Click(object sender, EventArgs e) {
            var diagnostics = new norpim.BusinessLogicLayer.Other.DiagnosticsServiceClient();
            try {
                DateTime startTime = DateTime.UtcNow;
                for (int loop = 0; loop<100; loop++)
                    diagnostics.PingTest();

                Log("diagnostics, ping test: " + DateTime.UtcNow.Subtract(startTime).ToString());

            } catch (Exception ex) {
                Log("exception: " + ex.Message);
                if (ex.InnerException != null)
                    Log("exception inner: " + ex.InnerException.Message);
            } finally {
                Log("login, closing diagnostics");
                diagnostics.Close();
                Log("login, closing login");
            }
        }
    }
}
