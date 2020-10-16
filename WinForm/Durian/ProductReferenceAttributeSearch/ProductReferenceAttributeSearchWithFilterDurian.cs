using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductReferenceAttributeSearchWithFilterDurian : UserControl {

        public ProductReferenceAttributeSearchWithFilterDurian() {
            InitializeComponent();
            InitializeGridProductReferenceAttributeSearchWithFilter();
        }

        public virtual string ProductAttributeName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductReferenceAttributeSearchWithFilter.CurrentRow.Cells["ProductAttributeName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual System.Guid UserId {
            get {
                if (!DesignMode) {
                    return (System.Guid)dataGridViewProductReferenceAttributeSearchWithFilter.CurrentRow.Cells["UserId"].Value;
                } else {
                    return Guid.Empty;
                };
            }
        }

        public virtual string DefaultUserName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductReferenceAttributeSearchWithFilter.CurrentRow.Cells["DefaultUserName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) {
                    return (System.DateTime)dataGridViewProductReferenceAttributeSearchWithFilter.CurrentRow.Cells["DateTime"].Value;
                } else {
                    return DateTime.MinValue;
                };
            }
        }

        public virtual string ProductAttributeRcd {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductReferenceAttributeSearchWithFilter.CurrentRow.Cells["ProductAttributeRcd"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewProductReferenceAttributeSearchWithFilter.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewProductReferenceAttributeSearchWithFilter_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshProductReferenceAttributeSearchWithFilter() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductReferenceAttributeSearchWithFilter.CurrentRow != null) {
                    position = dataGridViewProductReferenceAttributeSearchWithFilter.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new ProductReferenceAttributeSearchService().ProductReferenceAttributeSearchWithFilter();
                dataGridViewProductReferenceAttributeSearchWithFilter.AutoGenerateColumns = true;
                dataGridViewProductReferenceAttributeSearchWithFilter.DataSource = bindingSource;
                dataGridViewProductReferenceAttributeSearchWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductReferenceAttributeSearchWithFilter.Rows.Count > 0) {
                    dataGridViewProductReferenceAttributeSearchWithFilter.CurrentCell =
                        dataGridViewProductReferenceAttributeSearchWithFilter.Rows[position].Cells[1];
                    dataGridViewProductReferenceAttributeSearchWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridProductReferenceAttributeSearchWithFilter() {
            dataGridViewProductReferenceAttributeSearchWithFilter.Columns.Clear();
            dataGridViewProductReferenceAttributeSearchWithFilter.AutoGenerateColumns = false;
            dataGridViewProductReferenceAttributeSearchWithFilter.Columns.Add("ProductAttributeName", "Product Attribute Name");
            dataGridViewProductReferenceAttributeSearchWithFilter.Columns.Add("UserId", "User Id");
            dataGridViewProductReferenceAttributeSearchWithFilter.Columns.Add("DefaultUserName", "Default User Name");
            dataGridViewProductReferenceAttributeSearchWithFilter.Columns.Add("DateTime", "Date Time");
            dataGridViewProductReferenceAttributeSearchWithFilter.Columns.Add("ProductAttributeRcd", "Product Attribute");
            dataGridViewProductReferenceAttributeSearchWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewProductReferenceAttributeSearchWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductReferenceAttributeSearchWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewProductReferenceAttributeSearchWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductReferenceAttributeSearchWithFilter.AutoResizeColumns();
        }
    }
}
