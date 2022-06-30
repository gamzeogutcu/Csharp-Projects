using System;
using System.Collections.Generic;

namespace DICTIONARY
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10, "Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(20, "Özcan Coşar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("*** Elemanlara Erişim ***");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var kullanıcı in kullanıcılar)
                Console.WriteLine(kullanıcı);

            //Count
            Console.WriteLine("*** Count ***");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("*** Contains ***");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Gamze Öğütcü"));

            //Remove
            Console.WriteLine("*** Remove ***");
            kullanıcılar.Remove(12);
            foreach (var kullanıcı in kullanıcılar)
                Console.WriteLine(kullanıcı.Value);

            //Keys
            Console.WriteLine("*** Keys ***");
            foreach (var kullanıcı in kullanıcılar.Keys)
                Console.WriteLine(kullanıcı);

            //Values
            Console.WriteLine("*** Values ***");
            foreach (var kullanıcı in kullanıcılar.Values)
                Console.WriteLine(kullanıcı);
        }
    }
}