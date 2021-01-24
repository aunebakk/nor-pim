using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserListForDashboardDurian : UserControl {
        
        public DefaultUserListForDashboardDurian() {
           InitializeComponent();
           InitializeGridDefaultUserListForDashboard();
        }
        
        public virtual string DefaultUserCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["DefaultUserCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Email {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["Email"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultStateName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["DefaultStateName"].Value; else return String.Empty;;
            }
        }
        
        public virtual int ActivityCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["ActivityCount"].Value; else return 0;;
            }
        }
        
        public virtual string LastActivityDateTime {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["LastActivityDateTime"].Value; else return String.Empty;;
            }
        }
        
        public virtual string CreatedDateTime {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["CreatedDateTime"].Value; else return String.Empty;;
            }
        }
        
        public virtual string CreatedByDefaultUserCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["CreatedByDefaultUserCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string CreatedByDefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["CreatedByDefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid DefaultUserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewDefaultUserListForDashboard.CurrentRow.Cells["DefaultUserId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultUserListForDashboard.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultUserListForDashboard_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultUserListForDashboard() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultUserListForDashboard.CurrentRow != null)
                    position = dataGridViewDefaultUserListForDashboard.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchServiceClient().DefaultUserListForDashboard();
                dataGridViewDefaultUserListForDashboard.AutoGenerateColumns = true;
                dataGridViewDefaultUserListForDashboard.DataSource = bindingSource;
                dataGridViewDefaultUserListForDashboard.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultUserListForDashboard.Rows.Count > 0) { 
                    dataGridViewDefaultUserListForDashboard.CurrentCell = 
                        dataGridViewDefaultUserListForDashboard.Rows[position].Cells[1];
                    dataGridViewDefaultUserListForDashboard.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultUserListForDashboard() {
            dataGridViewDefaultUserListForDashboard.Columns.Clear();
            dataGridViewDefaultUserListForDashboard.AutoGenerateColumns = false;
            dataGridViewDefaultUserListForDashboard.Columns.Add("DefaultUserCode","Default User Code");
            dataGridViewDefaultUserListForDashboard.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewDefaultUserListForDashboard.Columns.Add("Email","Email");
            dataGridViewDefaultUserListForDashboard.Columns.Add("DefaultStateName","Default State Name");
            dataGridViewDefaultUserListForDashboard.Columns.Add("ActivityCount","Activity Count");
            dataGridViewDefaultUserListForDashboard.Columns.Add("LastActivityDateTime","Last Activity Date Time");
            dataGridViewDefaultUserListForDashboard.Columns.Add("CreatedDateTime","Created Date Time");
            dataGridViewDefaultUserListForDashboard.Columns.Add("CreatedByDefaultUserCode","Created By Default User Code");
            dataGridViewDefaultUserListForDashboard.Columns.Add("CreatedByDefaultUserName","Created By Default User Name");
            dataGridViewDefaultUserListForDashboard.Columns.Add("DefaultUserId","Default User Id");
            dataGridViewDefaultUserListForDashboard.Columns.Add("ExtensionData", "");
            dataGridViewDefaultUserListForDashboard.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultUserListForDashboard.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultUserListForDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultUserListForDashboard.AutoResizeColumns();
        }
    }
}
