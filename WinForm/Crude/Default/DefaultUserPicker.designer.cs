namespace SolutionNorSolutionPim.UserInterface
{


    public partial class DefaultUserPicker
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDefaultUserCode;

        private System.Windows.Forms.Label lblColon;

        private System.Windows.Forms.TextBox txtDefaultUserName;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        private void InitializeComponent() {
            this.txtDefaultUserCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtDefaultUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtDefaultUserCode
            //
            this.txtDefaultUserCode.Location = new System.Drawing.Point(0, 1);
            this.txtDefaultUserCode.Name = "txtDefaultUserCode";
            this.txtDefaultUserCode.Size = new System.Drawing.Size(100, 20);
            this.txtDefaultUserCode.TabIndex = 1;
            this.txtDefaultUserCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtDefaultUserCode_Validating);
            //
            // lblColon
            //
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(101, 2);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(10, 13);
            this.lblColon.TabIndex = 2;
            this.lblColon.Text = ":";
            //
            // txtDefaultUserName
            //
            this.txtDefaultUserName.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtDefaultUserName.Location = new System.Drawing.Point(111, 1);
            this.txtDefaultUserName.Name = "txtDefaultUserName";
            this.txtDefaultUserName.Size = new System.Drawing.Size(199, 20);
            this.txtDefaultUserName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDefaultUserName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtDefaultUserCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
