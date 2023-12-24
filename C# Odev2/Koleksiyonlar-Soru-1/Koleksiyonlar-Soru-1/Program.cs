// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("20 adet pozitif sayı giriniz!");
int sayi;
ArrayList sayiListesi = new ArrayList();
ArrayList asalSayilarListesi = new ArrayList();
ArrayList asalOlmayanSayilarListesi = new ArrayList();
//Negatif ve numeric olmayan girişleri engelleyin.
try
{
    for (int i = 0; i < 20; i++)
    {

        Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
        sayi = int.Parse(Console.ReadLine());

        if (sayi < 0)
        {
            throw new InvalidDataException("Lütfen pozitif bir sayı giriniz!");
        }
        else
        {
            sayiListesi.Add(sayi);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message.ToString());
}

foreach (int num in sayiListesi)
{
    int durum = 0;
    if (num == 1)
    {
        durum = 1;
    }
    else if (num == 2)
    {
        durum = 0;
    }
    else
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                durum = 1;
                break;

            }
         

        }
    }
        if (durum == 1)
        {
            asalOlmayanSayilarListesi.Add(num);
        }
        else
        {
            asalSayilarListesi.Add(num);
        }
    
}

//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
asalOlmayanSayilarListesi.Sort();
            asalSayilarListesi.Sort();
            asalOlmayanSayilarListesi.Reverse();
            asalSayilarListesi.Reverse();
            Console.WriteLine("Asal olmayan Sayılar: ");
float asalDeğilToplam = 0;
foreach (int asalDeğil in asalOlmayanSayilarListesi)
            {
    Console.WriteLine(asalDeğil + ",");
     
     asalDeğilToplam += asalDeğil;

}
            Console.WriteLine("Asal olan Sayılar: ");
float asalToplam = 0;
foreach (int asal in asalSayilarListesi)
            {
                Console.WriteLine(asal + ",");
   
    asalToplam += asal;
}
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
Console.WriteLine("Asal olan eleman sayısı: " + asalSayilarListesi.Count);
Console.WriteLine("Asal olan sayıların toplamı: " + asalToplam);
Console.WriteLine("Asal olan sayıların ortalaması: " + asalToplam/asalSayilarListesi.Count);

Console.WriteLine("Asal olmayan eleman sayısı: " + asalOlmayanSayilarListesi.Count);
Console.WriteLine("Asal olmayan sayıların toplamı: " + asalDeğilToplam);
Console.WriteLine("Asal olmayan sayıların ortalaması: " + asalDeğilToplam / asalSayilarListesi.Count);