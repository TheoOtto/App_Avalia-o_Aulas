namespace AppAvaliacoes.Views;

public partial class PaAvaliationsDetailPage : ContentPage
{
    private int Nota { get; set; }
    private string Comentario { get; set; }
    private int Usuario { get; set; }
    private int IdAula;
	public PaAvaliationsDetailPage(PaAvaliationsDetailViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
	}

    /* Método para armazenar a nota;
     * Chamado por mais de um objeto Image;
     * Falha ao tentar reconhecer e diferenciar o objeto que ativou o método.
     * 
    private async void NotaEscolhida(object sender, TappedEventArgs e)
    {
        try
        {
            switch (sender.ToString())
            {
                case "NotaUm":
                    Nota = 1;
                    MudaEstrelas("NotaUm");
                    break;
                case "NotaDois":
                    Nota = 2;
                    MudaEstrelas(sender.ToString());
                    break;
                case "NotaTres":
                    Nota = 3;
                    MudaEstrelas(sender.ToString());
                    break;
                case "NotaQuatro":
                    Nota = 4;
                    MudaEstrelas(sender.ToString());
                    break;
                case "NotaCinco":
                    Nota = 5;
                    MudaEstrelas(sender.ToString());
                    break;
                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }*/

    private async void EnviarAvaliacao(object sender, TappedEventArgs e)
    {
        try
        {
            if (Nota==0)
            {
                await DisplayAlert("Erro", "Para enviar uma avaliação é necessário que a nota seja selecionada.", "OK");
            }
            else
            {
                ComandosCRUD c = new ComandosCRUD();
                Comentario = comentarioEntry.Text;
                Usuario = c.usuarConectado;
                c.InserirComentario(Comentario, Usuario,IdAula, Nota);

                await DisplayAlert("Usuario", $"O Id do usuario conectado é {c.usuarConectado}", "Nice");
            }
        } catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }

    private async void NotaEscolhida_Um(object sender, TappedEventArgs e)
    {
        try
        {
            Nota = 1;
            MudaEstrelas(Nota);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    private async void NotaEscolhida_Dois(object sender, TappedEventArgs e)
    {
        try
        {
            Nota = 2;
            MudaEstrelas(Nota);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    private async void NotaEscolhida_Tres(object sender, TappedEventArgs e)
    {
        try
        {
            Nota = 3;
            MudaEstrelas(Nota);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    private async void NotaEscolhida_Quatro(object sender, TappedEventArgs e)
    {
        try
        {
            Nota = 4;
            MudaEstrelas(Nota);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    private async void NotaEscolhida_Cinco(object sender, TappedEventArgs e)
    {
        try
        {
            Nota = 5;
            MudaEstrelas(Nota);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    private async void MudaEstrelas(int nota)
    {
        try
        {
            ResetEstrelas();
            switch (nota)
            {
                case 1:
                    EstrelaUm.Source = ImageSource.FromFile("estrela_preenchida.png");
                    break;
                case 2:
                    EstrelaUm.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaDois.Source = ImageSource.FromFile("estrela_preenchida.png");
                    break;
                case 3:
                    EstrelaUm.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaDois.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaTres.Source = ImageSource.FromFile("estrela_preenchida.png");
                    break;
                case 4:
                    EstrelaUm.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaDois.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaTres.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaQuatro.Source = ImageSource.FromFile("estrela_preenchida.png");
                    break;
                case 5:
                    EstrelaUm.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaDois.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaTres.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaQuatro.Source = ImageSource.FromFile("estrela_preenchida.png");
                    EstrelaCinco.Source = ImageSource.FromFile("estrela_preenchida.png");
                    break;
                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.Message, "OK");
        }
    }

    private void ResetEstrelas()
    {
        EstrelaUm.Source = ImageSource.FromFile("estrela_nao_preenchida.png");
        EstrelaDois.Source = ImageSource.FromFile("estrela_nao_preenchida.png");
        EstrelaTres.Source = ImageSource.FromFile("estrela_nao_preenchida.png");
        EstrelaQuatro.Source = ImageSource.FromFile("estrela_nao_preenchida.png");
        EstrelaCinco.Source = ImageSource.FromFile("estrela_nao_preenchida.png");
    }

}
