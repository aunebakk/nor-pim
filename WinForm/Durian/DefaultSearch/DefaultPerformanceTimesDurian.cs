using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceTimesDurian : UserControl {

        public DefaultPerformanceTimesDurian() {
            InitializeComponent();
            InitializeGridDefaultPerformanceTimes();
        }

        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) {
                    return (System.DateTime)dataGridViewDefaultPerformanceTimes.CurrentRow.Cells["DateTime"].Value;
                } else {
                    return DateTime.MinValue;
                };
            }
        }

        public virtual int Milliseconds {
            get {
                if (!DesignMode) {
                    return (int)dataGridViewDefaultPerformanceTimes.CurrentRow.Cells["Milliseconds"].Value;
                } else {
                    return 0;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewDefaultPerformanceTimes.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewDefaultPerformanceTimes_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshDefaultPerformanceTimes(string commandName) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultPerformanceTimes.CurrentRow != null) {
                    position = dataGridViewDefaultPerformanceTimes.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new DefaultSearchService().DefaultPerformanceTimes(commandName);
                dataGridViewDefaultPerformanceTimes.AutoGenerateColumns = true;
                dataGridViewDefaultPerformanceTimes.DataSource = bindingSource;
                dataGridViewDefaultPerformanceTimes.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultPerformanceTimes.Rows.Count > 0) {
                    dataGridViewDefaultPerformanceTimes.CurrentCell =
                        dataGridViewDefaultPerformanceTimes.Rows[position].Cells[1];
                    dataGridViewDefaultPerformanceTimes.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridDefaultPerformanceTimes() {
            dataGridViewDefaultPerformanceTimes.Columns.Clear();
            dataGridViewDefaultPerformanceTimes.AutoGenerateColumns = false;
            dataGridViewDefaultPerformanceTimes.Columns.Add("DateTime", "Date Time");
            dataGridViewDefaultPerformanceTimes.Columns.Add("Milliseconds", "Milliseconds");
            dataGridViewDefaultPerformanceTimes.Columns.Add("ExtensionData", "");
            dataGridViewDefaultPerformanceTimes.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultPerformanceTimes.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewDefaultPerformanceTimes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultPerformanceTimes.AutoResizeColumns();
        }
    }
}
