using DriveSpaceFolderAnalyzer.Services;
using DriveSpaceFolderAnalyzer.ViewModel;

namespace DriveSpaceFolderAnalyzer.View;

public partial class MainViewPage : ContentPage
{
	public MainViewPage(MainViewViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}