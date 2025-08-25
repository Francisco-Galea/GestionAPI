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
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<OrderStateEntity> OrderStates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientEntity>()
                .HasOne(c => c.CreatedBy)
                .WithMany(u => u.Clients)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderEntity>()
                .HasOne(o => o.CreatedBy)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductEntity>()
                .HasOne(p => p.CreatedBy)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderStateEntity>()
                .HasOne(os => os.CreatedBy)
                .WithMany(u => u.OrderStates)
                .HasForeignKey(os => os.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderEntity>()
                .HasOne(o => o.Client)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderEntity>()
                .HasOne(o => o.OrderState)
                .WithMany(os => os.Orders)
                .HasForeignKey(o => o.OrderStateId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductOrderEntity>()
                .HasOne(po => po.Product)
                .WithMany(p => p.ProductOrders)
                .HasForeignKey(po => po.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductOrderEntity>()
                .HasOne(po => po.Order)
                .WithMany(o => o.ProductOrders)
                .HasForeignKey(po => po.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductOrderEntity>()
                .HasKey(po => new { po.ProductId, po.OrderId });

            base.OnModelCreating(modelBuilder);
        }

    }
}
