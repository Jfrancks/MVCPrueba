using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCPrueba.Models
{
    public partial class TiendaBDContext : DbContext
    {
        public TiendaBDContext()
        {
        }

        public TiendaBDContext(DbContextOptions<TiendaBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-D5QD68I\\SQLEXPRESS;Database=TiendaBD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Producto__sucurs__3B75D760");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Producto__tipo_i__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
