using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductIdentifierRefCombo : UserControl {
        
        public ProductIdentifierRefCombo() {
           InitializeComponent();
        }
        
        public override String Text {
            get {
                if (cboRef.SelectedValue != null)
                    return cboRef.SelectedValue.ToString();
                else
                    return string.Empty;
            }
            set {
                PopulateCombo();
                cboRef.SelectedValue = value;;
            }
        }
        
        private void cboRef_Click(object sender, EventArgs e) {
            PopulateCombo();
        }
        
        private void PopulateCombo() {
            if (!DesignMode && cboRef.DataSource == null) {
                CrudeProductIdentifierRefService productIdentifierRef = null;

                try {
                    productIdentifierRef = new CrudeProductIdentifierRefService();
                    CrudeProductIdentifierRefContract[] contracts = productIdentifierRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ProductIdentifierName";
                    cboRef.ValueMember = "ProductIdentifierRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (productIdentifierRef != null) productIdentifierRef.Close();
                }
            }
        }
    }
}
