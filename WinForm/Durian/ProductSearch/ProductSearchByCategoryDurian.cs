using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryDurian : UserControl {

        public ProductSearchByCategoryDurian() {
            InitializeComponent();
            InitializeGridProductSearchByCategory();
        }

        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) {
                    return (System.Guid)dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductId"].Value;
                } else {
                    return Guid.Empty;
                };
            }
        }

        public new virtual string ProductName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string Identifier {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategory.CurrentRow.Cells["Identifier"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string Value {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategory.CurrentRow.Cells["Value"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string ProductInfoValue {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductInfoValue"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string ProductImageTypeRcd {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductImageTypeRcd"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string ProductImageTypeName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductImageTypeName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual byte[] Image {
            get {
                if (!DesignMode) {
                    return (byte[])dataGridViewProductSearchByCategory.CurrentRow.Cells["Image"].Value;
                } else {
                    return null;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewProductSearchByCategory.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewProductSearchByCategory_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshProductSearchByCategory(System.Guid productCategoryId, bool onParent) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchByCategory.CurrentRow != null) {
                    position = dataGridViewProductSearchByCategory.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new ProductSearchService().ProductSearchByCategory(productCategoryId, onParent);
                dataGridViewProductSearchByCategory.AutoGenerateColumns = true;
                dataGridViewProductSearchByCategory.DataSource = bindingSource;
                dataGridViewProductSearchByCategory.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductSearchByCategory.Rows.Count > 0) {
                    dataGridViewProductSearchByCategory.CurrentCell =
                        dataGridViewProductSearchByCategory.Rows[position].Cells[1];
                    dataGridViewProductSearchByCategory.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridProductSearchByCategory() {
            dataGridViewProductSearchByCategory.Columns.Clear();
            dataGridViewProductSearchByCategory.AutoGenerateColumns = false;
            dataGridViewProductSearchByCategory.Columns.Add("ProductId", "Product Id");
            dataGridViewProductSearchByCategory.Columns.Add("ProductName", "Product Name");
            dataGridViewProductSearchByCategory.Columns.Add("Identifier", "Identifier");
            dataGridViewProductSearchByCategory.Columns.Add("Value", "Value");
            dataGridViewProductSearchByCategory.Columns.Add("ProductInfoValue", "Product Info Value");
            dataGridViewProductSearchByCategory.Columns.Add("ProductImageTypeRcd", "Product Image Type");
            dataGridViewProductSearchByCategory.Columns.Add("ProductImageTypeName", "Product Image Type Name");
            dataGridViewProductSearchByCategory.Columns.Add("Image", "Image");
            dataGridViewProductSearchByCategory.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchByCategory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchByCategory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewProductSearchByCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchByCategory.AutoResizeColumns();
        }
    }
}
