using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCrosshair
{
    public partial class FrmCrossHair : Form
    {
        public FrmCrossHair()
        {
            InitializeComponent();
            this.BackColor = Color.WhiteSmoke;
            this.TransparencyKey = Color.WhiteSmoke;
        }
    }
}
