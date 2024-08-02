
using DriveSpaceFolderAnalyzer.Services;

namespace DriveSpaceFolderAnalyzer.ViewModel;

public partial class MainViewViewModel : ObservableObject
{
    private readonly IDataService _ds;

    [ObservableProperty]
    ObservableCollection<Folder> folders;
    public MainViewViewModel(IDataService ds)
    {
        _ds = ds;

        Folders = _ds.GetFolders();
    }
}
