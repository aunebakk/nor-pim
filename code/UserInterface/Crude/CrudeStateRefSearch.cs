using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeStateRefSearch : Form {
        
        public CrudeStateRefSearch() {
            InitializeComponent();
            InitializeGridCrudeStateRef();
            this.AcceptButton = buttonSearch;
            this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            buttonSearch_Click(new object(), new EventArgs());
            base.Show();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeStateRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeStateRef.CurrentRow.Cells["StateRcd"].Value);
        }
        
        private void dataGridViewCrudeStateRef_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeStateRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.String) dataGridViewCrudeStateRef.CurrentRow.Cells["StateRcd"].Value);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e) {
            var crudeStateRef = new CrudeStateRefService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeStateRef.FetchWithFilter(                            
                     stateRefCombo.Text
                    ,textBoxStateName.Text
                    ,dateTimePickerDateTime.Checked == false ? DateTime.MinValue : Convert.ToDateTime(dateTimePickerDateTime.Value)
                    );

                dataGridViewCrudeStateRef.AutoGenerateColumns = false;
                dataGridViewCrudeStateRef.DataSource = bindingSource;
                dataGridViewCrudeStateRef.AutoResizeColumns();
                dataGridViewCrudeStateRef.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeStateRef.Close();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeStateRefEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd();
        }
        
        private void InitializeGridCrudeStateRef() {
            dataGridViewCrudeStateRef.Columns.Clear();
            dataGridViewCrudeStateRef.AutoGenerateColumns = false;
            dataGridViewCrudeStateRef.Columns.Add("StateRcd","State");
            dataGridViewCrudeStateRef.Columns.Add("StateName","State Name");
            dataGridViewCrudeStateRef.Columns.Add("DateTime","Date Time");
            dataGridViewCrudeStateRef.Columns.Add("ExtensionData", "");
            dataGridViewCrudeStateRef.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewCrudeStateRef.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewCrudeStateRef.AutoResizeColumns();
        }
    }
}
