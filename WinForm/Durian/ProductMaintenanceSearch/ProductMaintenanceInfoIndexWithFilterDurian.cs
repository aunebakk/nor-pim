using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceInfoIndexWithFilterDurian : UserControl {
        
        public ProductMaintenanceInfoIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridProductMaintenanceInfoIndexWithFilter();
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string StateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["StateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductInfoName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["ProductInfoName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ProductInfoRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["ProductInfoRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductInfoValue {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["ProductInfoValue"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ProductInfoId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Cells["ProductInfoId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductMaintenanceInfoIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductMaintenanceInfoIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductMaintenanceInfoIndexWithFilter(System.Guid productId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow != null)
                    position = dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductMaintenanceSearchServiceClient().ProductMaintenanceInfoIndexWithFilter(productId);
                dataGridViewProductMaintenanceInfoIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewProductMaintenanceInfoIndexWithFilter.DataSource = bindingSource;
                dataGridViewProductMaintenanceInfoIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductMaintenanceInfoIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewProductMaintenanceInfoIndexWithFilter.CurrentCell = 
                        dataGridViewProductMaintenanceInfoIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewProductMaintenanceInfoIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductMaintenanceInfoIndexWithFilter() {
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Clear();
            dataGridViewProductMaintenanceInfoIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("StateRcd","State");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("ProductInfoName","Product Info Name");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("ProductInfoRcd","Product Info");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("ProductInfoValue","Product Info Value");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("ProductInfoId","Product Info Id");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewProductMaintenanceInfoIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductMaintenanceInfoIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductMaintenanceInfoIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductMaintenanceInfoIndexWithFilter.AutoResizeColumns();
        }
    }
}
