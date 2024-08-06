
namespace DriveSpaceFolderAnalyzer.ViewModel;

public partial class MainViewViewModel : ObservableObject
{
    private readonly IDataService ds;

    [ObservableProperty]
    ObservableCollection<Folder> folders;
    public MainViewViewModel(IDataService ds)
    {
        this.ds = ds;

        Folders = this.ds.GetFolders();
    }

    [RelayCommand]
    public async Task Browse()
    {
        var Response = await Shell.Current.CurrentPage.ShowPopupAsync(new FolderPickerPage(new FolderPickerViewModel()));


    }
}
