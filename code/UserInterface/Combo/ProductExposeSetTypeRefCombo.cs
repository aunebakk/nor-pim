using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductExposeSetTypeRefCombo : UserControl {
        
        public ProductExposeSetTypeRefCombo() {
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
                CrudeProductExposeSetTypeRefService productExposeSetTypeRef = null;

                try {
                    productExposeSetTypeRef = new CrudeProductExposeSetTypeRefService();
                    CrudeProductExposeSetTypeRefContract[] contracts = productExposeSetTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ProductExposeSetTypeName";
                    cboRef.ValueMember = "ProductExposeSetTypeRcd";
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (productExposeSetTypeRef != null) productExposeSetTypeRef.Close();
                }
            }
        }
    }
}
