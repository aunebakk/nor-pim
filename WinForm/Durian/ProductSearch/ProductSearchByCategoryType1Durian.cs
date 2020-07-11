using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryType1Durian : UserControl {
        
        public ProductSearchByCategoryType1Durian() {
           InitializeComponent();
           InitializeGridProductSearchByCategoryType1();
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductSearchByCategoryType1.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType1.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Gtin13 {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType1.CurrentRow.Cells["Gtin13"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Color {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByCategoryType1.CurrentRow.Cells["Color"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductSearchByCategoryType1.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductSearchByCategoryType1_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductSearchByCategoryType1(System.Guid productCategoryId, bool onParent) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchByCategoryType1.CurrentRow != null)
                    position = dataGridViewProductSearchByCategoryType1.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductSearchService().ProductSearchByCategoryType1(productCategoryId,onParent);
                dataGridViewProductSearchByCategoryType1.AutoGenerateColumns = true;
                dataGridViewProductSearchByCategoryType1.DataSource = bindingSource;
                dataGridViewProductSearchByCategoryType1.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductSearchByCategoryType1.Rows.Count > 0) { 
                    dataGridViewProductSearchByCategoryType1.CurrentCell = 
                        dataGridViewProductSearchByCategoryType1.Rows[position].Cells[1];
                    dataGridViewProductSearchByCategoryType1.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductSearchByCategoryType1() {
            dataGridViewProductSearchByCategoryType1.Columns.Clear();
            dataGridViewProductSearchByCategoryType1.AutoGenerateColumns = false;
            dataGridViewProductSearchByCategoryType1.Columns.Add("ProductId","Product Id");
            dataGridViewProductSearchByCategoryType1.Columns.Add("ProductName","Product Name");
            dataGridViewProductSearchByCategoryType1.Columns.Add("Gtin13","Gtin13");
            dataGridViewProductSearchByCategoryType1.Columns.Add("Color","Color");
            dataGridViewProductSearchByCategoryType1.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchByCategoryType1.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchByCategoryType1.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductSearchByCategoryType1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchByCategoryType1.AutoResizeColumns();
        }
    }
}
