using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin",
            //    "Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Engin",
                "Murat","Kerem","Halil" };
            isimler2.Add("Talha");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);
        }
    }
}
