using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CagriMerkezi
{
    public partial class Form1 : Form
    {
        int saniye = 0, dakika = 0, saat = 0;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            TicariMusteriHizmetleri ticari = new TicariMusteriHizmetleri();
            ticari.ID = 1;
            ticari.Name = "Kadir Salaç";
            ticari.Ekle(ticari);

            TicariMusteriHizmetleri ticari2 = new TicariMusteriHizmetleri();
            ticari2.ID = 2;
            ticari2.Name = "Hatice Çetin ";
            ticari2.Ekle(ticari2);

            BireyselMusteriHizmetleri bireysel = new BireyselMusteriHizmetleri();
            bireysel.ID = 1;
            bireysel.Name = "Ayşe Kalan";
            bireysel.Ekle(bireysel);


            BireyselMusteriHizmetleri bireysel2 = new BireyselMusteriHizmetleri();
            bireysel2.ID = 2;
            bireysel2.Name = "Ali Mert";
            bireysel2.Ekle(bireysel2);

            cmbTemsilci.Items.Clear();

        }
        int a = 0;
        int toplamAramaSayisi = 0;
        PriorityQueue queue = new PriorityQueue(100);
        Musteri musteri = new Musteri();
        private void btnOrnekVeri_Click(object sender, EventArgs e)
        {
            queue.Insert(1);
            queue.Insert(2);
            //musteri.MusteriId[0] = 1;
            //musteri.MusteriId[1] = 2;


            a += 2;
        }
        private void btnAramaYap_Click(object sender, EventArgs e)
        {

            toplamAramaSayisi++;
            a++;
            // musteri.MusteriId[a-1] = a;
            queue.Insert(a);
            Thread thread = new Thread(SiraBekleme);
            thread.Start();
            //lvCagri.Items.Clear();
            btnOrnekVeri.Visible = false;

        }


        string[] cumleler;

        private void btnCagriyiBitir_Click(object sender, EventArgs e)
        {
            lvCagri.Items.Clear();
            KelimeYazma();
            queue.Remove();
            a--;
            rbBireysel.Checked = false;
            rbTicari.Checked=false;

            rbTicari.Visible = true;
            rbBireysel.Visible = true;
            cmbTemsilci.Items.Clear();
            cmbTemsilci.Text="";
            cmbTemsilci.Visible = false;
            btnOrnekVeri.Visible = true;


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye==60)
            {
                saniye = 0;
                dakika ++;
            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            //lblCagri.Text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString();
           //lvCagri.Items.Add(saat.ToString() + ":"+ dakika.ToString() + ":"+saniye.ToString());
            saniye++;
        }

        private void btnCagriAta_Click(object sender, EventArgs e)
        {
            toplamAramaSayisi++;
            lvCagri.Items.Clear();

            KelimeYazma();
            queue.Remove();
            a --;
            
        }


        private void SiraBekleme()
        {

            timer1.Start();
            if (a == 0)
                lvCagri.Items.Add("İlk sıradasınız."+DateTime.Now.ToLongTimeString());
            else
            {
                lvCagri.Items.Add(a+ ". sıradasınız. Lütfen hattan ayrılmayınız.."+ DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
            }

        }

        private void KelimeYazma()
        {
            cumleler = new string[a];
            for (int i = 0; i < a; i++)
            {
                cumleler[i] = txtNotlar.Text.ToString();

            }
            timer1.Stop();
            txtNotlar.Clear();
        }

        private void btnToplamCagri_Click(object sender, EventArgs e)
        {
            lblToplamCagri.Text=toplamAramaSayisi.ToString();
            //Sirala();
        }

        private void rbBireysel_CheckedChanged(object sender, EventArgs e)
        {
            rbTicari.Visible = false;
            cmbTemsilci.Visible = true;
            cmbTemsilci.Items.Add ("Ayşe Kalan");
            cmbTemsilci.Items.Add("Ali Mert");
        }
       
        private void rbTicari_CheckedChanged(object sender, EventArgs e)
        {
            rbBireysel.Visible= false;
            cmbTemsilci.Visible = true;
            cmbTemsilci.Items.Add("Hatice Çetin");
            cmbTemsilci.Items.Add("Kadir Salaç");
        }

        private void btnKelimeAra_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < cumleler.Length; i++)//lineer arama-arama algoritması
            {
                if (txtKelimeAra.Text == cumleler[i])
                    ltbKelimeAra.Items.Add(cumleler[i]);
                else
                    ltbKelimeAra.Items.Add("Aradığınız kelime bulunmamaktadır.");
            }
            ltbKelimeAra.Items.Clear();
        }

        public void Sirala()//Insertion Sort Implementasyonu-sıralama algoritması
        {
            int i, j,moved;
           
            for (i = 1; i < a; i++)
            {
                moved = musteri.MusteriId[i];
                j = i;
                while (j > 0 && musteri.MusteriId[j - 1] > moved)
                {
                    musteri.MusteriId[j] = musteri.MusteriId[j - 1];
                    j--;
                }
                musteri.MusteriId[j] = moved;
                lvTopamCagri.Items.Add(musteri.MusteriId[i].ToString());

            }

        }
    }
}
