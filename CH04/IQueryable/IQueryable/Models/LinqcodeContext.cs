using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IQueryable.Models;

public partial class LinqcodeContext : DbContext
{
    public LinqcodeContext()
    {
    }

    public LinqcodeContext(DbContextOptions<LinqcodeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    {
        optionsBuilder.UseSqlServer("Server=.;Database=LINQCode;Trusted_Connection=True;TrustServerCertificate=True;")
         .LogTo(Console.WriteLine,
        new[] { Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuted },  // 只記錄 SQL 命令
        Microsoft.Extensions.Logging.LogLevel.Information,                                      // 只顯示資訊層級的日誌
        Microsoft.EntityFrameworkCore.Diagnostics.DbContextLoggerOptions.None);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC2758A67695");

            entity.ToTable("Student");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
