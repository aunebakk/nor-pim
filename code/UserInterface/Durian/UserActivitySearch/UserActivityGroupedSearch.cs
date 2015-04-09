using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class UserActivityGroupedSearch : Form {
        
        public UserActivityGroupedSearch() {
           InitializeComponent();
           InitializeGridUserActivityGrouped();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            UserActivitySearchService userActivityGrouped = new UserActivitySearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = userActivityGrouped.UserActivityGrouped();
                gridUserActivityGrouped.AutoGenerateColumns = true;
                gridUserActivityGrouped.DataSource = bindingSource;
                gridUserActivityGrouped.AutoResizeColumns();
                gridUserActivityGrouped.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                userActivityGrouped.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridUserActivityGrouped() {
            gridUserActivityGrouped.Columns.Clear();
            gridUserActivityGrouped.AutoGenerateColumns = false;
            gridUserActivityGrouped.Columns.Add("OriginatingAddress","Originating Address");
            gridUserActivityGrouped.Columns.Add("UserActivityTypeName","User Activity Type Name");
            gridUserActivityGrouped.Columns.Add("UserActivityNote","User Activity Note");
            gridUserActivityGrouped.Columns.Add("Occurrences","Occurrences");
            gridUserActivityGrouped.Columns.Add("ExtensionData", "");
            gridUserActivityGrouped.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridUserActivityGrouped.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridUserActivityGrouped.AutoResizeColumns();
        }
    }
}
