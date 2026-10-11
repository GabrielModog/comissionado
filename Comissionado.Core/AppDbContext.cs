using Comissionado.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Comissionado.Core;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("FileName=comissionado.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movimentacao>().ToTable("Movimentacao");
        modelBuilder.Entity<Movimentacao>(entity =>
        {
            entity.HasKey(x => x.Id);
        });
        base.OnModelCreating(modelBuilder);
    }
}