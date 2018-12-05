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
    public partial class BSPaletteVisualizer : UserControl
    {
        public bool ColorsLoaded { get; set; }
        public ControlCollection Colors { get { return ColorContainer.Controls; } }

        public BSPaletteVisualizer()
        {
            InitializeComponent();
        }

        public void LoadColors(Color[] colors)
        {
            int i = 0;
            foreach (BSColorVisualizer item in ColorContainer.Controls)
            {
                item.Current = colors[i++];
            }
            ColorsLoaded = true;
        }

        public void UnloadColors()
        {
            if (ColorsLoaded == true)
            {
                foreach (BSColorVisualizer item in ColorContainer.Controls)
                {
                    item.Unload();
                }
            }
            ColorsLoaded = false;
        }
    }
}
