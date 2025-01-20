namespace DCEvaluacion3P.Views;
using DCEvaluacion3P.ViewModels;
using DCEvaluacion3P.Models;

public partial class DCCatApiView : ContentPage
{
	public DCCatApiView()
	{
		InitializeComponent();
	}
	private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.Count > 0)
		{
			var gatSelec = e.CurrentSelection[0] as DCCat;
			if (gatSelec != null)
			{
				var DCDetallesCat = new DCDetallesCat();
				var CatDetallesViewModel = (DCCatDetallesViewModel)DCDetallesCat.BindingContext;
			}
		}
	}
}