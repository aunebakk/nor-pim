using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceIdentifierIndexWithFilterDurian : UserControl {
        
        public ProductMaintenanceIdentifierIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridProductMaintenanceIdentifierIndexWithFilter();
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string StateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["StateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductIdentifierName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["ProductIdentifierName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ProductIdentifierRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["ProductIdentifierRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Identifier {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["Identifier"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ProductIdentifierId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["ProductIdentifierId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductMaintenanceIdentifierIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductMaintenanceIdentifierIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductMaintenanceIdentifierIndexWithFilter(System.Guid productId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow != null)
                    position = dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductMaintenanceSearchService().ProductMaintenanceIdentifierIndexWithFilter(productId);
                dataGridViewProductMaintenanceIdentifierIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewProductMaintenanceIdentifierIndexWithFilter.DataSource = bindingSource;
                dataGridViewProductMaintenanceIdentifierIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductMaintenanceIdentifierIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewProductMaintenanceIdentifierIndexWithFilter.CurrentCell = 
                        dataGridViewProductMaintenanceIdentifierIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewProductMaintenanceIdentifierIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductMaintenanceIdentifierIndexWithFilter() {
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Clear();
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("StateRcd","State");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("ProductIdentifierName","Product Identifier Name");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("ProductIdentifierRcd","Product Identifier");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("Identifier","Identifier");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("ProductIdentifierId","Product Identifier Id");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductMaintenanceIdentifierIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductMaintenanceIdentifierIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductMaintenanceIdentifierIndexWithFilter.AutoResizeColumns();
        }
    }
}
