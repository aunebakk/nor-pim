using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultStatisticsByMonthDurian : UserControl {

        public DefaultStatisticsByMonthDurian() {
            InitializeComponent();
            InitializeGridDefaultStatisticsByMonth();
        }

        public virtual string ActivityDate {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewDefaultStatisticsByMonth.CurrentRow.Cells["ActivityDate"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual int DayCount {
            get {
                if (!DesignMode) {
                    return (int)dataGridViewDefaultStatisticsByMonth.CurrentRow.Cells["DayCount"].Value;
                } else {
                    return 0;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewDefaultStatisticsByMonth.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewDefaultStatisticsByMonth_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshDefaultStatisticsByMonth() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultStatisticsByMonth.CurrentRow != null) {
                    position = dataGridViewDefaultStatisticsByMonth.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new DefaultSearchService().DefaultStatisticsByMonth();
                dataGridViewDefaultStatisticsByMonth.AutoGenerateColumns = true;
                dataGridViewDefaultStatisticsByMonth.DataSource = bindingSource;
                dataGridViewDefaultStatisticsByMonth.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultStatisticsByMonth.Rows.Count > 0) {
                    dataGridViewDefaultStatisticsByMonth.CurrentCell =
                        dataGridViewDefaultStatisticsByMonth.Rows[position].Cells[1];
                    dataGridViewDefaultStatisticsByMonth.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridDefaultStatisticsByMonth() {
            dataGridViewDefaultStatisticsByMonth.Columns.Clear();
            dataGridViewDefaultStatisticsByMonth.AutoGenerateColumns = false;
            dataGridViewDefaultStatisticsByMonth.Columns.Add("ActivityDate", "Activity Date");
            dataGridViewDefaultStatisticsByMonth.Columns.Add("DayCount", "Day Count");
            dataGridViewDefaultStatisticsByMonth.Columns.Add("ExtensionData", "");
            dataGridViewDefaultStatisticsByMonth.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultStatisticsByMonth.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewDefaultStatisticsByMonth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultStatisticsByMonth.AutoResizeColumns();
        }
    }
}
