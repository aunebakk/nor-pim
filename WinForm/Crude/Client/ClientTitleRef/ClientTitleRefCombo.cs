/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 3:40:19 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateComboStyle1
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this ComboBox UserControl class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class ClientTitleRefCombo : UserControl {
        
        // Constructs the control with an empty ComboBox
        public ClientTitleRefCombo() {
           InitializeComponent();
        }
        
        // get or sets the current combobox row
        public override string Text {
            get {
                System.String selectedValue = String.Empty;
                try { 
                    selectedValue = cboRef.SelectedValue.ToString();
                } catch {}
                return selectedValue;
            }
            set {
                PopulateCombo();
                cboRef.SelectedValue = value;;
            }
        }
        
        // event for when a new item is selected in the ComboBox
        public event EventHandler Picked;
        
        // populates the ComboBox with all rows from the SOAP service
        private void cboRef_Click(object sender, EventArgs e) {
            PopulateCombo();
        }
        
        // trigger Picked event when selected row in the ComboBox changes
        private void cboRef_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboRef.SelectedValue != null && this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        // fetch all rows from the SOAP layer and populate the ComboBox with it
        public void PopulateCombo() {
            if (!DesignMode && cboRef.DataSource == null) {
                CrudeClientTitleRefServiceClient clientTitleRef = null;

                try {
                    clientTitleRef = new CrudeClientTitleRefServiceClient();
                    List<CrudeClientTitleRefContract> contracts = clientTitleRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ClientTitleName";
                    cboRef.ValueMember = "ClientTitleRcd";
                } catch (Exception ex) {
                    // MessageBox.Show(ex.Message);
                } finally {
                    if (clientTitleRef != null) clientTitleRef.Close();
                }
            }
        }
    }
}
