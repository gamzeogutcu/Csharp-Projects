﻿using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            //System.Collections.Generic
            //T->object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

           
            //Foreach ve List.ForEach ile elemanlara erişim
            foreach(var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu!");

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi listeye çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi temizlemek
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
           
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas = 26;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });
            foreach(var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);

            }

            yeniListe.Clear();

        }
    }
    public class Kullanıcılar
    {
       private string isim;
        
       private string soyisim;
        
       private int yas;

        public string Isim { get => isim ; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
