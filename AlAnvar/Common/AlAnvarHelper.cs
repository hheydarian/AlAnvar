

namespace AlAnvar.Common;
public class AlAnvarHelper
{
    public static AlAnvarConfig Settings = JsonSettings.Configure<AlAnvarConfig>()
        .WithRecovery(RecoveryAction.RenameAndLoadDefault)
        .WithVersioning(VersioningResultAction.RenameAndLoadDefault)
        .LoadNow();
}
