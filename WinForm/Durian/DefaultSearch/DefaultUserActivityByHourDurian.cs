using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityByHourDurian : UserControl {

        public DefaultUserActivityByHourDurian() {
            InitializeComponent();
            InitializeGridDefaultUserActivityByHour();
        }

        public virtual string HourNumber {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewDefaultUserActivityByHour.CurrentRow.Cells["HourNumber"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual int HourCount {
            get {
                if (!DesignMode) {
                    return (int)dataGridViewDefaultUserActivityByHour.CurrentRow.Cells["HourCount"].Value;
                } else {
                    return 0;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewDefaultUserActivityByHour.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewDefaultUserActivityByHour_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshDefaultUserActivityByHour() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultUserActivityByHour.CurrentRow != null) {
                    position = dataGridViewDefaultUserActivityByHour.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new DefaultSearchService().DefaultUserActivityByHour();
                dataGridViewDefaultUserActivityByHour.AutoGenerateColumns = true;
                dataGridViewDefaultUserActivityByHour.DataSource = bindingSource;
                dataGridViewDefaultUserActivityByHour.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultUserActivityByHour.Rows.Count > 0) {
                    dataGridViewDefaultUserActivityByHour.CurrentCell =
                        dataGridViewDefaultUserActivityByHour.Rows[position].Cells[1];
                    dataGridViewDefaultUserActivityByHour.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridDefaultUserActivityByHour() {
            dataGridViewDefaultUserActivityByHour.Columns.Clear();
            dataGridViewDefaultUserActivityByHour.AutoGenerateColumns = false;
            dataGridViewDefaultUserActivityByHour.Columns.Add("HourNumber", "Hour Number");
            dataGridViewDefaultUserActivityByHour.Columns.Add("HourCount", "Hour Count");
            dataGridViewDefaultUserActivityByHour.Columns.Add("ExtensionData", "");
            dataGridViewDefaultUserActivityByHour.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultUserActivityByHour.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewDefaultUserActivityByHour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultUserActivityByHour.AutoResizeColumns();
        }
    }
}
