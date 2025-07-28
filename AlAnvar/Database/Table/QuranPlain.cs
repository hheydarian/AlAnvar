namespace AlAnvar.Database.Table;

[Table("QuranPlain")]
public class QuranPlain
{
    public int Id { get; set; }
    public int SurahId { get; set; }
    public int AyahNumber { get; set; }
    public string AyahText { get; set; }
    public int Juz { get; set; }
    public int Hizb { get; set; }
    public string Audio { get; set; }
}
