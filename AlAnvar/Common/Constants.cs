namespace AlAnvar.Common;
public class Constants
{
    public const string AppName = "AlAnvar1.0";
    public static string RootPath =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppName);
    public static string AppConfigPath =
        Path.Combine(RootPath, "AlAnvarConfig.json");
    public const string Audio = "Audio";
    public const string Translations = "Translations";
}
