using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityGroupedByAddressDurian : UserControl {
        
        public DefaultUserActivityGroupedByAddressDurian() {
           InitializeComponent();
           InitializeGridDefaultUserActivityGroupedByAddress();
        }
        
        public virtual string OriginatingAddress {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultUserActivityGroupedByAddress.CurrentRow.Cells["OriginatingAddress"].Value; else return String.Empty;;
            }
        }
        
        public virtual int Occurrences {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultUserActivityGroupedByAddress.CurrentRow.Cells["Occurrences"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultUserActivityGroupedByAddress.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultUserActivityGroupedByAddress_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultUserActivityGroupedByAddress() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultUserActivityGroupedByAddress.CurrentRow != null)
                    position = dataGridViewDefaultUserActivityGroupedByAddress.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultSearchService().DefaultUserActivityGroupedByAddress();
                dataGridViewDefaultUserActivityGroupedByAddress.AutoGenerateColumns = true;
                dataGridViewDefaultUserActivityGroupedByAddress.DataSource = bindingSource;
                dataGridViewDefaultUserActivityGroupedByAddress.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultUserActivityGroupedByAddress.Rows.Count > 0) { 
                    dataGridViewDefaultUserActivityGroupedByAddress.CurrentCell = 
                        dataGridViewDefaultUserActivityGroupedByAddress.Rows[position].Cells[1];
                    dataGridViewDefaultUserActivityGroupedByAddress.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultUserActivityGroupedByAddress() {
            dataGridViewDefaultUserActivityGroupedByAddress.Columns.Clear();
            dataGridViewDefaultUserActivityGroupedByAddress.AutoGenerateColumns = false;
            dataGridViewDefaultUserActivityGroupedByAddress.Columns.Add("OriginatingAddress","Originating Address");
            dataGridViewDefaultUserActivityGroupedByAddress.Columns.Add("Occurrences","Occurrences");
            dataGridViewDefaultUserActivityGroupedByAddress.Columns.Add("ExtensionData", "");
            dataGridViewDefaultUserActivityGroupedByAddress.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultUserActivityGroupedByAddress.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultUserActivityGroupedByAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultUserActivityGroupedByAddress.AutoResizeColumns();
        }
    }
}
