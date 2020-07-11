using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceIndicatorsDurian : UserControl {
        
        public DefaultPerformanceIndicatorsDurian() {
           InitializeComponent();
           InitializeGridDefaultPerformanceIndicators();
        }
        
        public virtual string CommandName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultPerformanceIndicators.CurrentRow.Cells["CommandName"].Value; else return String.Empty;;
            }
        }
        
        public virtual long HitCount {
            get {
                if (!DesignMode) return (System.Int64) dataGridViewDefaultPerformanceIndicators.CurrentRow.Cells["HitCount"].Value; else return 0;;
            }
        }
        
        public virtual int AverageMilliseconds {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultPerformanceIndicators.CurrentRow.Cells["AverageMilliseconds"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultPerformanceIndicators.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultPerformanceIndicators_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultPerformanceIndicators() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultPerformanceIndicators.CurrentRow != null)
                    position = dataGridViewDefaultPerformanceIndicators.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultPerformanceIndicators();
                dataGridViewDefaultPerformanceIndicators.AutoGenerateColumns = true;
                dataGridViewDefaultPerformanceIndicators.DataSource = bindingSource;
                dataGridViewDefaultPerformanceIndicators.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultPerformanceIndicators.Rows.Count > 0) { 
                    dataGridViewDefaultPerformanceIndicators.CurrentCell = 
                        dataGridViewDefaultPerformanceIndicators.Rows[position].Cells[1];
                    dataGridViewDefaultPerformanceIndicators.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultPerformanceIndicators() {
            dataGridViewDefaultPerformanceIndicators.Columns.Clear();
            dataGridViewDefaultPerformanceIndicators.AutoGenerateColumns = false;
            dataGridViewDefaultPerformanceIndicators.Columns.Add("CommandName","Command Name");
            dataGridViewDefaultPerformanceIndicators.Columns.Add("HitCount","Hit Count");
            dataGridViewDefaultPerformanceIndicators.Columns.Add("AverageMilliseconds","Average Milliseconds");
            dataGridViewDefaultPerformanceIndicators.Columns.Add("ExtensionData", "");
            dataGridViewDefaultPerformanceIndicators.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultPerformanceIndicators.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultPerformanceIndicators.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultPerformanceIndicators.AutoResizeColumns();
        }
    }
}
