using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SlavVVar.Models
{
    public partial class SlavVVarContext : DbContext
    {
        public SlavVVarContext()
        {
        }

        public SlavVVarContext(DbContextOptions<SlavVVarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mapa> Mapa { get; set; }
        public virtual DbSet<PoziomyBudynkow> PoziomyBudynkow { get; set; }
        public virtual DbSet<Surowce> Surowce { get; set; }
        public virtual DbSet<UserData> UserData { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Wojska> Wojska { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-KG79SGE\\SQLEXPRESS;Database=SlavVVar;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mapa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PoziomyBudynkow>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Budynek0).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek1).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek2).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek3).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek4).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek5).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek6).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek7).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek8).HasDefaultValueSql("((1))");

                entity.Property(e => e.Budynek9).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PoziomyBudynkow)
                    .HasForeignKey<PoziomyBudynkow>(x => x.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoziomyBudynkow_Users");
            });

            modelBuilder.Entity<Surowce>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Surowce)
                    .HasForeignKey<Surowce>(x => x.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Surowce_Users");
            });

            modelBuilder.Entity<UserData>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.UserData)
                    .HasForeignKey<UserData>(x => x.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserData_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password).IsRequired();
            });

            modelBuilder.Entity<Wojska>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Wojska)
                    .HasForeignKey<Wojska>(x => x.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wojska_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
