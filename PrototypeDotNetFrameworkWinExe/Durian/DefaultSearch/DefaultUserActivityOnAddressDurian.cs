using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityOnAddressDurian : UserControl {
        
        public DefaultUserActivityOnAddressDurian() {
           InitializeComponent();
           InitializeGridDefaultUserActivityOnAddress();
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewDefaultUserActivityOnAddress.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string UserActivityTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserActivityOnAddress.CurrentRow.Cells["UserActivityTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string OriginatingAddress {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserActivityOnAddress.CurrentRow.Cells["OriginatingAddress"].Value; else return String.Empty;;
            }
        }
        
        public virtual string UserActivityNote {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserActivityOnAddress.CurrentRow.Cells["UserActivityNote"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultUserActivityOnAddress.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultUserActivityOnAddress_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultUserActivityOnAddress(string originatingAddress) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultUserActivityOnAddress.CurrentRow != null)
                    position = dataGridViewDefaultUserActivityOnAddress.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultUserActivityOnAddress(originatingAddress);
                dataGridViewDefaultUserActivityOnAddress.AutoGenerateColumns = true;
                dataGridViewDefaultUserActivityOnAddress.DataSource = bindingSource;
                dataGridViewDefaultUserActivityOnAddress.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultUserActivityOnAddress.Rows.Count > 0) { 
                    dataGridViewDefaultUserActivityOnAddress.CurrentCell = 
                        dataGridViewDefaultUserActivityOnAddress.Rows[position].Cells[1];
                    dataGridViewDefaultUserActivityOnAddress.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultUserActivityOnAddress() {
            dataGridViewDefaultUserActivityOnAddress.Columns.Clear();
            dataGridViewDefaultUserActivityOnAddress.AutoGenerateColumns = false;
            dataGridViewDefaultUserActivityOnAddress.Columns.Add("DateTime","Date Time");
            dataGridViewDefaultUserActivityOnAddress.Columns.Add("UserActivityTypeName","User Activity Type Name");
            dataGridViewDefaultUserActivityOnAddress.Columns.Add("OriginatingAddress","Originating Address");
            dataGridViewDefaultUserActivityOnAddress.Columns.Add("UserActivityNote","User Activity Note");
            dataGridViewDefaultUserActivityOnAddress.Columns.Add("ExtensionData", "");
            dataGridViewDefaultUserActivityOnAddress.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultUserActivityOnAddress.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultUserActivityOnAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultUserActivityOnAddress.AutoResizeColumns();
        }
    }
}
