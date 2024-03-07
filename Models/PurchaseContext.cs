

using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class PurchaseContext : DbContext
{
    public PurchaseContext(DbContextOptions<PurchaseContext> options)
        : base(options)
    {
    }

    public DbSet<Purchase> Purchases { get; set; } = null!;
}