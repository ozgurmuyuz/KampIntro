using System;

namespace Ders2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sanal Bakkal'a Hoşgeldiniz");
            Console.WriteLine("*****");

            Sepet urun1 = new Sepet();
            urun1.UrunTuru = "İçecek";
            urun1.UrunAdi = "Soda";
            urun1.UrunFiyati = 3;
            urun1.UrunUretimTarihi = "10.01.21";

            Sepet urun2 = new Sepet();
            urun2.UrunTuru = "Tatlı";
            urun2.UrunAdi = "Baklava";
            urun2.UrunFiyati = 50;
            urun2.UrunUretimTarihi = "12.01.21";

            Sepet urun3 = new Sepet();
            urun3.UrunTuru = "Meyve";
            urun3.UrunAdi = "Mandalina";
            urun3.UrunFiyati = 7;
            urun3.UrunUretimTarihi = "05.01.21";

            Sepet urun4 = new Sepet();
            urun4.UrunTuru = "Temizlik";
            urun4.UrunAdi = "Deterjan";
            urun4.UrunFiyati = 25;
            urun4.UrunUretimTarihi = "02.12.20";


            Sepet[] urunler = new Sepet[] { urun1, urun2, urun3, urun4 };

            Console.WriteLine(urun1.UrunTuru + " : " + urun1.UrunAdi + " , " + urun1.UrunFiyati + " TL" + ", " + urun1.UrunUretimTarihi);
            Console.WriteLine(urun2.UrunTuru + " : " + urun2.UrunAdi + " , " + urun2.UrunFiyati + " TL" + ", " + urun2.UrunUretimTarihi);
            Console.WriteLine(urun3.UrunTuru + " : " + urun3.UrunAdi + " , " + urun3.UrunFiyati + " TL" + ", " + urun3.UrunUretimTarihi);
            Console.WriteLine(urun4.UrunTuru + " : " + urun4.UrunAdi + " , " + urun4.UrunFiyati + " TL" + ", " + urun4.UrunUretimTarihi);

            Console.WriteLine(" ");
            Console.WriteLine("*****WHILE*****");
            int urunSayisi = 0;
            while (urunSayisi < urunler.Length)
            {
                Console.WriteLine(urunler[urunSayisi].UrunTuru + " : " + urunler[urunSayisi].UrunAdi + ", " + urunler[urunSayisi].UrunFiyati + " TL" + ", " + urunler[urunSayisi].UrunUretimTarihi);
                urunSayisi++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("*****FOREACH*****");
            foreach (Sepet urun in urunler)
            {
                Console.WriteLine(urun.UrunTuru + " : " + urun.UrunAdi + " , " + urun.UrunFiyati + " TL" + ", " + urun.UrunUretimTarihi);
            }

            Console.WriteLine(" ");
            Console.WriteLine("*****FOR*****");
            int urunSirasi = 0;
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[urunSirasi].UrunTuru + " : " + urunler[urunSirasi].UrunAdi + ", " + urunler[urunSirasi].UrunFiyati + " TL" + ", " + urunler[urunSirasi].UrunUretimTarihi);
                urunSirasi++;
            }

            int urunAdetToplam = urunler.Length;
            string sepetKapasitesi = urunAdetToplam <= 10 ? "Toplam Ürün : " + urunAdetToplam : "Diğer sayfayı kontrol edin";

            Console.WriteLine(sepetKapasitesi);
            Console.WriteLine("Ödeme sayfasına devam et");

        }

    class Sepet
        {
            public string UrunTuru { get; set; }
            public string UrunAdi { get; set; }
            public int UrunFiyati { get; set; }
            public string UrunUretimTarihi { get; set; }
        }
    }
}
