using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class UserActivityRecentSearch : Form {
        
        public UserActivityRecentSearch() {
           InitializeComponent();
           InitializeGridUserActivityRecent();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            UserActivitySearchService userActivityRecent = new UserActivitySearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = userActivityRecent.UserActivityRecent();
                gridUserActivityRecent.AutoGenerateColumns = true;
                gridUserActivityRecent.DataSource = bindingSource;
                gridUserActivityRecent.AutoResizeColumns();
                gridUserActivityRecent.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                userActivityRecent.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridUserActivityRecent() {
            gridUserActivityRecent.Columns.Clear();
            gridUserActivityRecent.AutoGenerateColumns = false;
            gridUserActivityRecent.Columns.Add("DateTime","Date Time");
            gridUserActivityRecent.Columns.Add("UserActivityTypeName","User Activity Type Name");
            gridUserActivityRecent.Columns.Add("OriginatingAddress","Originating Address");
            gridUserActivityRecent.Columns.Add("UserActivityNote","User Activity Note");
            gridUserActivityRecent.Columns.Add("ExtensionData", "");
            gridUserActivityRecent.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridUserActivityRecent.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridUserActivityRecent.AutoResizeColumns();
        }
    }
}
