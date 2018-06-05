using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WARRIOR_FROG
{
    public partial class Giris : Form
    {
        int sayi = 0;
        public Giris()
        {
            InitializeComponent();
        }

        private void animasyon_Tick(object sender, EventArgs e)
        {
            
            sayi++;
            label1.Text = sayi.ToString();
            int xd =pictureBox1.Location.X;
            xd++;
            pictureBox1.Left = xd;
            if (sayi==650)
            {
                Level1 level1=new Level1();
                level1.Show();
                animasyon.Stop();
                this.Hide();
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            animasyon.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
