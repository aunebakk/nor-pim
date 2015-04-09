using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductGatherAttributeTypeRefCombo : UserControl {
        
        public ProductGatherAttributeTypeRefCombo() {
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
                CrudeProductGatherAttributeTypeRefService productGatherAttributeTypeRef = null;

                try {
                    productGatherAttributeTypeRef = new CrudeProductGatherAttributeTypeRefService();
                    CrudeProductGatherAttributeTypeRefContract[] contracts = productGatherAttributeTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ProductGatherAttributeTypeName";
                    cboRef.ValueMember = "ProductGatherAttributeTypeRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (productGatherAttributeTypeRef != null) productGatherAttributeTypeRef.Close();
                }
            }
        }
    }
}
