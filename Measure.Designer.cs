namespace Law {
    partial class Measure {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.labelL = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelL
            // 
            this.labelL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelL.BackColor = System.Drawing.Color.LightGray;
            this.labelL.Location = new System.Drawing.Point(12, 9);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(101, 432);
            this.labelL.TabIndex = 0;
            this.labelL.Click += new System.EventHandler(this.Button_Click);
            // 
            // labelR
            // 
            this.labelR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelR.BackColor = System.Drawing.Color.LightCoral;
            this.labelR.Location = new System.Drawing.Point(687, 9);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(101, 432);
            this.labelR.TabIndex = 1;
            this.labelR.Click += new System.EventHandler(this.Button_Click);
            // 
            // Measure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Measure";
            this.Text = "Measure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Measure_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelL;
        private Label labelR;
    }
}