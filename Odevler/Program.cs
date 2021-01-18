using System;

namespace Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.AnaBaslik = "Kadın";
            urun1.Kategori = "Giyim";
            urun1.AltKategori = "Sweatshirt";
            urun1.UrunAdi = "Mavi Blok Renkli Oversize Sweatshirt";

            Urun urun2 = new Urun();
            urun2.AnaBaslik = "Erkek";
            urun2.Kategori = "Ayakkabı";
            urun2.AltKategori = "Spor Ayakkabı";
            urun2.UrunAdi = "Siyah Sneaker Spor Ayakkabı";

            Urun urun3 = new Urun();
            urun3.AnaBaslik = "Çocuk";
            urun3.Kategori = "Oyuncak";
            urun3.AltKategori = "Eğitici Oyuncak";
            urun3.UrunAdi = "Eğlenceli Bambu Çubuklar";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.AnaBaslik + " / " + urun.Kategori + " / " + urun.AltKategori + " / " + urun.UrunAdi);
            }

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].AnaBaslik + " / " + urunler[i].Kategori + " / " + urunler[i].AltKategori + " / " + urunler[i].UrunAdi);
            }

            int b = 0;
          
            while (b<=2)
            {
                if (b==1)
                {
                    Console.WriteLine(urunler);
                }
            }

        }
    }
}


class Urun
{

    public string AnaBaslik { get; set; }

    public string Kategori { get; set; }

    public string AltKategori { get; set; }

    public string UrunAdi { get; set; }

}



