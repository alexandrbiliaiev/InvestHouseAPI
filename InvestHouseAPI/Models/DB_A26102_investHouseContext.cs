using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InvestHouseAPI.Models
{
    public partial class DB_A26102_investHouseContext : DbContext
    {
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Investments> Investments { get; set; }
        public virtual DbSet<Sites> Sites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source = SQL6002.SmarterASP.NET; Initial Catalog = DB_A26102_investHouse; User Id = DB_A26102_investHouse_admin; Password = k92gjdftyv;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("content");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("text");

                entity.Property(e => e.BodyUa)
                    .HasColumnName("bodyUA")
                    .HasColumnType("text");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("date");

                entity.Property(e => e.MenuName)
                    .HasColumnName("menuName")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.MenuNameUa)
                    .HasColumnName("menuNameUA")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.OrderNumber).HasColumnName("orderNumber");

                entity.Property(e => e.SiteId).HasColumnName("siteId");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TitleUa)
                    .HasColumnName("titleUA")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Investments>(entity =>
            {
                entity.ToTable("investments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DescriptionUa)
                    .HasColumnName("DescriptionUA")
                    .HasMaxLength(1000);

                entity.Property(e => e.Logo).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameUa)
                    .HasColumnName("NameUA")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Sites>(entity =>
            {
                entity.ToTable("sites");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(100)");
            });
        }
    }
}