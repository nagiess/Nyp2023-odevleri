using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelbilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///* Personel prs = new Personel(); */
            ///* prs.AdSoyad = adTxt.Text; prs.Adres = adresTxt.Text; prs.Yas = Convert.ToInt32(yasTxt.Text); */

            ///MessageBox.Show("Ad= " + adTxt.Text + "\n Adres= " + adresTxt.Text + "\n Yaş= " + yasTxt.Text, "Bilgilendirme Penceresi", MessageBoxButtons.OK); */


            Personel prs = new Personel
                (adTxt.Text, adresTxt.Text, comboBox1.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text));

            if (comboBox1.Text == "İşçi")
                MessageBox.Show(prs.ucretHesapla().ToString());
            else
                prs.ucretHesapla(1000);

                        
        }
    }
}
