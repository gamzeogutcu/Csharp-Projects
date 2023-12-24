// See https://aka.ms/new-console-template for more information
using System.Collections;

//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
//her iki grubun kendi içerisinde ortalamalarını alan ve
//bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
//(Array sınıfını kullanarak yazınız.)
int n = 20;
int n2 = 3;
Console.WriteLine("{0} adet sayı giriniz!",n);
float kucukSayilarTop=0;
float buyukSayilarTop=0;
int[] sayiListesi = new int[n];
int[] büyükSayilarListesi = new int[n2];
int[] küçükSayilarListesi = new int[n2];

for(int i=0; i < n; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
    sayiListesi[i] = Convert.ToInt32(Console.ReadLine());
  
}
Array.Sort(sayiListesi);
Console.WriteLine("Girdiğiniz sayılardan en büyük 3 tanesi: ");
for (int i=0; i < n2; i++)
{
    büyükSayilarListesi[i] = sayiListesi[n - n2+i];
    buyukSayilarTop += büyükSayilarListesi[i];
    Console.WriteLine(büyükSayilarListesi[i]);
}
Console.WriteLine("Girdiğiniz sayılardan en küçük 3 tanesi: ");
for (int i = 0; i < n2; i++)
{
    küçükSayilarListesi[i] = sayiListesi[i];
    kucukSayilarTop += küçükSayilarListesi[i];
    Console.WriteLine(küçükSayilarListesi[i]);
}
Console.WriteLine("Büyük sayıların toplamı: " + buyukSayilarTop);
Console.WriteLine("Büyük sayıların ortalaması: " + buyukSayilarTop/n2);
Console.WriteLine("Küçük sayıların toplamı: " + kucukSayilarTop);
Console.WriteLine("Küçük sayıların ortalaması: " + kucukSayilarTop / n2);
Console.WriteLine("Küçük sayıların ortalaması: " + kucukSayilarTop / n2);