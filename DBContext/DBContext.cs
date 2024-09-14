using Microsoft.EntityFrameworkCore;
public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options) { }
    public DbSet<ItemData> ItemDatas { get; set; }
    public DbSet<SaleData> SaleDatass { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ItemData>()
        .HasKey(id => id.ItemId);
    }
}