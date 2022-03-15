using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace BooksDB.Models
{

    public class BookContext : DbContext
    {
        public DbSet<BooksModel> Books {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlite(@"Data Source=books.db");
        
            
       
    }


}