using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstModel;
using System.Data.Entity;

namespace CodeFirstDataAccess
{
    public class BookEntityContext : DbContext
    {
        public BookEntityContext()
        : base("name=DbConnectionString")
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
