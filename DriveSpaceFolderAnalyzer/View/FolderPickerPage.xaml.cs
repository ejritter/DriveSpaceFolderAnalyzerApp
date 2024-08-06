namespace DriveSpaceFolderAnalyzer.View;
public partial class FolderPickerPage : Popup
{
    public FolderPickerPage(FolderPickerViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
