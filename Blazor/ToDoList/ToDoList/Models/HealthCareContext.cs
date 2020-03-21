using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ToDoList.Models
{
    public partial class HealthCareContext : DbContext
    {
        public HealthCareContext()
        {
        }

        public HealthCareContext(DbContextOptions<HealthCareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BagsGreski> BagsGreski { get; set; }
        public virtual DbSet<BagsGrupa> BagsGrupa { get; set; }
        public virtual DbSet<BagsKorisnik> BagsKorisnik { get; set; }
        public virtual DbSet<BagsPrevod> BagsPrevod { get; set; }
        public virtual DbSet<BagsPrivilegiiForm> BagsPrivilegiiForm { get; set; }
        public virtual DbSet<BagsPrivilegiiMeni> BagsPrivilegiiMeni { get; set; }
        public virtual DbSet<BagsRecnik> BagsRecnik { get; set; }
        public virtual DbSet<BagsSinhro> BagsSinhro { get; set; }
        public virtual DbSet<ONaodH> ONaodH { get; set; }
        public virtual DbSet<ONaodS> ONaodS { get; set; }
        public virtual DbSet<OPacient> OPacient { get; set; }
        public virtual DbSet<OPacientOVraboten> OPacientOVraboten { get; set; }
        public virtual DbSet<OPrivilegii> OPrivilegii { get; set; }
        public virtual DbSet<OSmetkaH> OSmetkaH { get; set; }
        public virtual DbSet<OSmetkaS> OSmetkaS { get; set; }
        public virtual DbSet<OUplata> OUplata { get; set; }
        public virtual DbSet<OUplataTip> OUplataTip { get; set; }
        public virtual DbSet<OUslugaH> OUslugaH { get; set; }
        public virtual DbSet<OUslugaS> OUslugaS { get; set; }
        public virtual DbSet<OVraboten> OVraboten { get; set; }
        public virtual DbSet<OVrabotenOPrivilegii> OVrabotenOPrivilegii { get; set; }
        public virtual DbSet<OVrabotenOUslugaH> OVrabotenOUslugaH { get; set; }
        public virtual DbSet<OZakazuvanje> OZakazuvanje { get; set; }
        public virtual DbSet<ROpstina> ROpstina { get; set; }
        public virtual DbSet<RStil> RStil { get; set; }
        public virtual DbSet<RZemja> RZemja { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=HealthCare;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BagsGreski>(entity =>
            {
                entity.ToTable("bagsGreski");

                entity.Property(e => e.BagsGreskiId).HasColumnName("bagsGreski_Id");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Procedura)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tip)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BagsGrupa>(entity =>
            {
                entity.ToTable("bagsGrupa");

                entity.Property(e => e.BagsGrupaId).HasColumnName("bagsGrupa_Id");

                entity.Property(e => e.Kod).HasMaxLength(50);

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr).HasMaxLength(100);
            });

            modelBuilder.Entity<BagsKorisnik>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("bagsKorisnik");

                entity.Property(e => e.BagsGrupaId).HasColumnName("bagsGrupa_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(101);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<BagsPrevod>(entity =>
            {
                entity.ToTable("bagsPrevod");

                entity.Property(e => e.BagsPrevodId).HasColumnName("bagsPrevod_Id");

                entity.Property(e => e.Cmng)
                    .HasColumnName("CMng")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Eng)
                    .HasColumnName("ENG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Form)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Grid)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mak)
                    .HasColumnName("MAK")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("Object Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ok)
                    .HasColumnName("OK")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Shq)
                    .HasColumnName("SHQ")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Table)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BagsPrivilegiiForm>(entity =>
            {
                entity.ToTable("bagsPrivilegiiForm");

                entity.Property(e => e.BagsPrivilegiiFormId).HasColumnName("bagsPrivilegiiForm_Id");

                entity.Property(e => e.AssemblyFile)
                    .IsRequired()
                    .HasColumnName("Assembly_File")
                    .HasMaxLength(200);

                entity.Property(e => e.BagsGrupaId).HasColumnName("bagsGrupa_Id");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BagsPrivilegiiMeni>(entity =>
            {
                entity.ToTable("bagsPrivilegiiMeni");

                entity.Property(e => e.BagsPrivilegiiMeniId).HasColumnName("bagsPrivilegiiMeni_Id");

                entity.Property(e => e.BagsGrupaId).HasColumnName("bagsGrupa_Id");

                entity.Property(e => e.MeniId)
                    .IsRequired()
                    .HasColumnName("Meni_Id")
                    .HasMaxLength(200);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BagsRecnik>(entity =>
            {
                entity.ToTable("bagsRecnik");

                entity.Property(e => e.Eng).HasMaxLength(4000);

                entity.Property(e => e.Gre).HasMaxLength(4000);

                entity.Property(e => e.Key).HasMaxLength(4000);

                entity.Property(e => e.Mak).HasMaxLength(4000);

                entity.Property(e => e.Shq).HasMaxLength(4000);

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SysDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SysUsr).HasMaxLength(100);
            });

            modelBuilder.Entity<BagsSinhro>(entity =>
            {
                entity.ToTable("bagsSinhro");

                entity.Property(e => e.BagsSinhroId).HasColumnName("bagsSinhro_Id");

                entity.Property(e => e.BagsGrupaId).HasColumnName("bagsGrupa_Id");

                entity.Property(e => e.BagsKorisnikId).HasColumnName("bagsKorisnik_Id");

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr).HasMaxLength(50);

                entity.Property(e => e.Tip).HasMaxLength(20);
            });

            modelBuilder.Entity<ONaodH>(entity =>
            {
                entity.ToTable("oNaodH");

                entity.Property(e => e.ONaodHId).HasColumnName("oNaodH_Id");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.NaodBroj)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OPacientId).HasColumnName("oPacient_Id");

                entity.Property(e => e.OUslugaHId).HasColumnName("oUslugaH_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ZaklucilOVrabotenId).HasColumnName("Zaklucil_oVraboten_Id");

                entity.HasOne(d => d.OPacient)
                    .WithMany(p => p.ONaodH)
                    .HasForeignKey(d => d.OPacientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oNaodH_oPacient");

                entity.HasOne(d => d.OUslugaH)
                    .WithMany(p => p.ONaodH)
                    .HasForeignKey(d => d.OUslugaHId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oNaodH_oUslugaH");
            });

            modelBuilder.Entity<ONaodS>(entity =>
            {
                entity.ToTable("oNaodS");

                entity.Property(e => e.ONaodSId).HasColumnName("oNaodS_Id");

                entity.Property(e => e.Informacija)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ONaodHId).HasColumnName("oNaodH_Id");

                entity.Property(e => e.OUslugaSId).HasColumnName("oUslugaS_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Zabeleska)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.ONaodH)
                    .WithMany(p => p.ONaodS)
                    .HasForeignKey(d => d.ONaodHId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oNaodS_oNaodH");

                entity.HasOne(d => d.OUslugaS)
                    .WithMany(p => p.ONaodS)
                    .HasForeignKey(d => d.OUslugaSId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oNaodS_oUslugaS");
            });

            modelBuilder.Entity<OPacient>(entity =>
            {
                entity.ToTable("oPacient");

                entity.Property(e => e.OPacientId).HasColumnName("oPacient_Id");

                entity.Property(e => e.Adresa).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KartonBroj)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KategorijaZo).HasColumnName("KategorijaZO");

                entity.Property(e => e.KniskaBroj).HasMaxLength(20);

                entity.Property(e => e.MaticenBroj).HasMaxLength(20);

                entity.Property(e => e.PasosBroj).HasMaxLength(20);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Profesija).HasMaxLength(100);

                entity.Property(e => e.ROpstinaId).HasColumnName("rOpstina_Id");

                entity.Property(e => e.RZemjaId).HasColumnName("rZemja_Id");

                entity.Property(e => e.RadjanjeDatum).HasColumnType("datetime");

                entity.Property(e => e.Sport).HasMaxLength(100);

                entity.Property(e => e.SportskiKlub).HasMaxLength(100);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TatkovoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.Property(e => e.Zabeleska).HasMaxLength(1000);

                entity.Property(e => e.ZdravstvenBroj).HasMaxLength(20);

                entity.HasOne(d => d.ROpstina)
                    .WithMany(p => p.OPacient)
                    .HasForeignKey(d => d.ROpstinaId)
                    .HasConstraintName("FK_oPacient_rOpstina");

                entity.HasOne(d => d.RZemja)
                    .WithMany(p => p.OPacient)
                    .HasForeignKey(d => d.RZemjaId)
                    .HasConstraintName("FK_oPacient_rZemja");
            });

            modelBuilder.Entity<OPacientOVraboten>(entity =>
            {
                entity.ToTable("oPacient_oVraboten");

                entity.Property(e => e.OPacientOVrabotenId).HasColumnName("oPacient_oVraboten_Id");

                entity.Property(e => e.OPacientId).HasColumnName("oPacient_Id");

                entity.Property(e => e.OVrabotenId).HasColumnName("oVraboten_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.OPacient)
                    .WithMany(p => p.OPacientOVraboten)
                    .HasForeignKey(d => d.OPacientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oPacient_oVraboten_oPacient");

                entity.HasOne(d => d.OVraboten)
                    .WithMany(p => p.OPacientOVraboten)
                    .HasForeignKey(d => d.OVrabotenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oPacient_oVraboten_oVraboten");
            });

            modelBuilder.Entity<OPrivilegii>(entity =>
            {
                entity.ToTable("oPrivilegii");

                entity.Property(e => e.OPrivilegiiId).HasColumnName("oPrivilegii_id");

                entity.Property(e => e.Grupa).HasMaxLength(50);

                entity.Property(e => e.Kluc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OSmetkaH>(entity =>
            {
                entity.ToTable("oSmetkaH");

                entity.Property(e => e.OSmetkaHId).HasColumnName("oSmetkaH_Id");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.FPecateno).HasColumnName("f_Pecateno");

                entity.Property(e => e.OPacientId).HasColumnName("oPacient_Id");

                entity.Property(e => e.Popust).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.SmetkaBroj)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.OPacient)
                    .WithMany(p => p.OSmetkaH)
                    .HasForeignKey(d => d.OPacientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oSmetkaH_oPacient");
            });

            modelBuilder.Entity<OSmetkaS>(entity =>
            {
                entity.ToTable("oSmetkaS");

                entity.Property(e => e.OSmetkaSId).HasColumnName("oSmetkaS_Id");

                entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ONaodHId).HasColumnName("oNaodH_Id");

                entity.Property(e => e.OSmetkaHId).HasColumnName("oSmetkaH_Id");

                entity.Property(e => e.OUslugaHId).HasColumnName("oUslugaH_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.OSmetkaH)
                    .WithMany(p => p.OSmetkaS)
                    .HasForeignKey(d => d.OSmetkaHId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oSmetkaS_oSmetkaH");
            });

            modelBuilder.Entity<OUplata>(entity =>
            {
                entity.ToTable("oUplata");

                entity.Property(e => e.OUplataId).HasColumnName("oUplata_Id");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OSmetkaHId).HasColumnName("oSmetkaH_Id");

                entity.Property(e => e.OUplataTipId).HasColumnName("oUplataTip_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.OSmetkaH)
                    .WithMany(p => p.OUplata)
                    .HasForeignKey(d => d.OSmetkaHId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oUplata_oSmetkaH");

                entity.HasOne(d => d.OUplataTip)
                    .WithMany(p => p.OUplata)
                    .HasForeignKey(d => d.OUplataTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oUplata_oUplataTip");
            });

            modelBuilder.Entity<OUplataTip>(entity =>
            {
                entity.ToTable("oUplataTip");

                entity.Property(e => e.OUplataTipId).HasColumnName("oUplataTip_Id");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OUslugaH>(entity =>
            {
                entity.ToTable("oUslugaH");

                entity.Property(e => e.OUslugaHId).HasColumnName("oUslugaH_Id");

                entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DostapniDenovi)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.DostapnostDo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DostapnostOd)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RStilId).HasColumnName("rStil_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.RStil)
                    .WithMany(p => p.OUslugaH)
                    .HasForeignKey(d => d.RStilId)
                    .HasConstraintName("FK_oUslugaH_rStil");
            });

            modelBuilder.Entity<OUslugaS>(entity =>
            {
                entity.ToTable("oUslugaS");

                entity.Property(e => e.OUslugaSId).HasColumnName("oUslugaS_Id");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OUslugaHId).HasColumnName("oUslugaH_Id");

                entity.Property(e => e.OUslugaHzId).HasColumnName("oUslugaHZ_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.OUslugaH)
                    .WithMany(p => p.OUslugaS)
                    .HasForeignKey(d => d.OUslugaHId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oUslugaS_oUslugaH");
            });

            modelBuilder.Entity<OVraboten>(entity =>
            {
                entity.ToTable("oVraboten");

                entity.Property(e => e.OVrabotenId).HasColumnName("oVraboten_Id");

                entity.Property(e => e.BagsGrupaId).HasColumnName("bagsGrupa_Id");

                entity.Property(e => e.BagsKorisnikId).HasColumnName("bagsKorisnik_Id");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Zvanje)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OVrabotenOPrivilegii>(entity =>
            {
                entity.ToTable("oVraboten_oPrivilegii");

                entity.Property(e => e.OVrabotenOPrivilegiiId).HasColumnName("oVraboten_oPrivilegii_id");

                entity.Property(e => e.OPrivilegiiId).HasColumnName("oPrivilegii_Id");

                entity.Property(e => e.OVrabotenId).HasColumnName("oVraboten_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.OPrivilegii)
                    .WithMany(p => p.OVrabotenOPrivilegii)
                    .HasForeignKey(d => d.OPrivilegiiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oVraboten_oPrivilegii_oPrivilegii");

                entity.HasOne(d => d.OVraboten)
                    .WithMany(p => p.OVrabotenOPrivilegii)
                    .HasForeignKey(d => d.OVrabotenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oVraboten_oPrivilegii_oVraboten");
            });

            modelBuilder.Entity<OVrabotenOUslugaH>(entity =>
            {
                entity.ToTable("oVraboten_oUslugaH");

                entity.Property(e => e.OVrabotenOUslugaHId).HasColumnName("oVraboten_oUslugaH_Id");

                entity.Property(e => e.OUslugaHId).HasColumnName("oUslugaH_Id");

                entity.Property(e => e.OVrabotenId).HasColumnName("oVraboten_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.OVraboten)
                    .WithMany(p => p.OVrabotenOUslugaH)
                    .HasForeignKey(d => d.OVrabotenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oVraboten_oUslugaH_oVraboten");
            });

            modelBuilder.Entity<OZakazuvanje>(entity =>
            {
                entity.ToTable("oZakazuvanje");

                entity.Property(e => e.OZakazuvanjeId).HasColumnName("oZakazuvanje_Id");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Dijagnoza).HasMaxLength(4000);

                entity.Property(e => e.Kluc).HasMaxLength(20);

                entity.Property(e => e.OPacientId).HasColumnName("oPacient_Id");

                entity.Property(e => e.OUslugaHId).HasColumnName("oUslugaH_Id");

                entity.Property(e => e.OVrabotenId).HasColumnName("oVraboten_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Zabeleska).HasMaxLength(4000);

                entity.HasOne(d => d.OPacient)
                    .WithMany(p => p.OZakazuvanje)
                    .HasForeignKey(d => d.OPacientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_oZakazuvanje_oPacient");

                entity.HasOne(d => d.OVraboten)
                    .WithMany(p => p.OZakazuvanje)
                    .HasForeignKey(d => d.OVrabotenId)
                    .HasConstraintName("FK_oZakazuvanje_oVraboten");
            });

            modelBuilder.Entity<ROpstina>(entity =>
            {
                entity.ToTable("rOpstina");

                entity.Property(e => e.ROpstinaId).HasColumnName("rOpstina_id");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv2).HasMaxLength(50);

                entity.Property(e => e.RZemjaId).HasColumnName("rZemja_Id");

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Zname).HasColumnType("image");

                entity.HasOne(d => d.RZemja)
                    .WithMany(p => p.ROpstina)
                    .HasForeignKey(d => d.RZemjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rOpstina_rZemja");
            });

            modelBuilder.Entity<RStil>(entity =>
            {
                entity.ToTable("rStil");

                entity.Property(e => e.RStilId).HasColumnName("rStil_Id");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StilBoja)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StilFont)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RZemja>(entity =>
            {
                entity.ToTable("rZemja");

                entity.Property(e => e.RZemjaId).HasColumnName("rZemja_id");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Naziv2).HasMaxLength(100);

                entity.Property(e => e.SysDt).HasColumnType("datetime");

                entity.Property(e => e.SysUsr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Zname).HasColumnType("image");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
