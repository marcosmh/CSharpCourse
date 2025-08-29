using System;
using System.Collections.Generic;
using BD.Models;
using Microsoft.EntityFrameworkCore;

namespace BD.Data;

public partial class CsharpContext : DbContext
{
    public CsharpContext()
    {
    }

    public CsharpContext(DbContextOptions<CsharpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Beer> Beers { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=CsharpBD;User=sa;Password=Admindba$;Encrypt=False;");
    */

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            //optionsBuilder.UseSqlServer("Server=localhost;Database=CsharpBD;User=sa;Password=Admindba$;Encrypt=False;");
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Beer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Beer_PK");

            entity.ToTable("Beer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            
            entity.HasOne(d => d.Brand).WithMany(p => p.InverseBrand)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("Beer_Beer_FK");
           
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Brand_PK");

            entity.ToTable("Brand");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
