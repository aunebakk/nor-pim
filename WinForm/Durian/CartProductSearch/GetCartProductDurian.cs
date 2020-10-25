using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetCartProductDurian : UserControl {
        
        public GetCartProductDurian() {
           InitializeComponent();
           InitializeGridGetCartProduct();
        }
        
        public virtual string FirstName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["FirstName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string MiddleName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["MiddleName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string LastName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["LastName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientNationalityRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["ClientNationalityRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientGenderRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["ClientGenderRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientTitleRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["ClientTitleRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["ClientTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ClientId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProduct.CurrentRow.Cells["ClientId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductStateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["ProductStateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProduct.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["FinancialCurrencyTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyAgainstFinancialCurrencyTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["FinancialCurrencyAgainstFinancialCurrencyTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["FinancialCurrencyTypeCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProduct.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual decimal Amount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetCartProduct.CurrentRow.Cells["Amount"].Value; else return 0;;
            }
        }
        
        public virtual string CartProductStateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["CartProductStateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ImageBlobFilename {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["ImageBlobFilename"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProduct.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetCartProduct.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid CartProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCartProduct.CurrentRow.Cells["CartProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string SessionIdentificator {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCartProduct.CurrentRow.Cells["SessionIdentificator"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetCartProduct.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetCartProduct_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetCartProduct(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId, System.Guid cartProductId, string sessionIdentificator) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetCartProduct.CurrentRow != null)
                    position = dataGridViewGetCartProduct.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new CartProductSearchService().GetCartProduct(clientId,productId,financialCurrencyId,userId,cartProductId,sessionIdentificator);
                dataGridViewGetCartProduct.AutoGenerateColumns = true;
                dataGridViewGetCartProduct.DataSource = bindingSource;
                dataGridViewGetCartProduct.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetCartProduct.Rows.Count > 0) { 
                    dataGridViewGetCartProduct.CurrentCell = 
                        dataGridViewGetCartProduct.Rows[position].Cells[1];
                    dataGridViewGetCartProduct.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetCartProduct() {
            dataGridViewGetCartProduct.Columns.Clear();
            dataGridViewGetCartProduct.AutoGenerateColumns = false;
            dataGridViewGetCartProduct.Columns.Add("FirstName","First Name");
            dataGridViewGetCartProduct.Columns.Add("MiddleName","Middle Name");
            dataGridViewGetCartProduct.Columns.Add("LastName","Last Name");
            dataGridViewGetCartProduct.Columns.Add("ClientNationalityRcd","Client Nationality");
            dataGridViewGetCartProduct.Columns.Add("ClientGenderRcd","Client Gender");
            dataGridViewGetCartProduct.Columns.Add("ClientTitleRcd","Client Title");
            dataGridViewGetCartProduct.Columns.Add("ClientTypeRcd","Client Type");
            dataGridViewGetCartProduct.Columns.Add("ClientId","Client Id");
            dataGridViewGetCartProduct.Columns.Add("ProductName","Product Name");
            dataGridViewGetCartProduct.Columns.Add("ProductStateRcd","Product State");
            dataGridViewGetCartProduct.Columns.Add("ProductId","Product Id");
            dataGridViewGetCartProduct.Columns.Add("FinancialCurrencyTypeRcd","Financial Currency Type");
            dataGridViewGetCartProduct.Columns.Add("FinancialCurrencyAgainstFinancialCurrencyTypeRcd","Financial Currency Against Financial Currency Type");
            dataGridViewGetCartProduct.Columns.Add("FinancialCurrencyTypeCode","Financial Currency Type Code");
            dataGridViewGetCartProduct.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewGetCartProduct.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewGetCartProduct.Columns.Add("Amount","Amount");
            dataGridViewGetCartProduct.Columns.Add("CartProductStateRcd","Cart Product State");
            dataGridViewGetCartProduct.Columns.Add("ImageBlobFilename","Image Blob Filename");
            dataGridViewGetCartProduct.Columns.Add("UserId","User Id");
            dataGridViewGetCartProduct.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetCartProduct.Columns.Add("DateTime","Date Time");
            dataGridViewGetCartProduct.Columns.Add("CartProductId","Cart Product Id");
            dataGridViewGetCartProduct.Columns.Add("SessionIdentificator","Session Identificator");
            dataGridViewGetCartProduct.Columns.Add("ExtensionData", "");
            dataGridViewGetCartProduct.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetCartProduct.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetCartProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetCartProduct.AutoResizeColumns();
        }
    }
}
