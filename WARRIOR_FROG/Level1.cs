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
    public partial class Level1 : Form
    {
        int saniye = 0;
        int sure = 0;
        
        
        bool nilufer1 = false, nilufer2 = false, nilufer3 = false, nilufer4 = false,nilufer5 = false,nilufer6 = false,nilufer7= false,nilufer8 = false;
        bool nilufer9 = false, nilufer10 = false, nilufer11 = false, nilufer12 = false, nilufer13 = false, nilufer14 = false;
        public Level1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double sayilar = 0, sayilar2 = 0, toplama = 0, cikarma = 0, carpma = 0, bolme = 0;
            int sayac = 0, kod = 0;

           
            // AŞAMA 1
            while (sayac < 3)
            {
                Random sayi_a2 = new Random();
                sayilar = sayi_a2.Next(1, 11);
                Random sayi_a2_2 = new Random();
                sayilar2 = sayi_a2_2.Next(1, 11);
                Random rastgele = new Random();
                kod = rastgele.Next(42, 48);
                char karakter = Convert.ToChar(kod);
                label4.Text = karakter.ToString();

                toplama = sayilar + sayilar2;
                carpma = sayilar * sayilar2;
                cikarma = sayilar - sayilar2;
                bolme = sayilar / sayilar2;

                if (sayilar2 != sayilar && kod != 44 && kod != 46 && cikarma > 1&&bolme>1.5)
                {

                    label2.Text = sayilar.ToString();
                    label3.Text = sayilar2.ToString();
                    sayac++;


                }



            }



            Random rnd_a1 = new Random();
            int uret = rnd_a1.Next(1, 100);

            int nilufer_a1 = uret % 2;
            
            Random rnd = new Random();
            
            if (kod == 43)
            {


                if (nilufer_a1 == 0 )
                {
                    label7.Text = toplama.ToString();
                    listBox2.Items.Add(toplama.ToString());
                }
                if (nilufer_a1 == 1)
                {
                    label1.Text = toplama.ToString();
                    listBox2.Items.Add(toplama.ToString());
                }


            }
            if (kod == 42)
            {



                if (nilufer_a1 == 0)
                {
                    label7.Text = carpma.ToString();
                    listBox2.Items.Add(carpma.ToString());
                }
                if (nilufer_a1 == 1)
                {
                    label1.Text = carpma.ToString();
                    listBox2.Items.Add(carpma.ToString());
                }


            }
            if (kod == 45)
            {


                if (nilufer_a1 == 0)
                {
                    label7.Text = cikarma.ToString();
                    listBox2.Items.Add(cikarma.ToString());
                }
                if (nilufer_a1 == 1)
                {
                    label1.Text = cikarma.ToString();
                    listBox2.Items.Add(cikarma.ToString());
                }

            }
            if (kod == 47)
            {


                if (nilufer_a1 == 0)
                {
                    label7.Text = bolme.ToString();
                    listBox2.Items.Add(bolme.ToString());
                }


                if (nilufer_a1 == 1)
                {
                    label1.Text = bolme.ToString();
                    listBox2.Items.Add(bolme.ToString());
                }

            }
            // AŞAMA 2

            double sayilar_a2 = 0, sayilar_a2_2 = 0, toplama_a2 = 0, cikarma_a2 = 0, carpma_a2 = 0, bolme_a2 = 0;
            int sayac_a2 = 1, kod_a2 = 0;

            while (sayac_a2 < 3)
            {
                Random sayi_a2 = new Random();
                sayilar_a2 = sayi_a2.Next(1, 11);
                Random sayi_a2_2 = new Random();
                sayilar_a2_2 = sayi_a2_2.Next(1, 11);
                
                if (kod == 42)
                {
                    Random rastgele_a2 = new Random();
                    kod_a2 = rastgele_a2.Next(43, 48);
                    char karakter = Convert.ToChar(kod_a2);
                    label20.Text = karakter.ToString();
                }
                else if (kod == 43)
                {
                    Random rastgele_a2 = new Random();
                    kod_a2 = rastgele_a2.Next(45, 48);
                    char karakter = Convert.ToChar(kod_a2);
                    label20.Text = karakter.ToString();
                }
                else if (kod == 45)
                {
                    Random rastgele_a2 = new Random();
                    kod_a2 = rastgele_a2.Next(47, 48);
                    char karakter = Convert.ToChar(kod_a2);
                    label20.Text = karakter.ToString();
                }
                else
                {
                    char karakter = Convert.ToChar(kod_a2);
                    label20.Text = karakter.ToString();
                }
                
                toplama_a2 = sayilar_a2 + sayilar_a2_2;
                carpma_a2 = sayilar_a2 * sayilar_a2_2;
                cikarma_a2 = sayilar_a2 - sayilar_a2_2;
                bolme_a2 = sayilar_a2 / sayilar_a2_2;

                if (sayilar_a2_2 != sayilar_a2 && kod_a2 != 44 && kod_a2 != 46 &&  cikarma_a2 > 1 && bolme_a2>1.5)
                {
                   
                    label18.Text = sayilar_a2.ToString();
                    label19.Text = sayilar_a2_2.ToString();

                    sayac_a2++;


                }



            }
            int nilufer_a2 = 0;
            if (nilufer_a1 == 0)
            {
                Random rnd_a2 = new Random();
                int uret_a2 = rnd_a2.Next(1, 100);
                int sonuc=0;
                sonuc = uret_a2 % 3;
                nilufer_a2 = sonuc;
            }
            else if (nilufer_a1 == 1)
            {
                Random rnd_a2 = new Random();
                int sonuc = rnd_a2.Next(1, 4);
                nilufer_a2 = sonuc;
            }


            if (kod_a2 == 43)
            {


                if (nilufer_a2 == 3)
                {
                    label13.Text = toplama_a2.ToString();
                    listBox2.Items.Add(toplama_a2.ToString());
                }
                if (nilufer_a2 == 0)
                {
                    label12.Text = toplama_a2.ToString();
                    listBox2.Items.Add(toplama_a2.ToString());
                }
                if (nilufer_a2 == 1)
                {
                    label11.Text = toplama_a2.ToString();
                    listBox2.Items.Add(toplama_a2.ToString());
                }
                if (nilufer_a2 == 2)
                {
                    label10.Text = toplama_a2.ToString();
                    listBox2.Items.Add(toplama_a2.ToString());
                }

            }
            if (kod_a2 == 42)
            {



                if (nilufer_a2 == 3)
                {
                    label13.Text = carpma_a2.ToString();
                    listBox2.Items.Add(carpma_a2.ToString());
                }
                if (nilufer_a2 == 0)
                {
                    label12.Text = carpma_a2.ToString();
                    listBox2.Items.Add(carpma_a2.ToString());
                }
                if (nilufer_a2 ==1)
                {
                    label11.Text = carpma_a2.ToString();
                    listBox2.Items.Add(carpma_a2.ToString());
                }
                if (nilufer_a2 == 2)
                {
                    label10.Text = carpma_a2.ToString();
                    listBox2.Items.Add(carpma_a2.ToString());
                }


            }
            if (kod_a2 == 45)
            {



                if (nilufer_a2 == 3)
                {
                    label13.Text = cikarma_a2.ToString();
                    listBox2.Items.Add(cikarma_a2.ToString());
                }
                if (nilufer_a2 == 0)
                {
                    label12.Text = cikarma_a2.ToString();
                    listBox2.Items.Add(cikarma_a2.ToString());
                }
                if (nilufer_a2 == 2)
                {
                    label10.Text = cikarma_a2.ToString();
                    listBox2.Items.Add(cikarma_a2.ToString());
                }
                if (nilufer_a2 ==1)
                {
                    label11.Text = cikarma_a2.ToString();
                    listBox2.Items.Add(cikarma_a2.ToString());
                }


            }
            if (kod_a2 == 47)
            {


                if (nilufer_a2 == 3)
                {
                    label13.Text = bolme_a2.ToString();
                    listBox2.Items.Add(bolme_a2.ToString());
                }


                if (nilufer_a2 == 0)
                {
                    label12.Text = bolme_a2.ToString();
                    listBox2.Items.Add(bolme_a2.ToString());
                }
                if (nilufer_a2 == 2)
                {
                    label10.Text = bolme_a2.ToString();
                    listBox2.Items.Add(bolme_a2.ToString());
                }
                if (nilufer_a2 ==1)
                {
                    label11.Text = bolme_a2.ToString();
                    listBox2.Items.Add(bolme_a2.ToString());
                }

            }
            // AŞAMA 3

            double sayilar_a3 = 0, sayilar_a3_2 = 0, toplama_a3 = 0, cikarma_a3 = 0, carpma_a3 = 0, bolme_a3 = 0;
            int sayac_a3 = 1, kod_a3 = 0;

            while (sayac_a3 < 3)
            {
                Random sayi_a3 = new Random();
                sayilar_a3 = sayi_a3.Next(1, 11);
                Random sayi_a3_2 = new Random();
                sayilar_a3_2 = sayi_a3_2.Next(1, 11);
                Random rastgele_a3 = new Random();
                if (kod_a2 == 45)
                {
                    kod_a3 = rastgele_a3.Next(42, 43);
                    char karakter = Convert.ToChar(kod_a3);
                    label25.Text = karakter.ToString();
                }
                else if (kod_a2 == 42)
                {
                    kod_a3 = rastgele_a3.Next(43, 46);
                    char karakter = Convert.ToChar(kod_a3);
                    label25.Text = karakter.ToString();
                }
                else if (kod_a2 == 43)
                {
                    kod_a3 = rastgele_a3.Next(45, 48);
                    char karakter = Convert.ToChar(kod_a3);
                    label25.Text = karakter.ToString();

                }
                else if (kod_a2 == 47)
                {
                    kod_a3 = rastgele_a3.Next(45, 47);
                    char karakter = Convert.ToChar(kod_a3);
                    label25.Text = karakter.ToString();
                }
                toplama_a3 = sayilar_a3 + sayilar_a3_2;
                carpma_a3 = sayilar_a3 * sayilar_a3_2;
                cikarma_a3 = sayilar_a3 - sayilar_a3_2;
                bolme_a3 = sayilar_a3 / sayilar_a3_2;

                if (sayilar_a3_2 != sayilar_a3 && kod_a3 != 44 && kod_a3 != 46 &&   cikarma_a3 > 1 && bolme_a3>1.5)
                {
                    label27.Text = sayilar_a3.ToString();
                    label26.Text = sayilar_a3_2.ToString();

                    sayac_a3++;


                }



            }
            int nilufer_a3 = 0;

            if (nilufer_a2 == 0)
            {
                Random rnd_a3 = new Random();
                int uret_a3 = rnd_a3.Next(1, 100);
                int sonuc = 0;
                sonuc = uret_a3 % 2;
                nilufer_a3 = sonuc;
            }
            else if (nilufer_a2 == 2)
            {
                Random rnd_a3 = new Random();
                int sonuc = rnd_a3.Next(1, 4);
                nilufer_a3 = sonuc;
            }
            else if (nilufer_a2 == 1)
            {
                Random rnd_a3 = new Random();
                int uret_a3_2 = rnd_a3.Next(1, 100);
                int sonuc = 0;
                sonuc = uret_a3_2 % 3;
                nilufer_a3 = sonuc;
            }
            else if (nilufer_a2 ==3)
            {
                Random rnd_a3 = new Random();
                int sonuc = rnd_a3.Next(2, 4);
                nilufer_a3 = sonuc;
            }

            if (kod_a3 == 43)
            {


                if (nilufer_a3 == 1)
                {
                    label22.Text = toplama_a3.ToString();
                    listBox2.Items.Add(toplama_a3.ToString());
                }
                if (nilufer_a3 == 2)
                {
                    label21.Text = toplama_a3.ToString();
                    listBox2.Items.Add(toplama_a3.ToString());
                }
                if (nilufer_a3 == 0)
                {
                    label23.Text = toplama_a3.ToString();
                    listBox2.Items.Add(toplama_a3.ToString());
                }
                if (nilufer_a3 == 3)
                {
                    label24.Text = toplama_a3.ToString();
                    listBox2.Items.Add(toplama_a3.ToString());
                }

            }
            if (kod_a3 == 42)
            {



                if (nilufer_a3 == 1)
                {
                    label22.Text = carpma_a3.ToString();
                    listBox2.Items.Add(carpma_a3.ToString());
                }
                if (nilufer_a3 == 2)
                {
                    label21.Text = carpma_a3.ToString();
                    listBox2.Items.Add(carpma_a3.ToString());
                }
                if (nilufer_a3 == 0)
                {
                    label23.Text = carpma_a3.ToString();
                    listBox2.Items.Add(carpma_a3.ToString());
                }
                if (nilufer_a3 == 3)
                {
                    label24.Text = carpma_a3.ToString();
                    listBox2.Items.Add(carpma_a3.ToString());
                }


            }
            if (kod_a3 == 45)
            {



                if (nilufer_a3 == 1)
                {
                    label22.Text = cikarma_a3.ToString();
                    listBox2.Items.Add(cikarma_a3.ToString());
                }
                if (nilufer_a3 == 2)
                {
                    label21.Text = cikarma_a3.ToString();
                    listBox2.Items.Add(cikarma_a3.ToString());
                }
                if (nilufer_a3 == 0)
                {
                    label23.Text = cikarma_a3.ToString();
                    listBox2.Items.Add(cikarma_a3.ToString());
                }
                if (nilufer_a3 == 3)
                {
                    label24.Text = cikarma_a3.ToString();
                    listBox2.Items.Add(cikarma_a3.ToString());
                }


            }
            if (kod_a3 == 47)
            {


                if (nilufer_a3 == 1)
                {
                    label22.Text = bolme_a3.ToString();
                    listBox2.Items.Add(bolme_a3.ToString());
                }


                if (nilufer_a3 == 2)
                {
                    label21.Text = bolme_a3.ToString();
                    listBox2.Items.Add(bolme_a3.ToString());
                }
                if (nilufer_a3 == 0)
                {
                    label23.Text = bolme_a3.ToString();
                    listBox2.Items.Add(bolme_a3.ToString());
                }
                if (nilufer_a3 == 3)
                {
                    label24.Text = bolme_a3.ToString();
                    listBox2.Items.Add(bolme_a3.ToString());
                }

            }
            // AŞAMA 4

            double sayilar_a4 = 0, sayilar_a4_2 = 0, toplama_a4 = 0, cikarma_a4 = 0, carpma_a4 = 0, bolme_a4 = 0;
            int sayac_a4 = 1, kod_a4 = 0;

            while (sayac_a4 < 3)
            {
                Random sayi_a4 = new Random();
                sayilar_a4 = sayi_a4.Next(1, 11);
                Random sayi_a4_2 = new Random();
                sayilar_a4_2 = sayi_a4_2.Next(1, 11);

                Random rastgele_a4 = new Random();
                if (kod_a3 == 42)
                {
                    kod_a4 = rastgele_a4.Next(43, 44);
                    char karakter = Convert.ToChar(kod_a4);
                    label28.Text = karakter.ToString();
                }
                else if (kod_a3 == 43)
                {
                    kod_a4 = rastgele_a4.Next(45, 48);
                    char karakter = Convert.ToChar(kod_a4);
                    label28.Text = karakter.ToString();
                }
                else  if (kod_a3 == 45)
                {
                    kod_a4 = rastgele_a4.Next(43, 44);
                    char karakter = Convert.ToChar(kod_a4);
                    label28.Text = karakter.ToString();
                }
                else if (kod_a3 == 47)
                {
                    kod_a4 = rastgele_a4.Next(42, 48);
                    char karakter = Convert.ToChar(kod_a4);
                    label28.Text = karakter.ToString();
                }
                toplama_a4 = sayilar_a4 + sayilar_a4_2;
                carpma_a4 = sayilar_a4 * sayilar_a4_2;
                cikarma_a4 = sayilar_a4 - sayilar_a4_2;

                bolme_a4 = sayilar_a4 / sayilar_a4_2;

                if (sayilar_a4_2 != sayilar_a4 && kod_a4 != 44 && kod_a4 != 46  && cikarma_a4 > 1 && bolme_a4>1.5)
                {
                    label30.Text = sayilar_a4.ToString();
                    label29.Text = sayilar_a4_2.ToString();

                    sayac_a4++;


                }



            }
            int nilufer_a4 = 0;

            if (nilufer_a3 == 0)
            {
                Random rnd_a3 = new Random();
                int uret_a4 = rnd_a3.Next(1, 100);
                int sonuc = 0;
                sonuc = uret_a4 % 2;
                nilufer_a4 = sonuc;
            }
            else if (nilufer_a3 == 2)
            {
                Random rnd_a3 = new Random();
                int sonuc = rnd_a3.Next(1, 4);
                nilufer_a4 = sonuc;
            }
            else if (nilufer_a3 == 1)
            {
                Random rnd_a3 = new Random();
                int uret_a4_2 = rnd_a3.Next(1, 100);
                int sonuc = 0;
                sonuc = uret_a4_2 % 3;
                nilufer_a4 = sonuc;
            }
            else if (nilufer_a3 == 3)
            {
                Random rnd_a3 = new Random();
                int sonuc = rnd_a3.Next(2, 4);
                nilufer_a4 = sonuc;
            }



            if (kod_a4 == 43)
            {


                if (nilufer_a4 == 2)
                {
                    label15.Text = toplama_a4.ToString();
                    listBox2.Items.Add(toplama_a4.ToString());
                }
                if (nilufer_a4 == 3)
                {
                    label17.Text = toplama_a4.ToString();
                    listBox2.Items.Add(toplama_a4.ToString());
                }
                if (nilufer_a4 == 1)
                {
                    label14.Text = toplama_a4.ToString();
                    listBox2.Items.Add(toplama_a4.ToString());
                }
                if (nilufer_a4 == 0)
                {
                    label16.Text = toplama_a4.ToString();
                    listBox2.Items.Add(toplama_a4.ToString());
                }

            }
            if (kod_a4 == 42)
            {



                if (nilufer_a4 == 2)
                {
                    label15.Text = carpma_a4.ToString();
                    listBox2.Items.Add(carpma_a4.ToString());
                }
                if (nilufer_a4 == 3)
                {
                    label17.Text = carpma_a4.ToString();
                    listBox2.Items.Add(carpma_a4.ToString());
                }
                if (nilufer_a4 == 1)
                {
                    label14.Text = carpma_a4.ToString();
                    listBox2.Items.Add(carpma_a4.ToString());
                }
                if (nilufer_a4 == 0)
                {
                    label16.Text = carpma_a4.ToString();
                    listBox2.Items.Add(carpma_a4.ToString());
                }


            }
            if (kod_a4 == 45)
            {



                if (nilufer_a4 == 2)
                {
                    label15.Text = cikarma_a4.ToString();
                    listBox2.Items.Add(cikarma_a4.ToString());
                }
                if (nilufer_a4 == 3)
                {
                    label17.Text = cikarma_a4.ToString();
                    listBox2.Items.Add(cikarma_a4.ToString());
                }
                if (nilufer_a4 == 1)
                {
                    label14.Text = cikarma_a4.ToString();
                    listBox2.Items.Add(cikarma_a4.ToString());
                }
                if (nilufer_a4 == 0)
                {
                    label16.Text = cikarma_a4.ToString();
                    listBox2.Items.Add(cikarma_a4.ToString());
                }


            }
            if (kod_a4 == 47)
            {


                if (nilufer_a4 ==3)
                {
                    label17.Text = bolme_a4.ToString();
                    listBox2.Items.Add(bolme_a4.ToString());
                }


                if (nilufer_a4 == 2)
                {
                    label15.Text = bolme_a4.ToString();
                    listBox2.Items.Add(bolme_a4.ToString());
                }
                if (nilufer_a4 == 1)
                {
                    label14.Text = bolme_a4.ToString();
                    listBox2.Items.Add(bolme_a4.ToString());
                }
                if (nilufer_a4 == 0)
                {
                    label16.Text = bolme_a4.ToString();
                    listBox2.Items.Add(bolme_a4.ToString());
                }

            }

            string bos = "....";


            int[] sayilar5 = new int[40];
            Random rastgele5 = new Random();
            int i2 = 0;
            while (i2 <40)
            {
                int sayi5 = rastgele5.Next(1, 50);
                if (sayilar5.Contains(sayi5))
                    continue;
                sayilar5[i2] = sayi5;
                i2++;
            }


            Array.Sort(sayilar5);
            foreach (int sayi5 in sayilar5)
            {
                listBox1.Items.Add(sayi5);
            }

            // TOPLAMA İŞLEMİ ELEME
            int indextop_a1 = listBox1.FindString(toplama.ToString());
            int indextop_a2 = listBox1.FindString(toplama_a2.ToString());
            int indextop_a3 = listBox1.FindString(toplama_a3.ToString());
            int indextop_a4 = listBox1.FindString(toplama_a4.ToString());

            if (indextop_a1 != -1)
            {
                listBox1.SetSelected(indextop_a1, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
              
            }
            if (indextop_a2 != -1)
            {
                listBox1.SetSelected(indextop_a2, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
                
            }
            if (indextop_a3 != -1)
            {
                listBox1.SetSelected(indextop_a3, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
           
            }
            if (indextop_a4 != -1)
            {
                listBox1.SetSelected(indextop_a4, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
              
            }

            // CARPMA İŞLEMİ ELEME
            int indexcrp_a1 = listBox1.FindString(carpma.ToString());
            int indexcrp_a2 = listBox1.FindString(carpma_a2.ToString());
            int indexcrp_a3 = listBox1.FindString(carpma_a3.ToString());
            int indexcrp_a4 = listBox1.FindString(carpma_a4.ToString());

            if (indexcrp_a1 > -1)
            {
                listBox1.SetSelected(indexcrp_a1, true);
                listBox1.Items.Remove(listBox1.SelectedItem); 
              
            }
             if (indexcrp_a2 != -1)
            {
                listBox1.SetSelected(indexcrp_a2, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
             
            }
             if (indexcrp_a3 != -1)
            {
                listBox1.SetSelected(indexcrp_a3, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
              
            }
            if (indexcrp_a4 != -1)
            {
                listBox1.SetSelected(indexcrp_a4, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
                
            }
            // CIKARMA İŞLEMİ ELEME
            int indexcik_a1 = listBox1.FindString(cikarma.ToString());
            int indexcik_a2 = listBox1.FindString(cikarma_a2.ToString());
            int indexcik_a3 = listBox1.FindString(cikarma_a3.ToString());
            int indexcik_a4 = listBox1.FindString(cikarma_a4.ToString());
            if (indexcik_a1 != -1)
            {
                listBox1.SetSelected(indexcik_a1, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
                
            }
            if (indexcik_a2 != -1)
            {
                listBox1.SetSelected(indexcik_a2, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
               
            }
            if (indexcik_a3 != -1)
            {
                listBox1.SetSelected(indexcik_a3, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
               
            }
             if (indexcik_a4 != -1)
            {
                listBox1.SetSelected(indexcik_a4, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
               
            }

            // bolme İŞLEMİ ELEME
            int indexbol_a1 = listBox1.FindString(bolme.ToString());
            int indexbol_a2 = listBox1.FindString(bolme_a2.ToString());
            int indexbol_a3 = listBox1.FindString(bolme_a3.ToString());
            int indexbol_a4 = listBox1.FindString(bolme_a4.ToString());
            if (indexbol_a1 > -1)
            {

                listBox1.SetSelected(indexbol_a1, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
                
            }
            if (indexbol_a2 != -1)
            {
                listBox1.SetSelected(indexbol_a2, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
              
            }
            if (indexbol_a3 != -1)
            {
                listBox1.SetSelected(indexbol_a3, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
              
            }
            if (indexbol_a4 != -1)
            {
                listBox1.SetSelected(indexbol_a4, true);
                listBox1.Items.Remove(listBox1.SelectedItem);
            
            }
            



            if (label1.Text == bos)
            {


                label1.Text = listBox1.Items[0].ToString();
                
            }
            if (label7.Text == bos)
            {


                label7.Text = listBox1.Items[1].ToString();
            }
            if (label8.Text == bos)
            {


                label8.Text = listBox1.Items[2].ToString();
            }
            if (label9.Text == bos)
            {


                label9.Text = listBox1.Items[3].ToString();
            }
            if (label13.Text == bos)
            {


                label13.Text = listBox1.Items[4].ToString();
            }
            if (label10.Text == bos)
            {


                label10.Text = listBox1.Items[5].ToString();
            }
            if (label11.Text == bos)
            {


                label11.Text = listBox1.Items[6].ToString();
            }
            if (label12.Text == bos)
            {


                label12.Text = listBox1.Items[7].ToString();
            }
            if (label24.Text == bos)
            {


                label24.Text = listBox1.Items[8].ToString();
            }
            if (label21.Text == bos)
            {


                label21.Text = listBox1.Items[9].ToString();
            }
            if (label22.Text == bos)
            {


                label22.Text = listBox1.Items[10].ToString();
            }
            if (label23.Text == bos)
            {


                label23.Text = listBox1.Items[11].ToString();
            }
            if (label14.Text == bos)
            {


                label14.Text = listBox1.Items[12].ToString();
            }
          
            if (label15.Text == bos)
            {


                label15.Text = listBox1.Items[13].ToString();
            }
            if (label16.Text == bos)
            {


                label16.Text = listBox1.Items[14].ToString();
            }
            if (label17.Text == bos)
            {


                label17.Text = listBox1.Items[15].ToString();
            }
            
         
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            
                if (nilufer2 == false)
                {
                    nilufer1 = true;
                    animasyon.Start();
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = true;
                    label1.Visible = false;
                    label7.Visible= false;
                    label9.Visible = false;
                    label8.Visible = false;
                }

            
        }

        private void animasyon_Tick(object sender, EventArgs e)
        {
          
                saniye++;
                
            
            label31.Text = saniye.ToString();
            
            if (saniye == 25 && nilufer1 == true)
            {
               pictureBox3.Visible = true;
               pictureBox1.Visible = false;
               

               int sayi = Convert.ToInt32(label7.Text); 
            int index= listBox2.FindString(sayi.ToString());
            if (index == -1)
            {
               

            
               pictureBox3.Visible = false;
               pictureBox52.Visible = true;

               
               
            }
            
                
            }
            
           if (saniye == 25 && nilufer2 == true)
            {
              pictureBox4.Visible = true;
              pictureBox5.Visible = false;

              double sayi3 = Convert.ToInt32(label1.Text);
              int index3 = listBox2.FindString(sayi3.ToString());
              if (index3 == -1)
              {



                  pictureBox4.Visible = false;
                  pictureBox53.Visible = true;



              }
            
                
            }
            if (saniye == 40)
            {
                pictureBox52.Visible = false;
                pictureBox53.Visible = false;
                animasyon.Stop();
              /*  DialogResult bolumgec = new DialogResult();

                bolumgec = MessageBox.Show("YENİDEN OYNAMAK İÇİN TIKLAYINIZ...", "MALESEF BÖLÜMÜ BAŞARILI BİR ŞEKİLDE GEÇEMEDİNİZ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (bolumgec == DialogResult.OK)
                {
                    Level1 level1 = new Level1();
                    level1.Close();
                    this.Hide();
                }*/
                
            
            }
           if (saniye == 65 && nilufer3 == true)
            {
                pictureBox22.Visible = false;
                pictureBox6.Visible = true;

                 double sayi = Convert.ToInt32(label12.Text);
                int index = listBox2.FindString(sayi.ToString());

                if (index == -1)
                {
                    pictureBox6.Visible = false;
                    pictureBox54.Visible = true;
                }

                

                
            }
           
           if (saniye == 65&& nilufer4 == true && nilufer1 == true)
            {
                pictureBox23.Visible = false;
                pictureBox7.Visible = true;

                 double sayi = Convert.ToInt32(label11.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox7.Visible = false;
                    pictureBox55.Visible = true;
                }
                

                
            }
           if (saniye == 65 && nilufer4 == true && nilufer2 == true)
           {
               
               pictureBox26.Visible = false;
               pictureBox7.Visible = true;

                double sayi = Convert.ToInt32(label11.Text);
               int index = listBox2.FindString(sayi.ToString());
               if (index == -1)
               {
                   pictureBox7.Visible = false;
                   pictureBox55.Visible = true;
               }
               
           }
           
            if (saniye ==65 && nilufer5 == true&& nilufer1==true)
            {
                pictureBox24.Visible = false;
                pictureBox8.Visible = true;
                 double sayi = Convert.ToInt32(label10.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox8.Visible = false;
                    pictureBox56.Visible = true;
                }
                
                

                
            }
            if (saniye == 65 && nilufer5 == true && nilufer2==true)
            {
                pictureBox25.Visible = false;
                pictureBox8.Visible = true;

                 double sayi = Convert.ToInt32(label10.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox8.Visible = false;
                    pictureBox56.Visible = true;
                }

              

                
            }
            
            if (saniye == 65 && nilufer6 == true )
            {

                pictureBox27.Visible = false;
                pictureBox9.Visible = true;

                 double sayi = Convert.ToInt32(label13.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox9.Visible = false;
                    pictureBox57.Visible = true;
                }
            }
            if (saniye == 80)
            {
                pictureBox57.Visible = false;
                pictureBox56.Visible = false;
                pictureBox55.Visible = false;
                pictureBox54.Visible = false;
                DialogResult bolumgec = new DialogResult();

                /*bolumgec = MessageBox.Show("YENİDEN OYNAMAK İÇİN TIKLAYINIZ...", "MALESEF BÖLÜMÜ BAŞARILI BİR ŞEKİLDE GEÇEMEDİNİZ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (bolumgec == DialogResult.OK)
                {
                    Level1 level1 = new Level1();
                    level1.Show();
                    this.Hide();
                }*/
                animasyon.Stop();

            }
            if (saniye == 105 && nilufer7 == true && nilufer6 == true)
            {
                
                pictureBox28.Visible = false;
                pictureBox13.Visible = true;
                 double sayi = Convert.ToInt32(label24.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox13.Visible = false;
                    pictureBox58.Visible = true;
                }
                

                
            }
            if (saniye == 105 && nilufer7 == true && nilufer5 == true)
            {

                pictureBox29.Visible = false;
                pictureBox13.Visible = true;
                 double sayi = Convert.ToInt32(label24.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox13.Visible = false;
                    pictureBox58.Visible = true;
                }
                

               
            }

            if (saniye == 105 && nilufer8 == true && nilufer4 == true)
            {
                pictureBox31.Visible = false;
                pictureBox12.Visible = true;
                 double sayi = Convert.ToInt32(label21.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox12.Visible = false;
                    pictureBox59.Visible = true;
                }
                
                
               
                
            }
            if (saniye == 105 && nilufer8 == true && nilufer5 == true)
            {

                pictureBox30.Visible = false;
                pictureBox12.Visible = true;
                 double sayi = Convert.ToInt32(label21.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox12.Visible = false;
                    pictureBox59.Visible = true;
                }
            }
            if (saniye == 105 && nilufer8 == true && nilufer6 == true)
            {

                pictureBox32.Visible = false;
                pictureBox12.Visible = true;
                 double sayi = Convert.ToInt32(label21.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox12.Visible = false;
                    pictureBox59.Visible = true;
                }

            }
            if (saniye == 105 && nilufer9 == true && nilufer5 == true)
            {

                pictureBox33.Visible = false;
                pictureBox11.Visible = true;
                 double sayi = Convert.ToInt32(label22.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox11.Visible = false;
                    pictureBox60.Visible = true;
                }
            }
            if (saniye == 105 && nilufer9 == true && nilufer4 == true)
           {

               pictureBox34.Visible = false;
               pictureBox11.Visible = true;
                double sayi = Convert.ToInt32(label22.Text);
               int index = listBox2.FindString(sayi.ToString());
               if (index == -1)
               {
                   pictureBox11.Visible = false;
                   pictureBox60.Visible = true;
               }
           }
            if (saniye == 105 && nilufer9 == true && nilufer3== true)
           {

               pictureBox35.Visible = false;
               pictureBox11.Visible = true;
                double sayi = Convert.ToInt32(label22.Text);
               int index = listBox2.FindString(sayi.ToString());
               if (index == -1)
               {
                   pictureBox11.Visible = false;
                   pictureBox60.Visible = true;
               }
           }
            if (saniye == 105 && nilufer10 == true && nilufer4 == true)
            {

                pictureBox36.Visible = false;
                pictureBox10.Visible = true;
                 double sayi = Convert.ToInt32(label23.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox10.Visible = false;
                    pictureBox61.Visible = true;
                }
            }
            if (saniye == 105 && nilufer10 == true && nilufer3 == true)
           {

               pictureBox37.Visible = false;
               pictureBox10.Visible = true;
                double sayi = Convert.ToInt32(label23.Text);
               int index = listBox2.FindString(sayi.ToString());
               if (index == -1)
               {
                   pictureBox10.Visible = false;
                   pictureBox61.Visible = true;
               }
           }
            if (saniye == 120)
            {
                pictureBox58.Visible = false;
                pictureBox59.Visible = false;
                pictureBox60.Visible = false;
                pictureBox61.Visible = false;
               /* DialogResult bolumgec = new DialogResult();

                bolumgec = MessageBox.Show("YENİDEN OYNAMAK İÇİN TIKLAYINIZ...", "MALESEF BÖLÜMÜ BAŞARILI BİR ŞEKİLDE GEÇEMEDİNİZ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (bolumgec == DialogResult.OK)
                {
                    Level1 level1 = new Level1();
                    level1.Show();
                    this.Hide();
                }*/
                animasyon.Stop();

            }

            if (saniye == 145&& nilufer11 == true && nilufer7 == true)
            {

                pictureBox38.Visible = false;
                pictureBox17.Visible = true;

                 double sayi = Convert.ToInt32(label17.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox17.Visible = false;
                    pictureBox62.Visible = true;
                }
                else
                {
                    pictureBox17.Visible = false;
                    pictureBox51.Visible = true;
                }
            }
            if (saniye == 145 && nilufer11 == true && nilufer8 == true)
            {

                pictureBox39.Visible = false;
                pictureBox17.Visible = true;
                 double sayi = Convert.ToInt32(label17.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox17.Visible = false;
                    pictureBox62.Visible = true;
                }
                else
                {
                    pictureBox17.Visible = false;
                    pictureBox51.Visible = true;
                }
            }
            if (saniye == 145&& nilufer12 == true && nilufer9== true)
             {

                 pictureBox40.Visible = false;
                 pictureBox16.Visible = true;
                 double sayi = Convert.ToInt32(label15.Text);
                int index = listBox2.FindString(sayi.ToString());
                if (index == -1)
                {
                    pictureBox16.Visible = false;
                    pictureBox63.Visible = true;
                }
                else
                {
                    pictureBox16.Visible = false;
                    pictureBox50.Visible = true;
                }
             }

            if (saniye == 145 && nilufer12 == true && nilufer8 == true)
            {

                pictureBox41.Visible = false;
                pictureBox16.Visible = true;
                  double sayi2 = Convert.ToInt32(label15.Text);
                int index2 = listBox2.FindString(sayi2.ToString());
                if (index2 == -1)
                {
                    pictureBox16.Visible = false;
                    pictureBox63.Visible = true;
                }
                else
                {
                pictureBox16.Visible = false;
                pictureBox50.Visible = true;
                }
            }
            if (saniye == 145 && nilufer12 == true && nilufer7 == true)
            {

                pictureBox42.Visible = false;
                pictureBox16.Visible = true;
                  double sayi2 = Convert.ToInt32(label15.Text);
                int index2 = listBox2.FindString(sayi2.ToString());
                if (index2 == -1)
                {
                    pictureBox16.Visible = false;
                    pictureBox63.Visible = true;
                }
                else
                {
                pictureBox16.Visible = false;
                pictureBox50.Visible = true;
                }
            }
             if (saniye == 145 && nilufer13 == true&& nilufer10 == true)
             {

                 pictureBox43.Visible = false;
                 pictureBox15.Visible = true;
                 int sayi2 = Convert.ToInt32(label14.Text);
                int index2 = listBox2.FindString(sayi2.ToString());
                if (index2 == -1)
                {
                    pictureBox15.Visible = false;
                    pictureBox64.Visible = true;
                }
                else
                {
                 pictureBox15.Visible = false;
                 pictureBox49.Visible = true;
                }
             }
             if (saniye == 145 && nilufer13 == true && nilufer9 == true)
             {

                 pictureBox44.Visible = false;
                 pictureBox15.Visible = true;
                  double sayi2 = Convert.ToInt32(label14.Text);
                int index2 = listBox2.FindString(sayi2.ToString());
                if (index2 == -1)
                {
                    pictureBox15.Visible = false;
                    pictureBox64.Visible = true;
                }
                else
                {
                 pictureBox15.Visible = false;
                 pictureBox49.Visible = true;
                }
             }
             if (saniye == 145 && nilufer13 == true && nilufer8 == true)
             {

                 pictureBox45.Visible = false;
                 pictureBox15.Visible = true;
                  double sayi2 = Convert.ToInt32(label14.Text);
                int index2 = listBox2.FindString(sayi2.ToString());
                if (index2 == -1)
                {
                    pictureBox15.Visible = false;
                    pictureBox64.Visible = true;
                }
                else
                {
                 pictureBox15.Visible = false;
                 pictureBox49.Visible = true;
                }
             }
             if (saniye == 145 && nilufer14 == true && nilufer9 == true)
             {

                 pictureBox46.Visible = false;
                 pictureBox14.Visible = true;
                  double sayi2 = Convert.ToInt32(label16.Text);
                int index2 = listBox2.FindString(sayi2.ToString());
                if (index2 == -1)
                {
                    pictureBox14.Visible = false;
                    pictureBox65.Visible = true;

                }
                else
                {
                 pictureBox14.Visible = false;
                pictureBox48.Visible = true;
                }
                 
             }
             if (saniye == 145 && nilufer14 == true && nilufer10 == true)
             {

                 pictureBox47.Visible = false;
                 pictureBox14.Visible = true;
                   double sayi2 = Convert.ToInt32(label16.Text);
                int index2 = listBox2.FindString(sayi2.ToString());
                if (index2 == -1)
                {
                    pictureBox14.Visible = false;
                    pictureBox65.Visible = true;
                }
                else
                {
                 pictureBox14.Visible = false;
                 pictureBox48.Visible = true;
                }
             }
             if (saniye == 170 && nilufer14 == true)
             {
                 pictureBox48.Visible = false;
                 
                pictureBox18.Visible = true;
                animasyon.Stop();
                DialogResult bolumgec = new DialogResult();

                bolumgec = MessageBox.Show("BİR SONRAKİ BÖLÜME GEÇMEK İÇİN TIKLAYINIZ...", "TEBRİKLER BÖLÜMÜ BAŞARILI BİR ŞEKİLDE GEÇTİNİZ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (bolumgec == DialogResult.OK)
                {
                    Level2 level2 = new Level2();
                    level2.Show();
                    this.Hide();
                }
             }
             if (saniye == 170 && nilufer13 == true)
             {

                pictureBox49.Visible = false;
                 pictureBox19.Visible = true;

                 animasyon.Stop();
                 DialogResult bolumgec = new DialogResult();

                 bolumgec = MessageBox.Show("BİR SONRAKİ BÖLÜME GEÇMEK İÇİN TIKLAYINIZ...", "TEBRİKLER BÖLÜMÜ BAŞARILI BİR ŞEKİLDE GEÇTİNİZ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 if (bolumgec == DialogResult.OK)
                 {
                     Level2 level2 = new Level2();
                     level2.Show();
                     this.Hide();
                 }
             }
             if (saniye == 170 && nilufer12 == true)
             {

                 pictureBox50.Visible = false;
                 pictureBox20.Visible = true;

                 animasyon.Stop();
                 DialogResult bolumgec = new DialogResult();

                 bolumgec = MessageBox.Show("BİR SONRAKİ BÖLÜME GEÇMEK İÇİN TIKLAYINIZ...", "TEBRİKLER BÖLÜMÜ BAŞARILI BİR ŞEKİLDE GEÇTİNİZ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 if (bolumgec == DialogResult.OK)
                 {
                     Level2 level2 = new Level2();
                     level2.Show();
                     this.Hide();
                 }
             }
             if (saniye == 170 && nilufer11 == true)
             {

                 pictureBox51.Visible = false;
                 pictureBox21.Visible = true;
                 animasyon.Stop();
                 DialogResult bolumgec = new DialogResult();
                 
                 bolumgec=MessageBox.Show("BİR SONRAKİ BÖLÜME GEÇMEK İÇİN TIKLAYINIZ...", "TEBRİKLER BÖLÜMÜ BAŞARILI BİR ŞEKİLDE GEÇTİNİZ...",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 if (bolumgec == DialogResult.OK)
                 {
                     Level2 level2 = new Level2();
                     level2.Show();
                     this.Hide();
                 }
                 
             }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            

            
                
                    nilufer2 = true;
                    animasyon.Start();
                    pictureBox2.Visible = false;
                    pictureBox5.Visible = true;
                    label1.Visible = false;
                    label7.Visible = false;
                    label9.Visible = false;
                    label8.Visible = false;

                
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
            
            
                if (nilufer1 == true)
                {
                    nilufer4 = true;
                    animasyon.Start();
                    pictureBox3.Visible = false;
                    pictureBox23.Visible = true;

                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                }
                if (nilufer2 == true)
                {
                    nilufer4 = true;
                    animasyon.Start();
                    pictureBox4.Visible = false;
                    pictureBox26.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    
                }
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label27.Visible = true;
                label26.Visible = true;
                label25.Visible = true;



            
          
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
            
                if (nilufer1 == true)
                {
                    nilufer3 = true;
                    animasyon.Start();
                    pictureBox3.Visible = false;
                    pictureBox22.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                }
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label27.Visible = true;
                label26.Visible = true;
                label25.Visible = true;
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
              if (nilufer1 == true)
                {
                    nilufer5 = true;
                    animasyon.Start();
                    pictureBox3.Visible = false;
                    pictureBox24.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                }
                if (nilufer2 == true)
                {
                    nilufer5 = true;
                    animasyon.Start();
                    pictureBox4.Visible = false;
                    pictureBox25.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                }
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label27.Visible = true;
                label26.Visible = true;
                label25.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
           
                if (nilufer2 == true)
                {
                    nilufer6 = true;
                    animasyon.Start();
                    pictureBox4.Visible = false;
                    pictureBox27.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                }
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label27.Visible = true;
                label26.Visible = true;
                label25.Visible = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {
           
            
                if (nilufer6 == true)
                {
                    nilufer7 = true;
                    animasyon.Start();
                    pictureBox9.Visible = false;
                    pictureBox28.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                if (nilufer5 == true)
                {
                    nilufer7 = true;
                    animasyon.Start();
                    pictureBox8.Visible = false;
                    pictureBox29.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
                if (nilufer6 == true)
                {
                    nilufer8 = true;

                    animasyon.Start();
                    pictureBox9.Visible = false;
                    pictureBox32.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                if (nilufer5 == true)
                {
                    nilufer8 = true;
                    animasyon.Start();
                    pictureBox8.Visible = false;
                    pictureBox30.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                if (nilufer4 == true)
                {
                    nilufer8 = true;

                    animasyon.Start();
                    pictureBox7.Visible = false;
                    pictureBox31.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false; ;
                }
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
        }

        private void label22_Click(object sender, EventArgs e)
        {
           
                if (nilufer5 == true)
                {
                    nilufer9 = true;
                    animasyon.Start();
                    pictureBox8.Visible = false;
                    pictureBox33.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                if (nilufer4 == true)
                {
                    nilufer9 = true;
                    animasyon.Start();
                    pictureBox7.Visible = false;
                    pictureBox34.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                if (nilufer3 == true)
                {
                    nilufer9 = true;
                    animasyon.Start();
                    pictureBox6.Visible = false;
                    pictureBox35.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label23_Click(object sender, EventArgs e)
        {
            
                if (nilufer3 == true)
                {
                    nilufer10 = true;
                    animasyon.Start();
                    pictureBox6.Visible = false;
                    pictureBox37.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                if (nilufer4 == true)
                {
                    nilufer10 = true;
                    animasyon.Start();
                    pictureBox7.Visible = false;
                    pictureBox36.Visible = true;
                    label21.Visible = false;
                    label22.Visible = false;
                    label23.Visible = false;
                    label24.Visible = false;
                }
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            
                if (nilufer7 == true)
                {
                    nilufer11 = true;
                    animasyon.Start();
                    pictureBox13.Visible = false;
                    pictureBox38.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                    
                }
                if (nilufer8 == true)
                {
                    nilufer11 = true;
                    animasyon.Start();
                    pictureBox12.Visible = false;
                    pictureBox39.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
                if (nilufer9 == true)
                {
                    nilufer12 = true;
                    animasyon.Start();
                    pictureBox11.Visible = false;
                    pictureBox40.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                if (nilufer8 == true)
                {
                    nilufer12 = true;
                    animasyon.Start();
                    pictureBox12.Visible = false;
                    pictureBox41.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                if (nilufer7 == true)
                {
                    nilufer12 = true;
                    animasyon.Start();
                    pictureBox13.Visible = false;
                    pictureBox42.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
                if (nilufer10 == true)
                {
                    nilufer13 = true;
                    animasyon.Start();
                    pictureBox10.Visible = false;
                    pictureBox43.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                if (nilufer9 == true)
                {
                    nilufer13 = true;
                    animasyon.Start();
                    pictureBox11.Visible = false;
                    pictureBox44.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                if (nilufer8 == true)
                {
                    nilufer13 = true;
                    animasyon.Start();
                    pictureBox12.Visible = false;
                    pictureBox45.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
                if (nilufer9 == true)
                {
                    nilufer14 = true;
                    animasyon.Start();
                    pictureBox11.Visible = false;
                    pictureBox46.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                if (nilufer10 == true)
                {
                    nilufer14 = true;
                    animasyon.Start();
                    pictureBox10.Visible = false;
                    pictureBox47.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    label15.Visible = false;
                    label14.Visible = false;
                }
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            label32.Text = sure.ToString();
        }
    }
}
