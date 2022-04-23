using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchoolSystem.Models
{
    public partial class SchoolDataBaseContext : DbContext
    {
        public SchoolDataBaseContext()
        {
        }

        public SchoolDataBaseContext(DbContextOptions<SchoolDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Professor> Professors { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-A82GUJV; Database=SchoolDataBase; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ClassRoom)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.ToTable("professor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProfessorClass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfessorLastN)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfessorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfessorPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StudentEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentLastN)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentParent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentPhoneParent)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
