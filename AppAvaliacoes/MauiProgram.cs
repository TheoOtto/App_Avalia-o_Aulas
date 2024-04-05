	namespace AppAvaliacoes;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
                fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
            });


		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<SignUpViewModel>();

		builder.Services.AddSingleton<SignUpPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<PaAvaliationsDetailViewModel>();
		builder.Services.AddTransient<PaAvaliationsDetailPage>();

		builder.Services.AddSingleton<PaAvaliationsViewModel>();

		builder.Services.AddSingleton<PaAvaliationsPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<BdAvaliationsDetailViewModel>();
		builder.Services.AddTransient<BdAvaliationsDetailPage>();

		builder.Services.AddSingleton<BdAvaliationsViewModel>();

		builder.Services.AddSingleton<BdAvaliationsPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<IotAvaliationsDetailViewModel>();
		builder.Services.AddTransient<IotAvaliationsDetailPage>();

		builder.Services.AddSingleton<IotAvaliationsViewModel>();

		builder.Services.AddSingleton<IotAvaliationsPage>();

		builder.Services.AddSingleton<UserAccountViewModel>();

		builder.Services.AddSingleton<UserAccountPage>();

		return builder.Build();
	}
}
