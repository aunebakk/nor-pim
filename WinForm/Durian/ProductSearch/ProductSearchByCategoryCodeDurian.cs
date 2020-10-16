using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryCodeDurian : UserControl {

        public ProductSearchByCategoryCodeDurian() {
            InitializeComponent();
            InitializeGridProductSearchByCategoryCode();
        }

        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) {
                    return (System.Guid)dataGridViewProductSearchByCategoryCode.CurrentRow.Cells["ProductId"].Value;
                } else {
                    return Guid.Empty;
                };
            }
        }

        public new virtual string ProductName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategoryCode.CurrentRow.Cells["ProductName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string Identifier {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategoryCode.CurrentRow.Cells["Identifier"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string Value {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategoryCode.CurrentRow.Cells["Value"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string ProductInfoValue {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategoryCode.CurrentRow.Cells["ProductInfoValue"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string ProductImageTypeRcd {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategoryCode.CurrentRow.Cells["ProductImageTypeRcd"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual string ProductImageTypeName {
            get {
                if (!DesignMode) {
                    return (string)dataGridViewProductSearchByCategoryCode.CurrentRow.Cells["ProductImageTypeName"].Value;
                } else {
                    return string.Empty;
                };
            }
        }

        public virtual byte[] Image {
            get {
                if (!DesignMode) {
                    return (byte[])dataGridViewProductSearchByCategoryCode.CurrentRow.Cells["Image"].Value;
                } else {
                    return null;
                };
            }
        }

        public int Count {
            get {
                if (!DesignMode) {
                    return dataGridViewProductSearchByCategoryCode.Rows.Count;
                } else {
                    return 0;
                };
            }
        }

        public event EventHandler Picked;

        private void dataGridViewProductSearchByCategoryCode_Click(object sender, EventArgs e) {
            if (Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        public void RefreshProductSearchByCategoryCode(string productCategoryCode, bool onParent) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchByCategoryCode.CurrentRow != null) {
                    position = dataGridViewProductSearchByCategoryCode.CurrentRow.Index;
                }

                // fetch new dataset
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = new ProductSearchService().ProductSearchByCategoryCode(productCategoryCode, onParent);
                dataGridViewProductSearchByCategoryCode.AutoGenerateColumns = true;
                dataGridViewProductSearchByCategoryCode.DataSource = bindingSource;
                dataGridViewProductSearchByCategoryCode.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductSearchByCategoryCode.Rows.Count > 0) {
                    dataGridViewProductSearchByCategoryCode.CurrentCell =
                        dataGridViewProductSearchByCategoryCode.Rows[position].Cells[1];
                    dataGridViewProductSearchByCategoryCode.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeGridProductSearchByCategoryCode() {
            dataGridViewProductSearchByCategoryCode.Columns.Clear();
            dataGridViewProductSearchByCategoryCode.AutoGenerateColumns = false;
            dataGridViewProductSearchByCategoryCode.Columns.Add("ProductId", "Product Id");
            dataGridViewProductSearchByCategoryCode.Columns.Add("ProductName", "Product Name");
            dataGridViewProductSearchByCategoryCode.Columns.Add("Identifier", "Identifier");
            dataGridViewProductSearchByCategoryCode.Columns.Add("Value", "Value");
            dataGridViewProductSearchByCategoryCode.Columns.Add("ProductInfoValue", "Product Info Value");
            dataGridViewProductSearchByCategoryCode.Columns.Add("ProductImageTypeRcd", "Product Image Type");
            dataGridViewProductSearchByCategoryCode.Columns.Add("ProductImageTypeName", "Product Image Type Name");
            dataGridViewProductSearchByCategoryCode.Columns.Add("Image", "Image");
            dataGridViewProductSearchByCategoryCode.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchByCategoryCode.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchByCategoryCode.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            dataGridViewProductSearchByCategoryCode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchByCategoryCode.AutoResizeColumns();
        }
    }
}
