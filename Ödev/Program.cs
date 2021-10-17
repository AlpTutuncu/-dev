using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaşıtLib;

namespace Ödev
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba arb = new Araba();

            Console.WriteLine("Kaç araba girmek istiyorsunuz?");
            int arbsayi = int.Parse(Console.ReadLine());

            for (int i = 0; i < arbsayi; i++)
            {
                FileStream fs = new FileStream("D:\\Arabalar.txt", FileMode.Append);
                fs.Close();
                

                StreamWriter sw = new StreamWriter("D:\\Arabalar.txt", true);

                sw.WriteLine($"{i + 1}. Araba");
                Console.WriteLine();
                Console.WriteLine($"{i + 1}. Araba");

                Console.WriteLine("Marka Giriniz");
                arb.Marka = Console.ReadLine();

                Console.WriteLine("Model Giriniz");
                arb.Model = Console.ReadLine();

                Console.WriteLine("Renk Giriniz");
                arb.Renk = Console.ReadLine();

                Console.WriteLine("Vites Sayısı Giriniz");
                arb.Vitessayisi = int.Parse(Console.ReadLine());


                sw.Write($"Girilen Marka: {arb.Marka}\nGirilen Model: {arb.Model}\nGirilen Renk: {arb.Renk}\nGirilen Vites Sayisi: {arb.Vitessayisi}");
                sw.WriteLine("\n----------------------");
                sw.Close();

            }

                Console.ReadKey();

        }
    }
}
