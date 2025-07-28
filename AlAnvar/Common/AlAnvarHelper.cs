

namespace AlAnvar.Common;
public static class AlAnvarHelper
{
    public static AlAnvarConfig Settings = JsonSettings.Configure<AlAnvarConfig>()
        .WithRecovery(RecoveryAction.RenameAndLoadDefault)
        .WithVersioning(VersioningResultAction.RenameAndLoadDefault)
        .LoadNow();
}
