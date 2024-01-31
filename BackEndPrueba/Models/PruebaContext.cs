using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackEndPrueba.Models;

public partial class PruebaContext : DbContext
{
    public PruebaContext()
    {
    }

    public PruebaContext(DbContextOptions<PruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
#warning

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCg).HasName("PK__cargos__00B7DEF2660CBF10");

            entity.ToTable("cargos");

            entity.Property(e => e.IdCg)
                .ValueGeneratedNever()
                .HasColumnName("id_cg");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CodigoCg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo_cg");
            entity.Property(e => e.IdUsuarioCreacionCg).HasColumnName("idUsuarioCreacion_cg");
            entity.Property(e => e.NombreCg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_cg");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDep).HasName("PK__departam__D5EA635C759077A0");

            entity.ToTable("departamentos");

            entity.Property(e => e.IdDep)
                .ValueGeneratedNever()
                .HasColumnName("id_dep");
            entity.Property(e => e.ActivoDep).HasColumnName("activo_dep");
            entity.Property(e => e.CodigoDep)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codigo_dep");
            entity.Property(e => e.IdUsuarioCreacionDep).HasColumnName("idUsuarioCreacion_dep");
            entity.Property(e => e.NombreDep)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_dep");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UsuarioUs).HasName("PK__users__2ED10B7FD9BB8EED");

            entity.ToTable("users");

            entity.Property(e => e.UsuarioUs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("usuario_us");
            entity.Property(e => e.IdCargoUs).HasColumnName("idCargo_us");
            entity.Property(e => e.IdDepartamentoUs).HasColumnName("idDepartamento_us");
            entity.Property(e => e.PrimerApellidoUs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("primerApellido_us");
            entity.Property(e => e.PrimerNombreUs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("primerNombre_us");
            entity.Property(e => e.SegundoApellidoUs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("segundoApellido_us");
            entity.Property(e => e.SegundoNombreUs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("segundoNombre_us");

            entity.HasOne(d => d.IdCargoUsNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdCargoUs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__users__idCargo_u__4E88ABD4");

            entity.HasOne(d => d.IdDepartamentoUsNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdDepartamentoUs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__users__idDeparta__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
