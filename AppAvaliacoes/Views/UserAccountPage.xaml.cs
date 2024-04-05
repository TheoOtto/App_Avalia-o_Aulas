namespace AppAvaliacoes.Views;

public partial class UserAccountPage : ContentPage
{
	public UserAccountPage(UserAccountViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void SalvarBtn_Clicked(object sender, EventArgs e)
    {

    }

	private void SairBtn_Clicked(object sender, EventArgs e)
	{

	}

	private void RemoverContaBtn_Clicked(object sender, EventArgs e)
	{

	}
}
