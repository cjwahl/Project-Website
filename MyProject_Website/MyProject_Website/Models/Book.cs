using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyProject_Website.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int ID { get; set; }

        public int ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }
    }

    public class Dbconnection : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}