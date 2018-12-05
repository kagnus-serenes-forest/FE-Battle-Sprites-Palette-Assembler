using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyHelpers
{
    public static class MsgBoxHelper
    {
        public static void Error(String Err)
        {
            MessageBox.Show(Err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warning(String Err)
        {
            MessageBox.Show(Err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Info(String Info)
        {
            MessageBox.Show(Info, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool AskYesNoQuestion(String Question)
        {
            return MessageBox.Show(Question, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes;
        }
    }
}
