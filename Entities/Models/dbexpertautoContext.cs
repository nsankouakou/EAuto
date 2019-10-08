using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Models
{
    public partial class DbExpertAutoContext : DbContext
    {
        public DbExpertAutoContext()
        {
        }

        public DbExpertAutoContext(DbContextOptions<DbExpertAutoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Connexion> Connexion { get; set; }
        public virtual DbSet<Fonction> Fonction { get; set; }
        public virtual DbSet<Tbagent> Tbagent { get; set; }
        public virtual DbSet<Tbassurance> Tbassurance { get; set; }
        public virtual DbSet<TbautreRubrique> TbautreRubrique { get; set; }
        public virtual DbSet<Tbavance> Tbavance { get; set; }
        public virtual DbSet<Tbcarosserie> Tbcarosserie { get; set; }
        public virtual DbSet<Tbcommune> Tbcommune { get; set; }
        public virtual DbSet<Tbconclusion> Tbconclusion { get; set; }
        public virtual DbSet<TbconclusionGen> TbconclusionGen { get; set; }
        public virtual DbSet<Tbcouleur> Tbcouleur { get; set; }
        public virtual DbSet<Tbdiscussion> Tbdiscussion { get; set; }
        public virtual DbSet<Tbdossier> Tbdossier { get; set; }
        public virtual DbSet<TbdossierEtatRapport> TbdossierEtatRapport { get; set; }
        public virtual DbSet<TbdossierRubriqueHonoraire> TbdossierRubriqueHonoraire { get; set; }
        public virtual DbSet<TbdossierSortis> TbdossierSortis { get; set; }
        public virtual DbSet<Tbdroits> Tbdroits { get; set; }
        public virtual DbSet<Tbenergie> Tbenergie { get; set; }
        public virtual DbSet<TbetatRapport> TbetatRapport { get; set; }
        public virtual DbSet<Tbexpertise> Tbexpertise { get; set; }
        public virtual DbSet<TbexpertiseDepannagePointChoc> TbexpertiseDepannagePointChoc { get; set; }
        public virtual DbSet<TbexpertiseEtatRapport> TbexpertiseEtatRapport { get; set; }
        public virtual DbSet<TbexpertiseFourniturePointChoc> TbexpertiseFourniturePointChoc { get; set; }
        public virtual DbSet<TbexpertisePointChoc> TbexpertisePointChoc { get; set; }
        public virtual DbSet<TbexpertisePourRecousPointChoc> TbexpertisePourRecousPointChoc { get; set; }
        public virtual DbSet<TbexpertiseRubriqueConstatationPointChoc> TbexpertiseRubriqueConstatationPointChoc { get; set; }
        public virtual DbSet<TbexpertiseRubriqueEstimation> TbexpertiseRubriqueEstimation { get; set; }
        public virtual DbSet<TbexpertiseRubriqueMo> TbexpertiseRubriqueMo { get; set; }
        public virtual DbSet<TbexpertiseTravauxExterieurPointChoc> TbexpertiseTravauxExterieurPointChoc { get; set; }
        public virtual DbSet<TbexpertiseTypeNote> TbexpertiseTypeNote { get; set; }
        public virtual DbSet<Tbfacture> Tbfacture { get; set; }
        public virtual DbSet<Tbfourniture> Tbfourniture { get; set; }
        public virtual DbSet<Tbgarage> Tbgarage { get; set; }
        public virtual DbSet<Tbgenre> Tbgenre { get; set; }
        public virtual DbSet<Tbhabilitation> Tbhabilitation { get; set; }
        public virtual DbSet<TbmainOeuvre> TbmainOeuvre { get; set; }
        public virtual DbSet<TbmainOeuvrePointChoc> TbmainOeuvrePointChoc { get; set; }
        public virtual DbSet<Tbmarque> Tbmarque { get; set; }
        public virtual DbSet<TbmarqueCarrosserie> TbmarqueCarrosserie { get; set; }
        public virtual DbSet<Tbmenu> Tbmenu { get; set; }
        public virtual DbSet<TbmodeReglement> TbmodeReglement { get; set; }
        public virtual DbSet<Tbmodele> Tbmodele { get; set; }
        public virtual DbSet<TbnbreElement> TbnbreElement { get; set; }
        public virtual DbSet<TbnbreElementMainOeuvreTypePeinture> TbnbreElementMainOeuvreTypePeinture { get; set; }
        public virtual DbSet<Tbnote> Tbnote { get; set; }
        public virtual DbSet<TbparamHonoraire> TbparamHonoraire { get; set; }
        public virtual DbSet<Tbparametre> Tbparametre { get; set; }
        public virtual DbSet<Tbphoto> Tbphoto { get; set; }
        public virtual DbSet<TbpointChoc> TbpointChoc { get; set; }
        public virtual DbSet<TbpourRecours> TbpourRecours { get; set; }
        public virtual DbSet<Tbpreambule> Tbpreambule { get; set; }
        public virtual DbSet<TbpreambuleGen> TbpreambuleGen { get; set; }
        public virtual DbSet<TbpriseEnCharge> TbpriseEnCharge { get; set; }
        public virtual DbSet<Tbprofil> Tbprofil { get; set; }
        public virtual DbSet<Tbproprietaire> Tbproprietaire { get; set; }
        public virtual DbSet<TbrapportAcheve> TbrapportAcheve { get; set; }
        public virtual DbSet<TbrecapPrejudice> TbrecapPrejudice { get; set; }
        public virtual DbSet<Tbreglement> Tbreglement { get; set; }
        public virtual DbSet<Tbrembourssement> Tbrembourssement { get; set; }
        public virtual DbSet<TbrubriqueConstatation> TbrubriqueConstatation { get; set; }
        public virtual DbSet<TbrubriqueEstimation> TbrubriqueEstimation { get; set; }
        public virtual DbSet<TbrubriqueEvalExpertise> TbrubriqueEvalExpertise { get; set; }
        public virtual DbSet<TbrubriqueEvaluation> TbrubriqueEvaluation { get; set; }
        public virtual DbSet<TbrubriqueHonoraire> TbrubriqueHonoraire { get; set; }
        public virtual DbSet<TbrubriqueMainOeuvre> TbrubriqueMainOeuvre { get; set; }
        public virtual DbSet<Tbservice> Tbservice { get; set; }
        public virtual DbSet<Tbspecialite> Tbspecialite { get; set; }
        public virtual DbSet<TbspecialiteUser> TbspecialiteUser { get; set; }
        public virtual DbSet<TbtarifActif> TbtarifActif { get; set; }
        public virtual DbSet<TbtarifHoraire> TbtarifHoraire { get; set; }
        public virtual DbSet<TbtarifHoraireGarageMarque> TbtarifHoraireGarageMarque { get; set; }
        public virtual DbSet<TbtravauxExterieur> TbtravauxExterieur { get; set; }
        public virtual DbSet<Tbtva> Tbtva { get; set; }
        public virtual DbSet<TbtypGarage> TbtypGarage { get; set; }
        public virtual DbSet<TbtypPeintureTarifActifTarifHonoraireNbreElemnt> TbtypPeintureTarifActifTarifHonoraireNbreElemnt { get; set; }
        public virtual DbSet<TbtypTravauxMainOuvre> TbtypTravauxMainOuvre { get; set; }
        public virtual DbSet<TbtypeExpertise> TbtypeExpertise { get; set; }
        public virtual DbSet<TbtypeNote> TbtypeNote { get; set; }
        public virtual DbSet<TbtypePeinture> TbtypePeinture { get; set; }
        public virtual DbSet<TbtypeTravaux> TbtypeTravaux { get; set; }
        public virtual DbSet<TbtypeUser> TbtypeUser { get; set; }
        public virtual DbSet<TbtypeValeur> TbtypeValeur { get; set; }
        public virtual DbSet<TbtypeVehicule> TbtypeVehicule { get; set; }
        public virtual DbSet<Tbuser> Tbuser { get; set; }
        public virtual DbSet<TbuserDossier> TbuserDossier { get; set; }
        public virtual DbSet<Tbvehicule> Tbvehicule { get; set; }
        public virtual DbSet<TbvehiculeAssurance> TbvehiculeAssurance { get; set; }
        public virtual DbSet<Tbville> Tbville { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=ASC-PC123\\SQL2016;Database=DbExpertAuto;User Id=sa;Password=P@ssword;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Connexion>(entity =>
            {
                entity.Property(e => e.AdresseIpSource)
                    .HasColumnName("Adresse_IP_Source")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Bsucces).HasColumnName("BSUCCES");

                entity.Property(e => e.DateConnexion)
                    .HasColumnName("Date_Connexion")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastConnexion)
                    .HasColumnName("Date_LastConnexion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fonction>(entity =>
            {
                entity.HasKey(e => e.Fonctionid)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("FONCTION");

                entity.Property(e => e.Fonctionid)
                    .HasColumnName("FONCTIONID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Fonctionlibelle)
                    .HasColumnName("FONCTIONLIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbagent>(entity =>
            {
                entity.HasKey(e => e.AgentId)
                    .HasName("PK_TBAgent_1");

                entity.ToTable("TBAgent");

                entity.Property(e => e.AgentId)
                    .HasColumnName("Agent_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Categorie).HasColumnName("CATEGORIE");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Fonctionid)
                    .HasColumnName("FONCTIONID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Lettreaffectee)
                    .HasColumnName("LETTREAFFECTEE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Matricule)
                    .HasColumnName("MATRICULE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prenoms)
                    .HasColumnName("PRENOMS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fonction)
                    .WithMany(p => p.Tbagent)
                    .HasForeignKey(d => d.Fonctionid)
                    .HasConstraintName("FK_TBAgent_FONCTION");
            });

            modelBuilder.Entity<Tbassurance>(entity =>
            {
                entity.HasKey(e => e.IdAssur)
                    .HasName("PK__TBAssura__F59CD20CD8706A75");

                entity.ToTable("TBAssurance");

                entity.Property(e => e.IdAssur)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdrAssur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BpAssur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.FaxAssur)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MailAssur)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomAssur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiglAssur)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelAssur)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbautreRubrique>(entity =>
            {
                entity.HasKey(e => e.IdAutreRub)
                    .HasName("PK__TBAutreR__886DD3F44B26E67E");

                entity.ToTable("TBAutreRubrique");

                entity.Property(e => e.IdAutreRub)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibAutreRub)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbavance>(entity =>
            {
                entity.HasKey(e => e.IdAvance)
                    .HasName("PK__TB_Avance__6754599E");

                entity.ToTable("TBAvance");

                entity.Property(e => e.IdAvance)
                    .HasColumnName("idAvance")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatAvance).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdModeReglmnt).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mtavance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumAvance)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCheqAvan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.Tbavance)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Avance__IdDos__04AFB25B");

                entity.HasOne(d => d.IdModeReglmntNavigation)
                    .WithMany(p => p.Tbavance)
                    .HasForeignKey(d => d.IdModeReglmnt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Avance__IdMod__498EEC8D");
            });

            modelBuilder.Entity<Tbcarosserie>(entity =>
            {
                entity.HasKey(e => e.Idcarross)
                    .HasName("PK_TB_Carosserie");

                entity.ToTable("TBCarosserie");

                entity.Property(e => e.Idcarross)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibCarross)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbcommune>(entity =>
            {
                entity.HasKey(e => e.IdComm)
                    .HasName("PK__TB_Commune__0DAF0CB0");

                entity.ToTable("TBCommune");

                entity.Property(e => e.IdComm)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Deplacement).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVille).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomComm)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdVilleNavigation)
                    .WithMany(p => p.Tbcommune)
                    .HasForeignKey(d => d.IdVille)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Commun__IdVil__0EA330E9");
            });

            modelBuilder.Entity<Tbconclusion>(entity =>
            {
                entity.HasKey(e => e.Idconclus)
                    .HasName("PK__TB_Conclusion__76969D2E");

                entity.ToTable("TBConclusion");

                entity.Property(e => e.Idconclus)
                    .HasColumnName("idconclus")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdExpert)
                    .HasColumnName("idExpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libconclus)
                    .IsRequired()
                    .HasColumnName("libconclus")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdExpertNavigation)
                    .WithMany(p => p.Tbconclusion)
                    .HasForeignKey(d => d.IdExpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBConclusion_TBExpertise");
            });

            modelBuilder.Entity<TbconclusionGen>(entity =>
            {
                entity.HasKey(e => e.IdconclusGen)
                    .HasName("PK__TB_ConclusionGen__6EF57B66");

                entity.ToTable("TBConclusionGen");

                entity.Property(e => e.IdconclusGen)
                    .HasColumnName("idconclusGen")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libconclus)
                    .IsRequired()
                    .HasColumnName("libconclus")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.TbconclusionGen)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Conclu__IdDos__38996AB5");
            });

            modelBuilder.Entity<Tbcouleur>(entity =>
            {
                entity.HasKey(e => e.IdCouleur)
                    .HasName("PK__TBCouleu__9B2F0AFCC309C3D6");

                entity.ToTable("TBCouleur");

                entity.Property(e => e.IdCouleur)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibCouleur)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbdiscussion>(entity =>
            {
                entity.HasKey(e => e.Iddiscus)
                    .HasName("PK__TB_Discussion__7C4F7684");

                entity.ToTable("TBDiscussion");

                entity.Property(e => e.Iddiscus)
                    .HasColumnName("iddiscus")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idexpert)
                    .HasColumnName("idexpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libdiscus)
                    .IsRequired()
                    .HasColumnName("libdiscus")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdexpertNavigation)
                    .WithMany(p => p.Tbdiscussion)
                    .HasForeignKey(d => d.Idexpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Discussion_TB_Expertise");
            });

            modelBuilder.Entity<Tbdossier>(entity =>
            {
                entity.HasKey(e => e.IdDoss)
                    .HasName("PK__TB_Dossier__30F848ED");

                entity.ToTable("TBDossier");

                entity.Property(e => e.IdDoss)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatDemExpert).HasColumnType("datetime");

                entity.Property(e => e.DatExpert).HasColumnType("datetime");

                entity.Property(e => e.DatOuvert).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateRdv)
                    .HasColumnName("DateRDV")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateSinistre)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HorsDouane).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HorsTaxe).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdComm).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdPriseCharg).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTva)
                    .HasColumnName("IdTVA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTypExpert).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LieuExpert)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtPrejudice).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumDoss)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumSinistre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCommNavigation)
                    .WithMany(p => p.Tbdossier)
                    .HasForeignKey(d => d.IdComm)
                    .HasConstraintName("FK_TB_Dossier_TB_Commune");

                entity.HasOne(d => d.IdPriseChargNavigation)
                    .WithMany(p => p.Tbdossier)
                    .HasForeignKey(d => d.IdPriseCharg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Dossier_TB_PriseEnCharge");

                entity.HasOne(d => d.IdTvaNavigation)
                    .WithMany(p => p.Tbdossier)
                    .HasForeignKey(d => d.IdTva)
                    .HasConstraintName("FK_TB_Dossier_TB_TVA");

                entity.HasOne(d => d.IdTypExpertNavigation)
                    .WithMany(p => p.Tbdossier)
                    .HasForeignKey(d => d.IdTypExpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Dossier_TB_TypeExpertise");
            });

            modelBuilder.Entity<TbdossierEtatRapport>(entity =>
            {
                entity.HasKey(e => new { e.IdDoss, e.IdEtaRaport })
                    .HasName("PK_TB_Dossier_EtatRapport");

                entity.ToTable("TBDossierEtatRapport");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdEtaRaport).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DatEtat).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.HeurEtat).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.TbdossierEtatRapport)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Dossier_EtatRapport_TB_Dossier");

                entity.HasOne(d => d.IdEtaRaportNavigation)
                    .WithMany(p => p.TbdossierEtatRapport)
                    .HasForeignKey(d => d.IdEtaRaport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Dossier_EtatRapport_TB_EtatRapport");
            });

            modelBuilder.Entity<TbdossierRubriqueHonoraire>(entity =>
            {
                entity.HasKey(e => new { e.Idrubhonr, e.IdDoss })
                    .HasName("PK_TB_Dossier_RubriqueHonoraire_1");

                entity.ToTable("TBDossierRubriqueHonoraire");

                entity.Property(e => e.Idrubhonr)
                    .HasColumnName("idrubhonr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtRubHono).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.TbdossierRubriqueHonoraire)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Dossier_RubriqueHonoraire_TB_Dossier");

                entity.HasOne(d => d.IdrubhonrNavigation)
                    .WithMany(p => p.TbdossierRubriqueHonoraire)
                    .HasForeignKey(d => d.Idrubhonr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Dossier_RubriqueHonoraire_TB_RubriqueHonoraire");
            });

            modelBuilder.Entity<TbdossierSortis>(entity =>
            {
                entity.HasKey(e => e.IdSorti)
                    .HasName("PK_TB");

                entity.ToTable("TBDossierSortis");

                entity.Property(e => e.IdSorti)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatSorti).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rubrique)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.TbdossierSortis)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_SortiDossier_TB_Dossier");
            });

            modelBuilder.Entity<Tbdroits>(entity =>
            {
                entity.HasKey(e => e.IdDroit)
                    .HasName("PK_TB_Menu");

                entity.ToTable("TBDroits");

                entity.Property(e => e.IdDroit)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LigMenu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumMenu).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbenergie>(entity =>
            {
                entity.HasKey(e => e.IdEnergie)
                    .HasName("PK__TBEnergi__4BFA6616F7EB5934");

                entity.ToTable("TBEnergie");

                entity.Property(e => e.IdEnergie)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LibEnergie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbetatRapport>(entity =>
            {
                entity.HasKey(e => e.IdEtaRaport)
                    .HasName("PK__TB_EtatRapport__1367E606");

                entity.ToTable("TBEtatRapport");

                entity.Property(e => e.IdEtaRaport)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibEtaRaport)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nbre).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbexpertise>(entity =>
            {
                entity.HasKey(e => e.IdExpert)
                    .HasName("PK__TB_Expertise__690797E6");

                entity.ToTable("TBExpertise");

                entity.Property(e => e.IdExpert)
                    .HasColumnName("idExpert")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ard)
                    .HasColumnName("ARD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Arg)
                    .HasColumnName("ARG")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Avd)
                    .HasColumnName("AVD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Avgp)
                    .HasColumnName("AVGP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DatEnreg).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Depreciation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duree)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeurEnreg).HasColumnType("datetime");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdEtatEntretien)
                    .HasColumnName("idEtatEntretien")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdGara)
                    .HasColumnName("idGara")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVeh).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idtypnote)
                    .HasColumnName("idtypnote")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Kilometrage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LieuVisite)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumExpert)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Typnote).HasColumnType("text");

                entity.Property(e => e.ValeurNeuve)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurSauvetage).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValeurVenale)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuApT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuAvT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuPdtT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.Tbexpertise)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Expertise_TB_Dossier");

                entity.HasOne(d => d.IdGaraNavigation)
                    .WithMany(p => p.Tbexpertise)
                    .HasForeignKey(d => d.IdGara)
                    .HasConstraintName("FK_TBExpertise_TBGarage");

                entity.HasOne(d => d.IdVehNavigation)
                    .WithMany(p => p.Tbexpertise)
                    .HasForeignKey(d => d.IdVeh)
                    .HasConstraintName("FK_TB_Expertise_TB_Vehicule");

                entity.HasOne(d => d.IdtypnoteNavigation)
                    .WithMany(p => p.Tbexpertise)
                    .HasForeignKey(d => d.Idtypnote)
                    .HasConstraintName("FK_TB_Expertise_TB_TypeNote");
            });

            modelBuilder.Entity<TbexpertiseDepannagePointChoc>(entity =>
            {
                entity.HasKey(e => new { e.IdExpert, e.IdPointChoc, e.IdDepann })
                    .HasName("PK_TB_Expertise_Depannage_PointChoc");

                entity.ToTable("TBExpertiseDepannagePointChoc");

                entity.Property(e => e.IdExpert).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdPointChoc).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDepann).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibelleDepann)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Montant).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdExpertNavigation)
                    .WithMany(p => p.TbexpertiseDepannagePointChoc)
                    .HasForeignKey(d => d.IdExpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertiseDepannagePointChoc_TBExpertise");
            });

            modelBuilder.Entity<TbexpertiseEtatRapport>(entity =>
            {
                entity.HasKey(e => new { e.IdExpert, e.IdEtaRaport, e.HeurEtat })
                    .HasName("PK_TB_Expertise_EtatRapport");

                entity.ToTable("TBExpertiseEtatRapport");

                entity.Property(e => e.IdExpert).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdEtaRaport).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HeurEtat).HasColumnType("datetime");

                entity.Property(e => e.DatEtat).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdEtaRaportNavigation)
                    .WithMany(p => p.TbexpertiseEtatRapport)
                    .HasForeignKey(d => d.IdEtaRaport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertiseEtatRapport_TBEtatRapport");

                entity.HasOne(d => d.IdExpertNavigation)
                    .WithMany(p => p.TbexpertiseEtatRapport)
                    .HasForeignKey(d => d.IdExpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertiseEtatRapport_TBExpertise");
            });

            modelBuilder.Entity<TbexpertiseFourniturePointChoc>(entity =>
            {
                entity.HasKey(e => new { e.Idexpert, e.Idpointchoc, e.Idfourn })
                    .HasName("PK__TB_Expertise_Fou__4E88ABD4");

                entity.ToTable("TBExpertiseFourniturePointChoc");

                entity.Property(e => e.Idexpert)
                    .HasColumnName("idexpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idpointchoc)
                    .HasColumnName("idpointchoc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idfourn)
                    .HasColumnName("idfourn")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DepRep)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Ligne).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTotHt)
                    .HasColumnName("MtTotHT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTotTtc)
                    .HasColumnName("MtTotTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTtc)
                    .HasColumnName("MtTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mtht).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Peint)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Pu)
                    .HasColumnName("PU")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rem).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Remp)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Reparer)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Vetuste).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Vneuve)
                    .HasColumnName("VNeuve")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdexpertNavigation)
                    .WithMany(p => p.TbexpertiseFourniturePointChoc)
                    .HasForeignKey(d => d.Idexpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Expertise_Fourniture_PointChoc_TB_Expertise");

                entity.HasOne(d => d.IdfournNavigation)
                    .WithMany(p => p.TbexpertiseFourniturePointChoc)
                    .HasForeignKey(d => d.Idfourn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Expertise_Fourniture_PointChoc_TB_ListeFourniture");

                entity.HasOne(d => d.IdpointchocNavigation)
                    .WithMany(p => p.TbexpertiseFourniturePointChoc)
                    .HasForeignKey(d => d.Idpointchoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Expert__idpoi__2FCF1A8A");
            });

            modelBuilder.Entity<TbexpertisePointChoc>(entity =>
            {
                entity.HasKey(e => new { e.Idexpert, e.Idpointchoc })
                    .HasName("PK_TB_Expertise_PointChoc");

                entity.ToTable("TBExpertisePointChoc");

                entity.Property(e => e.Idexpert)
                    .HasColumnName("idexpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idpointchoc)
                    .HasColumnName("idpointchoc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdFourn).HasMaxLength(10);

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Ligne)
                    .HasColumnName("ligne")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdexpertNavigation)
                    .WithMany(p => p.TbexpertisePointChoc)
                    .HasForeignKey(d => d.Idexpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertisePointChoc_TBExpertise");

                entity.HasOne(d => d.IdpointchocNavigation)
                    .WithMany(p => p.TbexpertisePointChoc)
                    .HasForeignKey(d => d.Idpointchoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertisePointChoc_TBPointChoc");
            });

            modelBuilder.Entity<TbexpertisePourRecousPointChoc>(entity =>
            {
                entity.HasKey(e => new { e.IdRecours, e.IdExpert, e.IdPointChoc })
                    .HasName("PK_TB_Expertise_PourRecous_PointChoc");

                entity.ToTable("TBExpertisePourRecousPointChoc");

                entity.Property(e => e.IdRecours).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdExpert).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdPointChoc).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibRecours)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontRecous).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdExpertNavigation)
                    .WithMany(p => p.TbexpertisePourRecousPointChoc)
                    .HasForeignKey(d => d.IdExpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertisePourRecousPointChoc_TBExpertise");

                entity.HasOne(d => d.IdPointChocNavigation)
                    .WithMany(p => p.TbexpertisePourRecousPointChoc)
                    .HasForeignKey(d => d.IdPointChoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertisePourRecousPointChoc_TBPointChoc");

                entity.HasOne(d => d.IdRecoursNavigation)
                    .WithMany(p => p.TbexpertisePourRecousPointChoc)
                    .HasForeignKey(d => d.IdRecours)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertisePourRecousPointChoc_TBPourRecours");
            });

            modelBuilder.Entity<TbexpertiseRubriqueConstatationPointChoc>(entity =>
            {
                entity.HasKey(e => new { e.Idexpert, e.IdRubConst, e.Idpointchoc })
                    .HasName("PK__TBExpert__817691B3CBC35370");

                entity.ToTable("TBExpertiseRubriqueConstatationPointChoc");

                entity.Property(e => e.Idexpert)
                    .HasColumnName("idexpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdRubConst).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idpointchoc)
                    .HasColumnName("idpointchoc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Constat)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdRubConstNavigation)
                    .WithMany(p => p.TbexpertiseRubriqueConstatationPointChoc)
                    .HasForeignKey(d => d.IdRubConst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TBExperti__IdRub__5AB9788F");

                entity.HasOne(d => d.IdexpertNavigation)
                    .WithMany(p => p.TbexpertiseRubriqueConstatationPointChoc)
                    .HasForeignKey(d => d.Idexpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertiseRubriqueConstatationPointChoc_TBExpertise");

                entity.HasOne(d => d.IdpointchocNavigation)
                    .WithMany(p => p.TbexpertiseRubriqueConstatationPointChoc)
                    .HasForeignKey(d => d.Idpointchoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TBExperti__idpoi__59C55456");
            });

            modelBuilder.Entity<TbexpertiseRubriqueEstimation>(entity =>
            {
                entity.HasKey(e => new { e.IdExpert, e.IdRubEstim })
                    .HasName("PK_TB_Expertise_RubriqueEstimation");

                entity.ToTable("TBExpertiseRubriqueEstimation");

                entity.Property(e => e.IdExpert)
                    .HasColumnName("idExpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdRubEstim).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Estimation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdExpertNavigation)
                    .WithMany(p => p.TbexpertiseRubriqueEstimation)
                    .HasForeignKey(d => d.IdExpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Expertise_RubriqueEstimation_TB_Expertise");

                entity.HasOne(d => d.IdRubEstimNavigation)
                    .WithMany(p => p.TbexpertiseRubriqueEstimation)
                    .HasForeignKey(d => d.IdRubEstim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Expertise_RubriqueEstimation_TB_Rubrique_Estimation");
            });

            modelBuilder.Entity<TbexpertiseRubriqueMo>(entity =>
            {
                entity.HasKey(e => new { e.Idexpert, e.IdrubriqMo })
                    .HasName("PK__TB_Constater2__787EE5A0");

                entity.ToTable("TBExpertiseRubriqueMo");

                entity.Property(e => e.Idexpert)
                    .HasColumnName("idexpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdrubriqMo)
                    .HasColumnName("idrubriqMO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Constat)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdexpertNavigation)
                    .WithMany(p => p.TbexpertiseRubriqueMo)
                    .HasForeignKey(d => d.Idexpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertiseRubriqueMo_TBExpertise");

                entity.HasOne(d => d.IdrubriqMoNavigation)
                    .WithMany(p => p.TbexpertiseRubriqueMo)
                    .HasForeignKey(d => d.IdrubriqMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Consta__idrub__56E8E7AB");
            });

            modelBuilder.Entity<TbexpertiseTravauxExterieurPointChoc>(entity =>
            {
                entity.HasKey(e => new { e.Idpointchoc, e.Idautrecharg, e.IdExpert });

                entity.ToTable("TBExpertiseTravauxExterieurPointChoc");

                entity.Property(e => e.Idpointchoc)
                    .HasColumnName("idpointchoc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idautrecharg)
                    .HasColumnName("idautrecharg")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdExpert).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Dep).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mtautrecharge).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdExpertNavigation)
                    .WithMany(p => p.TbexpertiseTravauxExterieurPointChoc)
                    .HasForeignKey(d => d.IdExpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Expertise_AutreCharges_PointChoc_TB_Expertise");

                entity.HasOne(d => d.IdautrechargNavigation)
                    .WithMany(p => p.TbexpertiseTravauxExterieurPointChoc)
                    .HasForeignKey(d => d.Idautrecharg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Expertise_AutreCharges_PointChoc_TB_AutresCharges");

                entity.HasOne(d => d.IdpointchocNavigation)
                    .WithMany(p => p.TbexpertiseTravauxExterieurPointChoc)
                    .HasForeignKey(d => d.Idpointchoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Expertise_AutreCharges_PointChoc_TB_PointChoc");
            });

            modelBuilder.Entity<TbexpertiseTypeNote>(entity =>
            {
                entity.HasKey(e => new { e.Idexpert, e.Idtypnote })
                    .HasName("PK__TBExpert__D119F4A3A8BB27C3");

                entity.ToTable("TBExpertiseTypeNote");

                entity.Property(e => e.Idexpert)
                    .HasColumnName("idexpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idtypnote)
                    .HasColumnName("idtypnote")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Texte)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdexpertNavigation)
                    .WithMany(p => p.TbexpertiseTypeNote)
                    .HasForeignKey(d => d.Idexpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBExpertiseTypeNote_TBExpertise");

                entity.HasOne(d => d.IdtypnoteNavigation)
                    .WithMany(p => p.TbexpertiseTypeNote)
                    .HasForeignKey(d => d.Idtypnote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Expert__idtyp__607251E5");
            });

            modelBuilder.Entity<Tbfacture>(entity =>
            {
                entity.HasKey(e => e.IdFact)
                    .HasName("PK__TB_Facture__6D0D32F4");

                entity.ToTable("TBFacture");

                entity.Property(e => e.IdFact)
                    .HasColumnName("idFact")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatFact).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdDoss)
                    .HasColumnName("idDoss")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtFact).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtFactTtc)
                    .HasColumnName("MtFactTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTva)
                    .HasColumnName("MtTVA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumFact)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.Tbfacture)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Factur__idDos__40058253");
            });

            modelBuilder.Entity<Tbfourniture>(entity =>
            {
                entity.HasKey(e => e.IdFourn)
                    .HasName("PK_TB_ListeFourniture");

                entity.ToTable("TBFourniture");

                entity.Property(e => e.IdFourn)
                    .HasColumnName("idFourn")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibFourn).HasMaxLength(255);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbgarage>(entity =>
            {
                entity.HasKey(e => e.IdGara)
                    .HasName("PK__TB_Garage__46E78A0C");

                entity.ToTable("TBGarage");

                entity.Property(e => e.IdGara)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdrGar)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BpGar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.FaxGar)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdTyGara).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MailGar)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Pme).HasColumnName("PME");

                entity.Property(e => e.RaisonSociale)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelGar)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbgenre>(entity =>
            {
                entity.HasKey(e => e.IdGenre)
                    .HasName("PK__TBGenre__E7B6739853B739EE");

                entity.ToTable("TBGenre");

                entity.Property(e => e.IdGenre)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibGenre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbhabilitation>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.ProfilId });

                entity.ToTable("TBHabilitation");

                entity.Property(e => e.MenuId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProfilId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Tbhabilitation)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBHabilitation_TBMenu");

                entity.HasOne(d => d.Profil)
                    .WithMany(p => p.Tbhabilitation)
                    .HasForeignKey(d => d.ProfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBHabilitation_TBPROFIL");
            });

            modelBuilder.Entity<TbmainOeuvre>(entity =>
            {
                entity.HasKey(e => e.IdMo)
                    .HasName("PK__TB_MainOeuvre__03F0984C");

                entity.ToTable("TBMainOeuvre");

                entity.Property(e => e.IdMo)
                    .HasColumnName("idMO")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idexpert)
                    .HasColumnName("idexpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToRem).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbmainOeuvrePointChoc>(entity =>
            {
                entity.HasKey(e => new { e.Idpointchoc, e.IdMo, e.Datetrav })
                    .HasName("PK_TB_MainOeuvre_PointChoc");

                entity.ToTable("TBMainOeuvrePointChoc");

                entity.Property(e => e.Idpointchoc)
                    .HasColumnName("idpointchoc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdMo)
                    .HasColumnName("IdMO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Datetrav).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.TbmainOeuvrePointChoc)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MainOeuvre_PointChoc_TB_MainOeuvre");

                entity.HasOne(d => d.IdpointchocNavigation)
                    .WithMany(p => p.TbmainOeuvrePointChoc)
                    .HasForeignKey(d => d.Idpointchoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_MainOeuvre_PointChoc_TB_PointChoc");
            });

            modelBuilder.Entity<Tbmarque>(entity =>
            {
                entity.HasKey(e => e.IdMarque)
                    .HasName("PK__TB_Marque__03317E3D");

                entity.ToTable("TBMarque");

                entity.Property(e => e.IdMarque)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibMarque)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbmarqueCarrosserie>(entity =>
            {
                entity.HasKey(e => new { e.IdMarque, e.Idcarross })
                    .HasName("PK_TB_Marque_Carosserie");

                entity.ToTable("TBMarqueCarrosserie");

                entity.Property(e => e.IdMarque).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idcarross).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdMarqueNavigation)
                    .WithMany(p => p.TbmarqueCarrosserie)
                    .HasForeignKey(d => d.IdMarque)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Marque_Carosserie_TB_Marque");

                entity.HasOne(d => d.IdcarrossNavigation)
                    .WithMany(p => p.TbmarqueCarrosserie)
                    .HasForeignKey(d => d.Idcarross)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Marque_Carosserie_TB_Carosserie");
            });

            modelBuilder.Entity<Tbmenu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK_MENU_1");

                entity.ToTable("TBMenu");

                entity.Property(e => e.MenuId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controlleur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbmodeReglement>(entity =>
            {
                entity.HasKey(e => e.IdModeReglmnt)
                    .HasName("PK__TB_ModeReglement__286302EC");

                entity.ToTable("TBModeReglement");

                entity.Property(e => e.IdModeReglmnt)
                    .HasColumnName("idModeReglmnt")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibModReglmnt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbmodele>(entity =>
            {
                entity.HasKey(e => e.Idmodel)
                    .HasName("PK__TBModele__5375949D1194DE38");

                entity.ToTable("TBModele");

                entity.Property(e => e.Idmodel)
                    .HasColumnName("idmodel")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idmarq)
                    .HasColumnName("idmarq")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libmodel)
                    .IsRequired()
                    .HasColumnName("libmodel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdmarqNavigation)
                    .WithMany(p => p.Tbmodele)
                    .HasForeignKey(d => d.Idmarq)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Modele__idmar__1CBC4616");
            });

            modelBuilder.Entity<TbnbreElement>(entity =>
            {
                entity.HasKey(e => e.Idnbelmt)
                    .HasName("PK__TBNbreEl__6C21E394A441BB8A");

                entity.ToTable("TBNbreElement");

                entity.Property(e => e.Idnbelmt)
                    .HasColumnName("idnbelmt")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libnbelmt)
                    .IsRequired()
                    .HasColumnName("libnbelmt")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbnbreElementMainOeuvreTypePeinture>(entity =>
            {
                entity.HasKey(e => new { e.Idnbelmt, e.IdMo, e.Idtyppeint })
                    .HasName("PK__TB_NbreElement_M__4CA06362");

                entity.ToTable("TBNbreElementMainOeuvreTypePeinture");

                entity.Property(e => e.Idnbelmt)
                    .HasColumnName("idnbelmt")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdMo)
                    .HasColumnName("idMO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idtyppeint)
                    .HasColumnName("idtyppeint")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Coef).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Conste).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtPeint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tpeint)
                    .HasColumnName("TPeint")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.TbnbreElementMainOeuvreTypePeinture)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_NbreEle__idMO__2CF2ADDF");

                entity.HasOne(d => d.IdnbelmtNavigation)
                    .WithMany(p => p.TbnbreElementMainOeuvreTypePeinture)
                    .HasForeignKey(d => d.Idnbelmt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_NbreEl__idnbe__2B0A656D");

                entity.HasOne(d => d.IdtyppeintNavigation)
                    .WithMany(p => p.TbnbreElementMainOeuvreTypePeinture)
                    .HasForeignKey(d => d.Idtyppeint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_NbreEl__idtyp__2BFE89A6");
            });

            modelBuilder.Entity<Tbnote>(entity =>
            {
                entity.HasKey(e => e.IdNot)
                    .HasName("PK_TB_Note");

                entity.ToTable("TBNote");

                entity.Property(e => e.IdNot)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idtypnote)
                    .HasColumnName("idtypnote")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibelleNot)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdtypnoteNavigation)
                    .WithMany(p => p.Tbnote)
                    .HasForeignKey(d => d.Idtypnote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Note_TB_TypeNote");
            });

            modelBuilder.Entity<TbparamHonoraire>(entity =>
            {
                entity.HasKey(e => e.IdParam)
                    .HasName("PK__TBParamH__19B5C2730EAA709D");

                entity.ToTable("TBParamHonoraire");

                entity.Property(e => e.IdParam)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CoefExced)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtHonoraire).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtInferPrej).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtSupPrej).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbparametre>(entity =>
            {
                entity.HasKey(e => e.IdParam);

                entity.ToTable("TBParametre");

                entity.Property(e => e.IdParam)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Param)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Tbphoto>(entity =>
            {
                entity.HasKey(e => e.Idphoto);

                entity.ToTable("TBPhoto");

                entity.HasIndex(e => e.Idphoto)
                    .HasName("UQ__TBPhoto__384563A983DA8AF4")
                    .IsUnique();

                entity.Property(e => e.Idphoto)
                    .HasColumnName("idphoto")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DocDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocExtension)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idexpert).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdexpertNavigation)
                    .WithMany(p => p.Tbphoto)
                    .HasForeignKey(d => d.Idexpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBPhoto_TBExpertise");
            });

            modelBuilder.Entity<TbpointChoc>(entity =>
            {
                entity.HasKey(e => e.IdPointChoc)
                    .HasName("PK__TBPointC__049C81B6866F5420");

                entity.ToTable("TBPointChoc");

                entity.Property(e => e.IdPointChoc)
                    .HasColumnName("idPointChoc")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibPointChoc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbpourRecours>(entity =>
            {
                entity.HasKey(e => e.IdRecours)
                    .HasName("PK_TB_PourRecours");

                entity.ToTable("TBPourRecours");

                entity.Property(e => e.IdRecours)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibRecours)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbpreambule>(entity =>
            {
                entity.HasKey(e => e.Idpreamb)
                    .HasName("PK__TB_Preambule__72C60C4A");

                entity.ToTable("TBPreambule");

                entity.Property(e => e.Idpreamb)
                    .HasColumnName("idpreamb")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdExpert)
                    .HasColumnName("idExpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libpreamb)
                    .IsRequired()
                    .HasColumnName("libpreamb")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdExpertNavigation)
                    .WithMany(p => p.Tbpreambule)
                    .HasForeignKey(d => d.IdExpert)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBPreambule_TBExpertise");
            });

            modelBuilder.Entity<TbpreambuleGen>(entity =>
            {
                entity.HasKey(e => new { e.Idpream, e.Iddoss });

                entity.ToTable("TBPreambuleGen");

                entity.Property(e => e.Idpream)
                    .HasColumnName("idpream")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Iddoss)
                    .HasColumnName("iddoss")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libpream)
                    .IsRequired()
                    .HasColumnName("libpream")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IddossNavigation)
                    .WithMany(p => p.TbpreambuleGen)
                    .HasForeignKey(d => d.Iddoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_PreambuleGen_TB_Dossier");
            });

            modelBuilder.Entity<TbpriseEnCharge>(entity =>
            {
                entity.HasKey(e => e.IdPriseCharg)
                    .HasName("PK__TBPriseE__89296450DCB31B6A");

                entity.ToTable("TBPriseEnCharge");

                entity.Property(e => e.IdPriseCharg)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibPriseCharg)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbprofil>(entity =>
            {
                entity.HasKey(e => e.ProfilId)
                    .HasName("PK_PROFIL_1");

                entity.ToTable("TBPROFIL");

                entity.Property(e => e.ProfilId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbproprietaire>(entity =>
            {
                entity.HasKey(e => e.IdProprio)
                    .HasName("PK__TB_Proprietaire__09DE7BCC");

                entity.ToTable("TBProprietaire");

                entity.Property(e => e.IdProprio)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdrProprio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BpProprio)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DatEnreg).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.FaxProprio)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MailProrio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomProprio)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PrenProPrio)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.TelProprio)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbrapportAcheve>(entity =>
            {
                entity.HasKey(e => e.Idrapport)
                    .HasName("PK_TB_Rapport_Acheve");

                entity.ToTable("TBRapportAcheve");

                entity.Property(e => e.Idrapport)
                    .HasColumnName("idrapport")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Heure)
                    .HasColumnName("heure")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdExpert)
                    .HasColumnName("idExpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbrecapPrejudice>(entity =>
            {
                entity.HasKey(e => e.IdRecapExp)
                    .HasName("PK_TB_RecapPrejudice");

                entity.ToTable("TBRecapPrejudice");

                entity.Property(e => e.IdRecapExp)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatCompo).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Eprejudice)
                    .HasColumnName("EPrejudice")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdExpert)
                    .HasColumnName("idExpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdPointChoc)
                    .HasColumnName("idPointChoc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtDepannage).HasMaxLength(10);

                entity.Property(e => e.MtFournitureTtc)
                    .HasColumnName("MtFournitureTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtMoHt)
                    .HasColumnName("MtMoHT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtMoPeintureHt)
                    .HasColumnName("MtMoPeintureHT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtMoPeintureTtc)
                    .HasColumnName("MtMoPeintureTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtMoTtc)
                    .HasColumnName("MtMoTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtPetiteFounHt)
                    .HasColumnName("MtPetiteFounHT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtPneuveHt)
                    .HasColumnName("MtPNeuveHT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtPneuveTtc)
                    .HasColumnName("MtPNeuveTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtProdPeintureHt)
                    .HasColumnName("MtProdPeintureHT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtRecupTtc)
                    .HasColumnName("MtRecupTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTotDesPrejudices).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTotMoTtc)
                    .HasColumnName("MtTotMoTTC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTotPrejudice).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTvamoPeinture)
                    .HasColumnName("MtTVAMoPeinture")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTvapetiteFournPeinture)
                    .HasColumnName("MtTVAPetiteFournPeinture")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTvapneuve)
                    .HasColumnName("MtTVAPNeuve")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.TbrecapPrejudice)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_RecapPrejudice_TB_Dossier");

                entity.HasOne(d => d.IdPointChocNavigation)
                    .WithMany(p => p.TbrecapPrejudice)
                    .HasForeignKey(d => d.IdPointChoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_RecapPrejudice_TB_PointChoc");
            });

            modelBuilder.Entity<Tbreglement>(entity =>
            {
                entity.HasKey(e => e.Idreglmt)
                    .HasName("PK__TB_Reglement__693CA210");

                entity.ToTable("TBReglement");

                entity.Property(e => e.Idreglmt)
                    .HasColumnName("idreglmt")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Datreglmt)
                    .HasColumnName("datreglmt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idfact)
                    .HasColumnName("idfact")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idmodrglmt)
                    .HasColumnName("idmodrglmt")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mtrglmt).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomMandant)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCheque)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCompte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRecu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numreglmt)
                    .IsRequired()
                    .HasColumnName("numreglmt")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdfactNavigation)
                    .WithMany(p => p.Tbreglement)
                    .HasForeignKey(d => d.Idfact)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Reglem__idfac__4A8310C6");

                entity.HasOne(d => d.IdmodrglmtNavigation)
                    .WithMany(p => p.Tbreglement)
                    .HasForeignKey(d => d.Idmodrglmt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Reglem__idmod__4B7734FF");
            });

            modelBuilder.Entity<Tbrembourssement>(entity =>
            {
                entity.HasKey(e => e.Idrembours)
                    .HasName("PK__TB_Rembourssemen__6B24EA82");

                entity.ToTable("TBRembourssement");

                entity.Property(e => e.Idrembours)
                    .HasColumnName("idrembours")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idfact)
                    .HasColumnName("idfact")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idmodrglmt)
                    .HasColumnName("idmodrglmt")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Librembours)
                    .IsRequired()
                    .HasColumnName("librembours")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdfactNavigation)
                    .WithMany(p => p.Tbrembourssement)
                    .HasForeignKey(d => d.Idfact)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Rembou__idfac__4C6B5938");

                entity.HasOne(d => d.IdmodrglmtNavigation)
                    .WithMany(p => p.Tbrembourssement)
                    .HasForeignKey(d => d.Idmodrglmt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Rembou__idmod__4D5F7D71");
            });

            modelBuilder.Entity<TbrubriqueConstatation>(entity =>
            {
                entity.HasKey(e => e.IdRubConst)
                    .HasName("PK__TBRubriq__EAB6F35738C3DBB0");

                entity.ToTable("TBRubriqueConstatation");

                entity.Property(e => e.IdRubConst)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibRubConst)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbrubriqueEstimation>(entity =>
            {
                entity.HasKey(e => e.IdRubEstim)
                    .HasName("PK_TB_Rubrique_Estimation");

                entity.ToTable("TBRubriqueEstimation");

                entity.Property(e => e.IdRubEstim)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibRubEstim)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbrubriqueEvalExpertise>(entity =>
            {
                entity.HasKey(e => new { e.Idexpert, e.IdRubEval })
                    .HasName("PK__TBRubriq__A3F68244F52FCD96");

                entity.ToTable("TBRubriqueEvalExpertise");

                entity.Property(e => e.Idexpert)
                    .HasColumnName("idexpert")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdRubEval).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Constater)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdRubEvalNavigation)
                    .WithMany(p => p.TbrubriqueEvalExpertise)
                    .HasForeignKey(d => d.IdRubEval)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TBRubriqu__IdRub__7849DB76");
            });

            modelBuilder.Entity<TbrubriqueEvaluation>(entity =>
            {
                entity.HasKey(e => e.IdRubEval)
                    .HasName("PK__TBRubriq__0166ED6F16E53A9F");

                entity.ToTable("TBRubriqueEvaluation");

                entity.Property(e => e.IdRubEval)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibRubEval)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbrubriqueHonoraire>(entity =>
            {
                entity.HasKey(e => e.Idrubhonr)
                    .HasName("PK__TB_RubriqueHonor__173876EA");

                entity.ToTable("TBRubriqueHonoraire");

                entity.Property(e => e.Idrubhonr)
                    .HasColumnName("idrubhonr")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Librubhonor)
                    .IsRequired()
                    .HasColumnName("librubhonor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbrubriqueMainOeuvre>(entity =>
            {
                entity.HasKey(e => e.IdrubriqMo)
                    .HasName("PK__TB_RubriqueMainO__267ABA7A");

                entity.ToTable("TBRubriqueMainOeuvre");

                entity.Property(e => e.IdrubriqMo)
                    .HasColumnName("idrubriqMO")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibrubriqMo)
                    .IsRequired()
                    .HasColumnName("librubriqMO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nbre).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbservice>(entity =>
            {
                entity.HasKey(e => e.IdServ)
                    .HasName("PK_TB_Service");

                entity.ToTable("TBService");

                entity.Property(e => e.IdServ)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibServ)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbspecialite>(entity =>
            {
                entity.HasKey(e => e.IdSpec)
                    .HasName("PK_TB_Specialite");

                entity.ToTable("TBSpecialite");

                entity.Property(e => e.IdSpec)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdServ).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibSepec)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdServNavigation)
                    .WithMany(p => p.Tbspecialite)
                    .HasForeignKey(d => d.IdServ)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Specialite_TB_Service1");
            });

            modelBuilder.Entity<TbspecialiteUser>(entity =>
            {
                entity.HasKey(e => new { e.IdUser, e.IdSpec })
                    .HasName("PK_TB_Specialite_User");

                entity.ToTable("TBSpecialiteUser");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdSpec).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdSpecNavigation)
                    .WithMany(p => p.TbspecialiteUser)
                    .HasForeignKey(d => d.IdSpec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Specialite_User_TB_Specialite");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.TbspecialiteUser)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Specialite_User_TB_User");
            });

            modelBuilder.Entity<TbtarifActif>(entity =>
            {
                entity.HasKey(e => e.IdTarifAct)
                    .HasName("PK__TBTarifA__AABB8F549AF84548");

                entity.ToTable("TBTarifActif");

                entity.Property(e => e.IdTarifAct)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibAct)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTarifAct).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbtarifHoraire>(entity =>
            {
                entity.HasKey(e => e.IdTarifHor)
                    .HasName("PK__TB_TarifHoraire__060DEAE8");

                entity.ToTable("TBTarifHoraire");

                entity.Property(e => e.IdTarifHor)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTarifHor).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbtarifHoraireGarageMarque>(entity =>
            {
                entity.HasKey(e => new { e.IdGara, e.IdMarque, e.IdTarifHor })
                    .HasName("PK_TB_TarifHoraire_Garage_Marque");

                entity.ToTable("TBTarifHoraireGarageMarque");

                entity.Property(e => e.IdGara).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdMarque).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTarifHor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTarif).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdGaraNavigation)
                    .WithMany(p => p.TbtarifHoraireGarageMarque)
                    .HasForeignKey(d => d.IdGara)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_TarifHoraire_Garage_Marque_TB_Garage");

                entity.HasOne(d => d.IdMarqueNavigation)
                    .WithMany(p => p.TbtarifHoraireGarageMarque)
                    .HasForeignKey(d => d.IdMarque)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_TarifHoraire_Garage_Marque_TB_Marque");

                entity.HasOne(d => d.IdTarifHorNavigation)
                    .WithMany(p => p.TbtarifHoraireGarageMarque)
                    .HasForeignKey(d => d.IdTarifHor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_TarifHoraire_Garage_Marque_TB_TarifHoraire");
            });

            modelBuilder.Entity<TbtravauxExterieur>(entity =>
            {
                entity.HasKey(e => e.Idautrecharg)
                    .HasName("PK__TB_AutresCharges__3B75D760");

                entity.ToTable("TBTravauxExterieur");

                entity.Property(e => e.Idautrecharg)
                    .HasColumnName("idautrecharg")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libautrecharg)
                    .IsRequired()
                    .HasColumnName("libautrecharg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NbAutres).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Tbtva>(entity =>
            {
                entity.HasKey(e => e.IdTva)
                    .HasName("PK_TB_TVA");

                entity.ToTable("TBTVA");

                entity.Property(e => e.IdTva)
                    .HasColumnName("IdTVA")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateTva)
                    .HasColumnName("DateTVA")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtatTva).HasColumnName("EtatTVA");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TxTva)
                    .IsRequired()
                    .HasColumnName("TxTVA")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbtypGarage>(entity =>
            {
                entity.HasKey(e => e.IdTyGara)
                    .HasName("PK__TB_TypGarage__44FF419A");

                entity.ToTable("TBTypGarage");

                entity.Property(e => e.IdTyGara)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdTarifHor).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibTypGara)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdTarifHorNavigation)
                    .WithMany(p => p.TbtypGarage)
                    .HasForeignKey(d => d.IdTarifHor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_TypGarage_TB_TarifHoraire");
            });

            modelBuilder.Entity<TbtypPeintureTarifActifTarifHonoraireNbreElemnt>(entity =>
            {
                entity.HasKey(e => new { e.IdTarif, e.IdTypPeint, e.IdTarifAct, e.Idnbelmt })
                    .HasName("PK_TB_Tarifer_1");

                entity.ToTable("TBTypPeintureTarifActifTarifHonoraireNbreElemnt");

                entity.Property(e => e.IdTarif).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTypPeint).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdTarifAct).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idnbelmt)
                    .HasColumnName("idnbelmt")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Coef).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Const).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mtprodpeint).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdTarifNavigation)
                    .WithMany(p => p.TbtypPeintureTarifActifTarifHonoraireNbreElemnt)
                    .HasForeignKey(d => d.IdTarif)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Tarife__IdTar__1DB06A4F");

                entity.HasOne(d => d.IdTarifActNavigation)
                    .WithMany(p => p.TbtypPeintureTarifActifTarifHonoraireNbreElemnt)
                    .HasForeignKey(d => d.IdTarifAct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Tarife__IdTar__1EA48E88");

                entity.HasOne(d => d.IdTypPeintNavigation)
                    .WithMany(p => p.TbtypPeintureTarifActifTarifHonoraireNbreElemnt)
                    .HasForeignKey(d => d.IdTypPeint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Tarife__IdTyp__1F98B2C1");

                entity.HasOne(d => d.IdnbelmtNavigation)
                    .WithMany(p => p.TbtypPeintureTarifActifTarifHonoraireNbreElemnt)
                    .HasForeignKey(d => d.Idnbelmt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_TypPeinture_TarifActif_TarifHonoraire_NbreElemnt_TB_NbreElement");
            });

            modelBuilder.Entity<TbtypTravauxMainOuvre>(entity =>
            {
                entity.HasKey(e => new { e.Idtyptrav, e.IdMo })
                    .HasName("PK__TB_TypTravaux_Ma__4AB81AF0");

                entity.ToTable("TBTypTravauxMainOuvre");

                entity.Property(e => e.Idtyptrav)
                    .HasColumnName("idtyptrav")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdMo)
                    .HasColumnName("idMO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.ElemntTravo)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtTravo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nbheure).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.TbtypTravauxMainOuvre)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_TypTravaux_MainOuvre_TB_MainOeuvre");

                entity.HasOne(d => d.IdtyptravNavigation)
                    .WithMany(p => p.TbtypTravauxMainOuvre)
                    .HasForeignKey(d => d.Idtyptrav)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_TypTravaux_MainOuvre_TB_TypeTravaux");
            });

            modelBuilder.Entity<TbtypeExpertise>(entity =>
            {
                entity.HasKey(e => e.IdTypExpert)
                    .HasName("PK__TB_TypeExpertise__1B0907CE");

                entity.ToTable("TBTypeExpertise");

                entity.Property(e => e.IdTypExpert)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibTypExpert)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MtPrejudiceHt).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbtypeNote>(entity =>
            {
                entity.HasKey(e => e.Idtypnote)
                    .HasName("PK__TB_TypeNote__300424B4");

                entity.ToTable("TBTypeNote");

                entity.Property(e => e.Idtypnote)
                    .HasColumnName("idtypnote")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libtypnote)
                    .IsRequired()
                    .HasColumnName("libtypnote")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbtypePeinture>(entity =>
            {
                entity.HasKey(e => e.IdTypePein)
                    .HasName("PK__TBTypePe__48A0C9E48F0ED9FE");

                entity.ToTable("TBTypePeinture");

                entity.Property(e => e.IdTypePein)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibTypePein)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbtypeTravaux>(entity =>
            {
                entity.HasKey(e => e.Idtyptrav)
                    .HasName("PK__TBTypeTr__303921730BD6FBC6");

                entity.ToTable("TBTypeTravaux");

                entity.Property(e => e.Idtyptrav)
                    .HasColumnName("idtyptrav")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libtyptrav)
                    .IsRequired()
                    .HasColumnName("libtyptrav")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbtypeUser>(entity =>
            {
                entity.HasKey(e => e.IdTypeUser)
                    .HasName("PK_TB_TypeUser");

                entity.ToTable("TBTypeUser");

                entity.Property(e => e.IdTypeUser)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LibTypeUser)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NbreUser).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbtypeValeur>(entity =>
            {
                entity.HasKey(e => e.Idtypval)
                    .HasName("PK__TBTypeVa__4A0245D6E0882DDE");

                entity.ToTable("TBTypeValeur");

                entity.Property(e => e.Idtypval)
                    .HasColumnName("idtypval")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libtypval)
                    .IsRequired()
                    .HasColumnName("libtypval")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TbtypeVehicule>(entity =>
            {
                entity.HasKey(e => e.Idtypveh)
                    .HasName("PK__TBTypeVe__4A0265A57C17B733");

                entity.ToTable("TBTypeVehicule");

                entity.Property(e => e.Idtypveh)
                    .HasColumnName("idtypveh")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idmodel)
                    .HasColumnName("idmodel")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Libtypveh)
                    .IsRequired()
                    .HasColumnName("libtypveh")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdmodelNavigation)
                    .WithMany(p => p.TbtypeVehicule)
                    .HasForeignKey(d => d.Idmodel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TBTypeVeh__idmod__662B2B3B");
            });

            modelBuilder.Entity<Tbuser>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__TB_User__59FA5E80");

                entity.ToTable("TBUser");

                entity.Property(e => e.IdUser)
                    .HasColumnName("idUser")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdrUser)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AgentId)
                    .HasColumnName("Agent_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatFonc).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateDebutValidite)
                    .HasColumnName("DATE_DEBUT_VALIDITE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDernierVerrouillage)
                    .HasColumnName("DATE_DERNIER_VERROUILLAGE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDerniereConnexion)
                    .HasColumnName("DATE_DERNIERE_CONNEXION")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDerniereModificationPassword)
                    .HasColumnName("DATE_DERNIERE_MODIFICATION_PASSWORD")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFinValidite)
                    .HasColumnName("DATE_FIN_VALIDITE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DerniereConnexionReussie).HasColumnName("DERNIERE_CONNEXION_REUSSIE");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hostname)
                    .HasColumnName("HOSTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTypeUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InitUserPassword).HasColumnName("INIT_USER_PASSWORD");

                entity.Property(e => e.LoginUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomPrenUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTel)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SexUser)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StatutSession).HasColumnName("STATUT_SESSION");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Tbuser)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_TBUser_TBAgent");

                entity.HasOne(d => d.IdTypeUserNavigation)
                    .WithMany(p => p.Tbuser)
                    .HasForeignKey(d => d.IdTypeUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_User_TB_TypeUser");

                entity.HasOne(d => d.Profil)
                    .WithMany(p => p.Tbuser)
                    .HasForeignKey(d => d.ProfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBUser_TBPROFIL");
            });

            modelBuilder.Entity<TbuserDossier>(entity =>
            {
                entity.HasKey(e => new { e.Iddoss, e.Iduser })
                    .HasName("PK__TBUserDo__B4F00F548CFB41C5");

                entity.ToTable("TBUserDossier");

                entity.Property(e => e.Iddoss)
                    .HasColumnName("iddoss")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Iduser)
                    .HasColumnName("iduser")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IddossNavigation)
                    .WithMany(p => p.TbuserDossier)
                    .HasForeignKey(d => d.Iddoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_User_D__iddos__3DB3258D");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.TbuserDossier)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_User_D__iduse__540C7B00");
            });

            modelBuilder.Entity<Tbvehicule>(entity =>
            {
                entity.HasKey(e => e.IdVeh)
                    .HasName("PK__TB_Vehicule__3D5E1FD2");

                entity.ToTable("TBVehicule");

                entity.Property(e => e.IdVeh)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Datmisecircul)
                    .HasColumnName("datmisecircul")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCouleur).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdDoss).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdEnergie).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdGenre).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdProprio).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idcarross).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idtypveh)
                    .HasColumnName("idtypveh")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Immatriculation)
                    .IsRequired()
                    .HasColumnName("immatriculation")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nbplace)
                    .HasColumnName("nbplace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Puissancefiscal)
                    .HasColumnName("puissancefiscal")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Serievehic)
                    .HasColumnName("serievehic")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisiteTech)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCouleurNavigation)
                    .WithMany(p => p.Tbvehicule)
                    .HasForeignKey(d => d.IdCouleur)
                    .HasConstraintName("FK__TB_Vehicu__IdCou__160F4887");

                entity.HasOne(d => d.IdDossNavigation)
                    .WithMany(p => p.Tbvehicule)
                    .HasForeignKey(d => d.IdDoss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBVehicule_TBDossier");

                entity.HasOne(d => d.IdEnergieNavigation)
                    .WithMany(p => p.Tbvehicule)
                    .HasForeignKey(d => d.IdEnergie)
                    .HasConstraintName("FK__TB_Vehicu__IdEne__17036CC0");

                entity.HasOne(d => d.IdGenreNavigation)
                    .WithMany(p => p.Tbvehicule)
                    .HasForeignKey(d => d.IdGenre)
                    .HasConstraintName("FK__TB_Vehicu__IdGen__17F790F9");

                entity.HasOne(d => d.IdProprioNavigation)
                    .WithMany(p => p.Tbvehicule)
                    .HasForeignKey(d => d.IdProprio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Vehicu__IdPro__2645B050");

                entity.HasOne(d => d.IdcarrossNavigation)
                    .WithMany(p => p.Tbvehicule)
                    .HasForeignKey(d => d.Idcarross)
                    .HasConstraintName("FK_TB_Vehicule_TB_Carosserie");

                entity.HasOne(d => d.IdtypvehNavigation)
                    .WithMany(p => p.Tbvehicule)
                    .HasForeignKey(d => d.Idtypveh)
                    .HasConstraintName("FK__TB_Vehicu__idtyp__19DFD96B");
            });

            modelBuilder.Entity<TbvehiculeAssurance>(entity =>
            {
                entity.HasKey(e => new { e.IdAss, e.IdVeh, e.DatAss })
                    .HasName("PK__TB_Assurer__3F466844");

                entity.ToTable("TBVehiculeAssurance");

                entity.Property(e => e.IdAss)
                    .HasColumnName("idAss")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVeh).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DatAss).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Ligne)
                    .HasColumnName("ligne")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumPolice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAssNavigation)
                    .WithMany(p => p.TbvehiculeAssurance)
                    .HasForeignKey(d => d.IdAss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Assure__idAss__1AD3FDA4");

                entity.HasOne(d => d.IdVehNavigation)
                    .WithMany(p => p.TbvehiculeAssurance)
                    .HasForeignKey(d => d.IdVeh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Vehicule_Assurance_TB_Vehicule");
            });

            modelBuilder.Entity<Tbville>(entity =>
            {
                entity.HasKey(e => e.IdVille)
                    .HasName("PK__TB_Ville__0BC6C43E");

                entity.ToTable("TBVille");

                entity.Property(e => e.IdVille)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Distance).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifieLe).HasColumnType("datetime");

                entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomVille)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });
        }
    }
}
