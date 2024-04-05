namespace AppAvaliacoes.Views;

public partial class IotAvaliationsPage : ContentPage
{
	IotAvaliationsViewModel ViewModel;

	public IotAvaliationsPage(IotAvaliationsViewModel viewModel)
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
