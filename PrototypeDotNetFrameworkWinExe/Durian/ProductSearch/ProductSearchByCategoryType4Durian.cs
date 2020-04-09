using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType4Durian : UserControl {
        
        public ProductSearchByCategoryType4Durian() {
           InitializeComponent();
           InitializeGridProductSearchByCategoryType4();
        }
        
        public virtual string Hn {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType4.CurrentRow.Cells["Hn"].Value; else return String.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType4.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Gtin13 {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType4.CurrentRow.Cells["Gtin13"].Value; else return String.Empty;;
            }
        }
        
        public virtual string SupplierName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType4.CurrentRow.Cells["SupplierName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductSearchByCategoryType4.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductSearchByCategoryType4.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductSearchByCategoryType4_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductSearchByCategoryType4(System.Guid productCategoryId, bool onParent) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchByCategoryType4.CurrentRow != null)
                    position = dataGridViewProductSearchByCategoryType4.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductSearchService().ProductSearchByCategoryType4(productCategoryId,onParent);
                dataGridViewProductSearchByCategoryType4.AutoGenerateColumns = true;
                dataGridViewProductSearchByCategoryType4.DataSource = bindingSource;
                dataGridViewProductSearchByCategoryType4.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductSearchByCategoryType4.Rows.Count > 0) { 
                    dataGridViewProductSearchByCategoryType4.CurrentCell = 
                        dataGridViewProductSearchByCategoryType4.Rows[position].Cells[1];
                    dataGridViewProductSearchByCategoryType4.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductSearchByCategoryType4() {
            dataGridViewProductSearchByCategoryType4.Columns.Clear();
            dataGridViewProductSearchByCategoryType4.AutoGenerateColumns = false;
            dataGridViewProductSearchByCategoryType4.Columns.Add("Hn","Hn");
            dataGridViewProductSearchByCategoryType4.Columns.Add("ProductName","Product Name");
            dataGridViewProductSearchByCategoryType4.Columns.Add("Gtin13","Gtin13");
            dataGridViewProductSearchByCategoryType4.Columns.Add("SupplierName","Supplier Name");
            dataGridViewProductSearchByCategoryType4.Columns.Add("ProductId","Product Id");
            dataGridViewProductSearchByCategoryType4.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchByCategoryType4.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchByCategoryType4.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductSearchByCategoryType4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchByCategoryType4.AutoResizeColumns();
        }
    }
}
