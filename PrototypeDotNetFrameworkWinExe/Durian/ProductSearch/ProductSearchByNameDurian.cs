using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByNameDurian : UserControl {
        
        public ProductSearchByNameDurian() {
           InitializeComponent();
           InitializeGridProductSearchByName();
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductSearchByName.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByName.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Identifier {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByName.CurrentRow.Cells["Identifier"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Value {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByName.CurrentRow.Cells["Value"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductInfoValue {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByName.CurrentRow.Cells["ProductInfoValue"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductImageTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByName.CurrentRow.Cells["ProductImageTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductImageTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchByName.CurrentRow.Cells["ProductImageTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual byte[] Image {
            get {
                if (!DesignMode) return (System.Byte[]) dataGridViewProductSearchByName.CurrentRow.Cells["Image"].Value; else return null;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductSearchByName.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductSearchByName_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductSearchByName(string productName) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchByName.CurrentRow != null)
                    position = dataGridViewProductSearchByName.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductSearchService().ProductSearchByName(productName);
                dataGridViewProductSearchByName.AutoGenerateColumns = true;
                dataGridViewProductSearchByName.DataSource = bindingSource;
                dataGridViewProductSearchByName.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductSearchByName.Rows.Count > 0) { 
                    dataGridViewProductSearchByName.CurrentCell = 
                        dataGridViewProductSearchByName.Rows[position].Cells[1];
                    dataGridViewProductSearchByName.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductSearchByName() {
            dataGridViewProductSearchByName.Columns.Clear();
            dataGridViewProductSearchByName.AutoGenerateColumns = false;
            dataGridViewProductSearchByName.Columns.Add("ProductId","Product Id");
            dataGridViewProductSearchByName.Columns.Add("ProductName","Product Name");
            dataGridViewProductSearchByName.Columns.Add("Identifier","Identifier");
            dataGridViewProductSearchByName.Columns.Add("Value","Value");
            dataGridViewProductSearchByName.Columns.Add("ProductInfoValue","Product Info Value");
            dataGridViewProductSearchByName.Columns.Add("ProductImageTypeRcd","Product Image Type");
            dataGridViewProductSearchByName.Columns.Add("ProductImageTypeName","Product Image Type Name");
            dataGridViewProductSearchByName.Columns.Add("Image","Image");
            dataGridViewProductSearchByName.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchByName.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchByName.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductSearchByName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchByName.AutoResizeColumns();
        }
    }
}
