using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetCartProductWithFilterDurian : UserControl {
        
        public GetCartProductWithFilterDurian() {
           InitializeComponent();
           InitializeGridGetCartProductWithFilter();
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal Amount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["Amount"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string StateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["StateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid CartProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProductWithFilter.CurrentRow.Cells["CartProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetCartProductWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetCartProductWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetCartProductWithFilter() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetCartProductWithFilter.CurrentRow != null)
                    position = dataGridViewGetCartProductWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new CartSearchService().GetCartProductWithFilter();
                dataGridViewGetCartProductWithFilter.AutoGenerateColumns = true;
                dataGridViewGetCartProductWithFilter.DataSource = bindingSource;
                dataGridViewGetCartProductWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetCartProductWithFilter.Rows.Count > 0) { 
                    dataGridViewGetCartProductWithFilter.CurrentCell = 
                        dataGridViewGetCartProductWithFilter.Rows[position].Cells[1];
                    dataGridViewGetCartProductWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetCartProductWithFilter() {
            dataGridViewGetCartProductWithFilter.Columns.Clear();
            dataGridViewGetCartProductWithFilter.AutoGenerateColumns = false;
            dataGridViewGetCartProductWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewGetCartProductWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewGetCartProductWithFilter.Columns.Add("Amount","Amount");
            dataGridViewGetCartProductWithFilter.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewGetCartProductWithFilter.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewGetCartProductWithFilter.Columns.Add("StateRcd","State");
            dataGridViewGetCartProductWithFilter.Columns.Add("UserId","User Id");
            dataGridViewGetCartProductWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetCartProductWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewGetCartProductWithFilter.Columns.Add("CartProductId","Cart Product Id");
            dataGridViewGetCartProductWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewGetCartProductWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetCartProductWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetCartProductWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetCartProductWithFilter.AutoResizeColumns();
        }
    }
}
