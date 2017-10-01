using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InvestHouseAPI.Models
{
    public partial class DB_A29536_investHouseContext : DbContext
    {
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<GeneralSettings> GeneralSettings { get; set; }
        public virtual DbSet<HouseFiles> HouseFiles { get; set; }
        public virtual DbSet<HouseGallery> HouseGallery { get; set; }
        public virtual DbSet<HouseMapping> HouseMapping { get; set; }
        public virtual DbSet<HouseMappingMarker> HouseMappingMarker { get; set; }
        public virtual DbSet<Houses> Houses { get; set; }
        public virtual DbSet<Investments> Investments { get; set; }
        public virtual DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=sql6003.smarterasp.net; Initial Catalog = DB_A29536_investHouse; User Id = DB_A29536_investHouse_admin; Password = k92gjdftyvqyzqyz;");
            }
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

                entity.Property(e => e.SiteId).HasColumnName("siteId");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<GeneralSettings>(entity =>
            {
                entity.ToTable("generalSettings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(500);

                entity.Property(e => e.BackgroundImage)
                    .HasColumnName("backgroundImage")
                    .HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(500);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(500);

                entity.Property(e => e.IntroButtonBgColor)
                    .HasColumnName("introButtonBgColor")
                    .HasMaxLength(50);

                entity.Property(e => e.IntroButtonColor)
                    .HasColumnName("introButtonColor")
                    .HasMaxLength(50);

                entity.Property(e => e.IntroButtonFontColor)
                    .HasColumnName("introButtonFontColor")
                    .HasMaxLength(50);

                entity.Property(e => e.IntroButtonText)
                    .HasColumnName("introButtonText")
                    .HasMaxLength(50);

                entity.Property(e => e.IntroButtonTextFont)
                    .HasColumnName("introButtonTextFont")
                    .HasMaxLength(100);

                entity.Property(e => e.IntroHeading)
                    .HasColumnName("introHeading")
                    .HasMaxLength(500);

                entity.Property(e => e.IntroHeadingColor)
                    .HasColumnName("introHeadingColor")
                    .HasMaxLength(50);

                entity.Property(e => e.IntroHeadingFont)
                    .HasColumnName("introHeadingFont")
                    .HasMaxLength(100);

                entity.Property(e => e.IntroLeadIn)
                    .HasColumnName("introLeadIn")
                    .HasMaxLength(500);

                entity.Property(e => e.IntroLeadInColor)
                    .HasColumnName("introLeadInColor")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.IntroLeadInFont)
                    .HasColumnName("introLeadInFont")
                    .HasColumnType("nchar(100)");

                entity.Property(e => e.Phones)
                    .HasColumnName("phones")
                    .HasMaxLength(500);

                entity.Property(e => e.Skype)
                    .HasColumnName("skype")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<HouseFiles>(entity =>
            {
                entity.ToTable("houseFiles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HouseId).HasColumnName("houseId");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(500);

                entity.Property(e => e.Preview).HasColumnName("preview");

                entity.Property(e => e.SiteId).HasColumnName("siteId");
            });

            modelBuilder.Entity<HouseGallery>(entity =>
            {
                entity.ToTable("houseGallery");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HouseId).HasColumnName("houseId");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(500);

                entity.Property(e => e.SiteId).HasColumnName("siteId");
            });

            modelBuilder.Entity<HouseMapping>(entity =>
            {
                entity.ToTable("houseMapping");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.IsOneImage).HasColumnName("isOneImage");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.SiteId).HasColumnName("siteId");
            });

            modelBuilder.Entity<HouseMappingMarker>(entity =>
            {
                entity.ToTable("houseMappingMarker");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HouseId).HasColumnName("houseId");

                entity.Property(e => e.ImageLink)
                    .HasColumnName("imageLink")
                    .HasMaxLength(500);

                entity.Property(e => e.MapId).HasColumnName("mapId");

                entity.Property(e => e.XMarker).HasColumnName("xMarker");

                entity.Property(e => e.YMarker).HasColumnName("yMarker");
            });

            modelBuilder.Entity<Houses>(entity =>
            {
                entity.ToTable("houses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaPrice)
                    .HasColumnName("areaPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaSquare)
                    .HasColumnName("areaSquare")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.HousePrice)
                    .HasColumnName("housePrice")
                    .HasMaxLength(50);

                entity.Property(e => e.HouseSqaure)
                    .HasColumnName("houseSqaure")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkerNumber)
                    .HasColumnName("markerNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(50);

                entity.Property(e => e.SiteId).HasColumnName("siteId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("totalPrice")
                    .HasMaxLength(50);
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
                    .HasColumnType("datetime");

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
