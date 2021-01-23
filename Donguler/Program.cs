using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kursu";
            string kurs2 = "programlamaya giriş kursu";
            string kurs3 = "java kursu";

            //array - diziler

            string[] kurslar = new string[] { "yazılım geliştirici kursu", "programlamaya giriş kursu", "java kursu", "python", "c#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("sayfa sonu");

        }
    }
}
