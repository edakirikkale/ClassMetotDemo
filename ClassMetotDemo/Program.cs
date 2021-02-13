using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 101;
            musteri1.MusteriAd = "Eda";
            musteri1.MusteriSoyad = "Kırıkkale ";
            musteri1.MusteriBakiye = 2500;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 102;
            musteri2.MusteriAd = "Emre ";
            musteri2.MusteriSoyad = "Çankaya";
            musteri2.MusteriBakiye = 1500;

           müsteriManager.MusteriAdd(musteri1);
            müsteriManager.MusteriSil(musteri2);

            Console.WriteLine("--------------------------");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            müsteriManager.MusteriList(musteriler);
        }
    }
}
