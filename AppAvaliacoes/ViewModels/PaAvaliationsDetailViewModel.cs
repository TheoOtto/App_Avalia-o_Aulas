namespace AppAvaliacoes.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class PaAvaliationsDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;


}
