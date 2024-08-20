namespace DriveSpaceFolderAnalyzer.View;

public partial class FolderView : ContentPage
{
	public FolderView(FolderViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}