using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Code_first_Assingnment_2.Entities
{
    internal class MyContextDB : DbContext
    {
        public MyContextDB() : base("name=BookDBConn")
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>(entity=>entity.HasCheckConstraint("Salary","Salary>0"));
        }
    }
}
