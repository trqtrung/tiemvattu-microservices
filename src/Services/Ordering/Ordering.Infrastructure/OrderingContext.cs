using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Ordering.Infrastructure
{
    public class OrderingContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "ordering";
        public DbSet<Order> Orders { get; set; }
    }
}
