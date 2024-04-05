namespace AppAvaliacoes.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class IotAvaliationsDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
