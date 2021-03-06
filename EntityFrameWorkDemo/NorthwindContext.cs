﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkDemo
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        //public class A
        //{
        //    public virtual void Do()
        //    {
        //        //
        //        //
        //        //
        //    }
        //}
        //public class B : A
        //{
        //    public override void Do()
        //    {
        //        base.Do();
        //    }
        //}
    }
}
