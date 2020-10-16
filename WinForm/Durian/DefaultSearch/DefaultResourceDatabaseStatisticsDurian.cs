using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultResourceDatabaseStatisticsDurian : UserControl {

        public DefaultResourceDatabaseStatisticsDurian() {
            InitializeComponent();
            InitializeGridDefaultResourceDatabaseStatistics();
        }

        public virtual int ReservedPageCount {
            get {
                if (!DesignMode) {
                    return (int)dataGridViewDefaultResourceDatabaseStatistics.CurrentRow.Cells["ReservedPageCount"].Value;
                } else {
                    return 0;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewDefaultResourceDatabaseStatistics.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewDefaultResourceDatabaseStatistics_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshDefaultResourceDatabaseStatistics() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultResourceDatabaseStatistics.CurrentRow != null) {
                    position = dataGridViewDefaultResourceDatabaseStatistics.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new DefaultSearchService().DefaultResourceDatabaseStatistics();
                dataGridViewDefaultResourceDatabaseStatistics.AutoGenerateColumns = true;
                dataGridViewDefaultResourceDatabaseStatistics.DataSource = bindingSource;
                dataGridViewDefaultResourceDatabaseStatistics.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultResourceDatabaseStatistics.Rows.Count > 0) {
                    dataGridViewDefaultResourceDatabaseStatistics.CurrentCell =
                        dataGridViewDefaultResourceDatabaseStatistics.Rows[position].Cells[1];
                    dataGridViewDefaultResourceDatabaseStatistics.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridDefaultResourceDatabaseStatistics() {
            dataGridViewDefaultResourceDatabaseStatistics.Columns.Clear();
            dataGridViewDefaultResourceDatabaseStatistics.AutoGenerateColumns = false;
            dataGridViewDefaultResourceDatabaseStatistics.Columns.Add("ReservedPageCount", "Reserved Page Count");
            dataGridViewDefaultResourceDatabaseStatistics.Columns.Add("ExtensionData", "");
            dataGridViewDefaultResourceDatabaseStatistics.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultResourceDatabaseStatistics.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewDefaultResourceDatabaseStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultResourceDatabaseStatistics.AutoResizeColumns();
        }
    }
}
