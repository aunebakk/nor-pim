using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultResourceStatisticsDurian : UserControl {
        
        public DefaultResourceStatisticsDurian() {
           InitializeComponent();
           InitializeGridDefaultResourceStatistics();
        }
        
        public virtual string HourNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultResourceStatistics.CurrentRow.Cells["HourNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual int ClientWorkingsetBytes {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultResourceStatistics.CurrentRow.Cells["ClientWorkingsetBytes"].Value; else return 0;;
            }
        }
        
        public virtual int BusinessWorkingsetBytes {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultResourceStatistics.CurrentRow.Cells["BusinessWorkingsetBytes"].Value; else return 0;;
            }
        }
        
        public virtual int DatabaseSizeBytes {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultResourceStatistics.CurrentRow.Cells["DatabaseSizeBytes"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultResourceStatistics.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultResourceStatistics_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultResourceStatistics() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultResourceStatistics.CurrentRow != null)
                    position = dataGridViewDefaultResourceStatistics.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultResourceStatistics();
                dataGridViewDefaultResourceStatistics.AutoGenerateColumns = true;
                dataGridViewDefaultResourceStatistics.DataSource = bindingSource;
                dataGridViewDefaultResourceStatistics.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultResourceStatistics.Rows.Count > 0) { 
                    dataGridViewDefaultResourceStatistics.CurrentCell = 
                        dataGridViewDefaultResourceStatistics.Rows[position].Cells[1];
                    dataGridViewDefaultResourceStatistics.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultResourceStatistics() {
            dataGridViewDefaultResourceStatistics.Columns.Clear();
            dataGridViewDefaultResourceStatistics.AutoGenerateColumns = false;
            dataGridViewDefaultResourceStatistics.Columns.Add("HourNumber","Hour Number");
            dataGridViewDefaultResourceStatistics.Columns.Add("ClientWorkingsetBytes","Client Workingset Bytes");
            dataGridViewDefaultResourceStatistics.Columns.Add("BusinessWorkingsetBytes","Business Workingset Bytes");
            dataGridViewDefaultResourceStatistics.Columns.Add("DatabaseSizeBytes","Database Size Bytes");
            dataGridViewDefaultResourceStatistics.Columns.Add("ExtensionData", "");
            dataGridViewDefaultResourceStatistics.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultResourceStatistics.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultResourceStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultResourceStatistics.AutoResizeColumns();
        }
    }
}
