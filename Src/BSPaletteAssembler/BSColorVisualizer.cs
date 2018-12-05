using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BSPaletteAssembler
{
    public partial class BSColorVisualizer : UserControl
    {
        private Color mCurrent;
        public Color Current
        {
            get { return mCurrent; }
            set
            {
                if (value != mCurrent)
                {
                    mCurrent = value;
                    ColorViewer.BackColor = value;
                    RedLabel.Text = (value.R >> 3).ToString("D2");
                    GreenLabel.Text = (value.G >> 3).ToString("D2");
                    BlueLabel.Text = (value.B >> 3).ToString("D2");
                }
            }
        }

        public BSColorVisualizer()
        {
            InitializeComponent();
        }


        public void Unload()
        {
            this.Current = Color.FromArgb(248, 248, 248);
            RedLabel.Text = "??";
            GreenLabel.Text = "??";
            BlueLabel.Text = "??";
        }
    }
}
