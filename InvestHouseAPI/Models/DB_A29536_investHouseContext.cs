using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InvestHouseAPI.Models
{
    public partial class DB_A29536_investHouseContext : DbContext
    {
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Investments> Investments { get; set; }
        public virtual DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source = sql6003.smarterasp.net; Initial Catalog = DB_A29536_investHouse; User Id = DB_A29536_investHouse_admin; Password = k92gjdftyvqyzqyz;");
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

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("date");

                entity.Property(e => e.MenuName)
                    .HasColumnName("menuName")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderNumber).HasColumnName("orderNumber");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Investments>(entity =>
            {
                entity.ToTable("investments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DescriptionUa)
                    .HasColumnName("descriptionUa")
                    .HasMaxLength(1000);

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(250);

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.NameUa)
                    .HasColumnName("nameUa")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("news");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("date");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(250);

                entity.Property(e => e.SiteId).HasColumnName("siteID");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(1000);

                entity.Property(e => e.TextUa)
                    .HasColumnName("textUa")
                    .HasMaxLength(1000);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200);

                entity.Property(e => e.TitleUa)
                    .HasColumnName("titleUa")
                    .HasMaxLength(200);
            });
        }
    }
}