using DriveSpaceFolderAnalyzer.Services;
using DriveSpaceFolderAnalyzer.View;
using DriveSpaceFolderAnalyzer.ViewModel;
using Microsoft.Extensions.Logging;

namespace DriveSpaceFolderAnalyzer;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<IDataService, DataService>();

        builder.Services.AddSingleton<MainViewPage>();
        builder.Services.AddSingleton<MainViewViewModel>();


        return builder.Build();
    }
}
