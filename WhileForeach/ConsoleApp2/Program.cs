using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a'dan z'ye kadar olan tüm harfleri konsola yazdır.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }
            string[] arabalar = { "Audi", "Bmw", "mercedes", "toyota", "nissan", "alfa romeo", "ssangyoung" };
   
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            Console.ReadLine();
        }
    }
}
