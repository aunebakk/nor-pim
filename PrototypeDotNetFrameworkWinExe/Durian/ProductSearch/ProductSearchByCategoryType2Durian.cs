using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType2Durian : UserControl {
        
        public ProductSearchByCategoryType2Durian() {
           InitializeComponent();
           InitializeGridProductSearchByCategoryType2();
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductSearchByCategoryType2.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType2.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Gtin13 {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType2.CurrentRow.Cells["Gtin13"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Hn {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType2.CurrentRow.Cells["Hn"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Color {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType2.CurrentRow.Cells["Color"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductSearchByCategoryType2.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductSearchByCategoryType2_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductSearchByCategoryType2(System.Guid productCategoryId, bool onParent) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchByCategoryType2.CurrentRow != null)
                    position = dataGridViewProductSearchByCategoryType2.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductSearchService().ProductSearchByCategoryType2(productCategoryId,onParent);
                dataGridViewProductSearchByCategoryType2.AutoGenerateColumns = true;
                dataGridViewProductSearchByCategoryType2.DataSource = bindingSource;
                dataGridViewProductSearchByCategoryType2.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductSearchByCategoryType2.Rows.Count > 0) { 
                    dataGridViewProductSearchByCategoryType2.CurrentCell = 
                        dataGridViewProductSearchByCategoryType2.Rows[position].Cells[1];
                    dataGridViewProductSearchByCategoryType2.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductSearchByCategoryType2() {
            dataGridViewProductSearchByCategoryType2.Columns.Clear();
            dataGridViewProductSearchByCategoryType2.AutoGenerateColumns = false;
            dataGridViewProductSearchByCategoryType2.Columns.Add("ProductId","Product Id");
            dataGridViewProductSearchByCategoryType2.Columns.Add("ProductName","Product Name");
            dataGridViewProductSearchByCategoryType2.Columns.Add("Gtin13","Gtin13");
            dataGridViewProductSearchByCategoryType2.Columns.Add("Hn","Hn");
            dataGridViewProductSearchByCategoryType2.Columns.Add("Color","Color");
            dataGridViewProductSearchByCategoryType2.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchByCategoryType2.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchByCategoryType2.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductSearchByCategoryType2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchByCategoryType2.AutoResizeColumns();
        }
    }
}
