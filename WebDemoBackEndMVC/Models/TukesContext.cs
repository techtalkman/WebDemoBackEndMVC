using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebDemoBackEndMVC.Models
{
    public partial class TukesContext : DbContext
    {
        public TukesContext()
        {
        }

        public TukesContext(DbContextOptions<TukesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Myyntikiellot> Myyntikiellot { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:codebootcamp2.database.windows.net,1433;Initial Catalog=Tukes;Persist Security Info=False;User ID=tukesadmin;Password=TamaVastaVa1k3a0n#2019;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Myyntikiellot>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Asiakirjat)
                    .HasColumnName("asiakirjat")
                    .HasColumnType("text");

                entity.Property(e => e.JulkaisuPvm)
                    .HasColumnName("julkaisu_pvm")
                    .HasColumnType("date");

                entity.Property(e => e.Malli)
                    .HasColumnName("malli")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MuutTiedot)
                    .HasColumnName("muut_tiedot")
                    .HasColumnType("text");

                entity.Property(e => e.Nimike)
                    .HasColumnName("nimike")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Paatos)
                    .HasColumnName("paatos")
                    .HasColumnType("text");

                entity.Property(e => e.Puutteet)
                    .HasColumnName("puutteet")
                    .HasColumnType("text");

                entity.Property(e => e.TapauksenKuvat)
                    .HasColumnName("tapauksen_kuvat")
                    .HasColumnType("text");

                entity.Property(e => e.TapausTulos)
                    .HasColumnName("tapaus_tulos")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tapausnumero)
                    .HasColumnName("tapausnumero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeknisetArvot)
                    .HasColumnName("tekniset_arvot")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TuotePaaryhmaNimi)
                    .HasColumnName("tuote_paaryhma_nimi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tuotenimi)
                    .HasColumnName("tuotenimi")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vaaranlaji)
                    .HasColumnName("vaaranlaji")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vastuutaho)
                    .HasColumnName("vastuutaho")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Viivakoodi)
                    .HasColumnName("viivakoodi")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
