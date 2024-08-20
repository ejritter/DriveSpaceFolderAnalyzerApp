using DriveSpaceFolderAnalyzer.View;

namespace DriveSpaceFolderAnalyzer;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(FolderView), typeof(FolderView));
    }
}
