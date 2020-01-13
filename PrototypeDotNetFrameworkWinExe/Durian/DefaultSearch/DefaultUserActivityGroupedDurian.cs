using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityGroupedDurian : UserControl {
        
        public DefaultUserActivityGroupedDurian() {
           InitializeComponent();
           InitializeGridDefaultUserActivityGrouped();
        }
        
        public virtual string OriginatingAddress {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserActivityGrouped.CurrentRow.Cells["OriginatingAddress"].Value; else return String.Empty;;
            }
        }
        
        public virtual string UserActivityTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserActivityGrouped.CurrentRow.Cells["UserActivityTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string UserActivityNote {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserActivityGrouped.CurrentRow.Cells["UserActivityNote"].Value; else return String.Empty;;
            }
        }
        
        public virtual int Occurrences {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultUserActivityGrouped.CurrentRow.Cells["Occurrences"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultUserActivityGrouped.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultUserActivityGrouped_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultUserActivityGrouped() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultUserActivityGrouped.CurrentRow != null)
                    position = dataGridViewDefaultUserActivityGrouped.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultUserActivityGrouped();
                dataGridViewDefaultUserActivityGrouped.AutoGenerateColumns = true;
                dataGridViewDefaultUserActivityGrouped.DataSource = bindingSource;
                dataGridViewDefaultUserActivityGrouped.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultUserActivityGrouped.Rows.Count > 0) { 
                    dataGridViewDefaultUserActivityGrouped.CurrentCell = 
                        dataGridViewDefaultUserActivityGrouped.Rows[position].Cells[1];
                    dataGridViewDefaultUserActivityGrouped.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultUserActivityGrouped() {
            dataGridViewDefaultUserActivityGrouped.Columns.Clear();
            dataGridViewDefaultUserActivityGrouped.AutoGenerateColumns = false;
            dataGridViewDefaultUserActivityGrouped.Columns.Add("OriginatingAddress","Originating Address");
            dataGridViewDefaultUserActivityGrouped.Columns.Add("UserActivityTypeName","User Activity Type Name");
            dataGridViewDefaultUserActivityGrouped.Columns.Add("UserActivityNote","User Activity Note");
            dataGridViewDefaultUserActivityGrouped.Columns.Add("Occurrences","Occurrences");
            dataGridViewDefaultUserActivityGrouped.Columns.Add("ExtensionData", "");
            dataGridViewDefaultUserActivityGrouped.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultUserActivityGrouped.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultUserActivityGrouped.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultUserActivityGrouped.AutoResizeColumns();
        }
    }
}
