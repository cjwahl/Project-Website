using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyProject_Website.Models
{
    [Table("Patrons")]
    public class Patron
    {
           [Key]
        public int ID { get; set; }

        public int LibraryNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Genre { get; set; }
    }

    public class Dbconnection : DbContext
    {
        public DbSet<Patron> Patrons { get; set; }
    }
}
    }
}