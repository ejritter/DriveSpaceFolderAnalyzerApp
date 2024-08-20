namespace DriveSpaceFolderAnalyzer.ViewModel;
public partial class FolderViewModel : ObservableObject
{
    private readonly IDataService _dataService;

    [ObservableProperty]
    string title;
    [ObservableProperty]
    string folderPath;

    [ObservableProperty]
    ObservableCollection<FolderModel> folders;

    public FolderViewModel(IDataService dataService)
    {
        _dataService = dataService;
        FolderPath = string.Empty;
        Title = "Folder Analyzer";
        Folders = new ObservableCollection<FolderModel>();
        Folders.Add(new FolderModel { Name ="Folder 1", Size ="10GB"});
        Folders.Add(new FolderModel { Name = "Folder 2", Size = "10GB" });
        Folders.Add(new FolderModel { Name = "Folder 3", Size = "10GB" });
        Folders.Add(new FolderModel { Name = "Folder 4", Size = "10GB" });
        Folders.Add(new FolderModel { Name = "Folder 5", Size = "10GB" });
        Folders.Add(new FolderModel { Name = "Folder 6", Size = "10GB" });

    }
}
