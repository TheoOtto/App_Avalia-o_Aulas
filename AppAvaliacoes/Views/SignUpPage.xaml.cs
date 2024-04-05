using CommunityToolkit.Maui.Converters;

namespace AppAvaliacoes.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage(SignUpViewModel viewModel)
	{
		InitializeComponent(); 
		BindingContext = viewModel;
        usernameEnt.Text = "";
        emailEnt.Text = "";
        senhaEnt.Text = "";
        confirmaSenhaEnt.Text = "";
	}

    private async void LogInBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync("..");
        }catch(Exception ex) { }
    }

    private async void cadastroBtn_Clicked(object sender, EventArgs e)
    {
        if (senhaEnt.Text != confirmaSenhaEnt.Text || 
            usernameValidator.IsNotValid || 
            emailValidator.IsNotValid ||
            senhaValidator.IsNotValid ||
            confirmaSenhaValidator.IsNotValid)
        {
            await DisplayAlert("Erro","Os campos não foram preenchidos corretamente.","OK");
        }
        else
        {
            ComandosCRUD c = new ComandosCRUD();

            c.criarConta(emailEnt.Text, usernameEnt.Text, senhaEnt.Text);

            emailEnt.Text = "";
            senhaEnt.Text = "";
            usernameEnt.Text = "";
            confirmaSenhaEnt.Text = "";
            await Shell.Current.GoToAsync("..");
        }
    }
}
