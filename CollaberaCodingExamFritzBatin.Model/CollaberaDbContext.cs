using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CollaberaCodingExamFritzBatin.Model;

public partial class CollaberaDbContext : DbContext
{
    public CollaberaDbContext()
    {
    }

    public CollaberaDbContext(DbContextOptions<CollaberaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CityTbl> CityTbls { get; set; }

    public virtual DbSet<CourseTbl> CourseTbls { get; set; }

    public virtual DbSet<DegreeTypeTbl> DegreeTypeTbls { get; set; }

    public virtual DbSet<GenderTbl> GenderTbls { get; set; }

    public virtual DbSet<StudentTbl> StudentTbls { get; set; }

    public virtual DbSet<SubjectTbl> SubjectTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=CollaberaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CityTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("City_tbl");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CourseTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Course_tbl");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DegreeTypeTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DegreeType_tbl");

            entity.Property(e => e.Degree)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GenderTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Gender_tbl");

            entity.Property(e => e.GenderName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<StudentTbl>(entity =>
        {
            entity
                //.HasNoKey()
                .ToTable("Student_tbl");

            entity.Property(e => e.CityId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubjectTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Subject_tbl");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
