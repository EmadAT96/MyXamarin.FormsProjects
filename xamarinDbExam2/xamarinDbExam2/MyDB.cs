using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace xamarinDbExam2
{
    public class MyDB : DbContext
    {
        public DbSet<Person> MyPerson { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            string dbFileName = "persons.db";
            string fullDbPath = dbFileName;
            fullDbPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), dbFileName);
            optionsBuilder.UseSqlite($"Filename={fullDbPath}", x => x.SuppressForeignKeyEnforcement());
            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
