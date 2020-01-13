using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetDefaultChangeLogDurian : UserControl {
        
        public GetDefaultChangeLogDurian() {
           InitializeComponent();
           InitializeGridGetDefaultChangeLog();
        }
        
        public virtual string DefaultChangeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetDefaultChangeLog.CurrentRow.Cells["DefaultChangeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultChangeDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetDefaultChangeLog.CurrentRow.Cells["DefaultChangeDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetDefaultChangeLog.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string DefaultChangeLogTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetDefaultChangeLog.CurrentRow.Cells["DefaultChangeLogTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultChangeLogTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetDefaultChangeLog.CurrentRow.Cells["DefaultChangeLogTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid DefaultIssueId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetDefaultChangeLog.CurrentRow.Cells["DefaultIssueId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string IssueName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetDefaultChangeLog.CurrentRow.Cells["IssueName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid DefaultChangeLogId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetDefaultChangeLog.CurrentRow.Cells["DefaultChangeLogId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetDefaultChangeLog.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetDefaultChangeLog_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetDefaultChangeLog(string defaultChangeName, string defaultChangeLogTypeRcd, System.Guid defaultIssueId, System.Guid defaultChangeLogId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetDefaultChangeLog.CurrentRow != null)
                    position = dataGridViewGetDefaultChangeLog.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().GetDefaultChangeLog(defaultChangeName,defaultChangeLogTypeRcd,defaultIssueId,defaultChangeLogId);
                dataGridViewGetDefaultChangeLog.AutoGenerateColumns = true;
                dataGridViewGetDefaultChangeLog.DataSource = bindingSource;
                dataGridViewGetDefaultChangeLog.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetDefaultChangeLog.Rows.Count > 0) { 
                    dataGridViewGetDefaultChangeLog.CurrentCell = 
                        dataGridViewGetDefaultChangeLog.Rows[position].Cells[1];
                    dataGridViewGetDefaultChangeLog.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetDefaultChangeLog() {
            dataGridViewGetDefaultChangeLog.Columns.Clear();
            dataGridViewGetDefaultChangeLog.AutoGenerateColumns = false;
            dataGridViewGetDefaultChangeLog.Columns.Add("DefaultChangeName","Default Change Name");
            dataGridViewGetDefaultChangeLog.Columns.Add("DefaultChangeDescription","Default Change Description");
            dataGridViewGetDefaultChangeLog.Columns.Add("DateTime","Date Time");
            dataGridViewGetDefaultChangeLog.Columns.Add("DefaultChangeLogTypeRcd","Default Change Log Type");
            dataGridViewGetDefaultChangeLog.Columns.Add("DefaultChangeLogTypeName","Default Change Log Type Name");
            dataGridViewGetDefaultChangeLog.Columns.Add("DefaultIssueId","Default Issue Id");
            dataGridViewGetDefaultChangeLog.Columns.Add("IssueName","Issue Name");
            dataGridViewGetDefaultChangeLog.Columns.Add("DefaultChangeLogId","Default Change Log Id");
            dataGridViewGetDefaultChangeLog.Columns.Add("ExtensionData", "");
            dataGridViewGetDefaultChangeLog.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetDefaultChangeLog.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetDefaultChangeLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetDefaultChangeLog.AutoResizeColumns();
        }
    }
}
