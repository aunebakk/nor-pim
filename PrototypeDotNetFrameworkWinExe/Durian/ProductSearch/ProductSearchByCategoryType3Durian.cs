using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType3Durian : UserControl {
        
        public ProductSearchByCategoryType3Durian() {
           InitializeComponent();
           InitializeGridProductSearchByCategoryType3();
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductSearchByCategoryType3.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType3.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Gtin13 {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType3.CurrentRow.Cells["Gtin13"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Hn {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType3.CurrentRow.Cells["Hn"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Color {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType3.CurrentRow.Cells["Color"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductSearchByCategoryType3.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductSearchByCategoryType3_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductSearchByCategoryType3(System.Guid productCategoryId, bool onParent) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchByCategoryType3.CurrentRow != null)
                    position = dataGridViewProductSearchByCategoryType3.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductSearchService().ProductSearchByCategoryType3(productCategoryId,onParent);
                dataGridViewProductSearchByCategoryType3.AutoGenerateColumns = true;
                dataGridViewProductSearchByCategoryType3.DataSource = bindingSource;
                dataGridViewProductSearchByCategoryType3.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductSearchByCategoryType3.Rows.Count > 0) { 
                    dataGridViewProductSearchByCategoryType3.CurrentCell = 
                        dataGridViewProductSearchByCategoryType3.Rows[position].Cells[1];
                    dataGridViewProductSearchByCategoryType3.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductSearchByCategoryType3() {
            dataGridViewProductSearchByCategoryType3.Columns.Clear();
            dataGridViewProductSearchByCategoryType3.AutoGenerateColumns = false;
            dataGridViewProductSearchByCategoryType3.Columns.Add("ProductId","Product Id");
            dataGridViewProductSearchByCategoryType3.Columns.Add("ProductName","Product Name");
            dataGridViewProductSearchByCategoryType3.Columns.Add("Gtin13","Gtin13");
            dataGridViewProductSearchByCategoryType3.Columns.Add("Hn","Hn");
            dataGridViewProductSearchByCategoryType3.Columns.Add("Color","Color");
            dataGridViewProductSearchByCategoryType3.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchByCategoryType3.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchByCategoryType3.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductSearchByCategoryType3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchByCategoryType3.AutoResizeColumns();
        }
    }
}
