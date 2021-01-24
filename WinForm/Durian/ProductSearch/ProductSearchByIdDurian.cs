using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByIdDurian : UserControl {
        
        public ProductSearchByIdDurian() {
           InitializeComponent();
           InitializeGridProductSearchById();
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchById.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Identifier {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchById.CurrentRow.Cells["Identifier"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Value {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchById.CurrentRow.Cells["Value"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductInfoValue {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchById.CurrentRow.Cells["ProductInfoValue"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductImageTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchById.CurrentRow.Cells["ProductImageTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductImageTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductSearchById.CurrentRow.Cells["ProductImageTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual byte[] Image {
            get {
                if (!DesignMode) return (System.Byte[]) dataGridViewProductSearchById.CurrentRow.Cells["Image"].Value; else return null;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductSearchById.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductSearchById_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductSearchById(System.Guid productId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductSearchById.CurrentRow != null)
                    position = dataGridViewProductSearchById.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductSearchServiceClient().ProductSearchById(productId);
                dataGridViewProductSearchById.AutoGenerateColumns = true;
                dataGridViewProductSearchById.DataSource = bindingSource;
                dataGridViewProductSearchById.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductSearchById.Rows.Count > 0) { 
                    dataGridViewProductSearchById.CurrentCell = 
                        dataGridViewProductSearchById.Rows[position].Cells[1];
                    dataGridViewProductSearchById.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductSearchById() {
            dataGridViewProductSearchById.Columns.Clear();
            dataGridViewProductSearchById.AutoGenerateColumns = false;
            dataGridViewProductSearchById.Columns.Add("ProductName","Product Name");
            dataGridViewProductSearchById.Columns.Add("Identifier","Identifier");
            dataGridViewProductSearchById.Columns.Add("Value","Value");
            dataGridViewProductSearchById.Columns.Add("ProductInfoValue","Product Info Value");
            dataGridViewProductSearchById.Columns.Add("ProductImageTypeRcd","Product Image Type");
            dataGridViewProductSearchById.Columns.Add("ProductImageTypeName","Product Image Type Name");
            dataGridViewProductSearchById.Columns.Add("Image","Image");
            dataGridViewProductSearchById.Columns.Add("ExtensionData", "");
            dataGridViewProductSearchById.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductSearchById.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductSearchById.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductSearchById.AutoResizeColumns();
        }
    }
}
