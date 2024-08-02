namespace DriveSpaceFolderAnalyzer.Services;
public partial class DataService : ObservableObject,IDataService
{
    [ObservableProperty]
    ObservableCollection<Folder> folders;

    public DataService()
    {

    }
    public void GetFolders()
    {

    }
}
