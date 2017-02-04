namespace MAS.Lab_2
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
            this.trackBarImages = new System.Windows.Forms.TrackBar();
            this.labelImages = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImages)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarImages
            // 
            this.trackBarImages.Location = new System.Drawing.Point(12, 12);
            this.trackBarImages.Maximum = 100000;
            this.trackBarImages.Minimum = 1000;
            this.trackBarImages.Name = "trackBarImages";
            this.trackBarImages.Size = new System.Drawing.Size(631, 45);
            this.trackBarImages.TabIndex = 1;
            this.trackBarImages.Value = 1000;
            this.trackBarImages.Scroll += new System.EventHandler(this.trackBarImages_Scroll);
            // 
            // labelImages
            // 
            this.labelImages.AutoSize = true;
            this.labelImages.Location = new System.Drawing.Point(649, 24);
            this.labelImages.Name = "labelImages";
            this.labelImages.Size = new System.Drawing.Size(31, 13);
            this.labelImages.TabIndex = 3;
            this.labelImages.Text = "1000";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.Location = new System.Drawing.Point(12, 63);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1460, 730);
            this.panel.TabIndex = 4;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(702, 19);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 805);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelImages);
            this.Controls.Add(this.trackBarImages);
            this.Name = "Form1";
            this.Text = "MAS.Lab_2";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarImages;
        private System.Windows.Forms.Label labelImages;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnGo;
    }
}

