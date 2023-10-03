// See https://aka.ms/new-console-template for more information

Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);

int sıcaklık = 32;
if (sıcaklık <= (int)HavaDurumu.Normal)
    Console.WriteLine("Dışarıya çıkmak için biraz daha bekleyelim.");
else if (sıcaklık >= (int)HavaDurumu.Sicak)
    Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSicak)
    Console.WriteLine("Hadi dışarıya çıkalım!");


enum Gunler
{
    Pazartesi=1,

    Salı,
    
    Çarşamba,
    
    Perşembe,
    
    Cuma,
    
    Cumartesi,
    
    Pazar
}
enum HavaDurumu
{
    Soguk = 5,

    Normal = 20,

    Sicak = 25,

    CokSicak = 30,
}
