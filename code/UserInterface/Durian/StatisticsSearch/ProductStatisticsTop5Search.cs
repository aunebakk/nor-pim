using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductStatisticsTop5Search : Form {
        
        public ProductStatisticsTop5Search() {
           InitializeComponent();
           InitializeGridProductStatisticsTop5();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            StatisticsSearchService productStatisticsTop5 = new StatisticsSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productStatisticsTop5.ProductStatisticsTop5();
                gridProductStatisticsTop5.AutoGenerateColumns = true;
                gridProductStatisticsTop5.DataSource = bindingSource;
                gridProductStatisticsTop5.AutoResizeColumns();
                gridProductStatisticsTop5.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productStatisticsTop5.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
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
    }
}
