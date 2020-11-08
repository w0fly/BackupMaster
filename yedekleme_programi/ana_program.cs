using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace yedekleme_programi
{
    public partial class ana_program : Form
    {
        public ana_program()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
        string kaynak;
        string hedef;
        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                kaynak = fbd.SelectedPath;
                MessageBox.Show("Kopyalanacak Olan Dizin : "+fbd.SelectedPath);
                textBox1.Text = kaynak;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                hedef = fbd.SelectedPath;
                MessageBox.Show("Yedekleme Dizini : " + fbd.SelectedPath);
                textBox2.Text = hedef;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Dosyalarınız kopyalanıyor. Lütfen bekleyin.";

            string yol1, yol2;
            yol1 = textBox1.Text;
            yol2 = textBox2.Text;

            if (yol1 != "" & yol2 != "")
            {
                ana_program.CopyDirectory(@yol1, @yol2);
                MessageBox.Show("Dosyalarınız " + yol2 + " adresine kopyalanmıştır.");
                label3.Text = "";
            }
            else if (yol1 =="" || yol2 =="")
            {

                MessageBox.Show("Lütfen adres satırlarını kontrol edin!");


            }
           

            
        }

        public static void CopyDirectory(string SourceFolderPath, string TargetFolderPath)
        {
            String[] files;

            if (TargetFolderPath[TargetFolderPath.Length - 1] != Path.DirectorySeparatorChar)
            {
                TargetFolderPath += Path.DirectorySeparatorChar;
            }

            // parametre olarak verilen hedef dizin yok ise oluştur.
            if (!Directory.Exists(TargetFolderPath))
            {
                Directory.CreateDirectory(TargetFolderPath);
            }

            // kaynak dizindeki tüm alt dizin ve dosya adlarını al.
            files = Directory.GetFileSystemEntries(SourceFolderPath);

            foreach (string file in files)
            {
                // alt dizinler
                if (Directory.Exists(file))
                {
                    // metot öz yineleme (recursive) kullanarak kaynak dizinde dosya bulunduğu
                    // müddetçe dizindeki tüm dosyalar hedef dizine kopyalanmaya devam ediyor.
                    CopyDirectory(file, TargetFolderPath + Path.GetFileName(file));
                }

                // dizindeki dosyalar
                else
                {
                    File.Copy(file, TargetFolderPath + Path.GetFileName(file), true);

                }
                {

                }
            }
        }

       

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ana_program_Load(object sender, EventArgs e)
        {
            ıconPictureBox3.Visible = false;
            MessageBox.Show("Bu uygulamayı 2020 Izmir depreminde kaybettiğim ZerOFoX dostum (Muhammet) ile beraber yazmıştık. Kendisi depremde hayatını kaybettiği için artık tek başıma geliştirme kararı aldım. Yazılımı kullanır ve develop ederken lütfen arkadaşımın ruhuna bir Fatiha hediye edin. Desteklerinizden ötürü ve projeye katkı sağladığınızdan dolayı teşekkür ederim.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Burayı kaldırma kararı aldım. İşini bilen insanlar kaynak kodlarından hakkimda.cs formunu açıp okuyabilirler.");

        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:work@emrecantemur.net.tr");

        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:work@emrecantemur.net.tr");

        }

        private void ıconPictureBox2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            ıconPictureBox1.BackColor = Color.Gray;
            ıconPictureBox2.BackColor = Color.Gray;
            ıconPictureBox3.BackColor = Color.Gray;
            ıconPictureBox3.Visible = true;
            ıconPictureBox2.Visible = false;
            ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Sun;



        }

        private void ıconPictureBox3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
            ıconPictureBox1.BackColor = Color.DodgerBlue;
            ıconPictureBox2.BackColor = Color.DodgerBlue;
            ıconPictureBox3.Visible = false;
            ıconPictureBox2.Visible = true;
            ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Moon;
        }
    }
}
