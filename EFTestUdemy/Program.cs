﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTestUdemy.Model;
using EFTestUdemy.Migrations;

namespace EFTestUdemy
{
    partial class Program
    {
        static void Main(string[] args)
        {

        }
    }
    [DbConfigurationType(typeof(PlutoDbConfig))]
    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public PlutoContext()
            : base("name=DefaultConnection")
        {

        }
    }
}
