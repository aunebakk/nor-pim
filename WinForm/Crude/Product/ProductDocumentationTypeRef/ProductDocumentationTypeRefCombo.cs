﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:09:35 PM
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
    public partial class ProductDocumentationTypeRefCombo : UserControl {
        
        // Constructs the control with an empty ComboBox
        public ProductDocumentationTypeRefCombo() {
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
                CrudeProductDocumentationTypeRefServiceClient productDocumentationTypeRef = null;

                try {
                    productDocumentationTypeRef = new CrudeProductDocumentationTypeRefServiceClient();
                    List<CrudeProductDocumentationTypeRefContract> contracts = productDocumentationTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ProductDocumentationTypeName";
                    cboRef.ValueMember = "ProductDocumentationTypeRcd";
                } catch (Exception ex) {
                    // MessageBox.Show(ex.Message);
                } finally {
                    if (productDocumentationTypeRef != null) productDocumentationTypeRef.Close();
                }
            }
        }
    }
}
