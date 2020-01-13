using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceIndexDurian : UserControl {
        
        public ProductMaintenanceIndexDurian() {
           InitializeComponent();
           InitializeGridProductMaintenanceIndex();
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIndex.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string StateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIndex.CurrentRow.Cells["StateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceIndex.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewProductMaintenanceIndex.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceIndex.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceIndex.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductMaintenanceIndex.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductMaintenanceIndex_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductMaintenanceIndex() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductMaintenanceIndex.CurrentRow != null)
                    position = dataGridViewProductMaintenanceIndex.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductMaintenanceSearchService().ProductMaintenanceIndex();
                dataGridViewProductMaintenanceIndex.AutoGenerateColumns = true;
                dataGridViewProductMaintenanceIndex.DataSource = bindingSource;
                dataGridViewProductMaintenanceIndex.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductMaintenanceIndex.Rows.Count > 0) { 
                    dataGridViewProductMaintenanceIndex.CurrentCell = 
                        dataGridViewProductMaintenanceIndex.Rows[position].Cells[1];
                    dataGridViewProductMaintenanceIndex.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductMaintenanceIndex() {
            dataGridViewProductMaintenanceIndex.Columns.Clear();
            dataGridViewProductMaintenanceIndex.AutoGenerateColumns = false;
            dataGridViewProductMaintenanceIndex.Columns.Add("ProductName","Product Name");
            dataGridViewProductMaintenanceIndex.Columns.Add("StateRcd","State");
            dataGridViewProductMaintenanceIndex.Columns.Add("UserId","User Id");
            dataGridViewProductMaintenanceIndex.Columns.Add("DateTime","Date Time");
            dataGridViewProductMaintenanceIndex.Columns.Add("ProductId","Product Id");
            dataGridViewProductMaintenanceIndex.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductMaintenanceIndex.Columns.Add("ExtensionData", "");
            dataGridViewProductMaintenanceIndex.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductMaintenanceIndex.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductMaintenanceIndex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductMaintenanceIndex.AutoResizeColumns();
        }
    }
}
