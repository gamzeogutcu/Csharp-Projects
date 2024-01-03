// See https://aka.ms/new-console-template for more information
Console.Write("Üçgenin kenar uzunluğunu girin: ");
int kenarUzunlugu = int.Parse(Console.ReadLine());
for (int i = 1; i <= kenarUzunlugu; i++) //n adet yıldız (satır kısmında)
{
    // sütün için döngü
    for (int j = 1; j < 2 * kenarUzunlugu; j++) // sütün kısmında n adet yıldız olması için 
    {
        // Eşit tarafları yazdırmak için 
        if (j == (kenarUzunlugu - i + 1) // sol kısımdaki yıldızları oluşturur
            || j == (kenarUzunlugu + i - 1)) // sağ kısımdaki yıldızları oluşturur
        {
            Console.Write("* ");
        }
        // dış üçgen için
        else if (i == kenarUzunlugu || (i == kenarUzunlugu))

        {

            Console.Write("* ");
        }

        // boşluklar için kullanılan kod satırları alt tarafta verilmiştir
        else
        {
            Console.Write(" " + " ");
        }
    }
    Console.Write("\n"); // bu kod satırını silersek üçgen bozuluyor metinde bir alt satıra geçmesini sağlayan kısımdır
}