using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DashboardCountsDurian : UserControl {
        
        public DashboardCountsDurian() {
           InitializeComponent();
           InitializeGridDashboardCounts();
        }
        
        public virtual string DashboardItemRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewDashboardCounts.CurrentRow.Cells["DashboardItemRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DashboardItemName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDashboardCounts.CurrentRow.Cells["DashboardItemName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ImageSource {
            get {
                if (!DesignMode) return (System.String) dataGridViewDashboardCounts.CurrentRow.Cells["ImageSource"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Value {
            get {
                if (!DesignMode) return (System.String) dataGridViewDashboardCounts.CurrentRow.Cells["Value"].Value; else return String.Empty;;
            }
        }
        
        public virtual int Last24HoursCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDashboardCounts.CurrentRow.Cells["Last24HoursCount"].Value; else return 0;;
            }
        }
        
        public virtual string LastDateTime {
            get {
                if (!DesignMode) return (System.String) dataGridViewDashboardCounts.CurrentRow.Cells["LastDateTime"].Value; else return String.Empty;;
            }
        }
        
        public virtual string LastUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDashboardCounts.CurrentRow.Cells["LastUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Url {
            get {
                if (!DesignMode) return (System.String) dataGridViewDashboardCounts.CurrentRow.Cells["Url"].Value; else return String.Empty;;
            }
        }
        
        public virtual int PositionLeft {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDashboardCounts.CurrentRow.Cells["PositionLeft"].Value; else return 0;;
            }
        }
        
        public virtual int PositionTop {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDashboardCounts.CurrentRow.Cells["PositionTop"].Value; else return 0;;
            }
        }
        
        public virtual int PositionOffset {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDashboardCounts.CurrentRow.Cells["PositionOffset"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDashboardCounts.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDashboardCounts_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDashboardCounts(string dashboardLayoutRcd) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDashboardCounts.CurrentRow != null)
                    position = dataGridViewDashboardCounts.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DashboardCounts(dashboardLayoutRcd);
                dataGridViewDashboardCounts.AutoGenerateColumns = true;
                dataGridViewDashboardCounts.DataSource = bindingSource;
                dataGridViewDashboardCounts.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDashboardCounts.Rows.Count > 0) { 
                    dataGridViewDashboardCounts.CurrentCell = 
                        dataGridViewDashboardCounts.Rows[position].Cells[1];
                    dataGridViewDashboardCounts.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDashboardCounts() {
            dataGridViewDashboardCounts.Columns.Clear();
            dataGridViewDashboardCounts.AutoGenerateColumns = false;
            dataGridViewDashboardCounts.Columns.Add("DashboardItemRcd","Dashboard Item");
            dataGridViewDashboardCounts.Columns.Add("DashboardItemName","Dashboard Item Name");
            dataGridViewDashboardCounts.Columns.Add("ImageSource","Image Source");
            dataGridViewDashboardCounts.Columns.Add("Value","Value");
            dataGridViewDashboardCounts.Columns.Add("Last24HoursCount","Last 24 Hours Count");
            dataGridViewDashboardCounts.Columns.Add("LastDateTime","Last Date Time");
            dataGridViewDashboardCounts.Columns.Add("LastUserName","Last User Name");
            dataGridViewDashboardCounts.Columns.Add("Url","Url");
            dataGridViewDashboardCounts.Columns.Add("PositionLeft","Position Left");
            dataGridViewDashboardCounts.Columns.Add("PositionTop","Position Top");
            dataGridViewDashboardCounts.Columns.Add("PositionOffset","Position Offset");
            dataGridViewDashboardCounts.Columns.Add("ExtensionData", "");
            dataGridViewDashboardCounts.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDashboardCounts.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDashboardCounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDashboardCounts.AutoResizeColumns();
        }
    }
}
