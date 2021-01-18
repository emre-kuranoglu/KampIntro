using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python", "C#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i=1; i<10; i+=3)
            {
                Console.WriteLine(i);
            }

            double[] kusuratlar = new double[] { 0.1, 0.2, 0.3 };

            for(double a=0.1; a < kusuratlar.Length; a++)
            {
                Console.WriteLine(a);
            }


            Console.WriteLine("Sayfa Sonu");
        }
    }
}
