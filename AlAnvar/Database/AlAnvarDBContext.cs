namespace AlAnvar.Database;
public class AlAnvarDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=E:\C#\WinUI\New folder\Al-Anvar.db");
    }
    public DbSet<ChapterProperty> Chapters { get; set; }
    public DbSet<QuranAudio> QuranAudios { get; set; }
    public DbSet<QuranPlain> QuranPlains { get; set; }
    public DbSet<QuranSearch> QuranSearches { get; set; }
    public DbSet<Translations> Translations { get; set; }
}