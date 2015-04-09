namespace norpim.UserInterface {
    partial class Engine {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGather = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGather
            // 
            this.buttonGather.Location = new System.Drawing.Point(202, 12);
            this.buttonGather.Name = "buttonGather";
            this.buttonGather.Size = new System.Drawing.Size(75, 23);
            this.buttonGather.TabIndex = 0;
            this.buttonGather.Text = "&Gather";
            this.buttonGather.UseVisualStyleBackColor = true;
            this.buttonGather.Click += new System.EventHandler(this.buttonGather_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(202, 41);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "&Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Engine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 73);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonGather);
            this.Name = "Engine";
            this.Text = "Engine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGather;
        private System.Windows.Forms.Button buttonTest;
    }
}