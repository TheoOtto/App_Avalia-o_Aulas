using System.Data;

namespace AppAvaliacoes.Views;

public partial class BdAvaliationsPage : ContentPage
{
	BdAvaliationsViewModel ViewModel;

	public BdAvaliationsPage(BdAvaliationsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
    }

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
}
