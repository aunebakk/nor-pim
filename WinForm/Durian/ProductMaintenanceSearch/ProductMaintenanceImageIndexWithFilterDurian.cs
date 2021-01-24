using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceImageIndexWithFilterDurian : UserControl {
        
        public ProductMaintenanceImageIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridProductMaintenanceImageIndexWithFilter();
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string StateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["StateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductImageTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["ProductImageTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ImageFileName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["ImageFileName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ProductImageTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["ProductImageTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual byte[] Image {
            get {
                if (!DesignMode) return (System.Byte[]) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["Image"].Value; else return null;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ProductImageId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Cells["ProductImageId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewProductMaintenanceImageIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewProductMaintenanceImageIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshProductMaintenanceImageIndexWithFilter(System.Guid productId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow != null)
                    position = dataGridViewProductMaintenanceImageIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ProductMaintenanceSearchServiceClient().ProductMaintenanceImageIndexWithFilter(productId);
                dataGridViewProductMaintenanceImageIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewProductMaintenanceImageIndexWithFilter.DataSource = bindingSource;
                dataGridViewProductMaintenanceImageIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewProductMaintenanceImageIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewProductMaintenanceImageIndexWithFilter.CurrentCell = 
                        dataGridViewProductMaintenanceImageIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewProductMaintenanceImageIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridProductMaintenanceImageIndexWithFilter() {
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Clear();
            dataGridViewProductMaintenanceImageIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("StateRcd","State");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("ProductImageTypeName","Product Image Type Name");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("ImageFileName","Image File Name");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("ProductImageTypeRcd","Product Image Type");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("Image","Image");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("ProductImageId","Product Image Id");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewProductMaintenanceImageIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewProductMaintenanceImageIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewProductMaintenanceImageIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductMaintenanceImageIndexWithFilter.AutoResizeColumns();
        }
    }
}
