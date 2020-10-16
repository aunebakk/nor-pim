using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityRecentDurian : UserControl {

        public DefaultUserActivityRecentDurian() {
            InitializeComponent();
            InitializeGridDefaultUserActivityRecent();
        }

        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) {
                    return (System.DateTime)dataGridViewDefaultUserActivityRecent.CurrentRow.Cells["DateTime"].Value;
                } else {
                    return DateTime.MinValue;
                };
            }
        }

        public virtual string UserActivityTypeName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewDefaultUserActivityRecent.CurrentRow.Cells["UserActivityTypeName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string OriginatingAddress {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewDefaultUserActivityRecent.CurrentRow.Cells["OriginatingAddress"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string Referrer {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewDefaultUserActivityRecent.CurrentRow.Cells["Referrer"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string UserActivityNote {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewDefaultUserActivityRecent.CurrentRow.Cells["UserActivityNote"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewDefaultUserActivityRecent.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewDefaultUserActivityRecent_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshDefaultUserActivityRecent(System.Guid defaultUserId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultUserActivityRecent.CurrentRow != null) {
                    position = dataGridViewDefaultUserActivityRecent.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new DefaultSearchService().DefaultUserActivityRecent(defaultUserId);
                dataGridViewDefaultUserActivityRecent.AutoGenerateColumns = true;
                dataGridViewDefaultUserActivityRecent.DataSource = bindingSource;
                dataGridViewDefaultUserActivityRecent.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultUserActivityRecent.Rows.Count > 0) {
                    dataGridViewDefaultUserActivityRecent.CurrentCell =
                        dataGridViewDefaultUserActivityRecent.Rows[position].Cells[1];
                    dataGridViewDefaultUserActivityRecent.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridDefaultUserActivityRecent() {
            dataGridViewDefaultUserActivityRecent.Columns.Clear();
            dataGridViewDefaultUserActivityRecent.AutoGenerateColumns = false;
            dataGridViewDefaultUserActivityRecent.Columns.Add("DateTime", "Date Time");
            dataGridViewDefaultUserActivityRecent.Columns.Add("UserActivityTypeName", "User Activity Type Name");
            dataGridViewDefaultUserActivityRecent.Columns.Add("OriginatingAddress", "Originating Address");
            dataGridViewDefaultUserActivityRecent.Columns.Add("Referrer", "Referrer");
            dataGridViewDefaultUserActivityRecent.Columns.Add("UserActivityNote", "User Activity Note");
            dataGridViewDefaultUserActivityRecent.Columns.Add("ExtensionData", "");
            dataGridViewDefaultUserActivityRecent.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultUserActivityRecent.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewDefaultUserActivityRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultUserActivityRecent.AutoResizeColumns();
        }
    }
}
