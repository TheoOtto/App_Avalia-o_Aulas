namespace AppAvaliacoes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(IotAvaliationsDetailPage), typeof(IotAvaliationsDetailPage));
		Routing.RegisterRoute(nameof(BdAvaliationsDetailPage), typeof(BdAvaliationsDetailPage));
		Routing.RegisterRoute(nameof(PaAvaliationsDetailPage), typeof(PaAvaliationsDetailPage));

		Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
	}
}
