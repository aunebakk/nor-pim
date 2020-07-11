using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultStatisticsTop5Durian : UserControl {
        
        public DefaultStatisticsTop5Durian() {
           InitializeComponent();
           InitializeGridDefaultStatisticsTop5();
        }
        
        public virtual string Measurement {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultStatisticsTop5.CurrentRow.Cells["Measurement"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Value {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultStatisticsTop5.CurrentRow.Cells["Value"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultStatisticsTop5.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultStatisticsTop5_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultStatisticsTop5() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultStatisticsTop5.CurrentRow != null)
                    position = dataGridViewDefaultStatisticsTop5.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultStatisticsTop5();
                dataGridViewDefaultStatisticsTop5.AutoGenerateColumns = true;
                dataGridViewDefaultStatisticsTop5.DataSource = bindingSource;
                dataGridViewDefaultStatisticsTop5.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultStatisticsTop5.Rows.Count > 0) { 
                    dataGridViewDefaultStatisticsTop5.CurrentCell = 
                        dataGridViewDefaultStatisticsTop5.Rows[position].Cells[1];
                    dataGridViewDefaultStatisticsTop5.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultStatisticsTop5() {
            dataGridViewDefaultStatisticsTop5.Columns.Clear();
            dataGridViewDefaultStatisticsTop5.AutoGenerateColumns = false;
            dataGridViewDefaultStatisticsTop5.Columns.Add("Measurement","Measurement");
            dataGridViewDefaultStatisticsTop5.Columns.Add("Value","Value");
            dataGridViewDefaultStatisticsTop5.Columns.Add("ExtensionData", "");
            dataGridViewDefaultStatisticsTop5.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultStatisticsTop5.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultStatisticsTop5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultStatisticsTop5.AutoResizeColumns();
        }
    }
}
