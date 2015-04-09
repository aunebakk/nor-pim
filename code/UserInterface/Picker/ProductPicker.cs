using System;
using System.ComponentModel;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductPicker : UserControl {
        
        private System.Guid _productId;
        
        public ProductPicker() {
           InitializeComponent();
        }
        
        public System.Guid SelectedValue {
            get {
                return _productId;
            }
            set {
                if (!DesignMode) {
                    _productId = value;
                    var product = new CrudeProductService();
                    try {
                        CrudeProductContract contract = product.FetchByProductId(_productId);
                        if (contract != null) {
                            txtProductName.Text = contract.ProductName;
                            txtProductCode.Text = contract.ProductName;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        if (product != null) product.Close();
                    }
                };
            }
        }
        
        private void txtProductCode_Validating(object sender, CancelEventArgs e) {
            if (!DesignMode) {
                // empty picker on no code
                if (txtProductCode.Text == String.Empty) {
                    _productId = Guid.Empty;
                    txtProductName.Text = string.Empty;
                    txtProductCode.Text = string.Empty;
                    return;
                }

                CrudeProductService product = null;

                try {
                    product = new CrudeProductService();
                    CrudeProductContract contract = product.FetchByProductName(txtProductCode.Text);

                    if (contract != null) {
                        txtProductCode.Text = contract.ProductName;
                        txtProductName.Text = contract.ProductName;
                        _productId = contract.ProductId;
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (product != null) product.Close();
                }
            }
        }
    }
}
