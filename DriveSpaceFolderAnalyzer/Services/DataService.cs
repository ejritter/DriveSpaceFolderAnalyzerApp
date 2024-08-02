namespace DriveSpaceFolderAnalyzer.Services;
public partial class DataService : ObservableObject,IDataService
{
    [ObservableProperty]
    ObservableCollection<Folder> folders;

    public DataService()
    {
        Folders = new();
    }
    public ObservableCollection<Folder> GetFolders()
    {
        for (int i = 0; i < 5; i++)
        {
            Folder folder = new Folder() { Name = "Folder " + (i + 1), Size = "100" };
            Folders.Add(folder);
        }

        return Folders;
    }
}
