using System;
using System.Linq;

namespace EntityFrameWorkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity FrameWork -- Bir ORM - Object Relational mapping
            //Nhibernate
            //Dapper
            //GetAll();
            GetProductsByCategory(2);
            Console.WriteLine("Hello World!");
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var item in northwindContext.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
