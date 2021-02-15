﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "Engin",
                Age = 32
            };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
        [ToTable("Customers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

        }
        class CustomerDal
        {
            [Obsolete("Don't use Add, instead use Addnew MEthod")] 
            //Bu fonksiyon eski demek obsolete....
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added!",customer.Id,
                    customer.FirstName,customer.LastName,customer.Age);
            }
            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added!", customer.Id,
                    customer.FirstName, customer.LastName, customer.Age);
            }
        }
        [AttributeUsage(AttributeTargets.Property,AllowMultiple = false)]
        class RequiredPropertyAttribute : Attribute
        {

        }
        [AttributeUsage(AttributeTargets.Class , AllowMultiple = true)]
        class ToTableAttribute : Attribute
        {
            private string _tablename;
            public ToTableAttribute(string tableName)
            {
                _tablename = tableName;
            }
        }
    }
}
