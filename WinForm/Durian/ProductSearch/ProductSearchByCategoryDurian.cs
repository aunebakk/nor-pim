using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryDurian : UserControl {
        
        public ProductSearchByCategoryDurian() {
           InitializeComponent();
           InitializeGridProductSearchByCategory();
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Identifier {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategory.CurrentRow.Cells["Identifier"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Value {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategory.CurrentRow.Cells["Value"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductInfoValue {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductInfoValue"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductImageTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductImageTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductImageTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategory.CurrentRow.Cells["ProductImageTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual byte[] Image {
            get {
                if (!DesignMode) return (System.Byte[]) dataGridViewProductSearchByCategory.CurrentRow.Cells["Image"].Value; else return null;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductSearchByCategory.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductSearchByCategory_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductSearchByCategory(System.Guid productCategoryId, bool onParent) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchByCategory.CurrentRow != null)
                    position = dataGridViewProductSearchByCategory.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductSearchServiceClient().ProductSearchByCategory(productCategoryId,onParent);
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
            dataGridViewProductSearchByCategory.Columns.Add("ProductId","Product Id");
            dataGridViewProductSearchByCategory.Columns.Add("ProductName","Product Name");
            dataGridViewProductSearchByCategory.Columns.Add("Identifier","Identifier");
            dataGridViewProductSearchByCategory.Columns.Add("Value","Value");
            dataGridViewProductSearchByCategory.Columns.Add("ProductInfoValue","Product Info Value");
            dataGridViewProductSearchByCategory.Columns.Add("ProductImageTypeRcd","Product Image Type");
            dataGridViewProductSearchByCategory.Columns.Add("ProductImageTypeName","Product Image Type Name");
            dataGridViewProductSearchByCategory.Columns.Add("Image","Image");
            dataGridViewProductSearchByCategory.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchByCategory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchByCategory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductSearchByCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchByCategory.AutoResizeColumns();
        }
    }
}
