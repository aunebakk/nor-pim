using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultStatisticsDurian : UserControl {

        public DefaultStatisticsDurian() {
            InitializeComponent();
            InitializeGridDefaultStatistics();
        }

        public virtual string ActivityDate {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewDefaultStatistics.CurrentRow.Cells["ActivityDate"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual int DayCount {
            get {
                if (!DesignMode) {
                    return (int)dataGridViewDefaultStatistics.CurrentRow.Cells["DayCount"].Value;
                } else {
                    return 0;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewDefaultStatistics.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewDefaultStatistics_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshDefaultStatistics() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultStatistics.CurrentRow != null) {
                    position = dataGridViewDefaultStatistics.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new DefaultSearchService().DefaultStatistics();
                dataGridViewDefaultStatistics.AutoGenerateColumns = true;
                dataGridViewDefaultStatistics.DataSource = bindingSource;
                dataGridViewDefaultStatistics.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultStatistics.Rows.Count > 0) {
                    dataGridViewDefaultStatistics.CurrentCell =
                        dataGridViewDefaultStatistics.Rows[position].Cells[1];
                    dataGridViewDefaultStatistics.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridDefaultStatistics() {
            dataGridViewDefaultStatistics.Columns.Clear();
            dataGridViewDefaultStatistics.AutoGenerateColumns = false;
            dataGridViewDefaultStatistics.Columns.Add("ActivityDate", "Activity Date");
            dataGridViewDefaultStatistics.Columns.Add("DayCount", "Day Count");
            dataGridViewDefaultStatistics.Columns.Add("ExtensionData", "");
            dataGridViewDefaultStatistics.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultStatistics.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewDefaultStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultStatistics.AutoResizeColumns();
        }
    }
}
