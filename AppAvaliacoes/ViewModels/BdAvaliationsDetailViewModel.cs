namespace AppAvaliacoes.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class BdAvaliationsDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
