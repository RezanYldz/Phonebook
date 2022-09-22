using Microsoft.EntityFrameworkCore;
using Phonebook.Entities.Book;
using Phonebook.Entities.Report;

namespace Phonebook.DAL.Concrete.EntityFrameworkCore.Context
{
    public class PhonebookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=PhonebookDB;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonInfo> PersonInfo { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
