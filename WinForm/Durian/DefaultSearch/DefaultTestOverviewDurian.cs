using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultTestOverviewDurian : UserControl {
        
        public DefaultTestOverviewDurian() {
           InitializeComponent();
           InitializeGridDefaultTestOverview();
        }
        
        public virtual string TestArea {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultTestOverview.CurrentRow.Cells["TestArea"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime StartDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewDefaultTestOverview.CurrentRow.Cells["StartDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string DefaultTestRunResultRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultTestOverview.CurrentRow.Cells["DefaultTestRunResultRcd"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultTestOverview.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultTestOverview_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultTestOverview(string commandName) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultTestOverview.CurrentRow != null)
                    position = dataGridViewDefaultTestOverview.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchServiceClient().DefaultTestOverview(commandName);
                dataGridViewDefaultTestOverview.AutoGenerateColumns = true;
                dataGridViewDefaultTestOverview.DataSource = bindingSource;
                dataGridViewDefaultTestOverview.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultTestOverview.Rows.Count > 0) { 
                    dataGridViewDefaultTestOverview.CurrentCell = 
                        dataGridViewDefaultTestOverview.Rows[position].Cells[1];
                    dataGridViewDefaultTestOverview.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultTestOverview() {
            dataGridViewDefaultTestOverview.Columns.Clear();
            dataGridViewDefaultTestOverview.AutoGenerateColumns = false;
            dataGridViewDefaultTestOverview.Columns.Add("TestArea","Test Area");
            dataGridViewDefaultTestOverview.Columns.Add("StartDateTime","Start Date Time");
            dataGridViewDefaultTestOverview.Columns.Add("DefaultTestRunResultRcd","Default Test Run Result");
            dataGridViewDefaultTestOverview.Columns.Add("ExtensionData", "");
            dataGridViewDefaultTestOverview.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultTestOverview.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultTestOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultTestOverview.AutoResizeColumns();
        }
    }
}
