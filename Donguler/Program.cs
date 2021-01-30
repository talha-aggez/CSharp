using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi 
            string[] kurslar = new string[] { "Yazılım Kampı",
                "Programlama Kampı","Java","Python","C#"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine();
            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("sayfa sonu  - footer");
        }
    }
}
