﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mma_database_project.Models.DataLayer;

public partial class MMABooksContext : DbContext
{
    public MMABooksContext()
    {
    }

    public MMABooksContext(DbContextOptions<MMABooksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }

    public virtual DbSet<OrderOption> OrderOptions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<State> States { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\c#\\MMABooks.mdf;Integrated security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.Rowversion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.ZipCode).IsFixedLength();

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Customers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_States");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasOne(d => d.Customer).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_Customers");
        });

        modelBuilder.Entity<InvoiceLineItem>(entity =>
        {
            entity.Property(e => e.ProductCode).IsFixedLength();

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceLineItems).HasConstraintName("FK_InvoiceLineItems_Invoices");

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.InvoiceLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceLineItems_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductCode).IsFixedLength();
            entity.Property(e => e.Rowversion)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.Property(e => e.StateCode).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
