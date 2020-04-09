using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserListDurian : UserControl {
        
        public DefaultUserListDurian() {
           InitializeComponent();
           InitializeGridDefaultUserList();
        }
        
        public virtual System.DateTime LastActivityDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewDefaultUserList.CurrentRow.Cells["LastActivityDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserList.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserList.CurrentRow.Cells["DefaultUserCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime CreatedDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewDefaultUserList.CurrentRow.Cells["CreatedDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string Email {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserList.CurrentRow.Cells["Email"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultStateName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserList.CurrentRow.Cells["DefaultStateName"].Value; else return String.Empty;;
            }
        }
        
        public virtual int ActivityCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultUserList.CurrentRow.Cells["ActivityCount"].Value; else return 0;;
            }
        }
        
        public virtual string CreatedByDefaultUserCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserList.CurrentRow.Cells["CreatedByDefaultUserCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string CreatedByDefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserList.CurrentRow.Cells["CreatedByDefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid DefaultUserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewDefaultUserList.CurrentRow.Cells["DefaultUserId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultUserList.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultUserList_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultUserList() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultUserList.CurrentRow != null)
                    position = dataGridViewDefaultUserList.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultUserList();
                dataGridViewDefaultUserList.AutoGenerateColumns = true;
                dataGridViewDefaultUserList.DataSource = bindingSource;
                dataGridViewDefaultUserList.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultUserList.Rows.Count > 0) { 
                    dataGridViewDefaultUserList.CurrentCell = 
                        dataGridViewDefaultUserList.Rows[position].Cells[1];
                    dataGridViewDefaultUserList.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultUserList() {
            dataGridViewDefaultUserList.Columns.Clear();
            dataGridViewDefaultUserList.AutoGenerateColumns = false;
            dataGridViewDefaultUserList.Columns.Add("LastActivityDateTime","Last Activity Date Time");
            dataGridViewDefaultUserList.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewDefaultUserList.Columns.Add("DefaultUserCode","Default User Code");
            dataGridViewDefaultUserList.Columns.Add("CreatedDateTime","Created Date Time");
            dataGridViewDefaultUserList.Columns.Add("Email","Email");
            dataGridViewDefaultUserList.Columns.Add("DefaultStateName","Default State Name");
            dataGridViewDefaultUserList.Columns.Add("ActivityCount","Activity Count");
            dataGridViewDefaultUserList.Columns.Add("CreatedByDefaultUserCode","Created By Default User Code");
            dataGridViewDefaultUserList.Columns.Add("CreatedByDefaultUserName","Created By Default User Name");
            dataGridViewDefaultUserList.Columns.Add("DefaultUserId","Default User Id");
            dataGridViewDefaultUserList.Columns.Add("ExtensionData", "");
            dataGridViewDefaultUserList.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultUserList.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultUserList.AutoResizeColumns();
        }
    }
}
