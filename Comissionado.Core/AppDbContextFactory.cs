using Microsoft.EntityFrameworkCore.Design;

namespace Comissionado.Core;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args) => new();
}