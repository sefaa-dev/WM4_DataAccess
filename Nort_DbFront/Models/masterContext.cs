using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Nort_DbFront.Models
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KafeBilgileri> KafeBilgileris { get; set; }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Katlar> Katlars { get; set; }
        public virtual DbSet<Masalar> Masalars { get; set; }
        public virtual DbSet<Siparisler> Siparislers { get; set; }
        public virtual DbSet<Universite> Universites { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8M7D7GE;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<KafeBilgileri>(entity =>
            {
                entity.HasKey(e => e.KafeId)
                    .HasName("PK__KafeBilg__9265357CB0315230");

                entity.ToTable("KafeBilgileri");

                entity.Property(e => e.KafeId).ValueGeneratedNever();

                entity.Property(e => e.KafeAdi)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.KafeLogo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.KatOlusturmaZamani)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => e.KategoriId)
                    .HasName("PK__Kategori__1782CC72D065679A");

                entity.ToTable("Kategoriler");

                entity.Property(e => e.KategoriId).ValueGeneratedNever();

                entity.Property(e => e.KategoriAciklama).HasMaxLength(70);

                entity.Property(e => e.KategoriAdi)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KategoriOlusturmaZamani)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KategoriResimYol).HasMaxLength(100);
            });

            modelBuilder.Entity<Katlar>(entity =>
            {
                entity.HasKey(e => e.KatId)
                    .HasName("PK__Katlar__04016A0A18EAA729");

                entity.ToTable("Katlar");

                entity.Property(e => e.KatId).ValueGeneratedNever();

                entity.Property(e => e.KatAdi)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.KatKod)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.KatOlusturmaZamani)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Kafe)
                    .WithMany(p => p.Katlars)
                    .HasForeignKey(d => d.KafeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Katlar__KafeId__16644E42");
            });

            modelBuilder.Entity<Masalar>(entity =>
            {
                entity.HasKey(e => e.MasaId)
                    .HasName("PK__Masalar__9F94EBF368625EC0");

                entity.ToTable("Masalar");

                entity.Property(e => e.MasaId).ValueGeneratedNever();

                entity.Property(e => e.MasaAdi)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MasaOlusturmaZamani)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Kat)
                    .WithMany(p => p.Masalars)
                    .HasForeignKey(d => d.KatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Masalar__KatId__1A34DF26");
            });

            modelBuilder.Entity<Siparisler>(entity =>
            {
                entity.HasKey(e => e.SiparisId)
                    .HasName("PK__Siparisl__C3F03BFD8FEF032E");

                entity.ToTable("Siparisler");

                entity.Property(e => e.SiparisId).ValueGeneratedNever();

                entity.Property(e => e.BirimFiyat).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SiparisOlusturmaZamani)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Masa)
                    .WithMany(p => p.Siparislers)
                    .HasForeignKey(d => d.MasaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Siparisle__MasaI__24B26D99");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Siparislers)
                    .HasForeignKey(d => d.UrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Siparisle__UrunI__25A691D2");
            });

            modelBuilder.Entity<Universite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("universite");

                entity.Property(e => e.Bolumler)
                    .HasMaxLength(50)
                    .HasColumnName("bolumler");

                entity.Property(e => e.Kademeler)
                    .HasMaxLength(50)
                    .HasColumnName("kademeler");

                entity.Property(e => e.Ogretmenler)
                    .HasMaxLength(50)
                    .HasColumnName("ogretmenler");

                entity.Property(e => e.OkulAdi)
                    .HasMaxLength(50)
                    .HasColumnName("okul_adi");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId)
                    .HasName("PK__Urunler__623D366B60D4F92E");

                entity.ToTable("Urunler");

                entity.Property(e => e.UrunId).ValueGeneratedNever();

                entity.Property(e => e.UrunAdi)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UrunFiyat).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.UrunOlusturmaZamani)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UrunResimYol).HasMaxLength(100);

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Urunlers)
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Urunler__Kategor__20E1DCB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
