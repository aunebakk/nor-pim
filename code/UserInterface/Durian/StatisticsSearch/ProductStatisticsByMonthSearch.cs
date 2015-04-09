using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductStatisticsByMonthSearch : Form {
        
        public ProductStatisticsByMonthSearch() {
           InitializeComponent();
           InitializeGridProductStatisticsByMonth();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            StatisticsSearchService productStatisticsByMonth = new StatisticsSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productStatisticsByMonth.ProductStatisticsByMonth();
                gridProductStatisticsByMonth.AutoGenerateColumns = true;
                gridProductStatisticsByMonth.DataSource = bindingSource;
                gridProductStatisticsByMonth.AutoResizeColumns();
                gridProductStatisticsByMonth.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productStatisticsByMonth.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductStatisticsByMonth() {
            gridProductStatisticsByMonth.Columns.Clear();
            gridProductStatisticsByMonth.AutoGenerateColumns = false;
            gridProductStatisticsByMonth.Columns.Add("ActivityDate","Activity Date");
            gridProductStatisticsByMonth.Columns.Add("DayCount","Day Count");
            gridProductStatisticsByMonth.Columns.Add("ExtensionData", "");
            gridProductStatisticsByMonth.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductStatisticsByMonth.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductStatisticsByMonth.AutoResizeColumns();
        }
    }
}
