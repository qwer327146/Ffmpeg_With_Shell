using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ffmpeg_With_Shell
{
    public partial class FrameRate : Form
    {
        public FrameRate()
        {
            InitializeComponent();
            textBox_FrameRate.Text = Main.CustomFrameRate.ToString();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            float.TryParse(textBox_FrameRate.Text, out float frameRate);
            if (frameRate > 0)
            {
                Main.CustomFrameRate = frameRate;
                Close();
            }
            else
            {
                MessageBox.Show("请填入有效数字！");
            }
        }

        private void textBox_FrameRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
