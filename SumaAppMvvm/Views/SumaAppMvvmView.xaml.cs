using SumaAppMvvm.ViewModels;

namespace SumaAppMvvm.Views;

public partial class SumaAppMvvmView : ContentPage
{
	SumaAppMvvmViewModel ViewModel;
	public SumaAppMvvmView()
	{
		InitializeComponent();
		ViewModel = new SumaAppMvvmViewModel();
		BindingContext = ViewModel;
	}
}