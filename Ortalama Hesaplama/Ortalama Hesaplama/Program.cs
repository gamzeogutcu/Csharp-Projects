// See https://aka.ms/new-console-template for more information
//Kulanıcıdan alınan derinliğe göre fibonacci serisindeki
//rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.
using System.Collections;
Console.WriteLine("Lütfen pozitif bir değer giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] sonuc = Fibonacci(ref n);
float ortalama = Ortalama(ref sonuc,ref n);
Console.WriteLine("Girmiş olduğunuz derinliğe göre fibonacci serisindeki rakamların ortalaması: "+ortalama);
static int[] Fibonacci(ref int n)
{
    int[] fibonacciSerisi = new int[n];
    fibonacciSerisi[0] = 1;
    fibonacciSerisi[1] = 1;
    for (int i = 2; i < n; i++){
        fibonacciSerisi[i] = fibonacciSerisi[i-1] + fibonacciSerisi[i-2];
}
    return fibonacciSerisi;

}
static float Ortalama(ref int[] x,ref int n)
{
    float toplam = 0;
   foreach(var item in x)
    {
        toplam += item;
    }
    float ortalama = toplam / n;
    return ortalama;
}
