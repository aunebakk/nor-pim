using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceIssueFetchWithFilterDurian : UserControl {
        
        public DefaultPerformanceIssueFetchWithFilterDurian() {
           InitializeComponent();
           InitializeGridDefaultPerformanceIssueFetchWithFilter();
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewDefaultPerformanceIssueFetchWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string CommandName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultPerformanceIssueFetchWithFilter.CurrentRow.Cells["CommandName"].Value; else return String.Empty;;
            }
        }
        
        public virtual int Milliseconds {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultPerformanceIssueFetchWithFilter.CurrentRow.Cells["Milliseconds"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid DefaultPerformanceIssueId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewDefaultPerformanceIssueFetchWithFilter.CurrentRow.Cells["DefaultPerformanceIssueId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultPerformanceIssueFetchWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultPerformanceIssueFetchWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultPerformanceIssueFetchWithFilter(string commandName) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultPerformanceIssueFetchWithFilter.CurrentRow != null)
                    position = dataGridViewDefaultPerformanceIssueFetchWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchServiceClient().DefaultPerformanceIssueFetchWithFilter(commandName);
                dataGridViewDefaultPerformanceIssueFetchWithFilter.AutoGenerateColumns = true;
                dataGridViewDefaultPerformanceIssueFetchWithFilter.DataSource = bindingSource;
                dataGridViewDefaultPerformanceIssueFetchWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultPerformanceIssueFetchWithFilter.Rows.Count > 0) { 
                    dataGridViewDefaultPerformanceIssueFetchWithFilter.CurrentCell = 
                        dataGridViewDefaultPerformanceIssueFetchWithFilter.Rows[position].Cells[1];
                    dataGridViewDefaultPerformanceIssueFetchWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultPerformanceIssueFetchWithFilter() {
            dataGridViewDefaultPerformanceIssueFetchWithFilter.Columns.Clear();
            dataGridViewDefaultPerformanceIssueFetchWithFilter.AutoGenerateColumns = false;
            dataGridViewDefaultPerformanceIssueFetchWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewDefaultPerformanceIssueFetchWithFilter.Columns.Add("CommandName","Command Name");
            dataGridViewDefaultPerformanceIssueFetchWithFilter.Columns.Add("Milliseconds","Milliseconds");
            dataGridViewDefaultPerformanceIssueFetchWithFilter.Columns.Add("DefaultPerformanceIssueId","Default Performance Issue Id");
            dataGridViewDefaultPerformanceIssueFetchWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewDefaultPerformanceIssueFetchWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultPerformanceIssueFetchWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultPerformanceIssueFetchWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultPerformanceIssueFetchWithFilter.AutoResizeColumns();
        }
    }
}
