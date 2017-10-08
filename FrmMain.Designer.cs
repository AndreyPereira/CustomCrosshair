namespace CustomCrosshair
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TxtFilePNG = new System.Windows.Forms.TextBox();
            this.NmrY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTirar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NmrX = new System.Windows.Forms.NumericUpDown();
            this.TrkOpacity = new System.Windows.Forms.TrackBar();
            this.PicCrosshair = new System.Windows.Forms.PictureBox();
            this.TrkSize = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NmrY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCrosshair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkSize)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(364, 56);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(37, 26);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "...";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(12, 302);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 34);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Show";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // TxtFilePNG
            // 
            this.TxtFilePNG.Enabled = false;
            this.TxtFilePNG.Location = new System.Drawing.Point(12, 56);
            this.TxtFilePNG.Name = "TxtFilePNG";
            this.TxtFilePNG.Size = new System.Drawing.Size(346, 26);
            this.TxtFilePNG.TabIndex = 2;
            // 
            // NmrY
            // 
            this.NmrY.Location = new System.Drawing.Point(12, 379);
            this.NmrY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NmrY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.NmrY.Name = "NmrY";
            this.NmrY.Size = new System.Drawing.Size(91, 26);
            this.NmrY.TabIndex = 3;
            this.NmrY.ValueChanged += new System.EventHandler(this.NmrY_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "PNG File";
            // 
            // BtnTirar
            // 
            this.BtnTirar.Location = new System.Drawing.Point(326, 302);
            this.BtnTirar.Name = "BtnTirar";
            this.BtnTirar.Size = new System.Drawing.Size(75, 34);
            this.BtnTirar.TabIndex = 5;
            this.BtnTirar.Text = "Hide";
            this.BtnTirar.UseVisualStyleBackColor = true;
            this.BtnTirar.Click += new System.EventHandler(this.BtnTirar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y Allign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "X Allign";
            // 
            // NmrX
            // 
            this.NmrX.Location = new System.Drawing.Point(310, 379);
            this.NmrX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NmrX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.NmrX.Name = "NmrX";
            this.NmrX.Size = new System.Drawing.Size(91, 26);
            this.NmrX.TabIndex = 8;
            this.NmrX.ValueChanged += new System.EventHandler(this.NmrX_ValueChanged);
            // 
            // TrkOpacity
            // 
            this.TrkOpacity.Location = new System.Drawing.Point(12, 117);
            this.TrkOpacity.Maximum = 100;
            this.TrkOpacity.Name = "TrkOpacity";
            this.TrkOpacity.Size = new System.Drawing.Size(389, 69);
            this.TrkOpacity.TabIndex = 11;
            this.TrkOpacity.Value = 100;
            this.TrkOpacity.Scroll += new System.EventHandler(this.TrkOpacity_Scroll);
            // 
            // PicCrosshair
            // 
            this.PicCrosshair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicCrosshair.Image = global::CustomCrosshair.Properties.Resources.CustomCrosshair;
            this.PicCrosshair.Location = new System.Drawing.Point(154, 302);
            this.PicCrosshair.Margin = new System.Windows.Forms.Padding(0);
            this.PicCrosshair.Name = "PicCrosshair";
            this.PicCrosshair.Size = new System.Drawing.Size(100, 100);
            this.PicCrosshair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCrosshair.TabIndex = 10;
            this.PicCrosshair.TabStop = false;
            // 
            // TrkSize
            // 
            this.TrkSize.Location = new System.Drawing.Point(12, 211);
            this.TrkSize.Maximum = 100;
            this.TrkSize.Name = "TrkSize";
            this.TrkSize.Size = new System.Drawing.Size(389, 69);
            this.TrkSize.TabIndex = 12;
            this.TrkSize.Value = 100;
            this.TrkSize.Scroll += new System.EventHandler(this.TrkSize_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Opacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Size";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TrkSize);
            this.Controls.Add(this.TrkOpacity);
            this.Controls.Add(this.PicCrosshair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NmrX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnTirar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NmrY);
            this.Controls.Add(this.TxtFilePNG);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Custom Crosshair";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NmrY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCrosshair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtFilePNG;
        private System.Windows.Forms.NumericUpDown NmrY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTirar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NmrX;
        private System.Windows.Forms.PictureBox PicCrosshair;
        private System.Windows.Forms.TrackBar TrkOpacity;
        private System.Windows.Forms.TrackBar TrkSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

