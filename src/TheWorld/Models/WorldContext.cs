using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace TheWorld.Models
{
  public class WorldContext : DbContext
  {
    public DbSet<Stop> Stops { get; set; }
    public DbSet<Trip> Trips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var connString = Startup.Configuration["Data:WorldContextConnection"];
      optionsBuilder.UseSqlServer(connString);


      base.OnConfiguring(optionsBuilder);
    }

  }
}
