// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen aralarına virgül(,) koyarak bir ifade ve sayı giriniz: ");
string input = Console.ReadLine();
string[] ifade = input.Split(',');
int sayi = int.Parse(ifade[1]);
Console.WriteLine(ifade[0].Remove(sayi - 1,1));