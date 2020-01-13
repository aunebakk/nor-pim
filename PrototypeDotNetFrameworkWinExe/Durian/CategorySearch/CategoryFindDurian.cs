using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CategoryFindDurian : UserControl {
        
        public CategoryFindDurian() {
           InitializeComponent();
           InitializeGridCategoryFind();
        }
        
        public virtual string ProductCategoryCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewCategoryFind.CurrentRow.Cells["ProductCategoryCode"].Value; else return String.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewCategoryFind.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductCategoryId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewCategoryFind.CurrentRow.Cells["ProductCategoryId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewCategoryFind.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewCategoryFind.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewCategoryFind_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshCategoryFind(string findWhat) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewCategoryFind.CurrentRow != null)
                    position = dataGridViewCategoryFind.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new CategorySearchService().CategoryFind(findWhat);
                dataGridViewCategoryFind.AutoGenerateColumns = true;
                dataGridViewCategoryFind.DataSource = bindingSource;
                dataGridViewCategoryFind.AutoResizeColumns();

                // position to previous row
                if (dataGridViewCategoryFind.Rows.Count > 0) { 
                    dataGridViewCategoryFind.CurrentCell = 
                        dataGridViewCategoryFind.Rows[position].Cells[1];
                    dataGridViewCategoryFind.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridCategoryFind() {
            dataGridViewCategoryFind.Columns.Clear();
            dataGridViewCategoryFind.AutoGenerateColumns = false;
            dataGridViewCategoryFind.Columns.Add("ProductCategoryCode","Product Category Code");
            dataGridViewCategoryFind.Columns.Add("ProductName","Product Name");
            dataGridViewCategoryFind.Columns.Add("ProductCategoryId","Product Category Id");
            dataGridViewCategoryFind.Columns.Add("ProductId","Product Id");
            dataGridViewCategoryFind.Columns.Add("ExtensionData", "");
            dataGridViewCategoryFind.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCategoryFind.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCategoryFind.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCategoryFind.AutoResizeColumns();
        }
    }
}
