using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class müsteriManager
    {

        public static void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
        }
        public static void MusteriList(Musteri[] musteri)
        {

            Console.WriteLine("        -  MÜŞTERİLER - ");
            Console.WriteLine();
            foreach (var a in musteri)
            {
                
                Console.WriteLine(a.MusteriAd + " " + a.MusteriSoyad + " :  " + a.MusteriBakiye);
            }
        }
        public static void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
        }
    }
}
