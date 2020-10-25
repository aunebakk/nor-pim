using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultIssueWithFilterDurian : UserControl {
        
        public DefaultIssueWithFilterDurian() {
           InitializeComponent();
           InitializeGridDefaultIssueWithFilter();
        }
        
        public virtual string DefaultIssueTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["DefaultIssueTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultIssueTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["DefaultIssueTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultIssueStatusRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["DefaultIssueStatusRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultIssueStatusName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["DefaultIssueStatusName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid DefaultErrorId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["DefaultErrorId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string MethodName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["MethodName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string IssueName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["IssueName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string IssueDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["IssueDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual string StepsToReproduce {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["StepsToReproduce"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Link {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["Link"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid DefaultIssueId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewDefaultIssueWithFilter.CurrentRow.Cells["DefaultIssueId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultIssueWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultIssueWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultIssueWithFilter(string defaultIssueTypeRcd, string defaultIssueStatusRcd) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultIssueWithFilter.CurrentRow != null)
                    position = dataGridViewDefaultIssueWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultIssueWithFilter(defaultIssueTypeRcd,defaultIssueStatusRcd);
                dataGridViewDefaultIssueWithFilter.AutoGenerateColumns = true;
                dataGridViewDefaultIssueWithFilter.DataSource = bindingSource;
                dataGridViewDefaultIssueWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultIssueWithFilter.Rows.Count > 0) { 
                    dataGridViewDefaultIssueWithFilter.CurrentCell = 
                        dataGridViewDefaultIssueWithFilter.Rows[position].Cells[1];
                    dataGridViewDefaultIssueWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultIssueWithFilter() {
            dataGridViewDefaultIssueWithFilter.Columns.Clear();
            dataGridViewDefaultIssueWithFilter.AutoGenerateColumns = false;
            dataGridViewDefaultIssueWithFilter.Columns.Add("DefaultIssueTypeRcd","Default Issue Type");
            dataGridViewDefaultIssueWithFilter.Columns.Add("DefaultIssueTypeName","Default Issue Type Name");
            dataGridViewDefaultIssueWithFilter.Columns.Add("DefaultIssueStatusRcd","Default Issue Status");
            dataGridViewDefaultIssueWithFilter.Columns.Add("DefaultIssueStatusName","Default Issue Status Name");
            dataGridViewDefaultIssueWithFilter.Columns.Add("DefaultErrorId","Default Error Id");
            dataGridViewDefaultIssueWithFilter.Columns.Add("MethodName","Method Name");
            dataGridViewDefaultIssueWithFilter.Columns.Add("IssueName","Issue Name");
            dataGridViewDefaultIssueWithFilter.Columns.Add("IssueDescription","Issue Description");
            dataGridViewDefaultIssueWithFilter.Columns.Add("StepsToReproduce","Steps To Reproduce");
            dataGridViewDefaultIssueWithFilter.Columns.Add("Link","Link");
            dataGridViewDefaultIssueWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewDefaultIssueWithFilter.Columns.Add("DefaultIssueId","Default Issue Id");
            dataGridViewDefaultIssueWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewDefaultIssueWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultIssueWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultIssueWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultIssueWithFilter.AutoResizeColumns();
        }
    }
}
