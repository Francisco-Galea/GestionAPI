using GestionAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionAPI.Infrastructure.Data
{
    public class GestionDbContext : DbContext
    {
        public GestionDbContext(DbContextOptions<GestionDbContext> options) : base (options)
        {
        }

        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductOrderEntity> ProductOrders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientEntity>(entity =>
            {
                entity.HasKey(c => c.ClientId);
                entity.Property(c => c.ClientName)
                      .IsRequired()
                      .HasMaxLength(60);
                entity.Property(c => c.ClientEmail)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.HasMany(c => c.Orders)
                      .WithOne(o => o.Client)
                      .HasForeignKey(o => o.ClientId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ProductEntity>(entity =>
            {
                entity.HasKey(p => p.ProductId);
                entity.Property(p => p.ProductName)
                      .IsRequired()
                      .HasMaxLength(256);
                entity.Property(p => p.ProductPrice)
                      .IsRequired()
                      .HasColumnType("decimal(18,2)");
                entity.HasMany(p => p.ProductOrders)
                      .WithOne(po => po.Product)
                      .HasForeignKey(po => po.ProductId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<OrderEntity>(entity =>
            {
                entity.HasKey(o => o.OrderId);
                entity.HasOne(o => o.Client)
                      .WithMany(c => c.Orders)
                      .HasForeignKey(o => o.ClientId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasMany(o => o.ProductOrders)
                      .WithOne(po => po.Order)
                      .HasForeignKey(po => po.OrderId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ProductOrderEntity>(entity =>
            {
                entity.HasKey(po => po.ProductOrderId);
                entity.HasOne(po => po.Product)
                      .WithMany(p => p.ProductOrders)
                      .HasForeignKey(po => po.ProductId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(po => po.Order)
                      .WithMany(o => o.ProductOrders)
                      .HasForeignKey(po => po.OrderId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.Property(po => po.Quantity)
                      .IsRequired();
                entity.Property(po => po.UnitaryPrice)
                      .HasColumnType("decimal(18,2)");
                entity.Property(po => po.IsOrderActive)
                      .HasDefaultValue(true);
                entity.Property(po => po.IsDeleted)
                      .HasDefaultValue(false);
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
