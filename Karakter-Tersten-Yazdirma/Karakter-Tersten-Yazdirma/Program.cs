// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen bir ifade giriniz: ");
string ifade = Console.ReadLine();
char[] ifade_ = ifade.ToCharArray();
Array.Reverse(ifade_);
Console.WriteLine(ifade_);
