using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceAttributeIndexWithFilterDurian : UserControl {
        
        public ProductMaintenanceAttributeIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridProductMaintenanceAttributeIndexWithFilter();
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string StateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["StateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductAttributeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["ProductAttributeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductAttributeUnitName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["ProductAttributeUnitName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ProductAttributeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["ProductAttributeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductAttributeUnitRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["ProductAttributeUnitRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Value {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["Value"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ProductAttributeId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Cells["ProductAttributeId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductMaintenanceAttributeIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductMaintenanceAttributeIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductMaintenanceAttributeIndexWithFilter(System.Guid productId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow != null)
                    position = dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductMaintenanceSearchService().ProductMaintenanceAttributeIndexWithFilter(productId);
                dataGridViewProductMaintenanceAttributeIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewProductMaintenanceAttributeIndexWithFilter.DataSource = bindingSource;
                dataGridViewProductMaintenanceAttributeIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductMaintenanceAttributeIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewProductMaintenanceAttributeIndexWithFilter.CurrentCell = 
                        dataGridViewProductMaintenanceAttributeIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewProductMaintenanceAttributeIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductMaintenanceAttributeIndexWithFilter() {
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Clear();
            dataGridViewProductMaintenanceAttributeIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("StateRcd","State");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("ProductAttributeName","Product Attribute Name");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("ProductAttributeUnitName","Product Attribute Unit Name");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("ProductAttributeRcd","Product Attribute");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("ProductAttributeUnitRcd","Product Attribute Unit");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("Value","Value");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("ProductAttributeId","Product Attribute Id");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductMaintenanceAttributeIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductMaintenanceAttributeIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductMaintenanceAttributeIndexWithFilter.AutoResizeColumns();
        }
    }
}
