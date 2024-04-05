namespace AppAvaliacoes.Views;

public partial class PaAvaliationsPage : ContentPage
{
	PaAvaliationsViewModel ViewModel;

	public PaAvaliationsPage(PaAvaliationsViewModel viewModel)
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
