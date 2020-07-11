using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetFinancialOrderDurian : UserControl {
        
        public GetFinancialOrderDurian() {
           InitializeComponent();
           InitializeGridGetFinancialOrder();
        }
        
        public virtual string FirstName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["FirstName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string MiddleName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["MiddleName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string LastName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["LastName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientNationalityRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["ClientNationalityRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientGenderRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["ClientGenderRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientTitleRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["ClientTitleRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["ClientTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ClientId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetFinancialOrder.CurrentRow.Cells["ClientId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["FinancialCurrencyTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyAgainstFinancialCurrencyTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["FinancialCurrencyAgainstFinancialCurrencyTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["FinancialCurrencyTypeCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetFinancialOrder.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ImageBlobFilename {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["ImageBlobFilename"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Comment {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["Comment"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialOrderComment {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["FinancialOrderComment"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetFinancialOrder.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFinancialOrder.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetFinancialOrder.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid FinancialOrderId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetFinancialOrder.CurrentRow.Cells["FinancialOrderId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetFinancialOrder.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetFinancialOrder_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetFinancialOrder(System.Guid clientId, System.Guid financialCurrencyId, System.Guid locationAddressId, string financialOrderSourceRcd, System.Guid userId, System.Guid financialOrderId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetFinancialOrder.CurrentRow != null)
                    position = dataGridViewGetFinancialOrder.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialOrderSearchService().GetFinancialOrder(clientId,financialCurrencyId,locationAddressId,financialOrderSourceRcd,userId,financialOrderId);
                dataGridViewGetFinancialOrder.AutoGenerateColumns = true;
                dataGridViewGetFinancialOrder.DataSource = bindingSource;
                dataGridViewGetFinancialOrder.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetFinancialOrder.Rows.Count > 0) { 
                    dataGridViewGetFinancialOrder.CurrentCell = 
                        dataGridViewGetFinancialOrder.Rows[position].Cells[1];
                    dataGridViewGetFinancialOrder.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetFinancialOrder() {
            dataGridViewGetFinancialOrder.Columns.Clear();
            dataGridViewGetFinancialOrder.AutoGenerateColumns = false;
            dataGridViewGetFinancialOrder.Columns.Add("FirstName","First Name");
            dataGridViewGetFinancialOrder.Columns.Add("MiddleName","Middle Name");
            dataGridViewGetFinancialOrder.Columns.Add("LastName","Last Name");
            dataGridViewGetFinancialOrder.Columns.Add("ClientNationalityRcd","Client Nationality");
            dataGridViewGetFinancialOrder.Columns.Add("ClientGenderRcd","Client Gender");
            dataGridViewGetFinancialOrder.Columns.Add("ClientTitleRcd","Client Title");
            dataGridViewGetFinancialOrder.Columns.Add("ClientTypeRcd","Client Type");
            dataGridViewGetFinancialOrder.Columns.Add("ClientId","Client Id");
            dataGridViewGetFinancialOrder.Columns.Add("FinancialCurrencyTypeRcd","Financial Currency Type");
            dataGridViewGetFinancialOrder.Columns.Add("FinancialCurrencyAgainstFinancialCurrencyTypeRcd","Financial Currency Against Financial Currency Type");
            dataGridViewGetFinancialOrder.Columns.Add("FinancialCurrencyTypeCode","Financial Currency Type Code");
            dataGridViewGetFinancialOrder.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewGetFinancialOrder.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewGetFinancialOrder.Columns.Add("ImageBlobFilename","Image Blob Filename");
            dataGridViewGetFinancialOrder.Columns.Add("Comment","Comment");
            dataGridViewGetFinancialOrder.Columns.Add("FinancialOrderComment","Financial Order Comment");
            dataGridViewGetFinancialOrder.Columns.Add("UserId","User Id");
            dataGridViewGetFinancialOrder.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetFinancialOrder.Columns.Add("DateTime","Date Time");
            dataGridViewGetFinancialOrder.Columns.Add("FinancialOrderId","Financial Order Id");
            dataGridViewGetFinancialOrder.Columns.Add("ExtensionData", "");
            dataGridViewGetFinancialOrder.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetFinancialOrder.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetFinancialOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetFinancialOrder.AutoResizeColumns();
        }
    }
}
