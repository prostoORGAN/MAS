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
            this.trackBarClasses = new System.Windows.Forms.TrackBar();
            this.trackBarImages = new System.Windows.Forms.TrackBar();
            this.labelClasses = new System.Windows.Forms.Label();
            this.labelImages = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblElapse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImages)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarClasses
            // 
            this.trackBarClasses.Location = new System.Drawing.Point(724, 12);
            this.trackBarClasses.Maximum = 20;
            this.trackBarClasses.Minimum = 2;
            this.trackBarClasses.Name = "trackBarClasses";
            this.trackBarClasses.Size = new System.Drawing.Size(293, 45);
            this.trackBarClasses.TabIndex = 0;
            this.trackBarClasses.Value = 2;
            this.trackBarClasses.Scroll += new System.EventHandler(this.trackBarClasses_Scroll);
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
            // labelClasses
            // 
            this.labelClasses.AutoSize = true;
            this.labelClasses.Location = new System.Drawing.Point(1023, 24);
            this.labelClasses.Name = "labelClasses";
            this.labelClasses.Size = new System.Drawing.Size(13, 13);
            this.labelClasses.TabIndex = 2;
            this.labelClasses.Text = "2";
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
            this.panel.Size = new System.Drawing.Size(700, 700);
            this.panel.TabIndex = 4;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(1049, 19);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblElapse
            // 
            this.lblElapse.AutoSize = true;
            this.lblElapse.Location = new System.Drawing.Point(732, 74);
            this.lblElapse.Name = "lblElapse";
            this.lblElapse.Size = new System.Drawing.Size(60, 13);
            this.lblElapse.TabIndex = 6;
            this.lblElapse.Text = "elapse time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 768);
            this.Controls.Add(this.lblElapse);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelImages);
            this.Controls.Add(this.labelClasses);
            this.Controls.Add(this.trackBarImages);
            this.Controls.Add(this.trackBarClasses);
            this.Name = "Form1";
            this.Text = "MAS.Lab_1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarClasses;
        private System.Windows.Forms.TrackBar trackBarImages;
        private System.Windows.Forms.Label labelClasses;
        private System.Windows.Forms.Label labelImages;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblElapse;
    }
}

