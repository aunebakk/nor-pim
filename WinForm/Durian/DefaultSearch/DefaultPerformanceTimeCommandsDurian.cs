using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceTimeCommandsDurian : UserControl {
        
        public DefaultPerformanceTimeCommandsDurian() {
           InitializeComponent();
           InitializeGridDefaultPerformanceTimeCommands();
        }
        
        public virtual string CommandName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultPerformanceTimeCommands.CurrentRow.Cells["CommandName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string CommandDisplayName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultPerformanceTimeCommands.CurrentRow.Cells["CommandDisplayName"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultPerformanceTimeCommands.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultPerformanceTimeCommands_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultPerformanceTimeCommands() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultPerformanceTimeCommands.CurrentRow != null)
                    position = dataGridViewDefaultPerformanceTimeCommands.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultPerformanceTimeCommands();
                dataGridViewDefaultPerformanceTimeCommands.AutoGenerateColumns = true;
                dataGridViewDefaultPerformanceTimeCommands.DataSource = bindingSource;
                dataGridViewDefaultPerformanceTimeCommands.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultPerformanceTimeCommands.Rows.Count > 0) { 
                    dataGridViewDefaultPerformanceTimeCommands.CurrentCell = 
                        dataGridViewDefaultPerformanceTimeCommands.Rows[position].Cells[1];
                    dataGridViewDefaultPerformanceTimeCommands.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultPerformanceTimeCommands() {
            dataGridViewDefaultPerformanceTimeCommands.Columns.Clear();
            dataGridViewDefaultPerformanceTimeCommands.AutoGenerateColumns = false;
            dataGridViewDefaultPerformanceTimeCommands.Columns.Add("CommandName","Command Name");
            dataGridViewDefaultPerformanceTimeCommands.Columns.Add("CommandDisplayName","Command Display Name");
            dataGridViewDefaultPerformanceTimeCommands.Columns.Add("ExtensionData", "");
            dataGridViewDefaultPerformanceTimeCommands.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultPerformanceTimeCommands.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultPerformanceTimeCommands.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultPerformanceTimeCommands.AutoResizeColumns();
        }
    }
}
