using System;

class MainClass
{
    static void Main(string[] args)
    {

        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;

        bool sistemeGirisYapmisMi = true;

        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        if (dolarDun > dolarBugun)
        {
            Console.WriteLine("azalış oku");
        }

        else if (dolarBugun > dolarDun)
        {
            Console.WriteLine("artış oku");
        }
        else
        {
            Console.WriteLine("değişmedi oku");
        }

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }

        Console.WriteLine(kategoriEtiketi);
    }
}