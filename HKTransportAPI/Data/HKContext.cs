using Microsoft.EntityFrameworkCore;
using HKTransportAPI.Models;
using System.Collections.Generic;

namespace HKTransportAPI.Data
{
    public class HKContext : DbContext
    {
        public HKContext(DbContextOptions<HKContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
    }
}
