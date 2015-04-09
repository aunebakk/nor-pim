using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class UserActivityGroupedByAddressSearch : Form {
        
        public UserActivityGroupedByAddressSearch() {
           InitializeComponent();
           InitializeGridUserActivityGroupedByAddress();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            UserActivitySearchService userActivityGroupedByAddress = new UserActivitySearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = userActivityGroupedByAddress.UserActivityGroupedByAddress();
                gridUserActivityGroupedByAddress.AutoGenerateColumns = true;
                gridUserActivityGroupedByAddress.DataSource = bindingSource;
                gridUserActivityGroupedByAddress.AutoResizeColumns();
                gridUserActivityGroupedByAddress.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                userActivityGroupedByAddress.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridUserActivityGroupedByAddress() {
            gridUserActivityGroupedByAddress.Columns.Clear();
            gridUserActivityGroupedByAddress.AutoGenerateColumns = false;
            gridUserActivityGroupedByAddress.Columns.Add("OriginatingAddress","Originating Address");
            gridUserActivityGroupedByAddress.Columns.Add("Occurrences","Occurrences");
            gridUserActivityGroupedByAddress.Columns.Add("ExtensionData", "");
            gridUserActivityGroupedByAddress.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridUserActivityGroupedByAddress.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridUserActivityGroupedByAddress.AutoResizeColumns();
        }
    }
}
