using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductReferenceAttributeUnitSearchWithFilterDurian : UserControl {

        public ProductReferenceAttributeUnitSearchWithFilterDurian() {
            InitializeComponent();
            InitializeGridProductReferenceAttributeUnitSearchWithFilter();
        }

        public virtual string ProductAttributeUnitName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductReferenceAttributeUnitSearchWithFilter.CurrentRow.Cells["ProductAttributeUnitName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual System.Guid UserId {
            get {
                if (!DesignMode) {
                    return (System.Guid)dataGridViewProductReferenceAttributeUnitSearchWithFilter.CurrentRow.Cells["UserId"].Value;
                } else {
                    return Guid.Empty;
                };
            }
        }

        public virtual string DefaultUserName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductReferenceAttributeUnitSearchWithFilter.CurrentRow.Cells["DefaultUserName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) {
                    return (System.DateTime)dataGridViewProductReferenceAttributeUnitSearchWithFilter.CurrentRow.Cells["DateTime"].Value;
                } else {
                    return DateTime.MinValue;
                };
            }
        }

        public virtual string ProductAttributeUnitRcd {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductReferenceAttributeUnitSearchWithFilter.CurrentRow.Cells["ProductAttributeUnitRcd"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewProductReferenceAttributeUnitSearchWithFilter.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewProductReferenceAttributeUnitSearchWithFilter_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshProductReferenceAttributeUnitSearchWithFilter() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductReferenceAttributeUnitSearchWithFilter.CurrentRow != null) {
                    position = dataGridViewProductReferenceAttributeUnitSearchWithFilter.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new ProductReferenceAttributeUnitSearchService().ProductReferenceAttributeUnitSearchWithFilter();
                dataGridViewProductReferenceAttributeUnitSearchWithFilter.AutoGenerateColumns = true;
                dataGridViewProductReferenceAttributeUnitSearchWithFilter.DataSource = bindingSource;
                dataGridViewProductReferenceAttributeUnitSearchWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductReferenceAttributeUnitSearchWithFilter.Rows.Count > 0) {
                    dataGridViewProductReferenceAttributeUnitSearchWithFilter.CurrentCell =
                        dataGridViewProductReferenceAttributeUnitSearchWithFilter.Rows[position].Cells[1];
                    dataGridViewProductReferenceAttributeUnitSearchWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridProductReferenceAttributeUnitSearchWithFilter() {
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns.Clear();
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.AutoGenerateColumns = false;
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns.Add("ProductAttributeUnitName", "Product Attribute Unit Name");
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns.Add("UserId", "User Id");
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns.Add("DefaultUserName", "Default User Name");
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns.Add("DateTime", "Date Time");
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns.Add("ProductAttributeUnitRcd", "Product Attribute Unit");
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductReferenceAttributeUnitSearchWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewProductReferenceAttributeUnitSearchWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductReferenceAttributeUnitSearchWithFilter.AutoResizeColumns();
        }
    }
}
