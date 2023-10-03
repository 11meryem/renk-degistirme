namespace button._17
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trRed = new System.Windows.Forms.TrackBar();
            this.trGreen = new System.Windows.Forms.TrackBar();
            this.trBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trRed
            // 
            this.trRed.Location = new System.Drawing.Point(67, 42);
            this.trRed.Maximum = 255;
            this.trRed.Name = "trRed";
            this.trRed.Size = new System.Drawing.Size(201, 45);
            this.trRed.TabIndex = 0;
            this.trRed.Scroll += new System.EventHandler(this.trRed_Scroll);
            // 
            // trGreen
            // 
            this.trGreen.Location = new System.Drawing.Point(67, 93);
            this.trGreen.Maximum = 255;
            this.trGreen.Name = "trGreen";
            this.trGreen.Size = new System.Drawing.Size(201, 45);
            this.trGreen.TabIndex = 1;
            this.trGreen.Scroll += new System.EventHandler(this.trGreen_Scroll);
            // 
            // trBlue
            // 
            this.trBlue.Location = new System.Drawing.Point(67, 144);
            this.trBlue.Maximum = 255;
            this.trBlue.Name = "trBlue";
            this.trBlue.Size = new System.Drawing.Size(201, 45);
            this.trBlue.TabIndex = 2;
            this.trBlue.Scroll += new System.EventHandler(this.trBlue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RED\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BLUE\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trBlue);
            this.Controls.Add(this.trGreen);
            this.Controls.Add(this.trRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trRed;
        private System.Windows.Forms.TrackBar trGreen;
        private System.Windows.Forms.TrackBar trBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

