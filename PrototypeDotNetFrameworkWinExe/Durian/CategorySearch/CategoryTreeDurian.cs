using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CategoryTreeDurian : UserControl {
        
        public CategoryTreeDurian() {
           InitializeComponent();
           InitializeGridCategoryTree();
        }
        
        public virtual System.Guid ProductCategoryId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewCategoryTree.CurrentRow.Cells["ProductCategoryId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ProductCategoryParentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewCategoryTree.CurrentRow.Cells["ProductCategoryParentId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ProductCategoryCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewCategoryTree.CurrentRow.Cells["ProductCategoryCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductCategoryName {
            get {
                if (!DesignMode) return (System.String) dataGridViewCategoryTree.CurrentRow.Cells["ProductCategoryName"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewCategoryTree.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewCategoryTree_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshCategoryTree() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewCategoryTree.CurrentRow != null)
                    position = dataGridViewCategoryTree.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new CategorySearchService().CategoryTree();
                dataGridViewCategoryTree.AutoGenerateColumns = true;
                dataGridViewCategoryTree.DataSource = bindingSource;
                dataGridViewCategoryTree.AutoResizeColumns();

                // position to previous row
                if (dataGridViewCategoryTree.Rows.Count > 0) { 
                    dataGridViewCategoryTree.CurrentCell = 
                        dataGridViewCategoryTree.Rows[position].Cells[1];
                    dataGridViewCategoryTree.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridCategoryTree() {
            dataGridViewCategoryTree.Columns.Clear();
            dataGridViewCategoryTree.AutoGenerateColumns = false;
            dataGridViewCategoryTree.Columns.Add("ProductCategoryId","Product Category Id");
            dataGridViewCategoryTree.Columns.Add("ProductCategoryParentId","Product Category Parent Id");
            dataGridViewCategoryTree.Columns.Add("ProductCategoryCode","Product Category Code");
            dataGridViewCategoryTree.Columns.Add("ProductCategoryName","Product Category Name");
            dataGridViewCategoryTree.Columns.Add("ExtensionData", "");
            dataGridViewCategoryTree.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCategoryTree.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCategoryTree.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCategoryTree.AutoResizeColumns();
        }
    }
}
