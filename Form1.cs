using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AdamAsmacaOyunudur
{
    public partial class Form1 : Form
    {
        List<string> kelimeler = new List<string>();
        string secilenKelime = "";
        char[] gorunurKelime;
        int hataSayisi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string yol = Application.StartupPath + "\\kelimeler.txt";
                if (File.Exists(yol)) kelimeler.AddRange(File.ReadAllLines(yol));
                else { kelimeler.Add("YAZILIM"); kelimeler.Add("KODLAMA"); }
            }
            catch { }

            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            if (kelimeler.Count == 0) return;
            hataSayisi = 0;
            Random rnd = new Random();
            secilenKelime = kelimeler[rnd.Next(kelimeler.Count)].ToUpper();

            gorunurKelime = new char[secilenKelime.Length];
            for (int i = 0; i < secilenKelime.Length; i++) gorunurKelime[i] = '_';

            lblKelime.Text = string.Join(" ", gorunurKelime);
            lblDurum.Text = "Kalan Hak: 6";
            if (picAdam != null) picAdam.Image = null;
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHarf.Text)) return;

            char tahmin = txtHarf.Text.ToUpper()[0];
            bool dogruMu = false;

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i] == tahmin)
                {
                    gorunurKelime[i] = tahmin;
                    dogruMu = true;
                }
            }

            if (!dogruMu)
            {
                hataSayisi++;
                try
                {
                    string resimYolu = Application.StartupPath + "\\resimler\\" + hataSayisi + ".jpg";
                    if (File.Exists(resimYolu)) picAdam.Image = Image.FromFile(resimYolu);
                }
                catch { }
            }

            lblKelime.Text = string.Join(" ", gorunurKelime);
            lblDurum.Text = "Kalan Hak: " + (6 - hataSayisi);
            txtHarf.Clear();
            txtHarf.Focus();

            if (!lblKelime.Text.Contains("_"))
            {
                MessageBox.Show("Tebrikler! Kazandınız.");
                OyunuBaslat();
            }
            else if (hataSayisi >= 6)
            {
                MessageBox.Show("Kaybettiniz! Kelime: " + secilenKelime);
                OyunuBaslat();
            }
        }

        private void picAdam_Click(object sender, EventArgs e)
        {

        }
    }
}