using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BSPaletteAssembler
{
    public partial class RepointingForm : Form
    {
        private Nintenlord.ROMHacking.GBA.GBAROM mROM;
        private int mPointerOffset;
        private byte[] mPalette;

        public RepointingForm(Nintenlord.ROMHacking.GBA.GBAROM FEROM, int pointerOffset, byte[] palette)
        {
            InitializeComponent();
            mROM = FEROM;
            mPointerOffset = pointerOffset;
            Offset.Maximum = Align4(mROM.Length);
            Offset.Value = Align4(mROM.Length);
            mPalette = palette;
        }

        private void repointButton_Click(object sender, EventArgs e)
        {
            int newOffset = Align4(Offset.Value);
            mROM.InsertData(mPointerOffset, newOffset | 0x08000000);
            mROM.InsertData(newOffset, mPalette);
            this.Close();
        }

        private decimal Align4(int i)
        {
            return (decimal)_Align4(i);
        }

        private int Align4(decimal d)
        {
            return _Align4((int)d);
        }

        private int _Align4(int i)
        {
            int ret = i;
            if ((ret & 3) != 0)
            {
                ret = (ret & ~3) + 4;
            }
            return ret;
        }
    }
}
