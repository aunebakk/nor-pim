using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface
{


    public partial class Statistics : Form
    {

        public Statistics() {
            InitializeComponent();
            InitializeGridDefaultStatisticsTop5();
            InitializeGridDefaultStatistics();
            this.AcceptButton = btnSearch;
            this.CancelButton = btnClose;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            var productStatisticsTop5 = new DefaultSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                Log("diagnostics, start test: " + DateTime.UtcNow);
                bindingSource.DataSource = productStatisticsTop5.DefaultStatisticsTop5();
                Log("diagnostics, end test: " + DateTime.UtcNow);

                gridDefaultStatisticsTop5.AutoGenerateColumns = true;
                gridDefaultStatisticsTop5.DataSource = bindingSource;
                gridDefaultStatisticsTop5.AutoResizeColumns();
                gridDefaultStatisticsTop5.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                productStatisticsTop5.Close();
            }

            // second
            var productStatistics = new DefaultSearchService();
            BindingSource bindingSource2 = new BindingSource();

            try {
                bindingSource2.DataSource = productStatistics.DefaultStatistics();
                gridDefaultStatistics.AutoGenerateColumns = true;
                gridDefaultStatistics.DataSource = bindingSource2;
                gridDefaultStatistics.AutoResizeColumns();
                gridDefaultStatistics.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                productStatistics.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void InitializeGridDefaultStatistics() {
            gridDefaultStatistics.Columns.Clear();
            gridDefaultStatistics.AutoGenerateColumns = false;
            gridDefaultStatistics.Columns.Add("ActivityDate", "Activity Date");
            gridDefaultStatistics.Columns.Add("DayCount", "Day Count");
            gridDefaultStatistics.Columns.Add("ExtensionData", "");
            gridDefaultStatistics.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in gridDefaultStatistics.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            gridDefaultStatistics.AutoResizeColumns();
        }

        private void InitializeGridDefaultStatisticsTop5() {
            gridDefaultStatisticsTop5.Columns.Clear();
            gridDefaultStatisticsTop5.AutoGenerateColumns = false;
            gridDefaultStatisticsTop5.Columns.Add("Measurement", "Measurement");
            gridDefaultStatisticsTop5.Columns.Add("Value", "Value");
            gridDefaultStatisticsTop5.Columns.Add("ExtensionData", "");
            gridDefaultStatisticsTop5.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in gridDefaultStatisticsTop5.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            gridDefaultStatisticsTop5.AutoResizeColumns();
        }

        private void Log(string message) {
            Singleton.Instance.Log(message);
        }

        private void buttonPingTest_Click(object sender, EventArgs e) {
            var diagnostics = new DiagnosticsServiceClient();
            try {
                DateTime startTime = DateTime.UtcNow;
                for ( int loop = 0; loop < 100; loop++ )
                    diagnostics.PingTest();

                Log("diagnostics, ping test: " + DateTime.UtcNow.Subtract(startTime).ToString());

            } catch ( Exception ex ) {
                Log("exception: " + ex.Message);
                if ( ex.InnerException != null )
                    Log("exception inner: " + ex.InnerException.Message);
            } finally {
                Log("login, closing diagnostics");
                diagnostics.Close();
                Log("login, closing login");
            }
        }
    }
}
