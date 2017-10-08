namespace CustomCrosshair
{
    partial class FrmCrossHair
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
            this.PicCrosshair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicCrosshair)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCrosshair
            // 
            this.PicCrosshair.BackColor = System.Drawing.Color.Transparent;
            this.PicCrosshair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicCrosshair.Image = global::CustomCrosshair.Properties.Resources.CustomCrosshair;
            this.PicCrosshair.Location = new System.Drawing.Point(0, 0);
            this.PicCrosshair.Margin = new System.Windows.Forms.Padding(0);
            this.PicCrosshair.Name = "PicCrosshair";
            this.PicCrosshair.Size = new System.Drawing.Size(100, 100);
            this.PicCrosshair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCrosshair.TabIndex = 0;
            this.PicCrosshair.TabStop = false;
            // 
            // FrmCrossHair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.Controls.Add(this.PicCrosshair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrossHair";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmCrossHair";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PicCrosshair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicCrosshair;
    }
}