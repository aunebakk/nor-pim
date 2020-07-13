﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:13:17 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultVersionEdit : Form {
        
        private CrudeDefaultVersionContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultVersionEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultVersionContract();
                _isNew = true;
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByRules(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultVersionContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultVersionContract();
                _isNew = true;
                _contract.FunVersion = funVersion;
                textBoxFunVersion.Text = _contract.FunVersion;
                _contract.Number = number;
                textBoxNumber.Text = _contract.Number;
                _contract.MajorNumber = majorNumber;
                maskedTextBoxMajorNumber.Text = _contract.MajorNumber.ToString();
                _contract.MinorNumber = minorNumber;
                maskedTextBoxMinorNumber.Text = _contract.MinorNumber.ToString();
                _contract.SequenceNumber = sequenceNumber;
                maskedTextBoxSequenceNumber.Text = _contract.SequenceNumber.ToString();
                _contract.DefaultUserId = defaultUserId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid defaultVersionId, System.Guid defaultUserId) {
            var service = new CrudeDefaultVersionServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultVersionId(defaultVersionId);
                textBoxFunVersion.Text = _contract.FunVersion;
                textBoxNumber.Text = _contract.Number;
                maskedTextBoxMajorNumber.Text = _contract.MajorNumber.ToString();
                maskedTextBoxMinorNumber.Text = _contract.MinorNumber.ToString();
                maskedTextBoxSequenceNumber.Text = _contract.SequenceNumber.ToString();
                _contract.DefaultUserId = defaultUserId;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeDefaultVersionServiceClient();
            try {
                _contract.FunVersion = textBoxFunVersion.Text;
                _contract.Number = textBoxNumber.Text;
                _contract.MajorNumber = maskedTextBoxMajorNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMajorNumber.Text);
                _contract.MinorNumber = maskedTextBoxMinorNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxMinorNumber.Text);
                _contract.SequenceNumber = maskedTextBoxSequenceNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSequenceNumber.Text);
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }

            Close();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}