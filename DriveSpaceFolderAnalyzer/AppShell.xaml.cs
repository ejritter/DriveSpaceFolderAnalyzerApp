﻿namespace DriveSpaceFolderAnalyzer;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MainViewPage), typeof(MainViewPage));
    }
}
