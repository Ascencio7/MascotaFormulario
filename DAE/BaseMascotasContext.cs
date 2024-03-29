using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Formulario_Mascotas.DAE;

public partial class BaseMascotasContext : DbContext
{
    public BaseMascotasContext()
    {
    }

    public BaseMascotasContext(DbContextOptions<BaseMascotasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DatosMascota> DatosMascotas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-E4D98NB\\SQLEXPRESS; Initial Catalog= BaseMascotas; Integrated Security= True; Encrypt= False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DatosMascota>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DatosMas__3214EC27A784928B");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Raza)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
