namespace AlAnvar.Common;
public class AlAnvarConfig : JsonSettings, IVersionable
{
    [EnforcedVersion("1.0.0.0")]
    public Version Version { get; set; } = new Version(1, 0, 0, 0);
    public override string FileName { get; set; } = Constants.AppConfigPath;

}
