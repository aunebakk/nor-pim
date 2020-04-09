using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultErrorOverviewDurian : UserControl {
        
        public DefaultErrorOverviewDurian() {
           InitializeComponent();
           InitializeGridDefaultErrorOverview();
        }
        
        public virtual System.Guid DefaultErrorId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewDefaultErrorOverview.CurrentRow.Cells["DefaultErrorId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewDefaultErrorOverview.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string DefaultErrorLayerName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultErrorOverview.CurrentRow.Cells["DefaultErrorLayerName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultErrorTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultErrorOverview.CurrentRow.Cells["DefaultErrorTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DomainName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultErrorOverview.CurrentRow.Cells["DomainName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClassName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultErrorOverview.CurrentRow.Cells["ClassName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string MethodName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultErrorOverview.CurrentRow.Cells["MethodName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ErrorMessage {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultErrorOverview.CurrentRow.Cells["ErrorMessage"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultErrorOverview.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultErrorOverview_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultErrorOverview() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultErrorOverview.CurrentRow != null)
                    position = dataGridViewDefaultErrorOverview.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultErrorOverview();
                dataGridViewDefaultErrorOverview.AutoGenerateColumns = true;
                dataGridViewDefaultErrorOverview.DataSource = bindingSource;
                dataGridViewDefaultErrorOverview.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultErrorOverview.Rows.Count > 0) { 
                    dataGridViewDefaultErrorOverview.CurrentCell = 
                        dataGridViewDefaultErrorOverview.Rows[position].Cells[1];
                    dataGridViewDefaultErrorOverview.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultErrorOverview() {
            dataGridViewDefaultErrorOverview.Columns.Clear();
            dataGridViewDefaultErrorOverview.AutoGenerateColumns = false;
            dataGridViewDefaultErrorOverview.Columns.Add("DefaultErrorId","Default Error Id");
            dataGridViewDefaultErrorOverview.Columns.Add("DateTime","Date Time");
            dataGridViewDefaultErrorOverview.Columns.Add("DefaultErrorLayerName","Default Error Layer Name");
            dataGridViewDefaultErrorOverview.Columns.Add("DefaultErrorTypeName","Default Error Type Name");
            dataGridViewDefaultErrorOverview.Columns.Add("DomainName","Domain Name");
            dataGridViewDefaultErrorOverview.Columns.Add("ClassName","Class Name");
            dataGridViewDefaultErrorOverview.Columns.Add("MethodName","Method Name");
            dataGridViewDefaultErrorOverview.Columns.Add("ErrorMessage","Error Message");
            dataGridViewDefaultErrorOverview.Columns.Add("ExtensionData", "");
            dataGridViewDefaultErrorOverview.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultErrorOverview.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultErrorOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultErrorOverview.AutoResizeColumns();
        }
    }
}
