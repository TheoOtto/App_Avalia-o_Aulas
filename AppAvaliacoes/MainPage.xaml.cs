using AppAvaliacoes.ViewModels;

namespace AppAvaliacoes.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private async void SignUpBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync(nameof(SignUpPage));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    private async void EntrarBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (emailValidator.IsNotValid)
            {
                await DisplayAlert("Erro", "Os campos não foram preenchidos corretamente.", "OK");
            }
            else
            {
                ComandosCRUD c = new ComandosCRUD();

                if (c.usuarioExistente(emailEntry.Text, passwordEntry.Text))
                {
                    await Shell.Current.GoToAsync("///PaAvaliationsPage");
                }
                else
                {
                    await DisplayAlert("Conta não existente", "Esta conta de usuário não foi criada", "OK");
                }
            }

            //await Shell.Current.GoToAsync("///UserAccountPage");
        } catch (Exception ex) {
            await DisplayAlert("Alert",ex.Message,"OK");
        }
    }


}
