using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductAttributeUnitRefCombo : UserControl {
        
        public ProductAttributeUnitRefCombo() {
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
                CrudeProductAttributeUnitRefService productAttributeUnitRef = null;

                try {
                    productAttributeUnitRef = new CrudeProductAttributeUnitRefService();
                    CrudeProductAttributeUnitRefContract[] contracts = productAttributeUnitRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ProductAttributeUnitName";
                    cboRef.ValueMember = "ProductAttributeUnitRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (productAttributeUnitRef != null) productAttributeUnitRef.Close();
                }
            }
        }
    }
}
