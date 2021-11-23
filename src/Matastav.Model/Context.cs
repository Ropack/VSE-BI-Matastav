using Microsoft.EntityFrameworkCore;

namespace Matastav.Model
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Matastav;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            const string tableNamePrefix = "rour01_";


            modelBuilder.Entity<Zdroj>()
                .ToTable($"{tableNamePrefix}D_zdroj");
            modelBuilder.Entity<ZdrojKategorie>()
                .ToTable($"{tableNamePrefix}D_zdroj_kategorie");
            modelBuilder.Entity<Zakaznik>()
                .ToTable($"{tableNamePrefix}D_zakaznik");
            modelBuilder.Entity<ZakaznikKategorie>()
                .ToTable($"{tableNamePrefix}D_zakaznik_kategorie");
            modelBuilder.Entity<Pobocka>()
                .ToTable($"{tableNamePrefix}D_pobocka");
            modelBuilder.Entity<Zamestnanec>()
                .ToTable($"{tableNamePrefix}D_zamestnanec");
            modelBuilder.Entity<ZamestnanecPozice>()
                .ToTable($"{tableNamePrefix}D_zamestnanec_pozice");
            modelBuilder.Entity<Kraj>()
                .ToTable($"{tableNamePrefix}D_kraj");
            modelBuilder.Entity<Region>()
                .ToTable($"{tableNamePrefix}D_region");
            modelBuilder.Entity<VydajDruh>()
                .ToTable($"{tableNamePrefix}D_vydaj_druh");


            modelBuilder.Entity<Kontrakt>()
                .ToTable($"{tableNamePrefix}F_kontrakt");
            modelBuilder.Entity<Mzda>()
                .ToTable($"{tableNamePrefix}F_mzda");
            modelBuilder.Entity<Vydaj>()
                .ToTable($"{tableNamePrefix}F_vydaj");
            modelBuilder.Entity<Prijem>()
                .ToTable($"{tableNamePrefix}F_prijem");

            modelBuilder.Entity<Region>()
                .HasIndex(x => x.Nazev)
                .IsUnique();
            modelBuilder.Entity<VydajDruh>()
                .HasIndex(x => x.Nazev)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}