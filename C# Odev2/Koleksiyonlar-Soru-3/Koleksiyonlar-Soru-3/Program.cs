// See https://aka.ms/new-console-template for more information
//Klavyeden girilen cümle içerisindeki sesli
//harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
using System.Collections;

Console.WriteLine("Lütfen bir cümle giriniz: ");
string cumle = Console.ReadLine();
cumle = cumle.ToLower();
ArrayList arrayList = new ArrayList();
foreach(var item in cumle)
{
    if(item == 'a' || item=='e' || item=='ı' || item=='i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
    {
        arrayList.Add(item);
    }
}
Console.WriteLine("Cümlenin içerisindeki sesli harfler: ");
foreach(var item in arrayList)
{
    Console.WriteLine(item + ",");
}