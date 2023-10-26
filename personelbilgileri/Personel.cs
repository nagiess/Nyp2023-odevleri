using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelbilgileri
{
    internal class Personel
    {

        public Personel(string gAdSoyad, string gAdres, string gUnvan, int gYas, int gMesai)

        {
            this.AdSoyad = gAdSoyad;
            this.Adres = gAdres;
            this.Unvan = gUnvan;
            this.Yas = gYas;
            this.Mesai = gMesai;

        }



            public string AdSoyad { get; set; }

            public string Adres { get; set; }

            public string Unvan { get; set; }

            string unvan;

            public int Yas { get; set; }

            public int Mesai { get; set; }


        public int ucretHesapla()

        {

            return this.Mesai * 100;

        }

        public void ucretHesapla(int ekUcret)
        { 
            
            MessageBox.Show((this.Mesai * 100 + ekUcret).ToString()); 
        
        }


    }

}





