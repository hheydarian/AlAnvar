namespace AlAnvar.Database.Table;

[Table("Translations")]
public class Translations
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string TranslationId { get; set; }
    public string Language { get; set; }
    public string Name { get; set; }
    public string Translator { get; set; }
    public string Link { get; set; }
}
