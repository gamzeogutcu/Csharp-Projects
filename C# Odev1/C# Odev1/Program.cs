// See https://aka.ms/new-console-template for more information
//1.soru
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.WriteLine("Lütfen girmek istediğiniz sayı adetini giriniz!");
int n = int.Parse(Console.ReadLine());
int[] sayiDizisi=new int[n]; 
for(int i=0; i<n; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Girmiş olduğunuz çift sayılar: ");
for (int i = 0; i < n; i++)
{
    if (sayiDizisi[i] % 2 == 0)
    {
        Console.WriteLine(sayiDizisi[i]);
    }
   
}
Console.WriteLine("2.soru");
//2.soru
//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
Console.WriteLine("Lütfen bölünmesini istediğiniz sayı adetini giriniz!");
int n2 = int.Parse(Console.ReadLine());
int[] sayiDizisi2 = new int[n2];
Console.WriteLine("Lütfen bölmek istediğiniz sayıyı giriniz!");
int m = int.Parse(Console.ReadLine());

for (int i = 0; i < n2; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
    sayiDizisi2[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Girmiş olduğunuz sayılardan istediğiniz değere tam bölünen sayılar: ");
for (int i = 0; i < n2; i++)
{
    if (sayiDizisi2[i] % m == 0 || sayiDizisi2[i]==m)
    {
        Console.WriteLine(sayiDizisi2[i]);
    }

}

Console.WriteLine("3.soru");
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
Console.WriteLine("Lütfen girmek istediğiniz kelime sayısını giriniz!");
int n3 = int.Parse(Console.ReadLine());
string[] kelimeDizisi = new string[n3];
for(int i=0; i<n3; i++)
{
    Console.WriteLine("Lütfen {0}. kelimeyi giriniz: ", i + 1);
    kelimeDizisi[i] = Console.ReadLine();
}
Console.WriteLine("Girmiş olduğunuz kelimeler sondan başa doğru: ");
for (int i = n3-1; 0 <= i; i--)
{
    Console.WriteLine(kelimeDizisi[i]);
}
Console.WriteLine("4.soru");
//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
Console.WriteLine("Lütfen toplam kelime ve harf sayısını öğrenmek istediğiniz cümleyi giriniz!");
string cumle = Console.ReadLine();
string[] kelimeDizisi2 = cumle.Split(' ');
int harfSayisi = cumle.Length-(kelimeDizisi2.Length-1);
int kelimeSayisi = kelimeDizisi2.Length;
Console.WriteLine("Toplam Kelime: " + kelimeSayisi + " Toplam Harf: " + harfSayisi);