using DiabetesAssistant.ViewModel;
using System.Net.Http;

namespace DiabetesAssistant;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
	}

	private string text;
	public string Text
	{
		get => SearchNutritionFacts.Text;
		set
		{
			if (value == null)
				return;

			Text = value;
			OnPropertyChanged();

		}
	}

	private void SearchNutrtionFactsClick_Clicked(object sender, EventArgs e)
	{
		
    }

}

