using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConnectMySql.Models;

public partial class LineBotApiPracticeContext : DbContext
{
    public LineBotApiPracticeContext()
    {
    }

    public LineBotApiPracticeContext(DbContextOptions<LineBotApiPracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Linebot> Linebots { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Linebot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("linebot");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Major)
                .HasMaxLength(20)
                .HasColumnName("major");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
