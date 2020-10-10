using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yedekleme_programi
{
    public partial class hakkimda : Form
    {
        public hakkimda()
        {
            InitializeComponent();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void hakkimda_Load(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Blue;

        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/emrecantemurofficial");

        }

        private void ıconPictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/emrebey.phtml");

        }

        private void ıconPictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/905319920584");

        }

        private void ıconPictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/w0fly");

        }

        private void ıconPictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/emrecantemurofficial");

        }

        private void ıconPictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/emrebey.phtml");

        }

        private void ıconPictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/905319920584");

        }

        private void ıconPictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emrecantemur.com.tr");

        }
    }
}
