using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new Context();
            foreach (var dbCompany in db.Companies)
            {
                Console.WriteLine(dbCompany.Id);
            }
        }
    }

    public class Context
    {
        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=WIN-B1N7P59KFSN\\Administrator;Integrated Security=True");
        }
    }

    public class Company
    {
        public int Id;
        public string CompanyName;
        public string Website;
        public string Notes;

        public Company() { }
        
    }
}
