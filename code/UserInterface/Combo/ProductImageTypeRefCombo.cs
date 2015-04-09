using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductImageTypeRefCombo : UserControl {
        
        public ProductImageTypeRefCombo() {
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
                CrudeProductImageTypeRefService productImageTypeRef = null;

                try {
                    productImageTypeRef = new CrudeProductImageTypeRefService();
                    CrudeProductImageTypeRefContract[] contracts = productImageTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ProductImageTypeName";
                    cboRef.ValueMember = "ProductImageTypeRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (productImageTypeRef != null) productImageTypeRef.Close();
                }
            }
        }
    }
}
