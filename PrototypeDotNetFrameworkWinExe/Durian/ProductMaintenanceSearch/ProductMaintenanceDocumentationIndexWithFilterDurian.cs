using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceDocumentationIndexWithFilterDurian : UserControl {
        
        public ProductMaintenanceDocumentationIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridProductMaintenanceDocumentationIndexWithFilter();
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string StateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["StateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductDocumentationTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["ProductDocumentationTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ProductDocumentationTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["ProductDocumentationTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Documentation {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["Documentation"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ProductDocumentationId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Cells["ProductDocumentationId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductMaintenanceDocumentationIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductMaintenanceDocumentationIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductMaintenanceDocumentationIndexWithFilter(System.Guid productId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow != null)
                    position = dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductMaintenanceSearchService().ProductMaintenanceDocumentationIndexWithFilter(productId);
                dataGridViewProductMaintenanceDocumentationIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewProductMaintenanceDocumentationIndexWithFilter.DataSource = bindingSource;
                dataGridViewProductMaintenanceDocumentationIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductMaintenanceDocumentationIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewProductMaintenanceDocumentationIndexWithFilter.CurrentCell = 
                        dataGridViewProductMaintenanceDocumentationIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewProductMaintenanceDocumentationIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductMaintenanceDocumentationIndexWithFilter() {
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Clear();
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("StateRcd","State");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("ProductDocumentationTypeName","Product Documentation Type Name");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("Documentation","Documentation");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("ProductDocumentationId","Product Documentation Id");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductMaintenanceDocumentationIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductMaintenanceDocumentationIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductMaintenanceDocumentationIndexWithFilter.AutoResizeColumns();
        }
    }
}
