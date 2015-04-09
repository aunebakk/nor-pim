using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductStatisticsSearch : Form {
        
        public ProductStatisticsSearch() {
           InitializeComponent();
           InitializeGridProductStatistics();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            StatisticsSearchService productStatistics = new StatisticsSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productStatistics.ProductStatistics();
                gridProductStatistics.AutoGenerateColumns = true;
                gridProductStatistics.DataSource = bindingSource;
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
    }
}
