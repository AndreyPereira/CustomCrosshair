using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomCrosshair.Properties;

namespace CustomCrosshair
{
    public partial class FrmMain : Form
    {
        FrmCrossHair F = new FrmCrossHair();
        private int x = 0;
        private int y = 0;

        private int ImageDefaultWidth = -1;
        private int ImageDefaultHeight = -1;

        public FrmMain()
        {
            InitializeComponent();
            this.Icon = Resources.if_target_42367;
        }

        private void BtnTirar_Click(object sender, EventArgs e)
        {
            F.Hide();
            Reallocate();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Reallocate();
            F.Show();
            
        }

        private void Reallocate()
        {
            F.Parent = null;
            F.StartPosition = FormStartPosition.Manual;

            int StartX = (Screen.PrimaryScreen.Bounds.Width / 2) - 50;
            int StartY = (Screen.PrimaryScreen.Bounds.Height / 2) - 50;
            StartX = StartX + x;
            StartY = StartY + y;

            F.Location = new Point(StartX, StartY);

            if (TxtFilePNG.Text != "")
            {
                ((PictureBox)F.Controls["PicCrosshair"]).ImageLocation = TxtFilePNG.Text;
                ((PictureBox)F.Controls["PicCrosshair"]).Refresh();

                PicCrosshair.Image = new Bitmap(TxtFilePNG.Text);
                PicCrosshair.ImageLocation = TxtFilePNG.Text;
                PicCrosshair.Load();
                PicCrosshair.Refresh();
                
            }

            if (ImageDefaultHeight == -1)
            {
                ImageDefaultWidth = PicCrosshair.Size.Width;
                ImageDefaultHeight = PicCrosshair.Size.Height;
            }

            F.Opacity = TrkOpacity.Value;
            ((PictureBox)F.Controls["PicCrosshair"]).Size = new Size(Convert.ToInt32(ImageDefaultWidth * ((TrkSize.Value) / 100d)), Convert.ToInt32(ImageDefaultHeight * (TrkSize.Value) / 100d));


            PicCrosshair.Size = new Size(Convert.ToInt32(ImageDefaultWidth * ((TrkSize.Value) / 100d)), Convert.ToInt32(ImageDefaultHeight * (TrkSize.Value) / 100d));

        }

        private void NmrX_ValueChanged(object sender, EventArgs e)
        {
            x = Convert.ToInt32(NmrX.Value);
            Reallocate();
        }

        private void NmrY_ValueChanged(object sender, EventArgs e)
        {
            y = Convert.ToInt32(NmrY.Value);
            Reallocate();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter = "PNG Files (.png)|*.png|GIF Files (*.gif)|*.gif";
            FD.FilterIndex = 1;
            FD.Multiselect = false;
            if (FD.ShowDialog() == DialogResult.OK)
            {
                TxtFilePNG.Text = FD.FileName;
            }
            ImageDefaultHeight = -1;
            Reallocate();
        }

        private void TrkOpacity_Scroll(object sender, EventArgs e)
        {
            F.Opacity = Convert.ToDouble(TrkOpacity.Value) / 100;
        }

        private void TrkSize_Scroll(object sender, EventArgs e)
        {
            ((PictureBox)F.Controls["PicCrosshair"]).Size = new Size(Convert.ToInt32(ImageDefaultWidth * ((TrkSize.Value) / 100d)), Convert.ToInt32(ImageDefaultHeight * (TrkSize.Value) / 100d));
            PicCrosshair.Size = new Size( Convert.ToInt32(ImageDefaultWidth * ((TrkSize.Value) / 100d)), Convert.ToInt32(ImageDefaultHeight * (TrkSize.Value) / 100d));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TrkOpacity.Value = Convert.ToInt32(Settings.Default.Opacity);
            TrkSize.Value = Convert.ToInt32(Settings.Default.Size);
            TxtFilePNG.Text = Settings.Default.PNGFile;
            NmrX.Value = Convert.ToInt32(Settings.Default.OffsetX);
            NmrY.Value = Convert.ToInt32(Settings.Default.OffsetY);

            Reallocate();

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Opacity = TrkOpacity.Value.ToString();
            Settings.Default.PNGFile = TxtFilePNG.Text;
            Settings.Default.Size = TrkSize.Value.ToString();
            Settings.Default.OffsetX = NmrX.Value.ToString();
            Settings.Default.OffsetY = NmrY.Value.ToString();

            Settings.Default.Save();
        }
    }
}
