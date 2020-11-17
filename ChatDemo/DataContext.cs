using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChatDemo {
    public class DataContext : DbContext {
        public DataContext (DbContextOptions options) : base (options) { }

        public DbSet<Message> Messages { get; set; }
    }
}