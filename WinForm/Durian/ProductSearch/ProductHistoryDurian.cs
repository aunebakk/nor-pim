using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductHistoryDurian : UserControl {

        public ProductHistoryDurian() {
            InitializeComponent();
            InitializeGridProductHistory();
        }

        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) {
                    return (System.Guid)dataGridViewProductHistory.CurrentRow.Cells["ProductId"].Value;
                } else {
                    return Guid.Empty;
                };
            }
        }

        public new virtual string ProductName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductHistory.CurrentRow.Cells["ProductName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string StateName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductHistory.CurrentRow.Cells["StateName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) {
                    return (System.DateTime)dataGridViewProductHistory.CurrentRow.Cells["DateTime"].Value;
                } else {
                    return DateTime.MinValue;
                };
            }
        }

        public virtual string UserName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductHistory.CurrentRow.Cells["UserName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual System.Guid ProductBecameId {
            get {
                if (!DesignMode) {
                    return (System.Guid)dataGridViewProductHistory.CurrentRow.Cells["ProductBecameId"].Value;
                } else {
                    return Guid.Empty;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewProductHistory.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewProductHistory_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshProductHistory(System.Guid productId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductHistory.CurrentRow != null) {
                    position = dataGridViewProductHistory.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new ProductSearchService().ProductHistory(productId);
                dataGridViewProductHistory.AutoGenerateColumns = true;
                dataGridViewProductHistory.DataSource = bindingSource;
                dataGridViewProductHistory.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductHistory.Rows.Count > 0) {
                    dataGridViewProductHistory.CurrentCell =
                        dataGridViewProductHistory.Rows[position].Cells[1];
                    dataGridViewProductHistory.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridProductHistory() {
            dataGridViewProductHistory.Columns.Clear();
            dataGridViewProductHistory.AutoGenerateColumns = false;
            dataGridViewProductHistory.Columns.Add("ProductId", "Product Id");
            dataGridViewProductHistory.Columns.Add("ProductName", "Product Name");
            dataGridViewProductHistory.Columns.Add("StateName", "State Name");
            dataGridViewProductHistory.Columns.Add("DateTime", "Date Time");
            dataGridViewProductHistory.Columns.Add("UserName", "User Name");
            dataGridViewProductHistory.Columns.Add("ProductBecameId", "Product Became Id");
            dataGridViewProductHistory.Columns.Add("ExtensionData", "");
            dataGridViewProductHistory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductHistory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewProductHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductHistory.AutoResizeColumns();
        }
    }
}
